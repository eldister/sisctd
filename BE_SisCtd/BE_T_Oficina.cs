using System;

namespace BESisCtd
{
	public class BE_T_Oficina
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the T_Oficina class.
		/// </summary>
		public BE_T_Oficina()
		{
		}

		/// <summary>
		/// Initializes a new instance of the T_Oficina class.
		/// </summary>
        public BE_T_Oficina(string idCliente, string idoficina, string descripcion, string idterritorio, string idubigeo, string direccion, bool estado, DateTime fechaRegistro, string horaRegistro, string usuarioRegistro)
		{
			this.IdCliente = idCliente;
			this.Idoficina = idoficina;
			this.Descripcion = descripcion;
			this.Idterritorio = idterritorio;
			this.Idubigeo = idubigeo;
			this.Direccion = direccion;
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
		/// Gets or sets the Idoficina value.
		/// </summary>
		public string Idoficina { get; set; }

		/// <summary>
		/// Gets or sets the Descripcion value.
		/// </summary>
		public string Descripcion { get; set; }

		/// <summary>
		/// Gets or sets the Idterritorio value.
		/// </summary>
		public string Idterritorio { get; set; }

		/// <summary>
		/// Gets or sets the Idubigeo value.
		/// </summary>
		public string Idubigeo { get; set; }

		/// <summary>
		/// Gets or sets the Direccion value.
		/// </summary>
		public string Direccion { get; set; }

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
