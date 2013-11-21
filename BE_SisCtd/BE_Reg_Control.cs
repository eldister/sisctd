using System;

namespace BESisCtd
{
	public class BE_Reg_Control
	{
		#region Fields

		private string idCliente;
		private string idControl;
		private DateTime fechaRecepcion;
		private string idOficinaRecepcion;
		private string idTipoDocumento;
		private string idRuta;
		private string idMaestroCliente;
		private string nroDocumento;
		private DateTime fechaDocumento;
		private string observacion;
		private DateTime fechaInicio;
		private DateTime fechaTermino;
		private string idImagen;
		private string estado;
		private DateTime fechaRegistro;
		private string horaRegistro;
		private string usuarioRegistro;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the Reg_Control class.
		/// </summary>
		public BE_Reg_Control()
		{
		}

		/// <summary>
		/// Initializes a new instance of the Reg_Control class.
		/// </summary>
		public BE_Reg_Control(string idCliente, string idControl, DateTime fechaRecepcion, string idOficinaRecepcion, string idTipoDocumento, string idRuta, string idMaestroCliente, string nroDocumento, DateTime fechaDocumento, string observacion, DateTime fechaInicio, DateTime fechaTermino, string idImagen, string estado, DateTime fechaRegistro, string horaRegistro, string usuarioRegistro)
		{
			this.idCliente = idCliente;
			this.idControl = idControl;
			this.fechaRecepcion = fechaRecepcion;
			this.idOficinaRecepcion = idOficinaRecepcion;
			this.idTipoDocumento = idTipoDocumento;
			this.idRuta = idRuta;
			this.idMaestroCliente = idMaestroCliente;
			this.nroDocumento = nroDocumento;
			this.fechaDocumento = fechaDocumento;
			this.observacion = observacion;
			this.fechaInicio = fechaInicio;
			this.fechaTermino = fechaTermino;
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
		public virtual string IdControl
		{
			get { return idControl; }
			set { idControl = value; }
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
		/// Gets or sets the IdOficinaRecepcion value.
		/// </summary>
		public virtual string IdOficinaRecepcion
		{
			get { return idOficinaRecepcion; }
			set { idOficinaRecepcion = value; }
		}

		/// <summary>
		/// Gets or sets the IdTipoDocumento value.
		/// </summary>
		public virtual string IdTipoDocumento
		{
			get { return idTipoDocumento; }
			set { idTipoDocumento = value; }
		}

		/// <summary>
		/// Gets or sets the IdRuta value.
		/// </summary>
		public virtual string IdRuta
		{
			get { return idRuta; }
			set { idRuta = value; }
		}

		/// <summary>
		/// Gets or sets the IdMaestroCliente value.
		/// </summary>
		public virtual string IdMaestroCliente
		{
			get { return idMaestroCliente; }
			set { idMaestroCliente = value; }
		}

		/// <summary>
		/// Gets or sets the NroDocumento value.
		/// </summary>
		public virtual string NroDocumento
		{
			get { return nroDocumento; }
			set { nroDocumento = value; }
		}

		/// <summary>
		/// Gets or sets the FechaDocumento value.
		/// </summary>
		public virtual DateTime FechaDocumento
		{
			get { return fechaDocumento; }
			set { fechaDocumento = value; }
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
		/// Gets or sets the FechaInicio value.
		/// </summary>
		public virtual DateTime FechaInicio
		{
			get { return fechaInicio; }
			set { fechaInicio = value; }
		}

		/// <summary>
		/// Gets or sets the FechaTermino value.
		/// </summary>
		public virtual DateTime FechaTermino
		{
			get { return fechaTermino; }
			set { fechaTermino = value; }
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
