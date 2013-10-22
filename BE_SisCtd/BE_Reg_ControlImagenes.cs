using System;

namespace BESisCtd
{
	public class BE_Reg_ControlImagenes
	{
		#region Fields

		private string idCliente;
		private string idimagen;
		private byte[] imagen;
		private int totalPaginas;
		private int pesoArchivo;
		private bool estado;
		private string extensionImagen;
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
        public BE_Reg_ControlImagenes(string idCliente, string idimagen, byte[] imagen, int totalPaginas, int pesoArchivo, bool estado, string extensionImagen, DateTime fechaRegistro, string horaRegistro, string usuarioRegistro)
		{
			this.idCliente = idCliente;
			this.idimagen = idimagen;
			this.imagen = imagen;
			this.totalPaginas = totalPaginas;
			this.pesoArchivo = pesoArchivo;
			this.estado = estado;
			this.extensionImagen = extensionImagen;
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
		/// Gets or sets the Imagen value.
		/// </summary>
		public virtual byte[] Imagen
		{
			get { return imagen; }
			set { imagen = value; }
		}

		/// <summary>
		/// Gets or sets the TotalPaginas value.
		/// </summary>
		public virtual int TotalPaginas
		{
			get { return totalPaginas; }
			set { totalPaginas = value; }
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
		/// Gets or sets the Estado value.
		/// </summary>
		public virtual bool Estado
		{
			get { return estado; }
			set { estado = value; }
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
