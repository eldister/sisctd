using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
namespace SisCtd
{
    public class TmpSeparadora
	{
		#region Fields

        private string _IdSeparadora;
        private string _Descripcion;
        private List<TmpDocumento> _Documentos = new List<TmpDocumento>();
		#endregion

		#region Constructors

		public TmpSeparadora()
		{

		}

        public TmpSeparadora(string IdSeparadora, string Descripcion)
		{
            this._IdSeparadora = IdSeparadora;
			this._Descripcion = Descripcion;
		}
        public TmpSeparadora(TmpSeparadora oSepa)
        {
            this._IdSeparadora = oSepa.IdSeparadora;
            this._Descripcion = oSepa.Descripcion;
        }

		#endregion

		#region Properties
		
        public virtual string IdSeparadora
        {
            get { return _IdSeparadora; }
            set { _IdSeparadora = value; }
        }

        public virtual string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        public virtual List<TmpDocumento> Documentos
        {
            get { return _Documentos; }
            set { _Documentos = value; }
        }

		#endregion

       
	}
}
