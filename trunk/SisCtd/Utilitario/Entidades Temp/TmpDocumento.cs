using System;
using System.Collections.Generic;

namespace SisCtd
{
	public class TmpDocumento
	{
		#region Fields

		private string _IdTipoDocumento;
		private string _Descripcion;
        private string _Numero;
        private string _Verificable;
        private string _Critico;
        private string _Digitalizable;
        private string _Fecha;
        private string _Detalle;
        private bool _OrigenIndex;
        private string _TipoLegajo;
        private string _CodigoIM;
        private string _NroOperacion;
        private string _NroSecuencia;
        private List<TmpDocumentoDatos> _Datos = new List<TmpDocumentoDatos>();
		#endregion

		#region Constructors

		public TmpDocumento()
		{
		}

        public TmpDocumento(string IdTipoDocumento, string Descripcion, string Numero, string Verificable, string Critico, string Digitalizable, string Fecha, string Detalle, bool OrigenIndex, string TipoLegajo, string CodigoIM, string NroOperacion, string NroSecuencia)
		{
			this._IdTipoDocumento = IdTipoDocumento;
			this._Descripcion = Descripcion;
            this._Numero = Numero;
            this._Verificable = Verificable;
            this._Critico = Critico;
            this._Digitalizable = Digitalizable;
			this._Fecha = Fecha;
            this._Detalle = Detalle;
            this._OrigenIndex = OrigenIndex;
            this._TipoLegajo = TipoLegajo;
            this._CodigoIM = CodigoIM;
            this._NroOperacion = NroOperacion;
            this._NroSecuencia = NroSecuencia;
        }

		#endregion

		#region Properties
		
		public virtual string IdTipoDocumento
		{
			get { return _IdTipoDocumento; }
			set { _IdTipoDocumento = value; }
		}

		public virtual string Descripcion
		{
			get { return _Descripcion; }
			set { _Descripcion = value; }
		}

        public virtual string Numero
        {
            get { return _Numero; }
            set { _Numero = value; }
        }

        public virtual string Verificable
        {
            get { return _Verificable; }
            set { _Verificable = value; }
        }
        public virtual string Critico
        {
            get { return _Critico; }
            set { _Critico = value; }
        }
		public virtual string Digitalizable
		{
            get { return _Digitalizable; }
            set { _Digitalizable = value; }
		}

		public virtual string Fecha
		{
			get { return _Fecha; }
			set { _Fecha = value; }
		}

        public virtual string Detalle
        {
            get { return _Detalle; }
            set { _Detalle = value; }
        }

        public virtual bool OrigenIndex
        {
            get { return _OrigenIndex; }
            set { _OrigenIndex = value; }
        }

        public virtual List<TmpDocumentoDatos> Datos
        {
            get { return _Datos; }
            set { _Datos = value; }
        }

        public virtual string TipoLegajo
        {
            get { return _TipoLegajo; }
            set { _TipoLegajo = value; }
        }

        public virtual string CodigoIM
        {
            get { return _CodigoIM; }
            set { _CodigoIM = value; }
        }

        public virtual string NroOperacion
        {
            get { return _NroOperacion; }
            set { _NroOperacion = value; }
        }

        public virtual string NroSecuencia
        {
            get { return _NroSecuencia; }
            set { _NroSecuencia = value; }
        }


		#endregion
	}
}
