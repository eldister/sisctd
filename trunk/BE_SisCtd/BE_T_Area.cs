using System;

namespace BESisCtd
{
	public class BE_T_Area
	{
		#region Fields

		private string idCliente;
		private string idArea;
		private string idGerencia;
		private string descripcion;
		private string idEmpleadoResponsable;
		private bool estado;
		private DateTime fechaRegistro;
		private string horaRegistro;
		private string usuarioRegistro;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the T_Area class.
		/// </summary>
		public BE_T_Area()
		{
		}

		/// <summary>
		/// Initializes a new instance of the T_Area class.
		/// </summary>
		public BE_T_Area(string idCliente, string idArea, string idGerencia, string descripcion, string idEmpleadoResponsable, bool estado, DateTime fechaRegistro, string horaRegistro, string usuarioRegistro)
		{
			this.idCliente = idCliente;
			this.idArea = idArea;
			this.idGerencia = idGerencia;
			this.descripcion = descripcion;
			this.idEmpleadoResponsable = idEmpleadoResponsable;
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
		/// Gets or sets the IdArea value.
		/// </summary>
		public virtual string IdArea
		{
			get { return idArea; }
			set { idArea = value; }
		}

		/// <summary>
		/// Gets or sets the IdGerencia value.
		/// </summary>
		public virtual string IdGerencia
		{
			get { return idGerencia; }
			set { idGerencia = value; }
		}

		/// <summary>
		/// Gets or sets the Descripcion value.
		/// </summary>
		public virtual string Descripcion
		{
			get { return descripcion; }
			set { descripcion = value; }
		}

		/// <summary>
		/// Gets or sets the IdEmpleadoResponsable value.
		/// </summary>
		public virtual string IdEmpleadoResponsable
		{
			get { return idEmpleadoResponsable; }
			set { idEmpleadoResponsable = value; }
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
