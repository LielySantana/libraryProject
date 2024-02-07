using System.ComponentModel.DataAnnotations;

namespace bibliotecaProject.Models;

	public class prestamo
	{
		
    [Key]
    public int Id { get; set; }
    [Required(ErrorMessage = "Debe especificar un id de empleado")]
    public int empleadoId { get; set; }
    public virtual empleados? Empleado { get; set; }
    [Required(ErrorMessage = "Debe especificar un nombre de libro")]
    public int libroId { get; set; }
    public virtual libros? Libro { get; set; }
    [Required(ErrorMessage = "Debe especificar un nombre de usuario")]
    public int usuarioId { get; set; }
    public virtual usuarios? Usuario{ get; set; }
    [Required(ErrorMessage = "Debe especificar una fecha de prestamo")]
    [DataType(DataType.Date)]
    public DateOnly? FechaPrestamo{ get; set; }
    [Required(ErrorMessage = "Debe especificar una fecha de devolucion")]
    [DataType(DataType.Date)]
    public DateOnly? FechaDevolucion { get; set; }

    [Required(ErrorMessage = "Debe especificar un monto por dia")]
    public double? MontoPorDia { get; set; }
    [Required(ErrorMessage = "Debe especificar una cantidad de dias")]
    public int? CantidadDias { get; set; }

    public string? Comentarios { get; set; }
    public string? Estado { get; set; }
}
	


