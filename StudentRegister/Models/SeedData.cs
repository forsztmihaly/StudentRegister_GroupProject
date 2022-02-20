using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using StudentRegister.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRegister.Models
{
    public class SeedData
    {
        public static void Inicializalas(IServiceProvider serviceProvider)
        {
            ApplicationDbContext db = new ApplicationDbContext(serviceProvider
                .GetRequiredService<DbContextOptions<ApplicationDbContext>>());

            if (!db.Student.Any())
            {
                var sorok = File.ReadAllLines(@"C:\Users\Acer\Desktop\C#\StudentRegister\diakok.csv").Skip(1);
                foreach (var sor in sorok)
                {
                    db.Student.Add(new Student(sor));
                }
                db.SaveChanges();
            }
        }
    }
}
    

