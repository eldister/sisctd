using System;

namespace BESisCtd
{
	public class BE_T_MaestroCliente
	{
        //#region Fields

        //private string idCliente;
        //private string idMaestroCliente;
        //private string tipoPersona;
        //private string tipoDoi;
        //private string numeroDoi;
        //private string razonSocial;
        //private string direccion;
        //private string contacto;
        //private string telefono1;
        //private string telefono2;
        //private string fax;
        //private string email;
        //private DateTime fechaRegistro;
        //private string horaRegistro;
        //private string usuarioRegistro;

        //#endregion

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
			this.IdCliente = idCliente;
			this.IdMaestroCliente = idMaestroCliente;
			this.TipoPersona = tipoPersona;
			this.TipoDoi = tipoDoi;
			this.NumeroDoi = numeroDoi;
			this.RazonSocial = razonSocial;
			this.Direccion = direccion;
			this.Contacto = contacto;
			this.Telefono1 = telefono1;
			this.Telefono2 = telefono2;
			this.Fax = fax;
			this.Email = email;
			this.FechaRegistro = fechaRegistro;
			this.HoraRegistro = horaRegistro;
			this.UsuarioRegistro = usuarioRegistro;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the IdCliente value.
		/// </summary>
		public string IdCliente  { get; set; }
        //{
        //    get { return IdCliente; }
        //    set { IdCliente = value; }
        //}

		/// <summary>
		/// Gets or sets the IdMaestroCliente value.
		/// </summary>
		public string IdMaestroCliente  { get; set; }
        //{
        //    get { return IdMaestroCliente; }
        //    set { IdMaestroCliente = value; }
        //}

		/// <summary>
		/// Gets or sets the TipoPersona value.
		/// </summary>
		public  string TipoPersona  { get; set; }
        //{
        //    get { return TipoPersona; }
        //    set { TipoPersona = value; }
        //}

		/// <summary>
		/// Gets or sets the TipoDoi value.
		/// </summary>
		public  string TipoDoi  { get; set; }
        //{
        //    get { return TipoDoi; }
        //    set { TipoDoi = value; }
        //}

		/// <summary>
		/// Gets or sets the NumeroDoi value.
		/// </summary>
		public  string NumeroDoi  { get; set; }
        //{
        //    get { return NumeroDoi; }
        //    set { NumeroDoi = value; }
        //}

		/// <summary>
		/// Gets or sets the RazonSocial value.
		/// </summary>
		public  string RazonSocial  { get; set; }
        //{
        //    get { return RazonSocial; }
        //    set { RazonSocial = value; }
        //}

		/// <summary>
		/// Gets or sets the Direccion value.
		/// </summary>
		public string Direccion  { get; set; }
        //{
        //    get { return Direccion; }
        //    set { Direccion = value; }
        //}

		/// <summary>
		/// Gets or sets the Contacto value.
		/// </summary>
		public  string Contacto  { get; set; }
        //{
        //    get { return Contacto; }
        //    set { Contacto = value; }
        //}

		/// <summary>
		/// Gets or sets the Telefono1 value.
		/// </summary>
		public  string Telefono1  { get; set; }
        //{
        //    get { return Telefono1; }
        //    set { Telefono1 = value; }
        //}

		/// <summary>
		/// Gets or sets the Telefono2 value.
		/// </summary>
		public  string Telefono2  { get; set; }
        //{
        //    get { return Telefono2; }
        //    set { Telefono2 = value; }
        //}

		/// <summary>
		/// Gets or sets the Fax value.
		/// </summary>
		public  string Fax  { get; set; }
        //{
        //    get { return Fax; }
        //    set { Fax = value; }
        //}

		/// <summary>
		/// Gets or sets the Email value.
		/// </summary>
		public  string Email  { get; set; }
        //{
        //    get { return Email; }
        //    set { Email = value; }
        //}

		/// <summary>
		/// Gets or sets the FechaRegistro value.
		/// </summary>
		public  DateTime FechaRegistro  { get; set; }
        //{
        //    get { return FechaRegistro; }
        //    set { FechaRegistro = value; }
        //}

		/// <summary>
		/// Gets or sets the HoraRegistro value.
		/// </summary>
		public  string HoraRegistro  { get; set; }
        //{
        //    get { return HoraRegistro; }
        //    set { HoraRegistro = value; }
        //}

		/// <summary>
		/// Gets or sets the UsuarioRegistro value.
		/// </summary>
		public string UsuarioRegistro  { get; set; }
        //{
        //    get { return UsuarioRegistro; }
        //    set { UsuarioRegistro = value; }
        //}

		#endregion
	}
}
