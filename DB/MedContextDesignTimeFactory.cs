using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.DB;
public class MedContextDesignTimeFactory : IDesignTimeDbContextFactory<MedContext>
{
    public MedContext CreateDbContext(string[] args)
    {
        return new MedContext();
    }
}   

