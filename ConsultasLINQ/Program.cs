using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultasLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            CursosContext db = new CursosContext();

            //1) Listando todos os cursos
            ; var cursos = db.Cursos.Count(c => c.Canal == Canal.BancoDeDados);

            //foreach (Curso c in cursos)
            //{
            //    Console.WriteLine(c);
            //}

            Console.ReadKey();
        }
    }

}
