using EmployeeDepartmentApp.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeDepartmentApp.API.Data
{
   
    
        public class DataContext : DbContext
        {
            public DataContext(DbContextOptions<DataContext> options) : base(options) { }

            public DbSet<Employee> Employees { get; set; }

            public DbSet<Department> Departments { get; set; }


            public DbSet<EmployeeDepartmentRelation> EmployeeDepartmentRelations { get; set; }

     
    }
    }
