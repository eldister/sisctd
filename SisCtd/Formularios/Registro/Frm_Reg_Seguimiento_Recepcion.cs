using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BLSisCtd;
using BESisCtd;
using System.Runtime.InteropServices;
using System.Drawing.Text;
namespace SisCtd
{
    public partial class Frm_Reg_Seguimiento_Recepcion : Form
    {
        #region Declaración Variables

        BL_Reg_Control oBL_Reg_Control = new BL_Reg_Control();
        BE_Reg_Control oBE_Reg_Control = new BE_Reg_Control();
        BE_Reg_ControlDetalle oBE_Reg_ControlDetalle = new BE_Reg_ControlDetalle();
        BE_T_Empleado oBE_T_Empleado = new BE_T_Empleado();

        BL_T_TipoDocumento oBL_T_TipoDocumento = new BL_T_TipoDocumento();
        BL_T_MaestroCliente oBL_T_MaestroCliente = new BL_T_MaestroCliente();
        BL_T_Actividad oBL_T_Actividad = new BL_T_Actividad();
        BL_T_Oficina oBL_T_Oficina = new BL_T_Oficina();
        BL_Sis_Usuario oBL_Sis_Usuario = new BL_Sis_Usuario();
        BL_T_Empleado oBL_T_Empleado = new BL_T_Empleado();
        BL_T_Area oBL_T_Area = new BL_T_Area();

        #endregion

        #region Iniciar Formulario
        public Frm_Reg_Seguimiento_Recepcion()
        {
            InitializeComponent();

        }
        private void Frm_Reg_Seguimiento_Recepcion_Load(object sender, EventArgs e)
        {
            lblFechaRecepcion.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        private void Frm_Reg_Seguimiento_Recepcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape)) this.Close();
        }


        #endregion

        #region Metodos


        #endregion

        #region Eventos Objetos

        private void txtIdControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    oBE_Reg_Control = oBL_Reg_Control.Get_Control(txtIdControl.Text);
                    if (oBE_Reg_Control != null)
                    {

                        lblIdTipoDocumento.Text = oBE_Reg_Control.IdTipoDocumento;
                        lblDesTipoDocumento.Text = oBL_T_TipoDocumento.Get_Descripcion(lblIdTipoDocumento.Text);
                        lblIdMaestroCliente.Text = oBE_Reg_Control.IdMaestroCliente;
                        lblDesMaestroCliente.Text = oBL_T_MaestroCliente.Get_RazonSocial(lblIdMaestroCliente.Text);
                        lblNroDocumento.Text = oBE_Reg_Control.NroDocumento;
                        lblFechaDocumento.Text = oBE_Reg_Control.FechaDocumento.ToString("dd/MM/yyyy");
                        txtObservacionGeneral.Text = oBE_Reg_Control.Observacion;


                        string sActividadPendiente = oBL_Reg_Control.ActividadPendiente(txtIdControl.Text);
                        if (sActividadPendiente != "")
                        {
                            MessageBox.Show("Existe una Actividad Pendiente de Envío : " + sActividadPendiente + " . Verificar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            BtnGrabar.Visible = false; txtIdControl.Focus(); return;
                        }

                        oBE_Reg_ControlDetalle = oBL_Reg_Control.Get_ControlDetalleRecepcion(txtIdControl.Text);

                        if (oBE_Reg_ControlDetalle != null)
                        {
                            lblIdActividad.Text = oBE_Reg_ControlDetalle.IdActividad;
                            lblDesActividad.Text = oBL_T_Actividad.Get_Descripcion(lblIdActividad.Text);
                        }
                        else
                        {
                            MessageBox.Show("Ya no hay mas acividades para este control. Verificar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            BtnGrabar.Visible = false; txtIdControl.Focus(); return;
                        }

                        //Validando Actividad con empleado
                        string sIdEmpleado = oBL_Sis_Usuario.Get_IdEmpleado(BE_Helper.oBE_Sis_Usuario.IdUsuario);
                        if (oBL_Reg_Control.Empleado_Valido_Recepcion(sIdEmpleado, lblIdActividad.Text) == false)
                        {
                            MessageBox.Show("Ud. no está autorizado para recepcionar este documento en esta actividad. Verificar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            BtnGrabar.Visible = false; txtIdControl.Focus(); return;
                        }

                        oBE_T_Empleado = oBL_T_Empleado.Get_Empleado(sIdEmpleado);
                        
                        //Buscando Datos de Recepcion con respecto al Empleado

                        lblFechaRecepcion.Text = DateTime.Now.ToString("dd/MM/yyyy");
                        lblIdEmpleado.Text = sIdEmpleado;
                        lblDesEmpleado.Text = oBE_T_Empleado.Nombre;
                        lblIdOficinaRecepcion.Text = oBE_T_Empleado.IdOficina;
                        lblDesOficinaRecepcion.Text = oBL_T_Oficina.Get_Descripcion(lblIdOficinaRecepcion.Text);
                        lblIdAreaRecepcion.Text = oBE_T_Empleado.IdArea;
                        lblDesAreaRecepcion.Text = oBL_T_Area.Get_Descripcion(lblIdAreaRecepcion.Text);


                        txtObservacion.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Control No Existe. Verificar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtIdControl.Focus(); return;
                    }
                }
            }
            catch (Exception Er)
            { MessageBox.Show(this, Er.Message, "Error : " + Er.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }
        private void txtIdControl_TextChanged(object sender, EventArgs e)
        {
            
            lblIdTipoDocumento.Text = "";
            lblDesTipoDocumento.Text = "";
            lblIdMaestroCliente.Text = "";
            lblDesMaestroCliente.Text = "";
            lblNroDocumento.Text = "";
            lblFechaDocumento.Text = "";
            txtObservacionGeneral.Text = "";

            lblIdActividad.Text = "";
            lblDesActividad.Text = "";
            lblIdEmpleado.Text = "";
            lblDesEmpleado.Text = "";
            lblFechaRecepcion.Text = "";
            lblIdOficinaRecepcion.Text = "";
            lblDesOficinaRecepcion.Text = "";
            lblIdAreaRecepcion.Text = "";
            lblDesAreaRecepcion.Text = "";
            txtObservacion.Text = "";

            BtnGrabar.Visible = true;
        }

        private void BtnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblDesTipoDocumento.Text == "")
                {
                    MessageBox.Show("El registro de control no existe. Verificar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtIdControl.Focus(); return;
                }
                if (lblDesActividad.Text == "")
                {
                    MessageBox.Show("El registro de control no tiene actividades pendientes de Recepción. Verificar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtIdControl.Focus(); return;
                }
                if (lblDesEmpleado.Text == "")
                {
                    MessageBox.Show("Ud no tiene acceso a Recepcionar este documento. Verificar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtIdControl.Focus(); return;
                }

                oBE_Reg_ControlDetalle.IdControl = txtIdControl.Text;
                oBE_Reg_ControlDetalle.IdOficinaRecepcion = lblIdOficinaRecepcion.Text;
                oBE_Reg_ControlDetalle.IdEmpleadoRecepcion = lblIdEmpleado.Text;
                oBE_Reg_ControlDetalle.IdAreaRecepcion = lblIdAreaRecepcion.Text;
                oBE_Reg_ControlDetalle.Observacion = txtObservacion.Text;
                oBL_Reg_Control.Recepcionar(oBE_Reg_ControlDetalle);
                MessageBox.Show("Se ha Recepcionado el Control " + txtIdControl.Text + " en la actividad " + lblDesActividad.Text + " forma exitosa", "Mensaje al Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIdControl.Text = "";
                txtIdControl.Focus();
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