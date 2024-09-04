using System.ComponentModel.DataAnnotations;

namespace WebAppCrudEf.Models
{
    public class Alumno
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }

        [Display(Name = "Año de ingreso")]
        public string AnioIngreso { get; set; }
        public int Legajo { get; set; }
        public int CarreraId { get; set; }
        public Domicilio Domicilio { get; set; }
        public Carrera Carrera { get; set; }
    }
}
