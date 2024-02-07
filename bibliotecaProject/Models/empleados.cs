using System.ComponentModel.DataAnnotations;

namespace bibliotecaProject.Models;

	public class empleados
	{
	
		[Key]
    public int Id { get; set; }
    [Required(ErrorMessage = "Debe especificar un nombre de empleado")]
    public string? Nombre { get; set; }
    [Required(ErrorMessage = "Debe especificar un numero de cedula")]
    public string? Cedula { get; set; }
    [Required(ErrorMessage = "Debe especificar una tanda")]
    public string? TandaLabor { get; set; }
    [Required(ErrorMessage = "Debe especificar un numero de porcentaje")]
    public string? PorcientoComision { get; set; }
    [DataType(DataType.Date)]
    public DateOnly FechaIngreso { get; set; }
    public string? Estado { get; set; }
}
	


