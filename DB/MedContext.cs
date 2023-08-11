using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.DB;
public class MedContext : DbContext
{
    public MedContext(DbContextOptions<MedContext> options) : base(options)
    {
    }
    public MedContext()
    {
            
    }

    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Clinic> Clinics { get; set; }
    public DbSet<ConsultationRequest> ConsultationRequests { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            var connectionString = "Server=myodeon.com,1437;Initial Catalog=MedDb;Persist Security Info=True;Encrypt=False;User ID=sa;Password=Sa.2017";   
            optionsBuilder.UseSqlServer(connectionString);
        }

        optionsBuilder.EnableSensitiveDataLogging();
    }




}

