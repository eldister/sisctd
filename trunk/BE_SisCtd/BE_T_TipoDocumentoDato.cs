using System;

namespace BESisCtd
{
	public class BE_T_TipoDocumentoDato
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the T_TipoDocumentoDato class.
		/// </summary>
		public BE_T_TipoDocumentoDato()
		{
		}

		/// <summary>
		/// Initializes a new instance of the T_TipoDocumentoDato class.
		/// </summary>
        public BE_T_TipoDocumentoDato(string idCliente, string idTipoDocumento, string iddato, int orden, DateTime fechaRegistro, string horaRegistro, string usuarioRegistro)
		{
			this.IdCliente = idCliente;
			this.IdTipoDocumento = idTipoDocumento;
			this.Iddato = iddato;
			this.Orden = orden;
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
		/// Gets or sets the Iddato value.
		/// </summary>
		public string Iddato { get; set; }

		/// <summary>
		/// Gets or sets the Orden value.
		/// </summary>
		public int Orden { get; set; }

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
