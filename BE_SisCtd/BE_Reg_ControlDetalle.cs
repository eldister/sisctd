using System;

namespace BESisCtd
{
	public class BE_Reg_ControlDetalle
	{
		#region Fields

		private string idCliente;
		private string idControl;
		private string nroSecuencia;
		private int orden;
		private string idActividad;
		private string idOficinaRecepcion;
		private string idEmpleadoRecepcion;
		private string idAreaRecepcion;
		private DateTime fechaRecepcion;
		private string idOficinaDestinatario;
		private string idEmpleadoDestinatario;
		private string idAreaDestinatario;
		private DateTime fechaDestinatario;
		private string observacion;
		private int duracionEnDias;
		private string estado;
		private DateTime fechaRegistro;
		private string horaRegistro;
		private string usuarioRegistro;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the Reg_ControlDetalle class.
		/// </summary>
		public BE_Reg_ControlDetalle()
		{
		}

		/// <summary>
		/// Initializes a new instance of the Reg_ControlDetalle class.
		/// </summary>
		public BE_Reg_ControlDetalle(string idCliente, string idControl, string nroSecuencia, int orden, string idActividad, string idOficinaRecepcion, string idEmpleadoRecepcion, string idAreaRecepcion, DateTime fechaRecepcion, string idOficinaDestinatario, string idEmpleadoDestinatario, string idAreaDestinatario, DateTime fechaDestinatario, string observacion, int duracionEnDias, string estado, DateTime fechaRegistro, string horaRegistro, string usuarioRegistro)
		{
			this.idCliente = idCliente;
			this.idControl = idControl;
			this.nroSecuencia = nroSecuencia;
			this.orden = orden;
			this.idActividad = idActividad;
			this.idOficinaRecepcion = idOficinaRecepcion;
			this.idEmpleadoRecepcion = idEmpleadoRecepcion;
			this.idAreaRecepcion = idAreaRecepcion;
			this.fechaRecepcion = fechaRecepcion;
			this.idOficinaDestinatario = idOficinaDestinatario;
			this.idEmpleadoDestinatario = idEmpleadoDestinatario;
			this.idAreaDestinatario = idAreaDestinatario;
			this.fechaDestinatario = fechaDestinatario;
			this.observacion = observacion;
			this.duracionEnDias = duracionEnDias;
			this.estado = estado;
			this.fechaRegistro = fechaRegistro;
			this.horaRegistro = horaRegistro;
			this.usuarioRegistro = usuarioRegistro;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the IdCliente value.
		/// </summary>
		public virtual string IdCliente
		{
			get { return idCliente; }
			set { idCliente = value; }
		}

		/// <summary>
		/// Gets or sets the IdControl value.
		/// </summary>
		public virtual string IdControl
		{
			get { return idControl; }
			set { idControl = value; }
		}

		/// <summary>
		/// Gets or sets the NroSecuencia value.
		/// </summary>
		public virtual string NroSecuencia
		{
			get { return nroSecuencia; }
			set { nroSecuencia = value; }
		}

		/// <summary>
		/// Gets or sets the Orden value.
		/// </summary>
		public virtual int Orden
		{
			get { return orden; }
			set { orden = value; }
		}

		/// <summary>
		/// Gets or sets the IdActividad value.
		/// </summary>
		public virtual string IdActividad
		{
			get { return idActividad; }
			set { idActividad = value; }
		}

		/// <summary>
		/// Gets or sets the IdOficinaRecepcion value.
		/// </summary>
		public virtual string IdOficinaRecepcion
		{
			get { return idOficinaRecepcion; }
			set { idOficinaRecepcion = value; }
		}

		/// <summary>
		/// Gets or sets the IdEmpleadoRecepcion value.
		/// </summary>
		public virtual string IdEmpleadoRecepcion
		{
			get { return idEmpleadoRecepcion; }
			set { idEmpleadoRecepcion = value; }
		}

		/// <summary>
		/// Gets or sets the IdAreaRecepcion value.
		/// </summary>
		public virtual string IdAreaRecepcion
		{
			get { return idAreaRecepcion; }
			set { idAreaRecepcion = value; }
		}

		/// <summary>
		/// Gets or sets the FechaRecepcion value.
		/// </summary>
		public virtual DateTime FechaRecepcion
		{
			get { return fechaRecepcion; }
			set { fechaRecepcion = value; }
		}

		/// <summary>
		/// Gets or sets the IdOficinaDestinatario value.
		/// </summary>
		public virtual string IdOficinaDestinatario
		{
			get { return idOficinaDestinatario; }
			set { idOficinaDestinatario = value; }
		}

		/// <summary>
		/// Gets or sets the IdEmpleadoDestinatario value.
		/// </summary>
		public virtual string IdEmpleadoDestinatario
		{
			get { return idEmpleadoDestinatario; }
			set { idEmpleadoDestinatario = value; }
		}

		/// <summary>
		/// Gets or sets the IdAreaDestinatario value.
		/// </summary>
		public virtual string IdAreaDestinatario
		{
			get { return idAreaDestinatario; }
			set { idAreaDestinatario = value; }
		}

		/// <summary>
		/// Gets or sets the FechaDestinatario value.
		/// </summary>
		public virtual DateTime FechaDestinatario
		{
			get { return fechaDestinatario; }
			set { fechaDestinatario = value; }
		}

		/// <summary>
		/// Gets or sets the Observacion value.
		/// </summary>
		public virtual string Observacion
		{
			get { return observacion; }
			set { observacion = value; }
		}

		/// <summary>
		/// Gets or sets the DuracionEnDias value.
		/// </summary>
		public virtual int DuracionEnDias
		{
			get { return duracionEnDias; }
			set { duracionEnDias = value; }
		}

		/// <summary>
		/// Gets or sets the Estado value.
		/// </summary>
		public virtual string Estado
		{
			get { return estado; }
			set { estado = value; }
		}

		/// <summary>
		/// Gets or sets the FechaRegistro value.
		/// </summary>
		public virtual DateTime FechaRegistro
		{
			get { return fechaRegistro; }
			set { fechaRegistro = value; }
		}

		/// <summary>
		/// Gets or sets the HoraRegistro value.
		/// </summary>
		public virtual string HoraRegistro
		{
			get { return horaRegistro; }
			set { horaRegistro = value; }
		}

		/// <summary>
		/// Gets or sets the UsuarioRegistro value.
		/// </summary>
		public virtual string UsuarioRegistro
		{
			get { return usuarioRegistro; }
			set { usuarioRegistro = value; }
		}

		#endregion
	}
}
