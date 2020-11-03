using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultasLINQ
{
    public class CursosContext : DbContext
    {
        public CursosContext() : base("DbCursos")
        {
            Database.SetInitializer<CursosContext>(
                new CreateDatabaseIfNotExists<CursosContext>());
            Database.Initialize(false);
        }

        public DbSet<Curso> Cursos { get; set; }
    }
}