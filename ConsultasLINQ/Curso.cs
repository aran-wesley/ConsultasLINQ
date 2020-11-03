using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultasLINQ
{
    [Table("Cursos")]
    public class Curso
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int CargaHoraria { get; set; }
        public DateTime DataPublicacao { get; set; }
        public Canal Canal { get; set; }

        public override string ToString()
        {
            return $"{Id.ToString("000")} | {Titulo.PadRight(30)} | {CargaHoraria.ToString().PadLeft(3)} | { DataPublicacao.ToString("dd/MM/yyyy")} | { Canal}";
        }
    }
}