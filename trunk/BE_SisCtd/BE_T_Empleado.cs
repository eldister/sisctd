using System;

namespace BESisCtd
{
    public class BE_T_Empleado
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the T_Empleado class.
        /// </summary>
        public BE_T_Empleado()
        {
        }

        /// <summary>
        /// Initializes a new instance of the T_Empleado class.
        /// </summary>
        public BE_T_Empleado(string idCliente, string idEmpleado, string idArea, string idPosicion, string nombre, bool estado, DateTime fechaRegistro, string horaRegistro, string usuarioRegistro)
        {
            this.IdCliente = idCliente;
            this.IdEmpleado = idEmpleado;
            this.IdArea = idArea;
            this.IdPosicion = idPosicion;
            this.Nombre = nombre;
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
        /// Gets or sets the IdEmpleado value.
        /// </summary>
        public string IdEmpleado { get; set; }

        /// <summary>
        /// Gets or sets the IdArea value.
        /// </summary>
        public string IdArea { get; set; }

        /// <summary>
        /// Gets or sets the IdPosicion value.
        /// </summary>
        public string IdPosicion { get; set; }

        /// <summary>
        /// Gets or sets the Nombre value.
        /// </summary>
        public string Nombre { get; set; }

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
