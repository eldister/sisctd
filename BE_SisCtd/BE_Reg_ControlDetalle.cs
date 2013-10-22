using System;

namespace BESisCtd
{
	public class BE_Reg_ControlDetalle
	{
		#region Fields

		private string idCliente;
		private int idControl;
		private string nroSecuencia;
		private int orden;
		private string idActividad;
		private string idOficinaResponsable;
		private string idEmpleado;
		private string idArea;
		private bool recibido;
		private bool visado;
		private bool firmado;
		private string idImagen;
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
        public BE_Reg_ControlDetalle(string idCliente, int idControl, string nroSecuencia, int orden, string idActividad, string idOficinaResponsable, string idEmpleado, string idArea, bool recibido, bool visado, bool firmado, string idImagen, string estado, DateTime fechaRegistro, string horaRegistro, string usuarioRegistro)
		{
			this.idCliente = idCliente;
			this.idControl = idControl;
			this.nroSecuencia = nroSecuencia;
			this.orden = orden;
			this.idActividad = idActividad;
			this.idOficinaResponsable = idOficinaResponsable;
			this.idEmpleado = idEmpleado;
			this.idArea = idArea;
			this.recibido = recibido;
			this.visado = visado;
			this.firmado = firmado;
			this.idImagen = idImagen;
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
		public virtual int IdControl
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
		/// Gets or sets the IdOficinaResponsable value.
		/// </summary>
		public virtual string IdOficinaResponsable
		{
			get { return idOficinaResponsable; }
			set { idOficinaResponsable = value; }
		}

		/// <summary>
		/// Gets or sets the IdEmpleado value.
		/// </summary>
		public virtual string IdEmpleado
		{
			get { return idEmpleado; }
			set { idEmpleado = value; }
		}

		/// <summary>
		/// Gets or sets the IdArea value.
		/// </summary>
		public virtual string IdArea
		{
			get { return idArea; }
			set { idArea = value; }
		}

		/// <summary>
		/// Gets or sets the Recibido value.
		/// </summary>
		public virtual bool Recibido
		{
			get { return recibido; }
			set { recibido = value; }
		}

		/// <summary>
		/// Gets or sets the Visado value.
		/// </summary>
		public virtual bool Visado
		{
			get { return visado; }
			set { visado = value; }
		}

		/// <summary>
		/// Gets or sets the Firmado value.
		/// </summary>
		public virtual bool Firmado
		{
			get { return firmado; }
			set { firmado = value; }
		}

		/// <summary>
		/// Gets or sets the IdImagen value.
		/// </summary>
		public virtual string IdImagen
		{
			get { return idImagen; }
			set { idImagen = value; }
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
