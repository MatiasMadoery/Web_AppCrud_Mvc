namespace WebAppCrudEf.Models
{
    public class Carrera
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<Alumno> Alumnos { get; set; }
    }
}
