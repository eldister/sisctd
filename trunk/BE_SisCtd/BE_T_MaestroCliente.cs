using System;

namespace BESisCtd
{
	public class BE_T_MaestroCliente
	{
		#region Fields

		private string idCliente;
		private string idMaestroCliente;
		private string tipoPersona;
		private string tipoDoi;
		private string numeroDoi;
		private string razonSocial;
		private string direccion;
		private string contacto;
		private string telefono1;
		private string telefono2;
		private string fax;
		private string email;
		private DateTime fechaRegistro;
		private string horaRegistro;
		private string usuarioRegistro;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the T_MaestroCliente class.
		/// </summary>
		public BE_T_MaestroCliente()
		{
		}

		/// <summary>
		/// Initializes a new instance of the T_MaestroCliente class.
		/// </summary>
        public BE_T_MaestroCliente(string idCliente, string idMaestroCliente, string tipoPersona, string tipoDoi, string numeroDoi, string razonSocial, string direccion, string contacto, string telefono1, string telefono2, string fax, string email, DateTime fechaRegistro, string horaRegistro, string usuarioRegistro)
		{
			this.idCliente = idCliente;
			this.idMaestroCliente = idMaestroCliente;
			this.tipoPersona = tipoPersona;
			this.tipoDoi = tipoDoi;
			this.numeroDoi = numeroDoi;
			this.razonSocial = razonSocial;
			this.direccion = direccion;
			this.contacto = contacto;
			this.telefono1 = telefono1;
			this.telefono2 = telefono2;
			this.fax = fax;
			this.email = email;
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
		/// Gets or sets the IdMaestroCliente value.
		/// </summary>
		public virtual string IdMaestroCliente
		{
			get { return idMaestroCliente; }
			set { idMaestroCliente = value; }
		}

		/// <summary>
		/// Gets or sets the TipoPersona value.
		/// </summary>
		public virtual string TipoPersona
		{
			get { return tipoPersona; }
			set { tipoPersona = value; }
		}

		/// <summary>
		/// Gets or sets the TipoDoi value.
		/// </summary>
		public virtual string TipoDoi
		{
			get { return tipoDoi; }
			set { tipoDoi = value; }
		}

		/// <summary>
		/// Gets or sets the NumeroDoi value.
		/// </summary>
		public virtual string NumeroDoi
		{
			get { return numeroDoi; }
			set { numeroDoi = value; }
		}

		/// <summary>
		/// Gets or sets the RazonSocial value.
		/// </summary>
		public virtual string RazonSocial
		{
			get { return razonSocial; }
			set { razonSocial = value; }
		}

		/// <summary>
		/// Gets or sets the Direccion value.
		/// </summary>
		public virtual string Direccion
		{
			get { return direccion; }
			set { direccion = value; }
		}

		/// <summary>
		/// Gets or sets the Contacto value.
		/// </summary>
		public virtual string Contacto
		{
			get { return contacto; }
			set { contacto = value; }
		}

		/// <summary>
		/// Gets or sets the Telefono1 value.
		/// </summary>
		public virtual string Telefono1
		{
			get { return telefono1; }
			set { telefono1 = value; }
		}

		/// <summary>
		/// Gets or sets the Telefono2 value.
		/// </summary>
		public virtual string Telefono2
		{
			get { return telefono2; }
			set { telefono2 = value; }
		}

		/// <summary>
		/// Gets or sets the Fax value.
		/// </summary>
		public virtual string Fax
		{
			get { return fax; }
			set { fax = value; }
		}

		/// <summary>
		/// Gets or sets the Email value.
		/// </summary>
		public virtual string Email
		{
			get { return email; }
			set { email = value; }
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
