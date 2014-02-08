using System;

namespace BESisCtd
{
	public class BE_T_RutaActividad
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the T_RutaActividad class.
		/// </summary>
		public BE_T_RutaActividad()
		{
		}

		/// <summary>
		/// Initializes a new instance of the T_RutaActividad class.
		/// </summary>
        public BE_T_RutaActividad(string idCliente, string idRuta, string idActividad, int orden, string idOficina, string idArea, int DuracionenDia, DateTime fechaRegistro, string horaRegistro, string usuarioRegistro)
		{
			this.IdCliente = idCliente;
			this.IdRuta = idRuta;
			this.IdActividad = idActividad;
			this.Orden = orden;
            this.IdOficina = idOficina;
            this.IdArea = idArea;
            this.DuracionenDia = DuracionenDia;
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
		/// Gets or sets the IdRuta value.
		/// </summary>
		public string IdRuta { get; set; }

		/// <summary>
		/// Gets or sets the IdActividad value.
		/// </summary>
		public string IdActividad { get; set; }

		/// <summary>
		/// Gets or sets the Orden value.
		/// </summary>
        /// 
		public int Orden { get; set; }
        /// <summary>
        /// Gets or sets the Orden value.
        /// </summary>
        public string IdOficina { get; set; }
        /// <summary>
        /// Gets or sets the Orden value.
        /// </summary>
        public string IdArea { get; set; }
        /// <summary>
        /// Gets or sets the Orden value.
        /// </summary>
        public int DuracionenDia { get; set; }

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
