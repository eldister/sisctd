using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BLSisCtd;
using BESisCtd;

namespace SisCtd
{
    public partial class Frm_T_Detalle : Form
    {
        #region Declaraci�n Variables
        public string sIdtabla;
        Helper.eTablas eTabla;
        public Boolean bGrabo = false;
        Helper.eOpcion qOpcion;
        
        BL_T_Posicion oBL_T_Posicion = new BL_T_Posicion();
        BE_T_Posicion oBE_T_Posicion = new BE_T_Posicion();
        BL_T_Gerencia oBL_T_Gerencia = new BL_T_Gerencia();
        BE_T_Gerencia oBE_T_Gerencia = new BE_T_Gerencia();
        BL_T_Ruta oBL_T_Ruta = new BL_T_Ruta();
        BE_T_Ruta oBE_T_Ruta = new BE_T_Ruta();
        BL_T_Actividad oBL_T_Actividad = new BL_T_Actividad();
        BE_T_Actividad oBE_T_Actividad = new BE_T_Actividad();

        #endregion

        #region Iniciar Formulario
        public Frm_T_Detalle(Helper.eOpcion _qOpcion, Helper.eTablas _eTabla, string Idtabla)
        {
            InitializeComponent();
            qOpcion = _qOpcion;
            eTabla = _eTabla;
            sIdtabla = Idtabla;
        }

        private void Frm_T_Detalle_Load(object sender, EventArgs e)
        {
            try
            {
                switch (qOpcion)
                {
                    case Helper.eOpcion.Nuevo:
                        this.Text = " Nuevo";
                        cboEstado.SelectedIndex = 0;
                        break;
                    case Helper.eOpcion.Modificar:
                    case Helper.eOpcion.Consultar:
                        txtCodigo.ReadOnly = true;
                        if (qOpcion == Helper.eOpcion.Consultar)
                        {
                            this.Text = " Consultar";
                            txtDescripcion.ReadOnly = true;
                            BtnGrabar.Visible = false;
                        }
                        else
                        {
                            this.Text = " Modificar";
                        }
                        txtCodigo.Text = sIdtabla.Trim();
                        switch (eTabla)
                        {
                            case Helper.eTablas.Posiciones: oBE_T_Posicion = oBL_T_Posicion.Get_Posicion(sIdtabla);
                                if (oBE_T_Posicion != null)
                                {
                                    txtDescripcion.Text = oBE_T_Posicion.Descripcion;
                                    cboEstado.SelectedIndex = oBE_T_Posicion.Estado ? 0 : 1;
                                }
                                break;
                            case Helper.eTablas.Gerencias: oBE_T_Gerencia = oBL_T_Gerencia.Get_Gerencia(sIdtabla);
                                if (oBE_T_Posicion != null)
                                {
                                    txtDescripcion.Text = oBE_T_Gerencia.Descripcion;
                                    cboEstado.SelectedIndex = oBE_T_Gerencia.Estado ? 0 : 1;
                                }
                                break;
                            case Helper.eTablas.Rutas: oBE_T_Ruta = oBL_T_Ruta.Get_Ruta(sIdtabla);
                                if (oBE_T_Ruta != null)
                                {
                                    txtDescripcion.Text = oBE_T_Ruta.Descripcion;
                                    cboEstado.SelectedIndex = oBE_T_Ruta.Estado ? 0 : 1;
                                }
                                break;
                            case Helper.eTablas.Actividades: oBE_T_Actividad = oBL_T_Actividad.Get_Actividad(sIdtabla);
                                if (oBE_T_Actividad != null)
                                {
                                    txtDescripcion.Text = oBE_T_Actividad.Descripcion;
                                    cboEstado.SelectedIndex = oBE_T_Actividad.Estado ? 0 : 1;
                                }
                                break;

                        }
                        break;
                }
            }
            catch (Exception Er)
            { MessageBox.Show(this, Er.Message, "Error : " + Er.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void Frm_T_Detalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape)) this.Close();
        }
        private void Frm_T_Detalle_Activated(object sender, EventArgs e)
        {
            if (qOpcion == Helper.eOpcion.Modificar) { txtDescripcion.Focus(); }
            if (qOpcion == Helper.eOpcion.Consultar) { BtnCancelar.Focus(); }
        }

        #endregion

        #region Eventos Objetos
        private void BtnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigo.Text.Trim() == "")
                {
                    MessageBox.Show("Ingrese el C�digo", "Validaci�n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCodigo.Focus(); return;
                }
                Boolean bExiste = false;
                if (qOpcion == Helper.eOpcion.Nuevo)
                {
                    switch (eTabla)
                    {
                        case Helper.eTablas.Posiciones: bExiste = oBL_T_Posicion.Existe(txtCodigo.Text); break;
                        case Helper.eTablas.Gerencias: bExiste = oBL_T_Gerencia.Existe(txtCodigo.Text); break;
                        case Helper.eTablas.Rutas: bExiste = oBL_T_Ruta.Existe(txtCodigo.Text); break;
                        case Helper.eTablas.Actividades: bExiste = oBL_T_Actividad.Existe(txtCodigo.Text); break;
                    }
                    if (bExiste)
                    {
                        MessageBox.Show("El C�digo ya existe para esta Tabla. Verificar", "Validaci�n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtCodigo.Focus(); return;
                    }
                }

                if (txtDescripcion.Text.Trim() == "")
                {
                    MessageBox.Show("Ingrese el Nombre o Descripci�n", "Validaci�n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtDescripcion.Focus(); return;
                }

                switch (eTabla)
                {
                    case Helper.eTablas.Posiciones:
                        oBE_T_Posicion.IdPosicion = txtCodigo.Text.Trim();
                        oBE_T_Posicion.Descripcion = txtDescripcion.Text.Trim();
                        oBE_T_Posicion.Estado = (cboEstado.SelectedIndex == 0);
                        break;
                    case Helper.eTablas.Gerencias:
                        oBE_T_Gerencia.IdGerencia = txtCodigo.Text.Trim();
                        oBE_T_Gerencia.Descripcion = txtDescripcion.Text.Trim();
                        oBE_T_Gerencia.Estado = (cboEstado.SelectedIndex == 0);
                        break;
                    case Helper.eTablas.Rutas:
                        oBE_T_Ruta.IdRuta = txtCodigo.Text.Trim();
                        oBE_T_Ruta.Descripcion  = txtDescripcion.Text.Trim();
                        oBE_T_Ruta.Estado  = (cboEstado.SelectedIndex == 0);
                        break;
                    case Helper.eTablas.Actividades:
                        oBE_T_Actividad.IdActividad = txtCodigo.Text.Trim();
                        oBE_T_Actividad.Descripcion = txtDescripcion.Text.Trim();
                        oBE_T_Actividad.Estado = (cboEstado.SelectedIndex == 0);
                        break;

                }

                if (qOpcion == Helper.eOpcion.Nuevo)
                {
                    switch (eTabla)
                    {
                        case Helper.eTablas.Posiciones: oBL_T_Posicion.Insertar(oBE_T_Posicion); break;
                        case Helper.eTablas.Gerencias: oBL_T_Gerencia.Insertar(oBE_T_Gerencia); break;
                        case Helper.eTablas.Rutas: oBL_T_Ruta.Insertar(oBE_T_Ruta); break;
                        case Helper.eTablas.Actividades: oBL_T_Actividad.Insertar(oBE_T_Actividad); break;
                    }
                }
                if (qOpcion == Helper.eOpcion.Modificar)
                {
                    switch (eTabla)
                    {
                        case Helper.eTablas.Posiciones: oBL_T_Posicion.Modificar(oBE_T_Posicion); break;
                        case Helper.eTablas.Gerencias: oBL_T_Gerencia.Modificar(oBE_T_Gerencia); break;
                        case Helper.eTablas.Rutas: oBL_T_Ruta.Modificar(oBE_T_Ruta); break;
                        case Helper.eTablas.Actividades: oBL_T_Actividad.Modificar(oBE_T_Actividad); break;
                    }
                }
                sIdtabla = txtCodigo.Text; bGrabo = true; this.Close();

            }
            catch (Exception Er)
            { MessageBox.Show(this, Er.Message, "Error : " + Er.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}