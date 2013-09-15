using System;

namespace BESisCtd
{
    public class BE_T_Area
    {
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
        public BE_T_Area(string idCliente, string idArea, string idGerencia, string descripcion, bool estado, DateTime fechaRegistro, string horaRegistro, string usuarioRegistro)
        {
            this.IdCliente = idCliente;
            this.IdArea = idArea;
            this.IdGerencia = idGerencia;
            this.Descripcion = descripcion;
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
        /// Gets or sets the IdArea value.
        /// </summary>
        public string IdArea { get; set; }

        /// <summary>
        /// Gets or sets the IdGerencia value.
        /// </summary>
        public string IdGerencia { get; set; }

        /// <summary>
        /// Gets or sets the Descripcion value.
        /// </summary>
        public string Descripcion { get; set; }

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
