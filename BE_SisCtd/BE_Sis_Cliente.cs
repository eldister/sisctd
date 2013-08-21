using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BESisCtd
{
    public class BE_Sis_Cliente
    {
        #region Fields

        private string _IdCliente;
        private string _Descripcion;
        private bool _Estado;
        private DateTime _FechaRegistro;
        private string _HoraRegistro;
        private string _UsuarioRegistro;
        private List<BE_Sis_Cliente> _Lista = new List<BE_Sis_Cliente>();

        #endregion

        #region Constructors

        public BE_Sis_Cliente(string IdCliente, string Descripcion, bool Estado, DateTime FechaRegistro, string HoraRegistro, string UsuarioRegistro)
            {
                this._IdCliente = IdCliente;
                this._Descripcion = Descripcion;
                this._Estado = Estado;
                this._FechaRegistro = FechaRegistro;
                this._HoraRegistro = HoraRegistro;
                this._UsuarioRegistro = UsuarioRegistro;
            }

        public BE_Sis_Cliente()
        {

        }
        
        public void Agregar(BE_Sis_Cliente oCliente)
        {
            _Lista.Add(oCliente);
        }

        public BE_Sis_Cliente GetRegistro(string sIdCliente)
        { 
            
            foreach(BE_Sis_Cliente i in _Lista)
            {
                if (i.IdCliente == sIdCliente)
                { return i;
                }

            }
            return null;
        }

               
        #endregion

        #region Properties

        public virtual string IdCliente
        {
            get { return _IdCliente; }

            set { _IdCliente = value; }
        }
        public virtual string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        public virtual bool Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }
        public virtual DateTime FechaRegistro
        {
            get { return _FechaRegistro; }
            set { _FechaRegistro = value; }
        }
        public virtual string HoraRegistro
        {
            get { return _HoraRegistro; }
            set { _HoraRegistro = value; }
        }
        public virtual string UsuarioRegistro
        {
            get { return _UsuarioRegistro; }
            set { _UsuarioRegistro = value; }
        }
        public virtual List<BE_Sis_Cliente> Lista
        {
            get { return _Lista; }
            set { _Lista = value; }
        }

        #endregion

    }
}
