using System.ComponentModel.DataAnnotations;

namespace bibliotecaProject.Models;

public class autores
{
	
	[Key]
	public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Pais { get; set; }
        public string? IdiomaNativo { get; set; }
        public string? Estado { get; set; }
    

}

