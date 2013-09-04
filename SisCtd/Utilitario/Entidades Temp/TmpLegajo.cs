using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BESisCtd
{
    public class TmpLegajo
    {
        #region Fields

        private string _Legajo;
        private string _CodTrab;
        private string _TipoNumDoi;
        private string _NomCompeto;
		#endregion

		#region Constructors

		public TmpLegajo()
		{
		}

        public TmpLegajo(string Legajo, string CodTrab, string TipoNumDoi, string NomCompeto)
		{
            _Legajo = Legajo;
            _CodTrab = CodTrab;
            _TipoNumDoi = TipoNumDoi;
            _NomCompeto = NomCompeto;

        }

		#endregion

		#region Properties

        public string Legajo
        {
            get { return _Legajo; }
            set { _Legajo = value; }
        }
        public string CodTrab
        {
            get { return _CodTrab; }
            set { _CodTrab = value; }
        }
        public string TipoNumDoi
        {
            get { return _TipoNumDoi; }
            set { _TipoNumDoi = value; }
        }
        public string NomCompeto
        {
            get { return _NomCompeto; }
            set { _NomCompeto = value; }
        }

		#endregion
    }
    public class TmpLegajos
    {
        private List<TmpLegajo> _Lista = new List<TmpLegajo>();

        public TmpLegajos(TmpLegajo oTmpLegajo)
        {
            _Lista.Add(oTmpLegajo);
        }
        public TmpLegajos()
        {
        }

        public List<TmpLegajo> Lista
        {
            get { return _Lista; }
            set { _Lista = value; }
        }

    }

}
