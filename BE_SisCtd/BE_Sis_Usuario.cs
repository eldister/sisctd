using System;

namespace BESisCtd
{
	public class BE_Sis_Usuario
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the Sis_UsuarioBE class.
		/// </summary>
		public BE_Sis_Usuario()
		{
		}

		/// <summary>
		/// Initializes a new instance of the Sis_UsuarioBE class.
		/// </summary>
        public BE_Sis_Usuario(string idUsuario, string nombre, string idPerfil, string correo, string contraseña, bool estado, DateTime fechaRegistro, string horaRegistro, string usuarioRegistro)
		{
			this.IdUsuario = idUsuario;
			this.Nombre = nombre;
			this.IdPerfil = idPerfil;
			this.Correo = correo;
			this.Contraseña = contraseña;
			this.Estado = estado;
			this.FechaRegistro = fechaRegistro;
			this.HoraRegistro = horaRegistro;
			this.UsuarioRegistro = usuarioRegistro;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the IdUsuario value.
		/// </summary>
		public string IdUsuario { get; set; }

		/// <summary>
		/// Gets or sets the Nombre value.
		/// </summary>
		public string Nombre { get; set; }

		/// <summary>
		/// Gets or sets the IdPerfil value.
		/// </summary>
		public string IdPerfil { get; set; }

		/// <summary>
		/// Gets or sets the Correo value.
		/// </summary>
		public string Correo { get; set; }

		/// <summary>
		/// Gets or sets the Contraseña value.
		/// </summary>
		public string Contraseña { get; set; }

		/// <summary>
		/// Gets or sets the Estado value.
		/// </summary>
		public bool Estado { get; set; }

		/// <summary>
		/// Gets or sets the FechaRegistro value.
		/// </summary>
		public DateTime FechaRegistro { get; set; }

		/// <summary>
		/// Gets or sets the HoraRegistro value.
		/// </summary>
		public string HoraRegistro { get; set; }

		/// <summary>
		/// Gets or sets the UsuarioRegistro value.
		/// </summary>
		public string UsuarioRegistro { get; set; }

		#endregion
	}
}
