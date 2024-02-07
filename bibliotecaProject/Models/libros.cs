using System.ComponentModel.DataAnnotations;

namespace bibliotecaProject.Models;

	public class libros
	{
		
    [Key]
    public int Id { get; set; }
    public string? Descripcion { get; set; }
    [Required(ErrorMessage = "Debe especificar un tipo de Signatura Topografica")]
    public string? SignaturaTopografica { get; set; }
    [Required(ErrorMessage = "Debe especificar un tipo de ISBN")]
    public string? ISBN { get; set; }
    [Required(ErrorMessage = "Debe especificar un tipo de Bibliografia")]
    public int tipoBibliografiaId { get; set; }
    public virtual tiposBibliografia? tiposBibliografia { get; set; }
    [Required(ErrorMessage = "Debe especificar un Autor")]
    public int autoresId { get; set; }
    public virtual autores? autores{ get; set; }
    [Required(ErrorMessage = "Debe especificar una Editorial")]
    public int editoraId { get; set; }
    public virtual editoras? editora{ get; set; }

    public string? AnoPublicacion { get; set; }

    public int cienciaId { get; set; }
    public virtual ciencias? Ciencia { get; set; }
    [Required(ErrorMessage = "Debe especificar un idioma")]
    public int idiomaId { get; set; }
    public virtual idiomas? Idioma { get; set; }

   
    public string? Estado { get; set; }
}
	


