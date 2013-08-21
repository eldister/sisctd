using System;

namespace BESisCtd
{
    public class BE_Sis_Cliente
    {
        #region Constructors

		/// <summary>
		/// Initializes a new instance of the Sis_ClienteBE class.
		/// </summary>
		public BE_Sis_Cliente()
		{
		}

		/// <summary>
		/// Initializes a new instance of the Sis_ClienteBE class.
		/// </summary>
        public BE_Sis_Cliente(string idCliente, string descripcion, bool estado, DateTime fechaRegistro, string horaRegistro, string usuarioRegistro)
		{
			this.IdCliente = idCliente;
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
		/// Gets or sets the Descripcion value.
		/// </summary>
		public string Descripcion { get; set; }

		/// <summary>
		/// Gets or sets the Modulo value.
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
