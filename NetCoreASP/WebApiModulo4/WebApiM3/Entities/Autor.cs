using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApiM3.Helpers;

namespace WebApiM3.Entities
{
    //public class Autor : IValidatableObject //validacion por modelo
    public class Autor
    {
        public int Id { get; set; }
        [Required]
        //[PrimeraLetraMayuscula]
        //[StringLength(10, ErrorMessage = "El campo Nombre debe tener {1} caracteres o menos")]
        public string Nombre { get; set; }
        public List<Libros> Libros { get; set; }

        //public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        //{
        //    if (!string.IsNullOrEmpty(Nombre))
        //    {
        //        var primeraLetra = Nombre[0].ToString();

        //        if (primeraLetra != primeraLetra.ToUpper())
        //        {
        //            yield return new ValidationResult("La primera letra debe ser mayúscula", new string[] { nameof(Nombre) });
        //        }
        //    }
        //}
    }
}
