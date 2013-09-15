using System;

namespace BESisCtd
{
    public class BE_T_TipoDocumento
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the T_TipoDocumento class.
        /// </summary>
        public BE_T_TipoDocumento()
        {
        }

        /// <summary>
        /// Initializes a new instance of the T_TipoDocumento class.
        /// </summary>
        public BE_T_TipoDocumento(string idCliente, string idTipoDocumento, string descripcion, string descripcionLarga, bool verificable, bool critico, bool digitalizable, bool estado, DateTime fechaRegistro, string horaRegistro, string usuarioRegistro)
        {
            this.IdCliente = idCliente;
            this.IdTipoDocumento = idTipoDocumento;
            this.Descripcion = descripcion;
            this.DescripcionLarga = descripcionLarga;
            this.Verificable = verificable;
            this.Critico = critico;
            this.Digitalizable = digitalizable;
            this.Estado = estado;
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
        /// Gets or sets the IdTipoDocumento value.
        /// </summary>
        public string IdTipoDocumento { get; set; }

        /// <summary>
        /// Gets or sets the Descripcion value.
        /// </summary>
        public string Descripcion { get; set; }

        /// <summary>
        /// Gets or sets the DescripcionLarga value.
        /// </summary>
        public string DescripcionLarga { get; set; }

        /// <summary>
        /// Gets or sets the Verificable value.
        /// </summary>
        public bool Verificable { get; set; }

        /// <summary>
        /// Gets or sets the Critico value.
        /// </summary>
        public bool Critico { get; set; }

        /// <summary>
        /// Gets or sets the Digitalizable value.
        /// </summary>
        public bool Digitalizable { get; set; }

        /// <summary>
        /// Gets or sets the Estado value.
        /// </summary>
        public bool Estado { get; set; }

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
