﻿using System.ComponentModel.DataAnnotations;

namespace bibliotecaProject.Models;

	public class ciencias
	{
		
    [Key]
    public int Id { get; set; }
    public string? Descripcion { get; set; }
    public string? Estado { get; set; }
}
	

