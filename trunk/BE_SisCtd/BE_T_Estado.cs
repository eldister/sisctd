using System;

namespace BESisCtd
{
	public class BE_T_Estado
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the T_Estado class.
		/// </summary>
		public BE_T_Estado()
		{
		}

		/// <summary>
		/// Initializes a new instance of the T_Estado class.
		/// </summary>
        public BE_T_Estado(string idCliente, string idEstado, string descripcion, bool estado, DateTime fechaRegistro, string horaRegistro, string usuarioRegistro)
		{
			this.IdCliente = idCliente;
			this.IdEstado = idEstado;
			this.Descripcion = descripcion;
			this.Estado = estado;
			this.FechaRegistro = fechaRegistro;
			this.HoraRegistro = horaRegistro;
			this.UsuarioRegistro = usuarioRegistro;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the IdCliente value.
		/// </summary>
		public string IdCliente { get; set; }

		/// <summary>
		/// Gets or sets the IdEstado value.
		/// </summary>
		public string IdEstado { get; set; }

		/// <summary>
		/// Gets or sets the Descripcion value.
		/// </summary>
		public string Descripcion { get; set; }

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
