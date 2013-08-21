using System;

namespace BESisCtd
{
	public class BE_Sis_Perfil
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the Sis_PerfilBE class.
		/// </summary>
		public BE_Sis_Perfil()
		{
		}

		/// <summary>
		/// Initializes a new instance of the Sis_PerfilBE class.
		/// </summary>
        public BE_Sis_Perfil(string idPerfil, string descripcion, DateTime fechaRegistro, string horaRegistro, string usuarioRegistro)
		{
			this.IdPerfil = idPerfil;
			this.Descripcion = descripcion;
			this.FechaRegistro = fechaRegistro;
			this.HoraRegistro = horaRegistro;
			this.UsuarioRegistro = usuarioRegistro;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the IdPerfil value.
		/// </summary>
		public string IdPerfil { get; set; }

		/// <summary>
		/// Gets or sets the Descripcion value.
		/// </summary>
		public string Descripcion { get; set; }

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
