using System.ComponentModel.DataAnnotations;

namespace bibliotecaProject.Models;

	public class usuarios
	{
		
    [Key]
    public int Id { get; set; }
    [Required(ErrorMessage = "Debe especificar un nombre de usuario")]
    public string? Nombre { get; set; }
    [Required(ErrorMessage = "Debe especificar un numero de cedula")]
    public string? Cedula { get; set; }
    [Required(ErrorMessage = "Debe especificar un numero de carnet")]
    public string? noCarnet { get; set; }
    [Required(ErrorMessage = "Debe especificar un tipo de persona")]
    public string? tipoPersona { get; set; }
    public string? Estado { get; set; }
}
	


