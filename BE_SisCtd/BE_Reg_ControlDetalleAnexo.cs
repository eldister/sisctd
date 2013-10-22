using System;

namespace BESisCtd
{
	public class BE_Reg_ControlDetalleAnexo
	{
		#region Fields

		private string idCliente;
		private int idControl;
		private string nroSecuencia;
		private int idAnexo;
		private string idTipoDocumento;
		private string idImagen;
		private DateTime fechaRegistro;
		private string horaRegistro;
		private string usuarioRegistro;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the Reg_ControlDetalleAnexo class.
		/// </summary>
		public BE_Reg_ControlDetalleAnexo()
		{
		}

		/// <summary>
		/// Initializes a new instance of the Reg_ControlDetalleAnexo class.
		/// </summary>
        public BE_Reg_ControlDetalleAnexo(string idCliente, int idControl, string nroSecuencia, int idAnexo, string idTipoDocumento, string idImagen, DateTime fechaRegistro, string horaRegistro, string usuarioRegistro)
		{
			this.idCliente = idCliente;
			this.idControl = idControl;
			this.nroSecuencia = nroSecuencia;
			this.idAnexo = idAnexo;
			this.idTipoDocumento = idTipoDocumento;
			this.idImagen = idImagen;
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
		/// Gets or sets the IdAnexo value.
		/// </summary>
		public virtual int IdAnexo
		{
			get { return idAnexo; }
			set { idAnexo = value; }
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
		/// Gets or sets the IdImagen value.
		/// </summary>
		public virtual string IdImagen
		{
			get { return idImagen; }
			set { idImagen = value; }
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
