﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Reciclaap.Models
{
    public class Usuario
    {
		public enum enRoles
		{
			Administrador = 1,
			Empleado = 2,

		}

		[Key]
		[Display(Name = "Código")]
		public int Id { get; set; }

		[Required]
		public string Nombre { get; set; }

		[Required]
		public string Apellido { get; set; }

		[Required]
		public string Dni { get; set; }

		[Required, EmailAddress]
		public string Telefono { get; set; }

		[Required]
		public string Direccion { get; set; }

		[Required]
		public string Email { get; set; }

		[Required, DataType(DataType.Password)]
		public string Clave { get; set; }

		public int Rol { get; set; }

		[Required]
		public string Foto{ get; set; }

		[Required]
		public bool Estado{ get; set; }

		[Required]
		public int Puntos { get; set; }
		
		public string RolNombre => Rol > 0 ? ((enRoles)Rol).ToString() : "";
		public static IDictionary<int, string> ObtenerRoles()
		{
			SortedDictionary<int, string> roles = new SortedDictionary<int, string>();
			Type tipoEnumRol = typeof(enRoles);
			foreach (var valor in Enum.GetValues(tipoEnumRol))
			{
				roles.Add((int)valor, Enum.GetName(tipoEnumRol, valor));
			}
			return roles;
		}

	}
}
