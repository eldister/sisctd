using System;

namespace BESisCtd
{
	public class BE_Reg_ControlImagenes
	{
		#region Fields

		private string idCliente;
		private string idimagen;
		private string nombre;
		private byte[] archivo;
		private int pesoArchivo;
		private string extensionImagen;
		private bool estado;
		private DateTime fechaRegistro;
		private string horaRegistro;
		private string usuarioRegistro;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the Reg_ControlImagene class.
		/// </summary>
		public BE_Reg_ControlImagenes()
		{
		}

		/// <summary>
		/// Initializes a new instance of the Reg_ControlImagene class.
		/// </summary>
		public BE_Reg_ControlImagenes(string idCliente, string idimagen, string nombre, byte[] archivo, int pesoArchivo, string extensionImagen, bool estado, DateTime fechaRegistro, string horaRegistro, string usuarioRegistro)
		{
			this.idCliente = idCliente;
			this.idimagen = idimagen;
			this.nombre = nombre;
			this.archivo = archivo;
			this.pesoArchivo = pesoArchivo;
			this.extensionImagen = extensionImagen;
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
		/// Gets or sets the Idimagen value.
		/// </summary>
		public virtual string Idimagen
		{
			get { return idimagen; }
			set { idimagen = value; }
		}

		/// <summary>
		/// Gets or sets the Nombre value.
		/// </summary>
		public virtual string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		/// <summary>
		/// Gets or sets the Archivo value.
		/// </summary>
		public virtual byte[] Archivo
		{
			get { return archivo; }
			set { archivo = value; }
		}

		/// <summary>
		/// Gets or sets the PesoArchivo value.
		/// </summary>
		public virtual int PesoArchivo
		{
			get { return pesoArchivo; }
			set { pesoArchivo = value; }
		}

		/// <summary>
		/// Gets or sets the ExtensionImagen value.
		/// </summary>
		public virtual string ExtensionImagen
		{
			get { return extensionImagen; }
			set { extensionImagen = value; }
		}

		/// <summary>
		/// Gets or sets the Estado value.
		/// </summary>
		public virtual bool Estado
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
