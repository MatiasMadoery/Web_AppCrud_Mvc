using System.Reflection.Metadata.Ecma335;

namespace WebAppCrudEf.Models
{
    public class AlumnoCurso
    {
        public int Id { get; set; }
        public int AlumnoId { get; set; }
        public int CursoId {  get; set; }
        public DateTime FechaInscripcion { get; set; }
        public Alumno Alumno { get; set; }
        public Curso Curso { get; set; }
    }
}
