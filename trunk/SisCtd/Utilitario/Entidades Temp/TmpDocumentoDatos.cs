using System;

namespace SisCtd
{
	public class TmpDocumentoDatos
	{
		#region Fields

		private string _Iddato;
        private string _Detalle;
		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the T_TipoDocumentoDato class.
		/// </summary>
		public TmpDocumentoDatos()
		{
		}

		/// <summary>
		/// Initializes a new instance of the T_TipoDocumentoDato class.
		/// </summary>
		public TmpDocumentoDatos(string Iddato, string Detalle)
		{
			this._Iddato = Iddato;
			this._Detalle = Detalle;
		}

		#endregion

		#region Properties

		public virtual string Iddato
		{
			get { return _Iddato; }
			set { _Iddato = value; }
		}

        public virtual string Detalle
        {
            get { return _Detalle; }
            set { _Detalle = value; }
        }
        
		#endregion
	}
}
