using ClinicApp.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Application;
internal class DoctorsRepository
{
    public List<Doctor> GetAll()
    {
        using (var db = new MedContext())
        {
            return db.Doctors.ToList();
        }
    }
    public Doctor GetById(int id)
    {
        using (var db = new MedContext())
        {
            return db.Doctors.Find(id);
        }
    }
    public void Add(Doctor doctor)
    {
        using (var db = new MedContext())
        {
            db.Doctors.Add(doctor);
            db.SaveChanges();
        }
    }
    public void Update(Doctor doctor)
    {
        using (var db = new MedContext())
        {
            db.Doctors.Update(doctor);
            db.SaveChanges();
        }
    }
    public bool Login(string username, string password)
    {
        using (var db = new MedContext())
        {
            var doctor = db.Doctors.FirstOrDefault(d => d.Email == username && d.Password == password);
            if (doctor != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
