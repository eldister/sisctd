using System;

namespace BESisCtd
{
	public class BE_T_TipoDocumentoRuta
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the T_TipoDocumentoRuta class.
		/// </summary>
		public BE_T_TipoDocumentoRuta()
		{
		}

		/// <summary>
		/// Initializes a new instance of the T_TipoDocumentoRuta class.
		/// </summary>
        public BE_T_TipoDocumentoRuta(string idCliente, string idTipoDocumento, string idRuta, bool estado, DateTime fechaRegistro, string horaRegistro, string usuarioRegistro)
		{
			this.IdCliente = idCliente;
			this.IdTipoDocumento = idTipoDocumento;
			this.IdRuta = idRuta;
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
		/// Gets or sets the IdTipoDocumento value.
		/// </summary>
		public string IdTipoDocumento { get; set; }

		/// <summary>
		/// Gets or sets the IdRuta value.
		/// </summary>
		public string IdRuta { get; set; }

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
