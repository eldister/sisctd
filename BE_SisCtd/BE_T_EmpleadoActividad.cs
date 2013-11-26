using System;

namespace BESisCtd
{
	public class BE_T_EmpleadoActividad
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the T_Actividad class.
		/// </summary>
		public BE_T_EmpleadoActividad()
		{
		}

		/// <summary>
		/// Initializes a new instance of the T_Actividad class.
		/// </summary>
        public BE_T_EmpleadoActividad(string idCliente, string idActividad, string idEmpleado, DateTime fechaRegistro, string horaRegistro, string usuarioRegistro)
		{
			this.IdCliente = idCliente;
			this.IdActividad = idActividad;
            this.IdEmpleado = idEmpleado;
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
		/// Gets or sets the IdActividad value.
		/// </summary>
		public string IdActividad { get; set; }

		/// <summary>
		/// Gets or sets the IdEmpleado value.
		/// </summary>
		public string IdEmpleado { get; set; }

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
