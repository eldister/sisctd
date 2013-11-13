using System;

namespace BESisCtd
{
	public class BE_T_Ubigeo
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the T_PosicionBE class.
		/// </summary>
		public BE_T_Ubigeo()
		{
		}

		/// <summary>
		/// Initializes a new instance of the T_PosicionBE class.
		/// </summary>
        public BE_T_Ubigeo(string idUbigeo, string descripcion, string DesUbigeo)
		{
			this.IdUbigeo = idUbigeo;
			this.Descripcion = descripcion;
            this.DesUbigeo = DesUbigeo;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the IdCliente value.
		/// </summary>
		public string IdUbigeo { get; set; }

		/// <summary>
		/// Gets or sets the IdDescripcion value.
		/// </summary>
		public string Descripcion { get; set; }

        /// <summary>
        /// Gets or sets the IdDesUbigeo value.
        /// </summary>
        public string DesUbigeo { get; set; }


		/// <summary>
		/// Gets or sets the Estado value.
		/// </summary>

		#endregion
	}
}
