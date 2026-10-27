namespace api.Entitis;
using System.ComponentModel.DataAnnotations;
using api.Validaciones;
public class Genero
{
    public int id { get; set; }

    [Required(ErrorMessage = "El campo {0} es requerido")]
    [StringLength(50, ErrorMessage = "El campo {0} debe tener {1} caracteres o menos")]
    [PrimeraLetraMayuscula]
    public required String nombre  { get; set; }
}
