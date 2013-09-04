using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BESisCtd;
namespace BESisCtd
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Frm_Sis_Login fAcceso = new Frm_Sis_Login();
            if (fAcceso.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fAcceso.Close();
                if (BE_Helper.oBE_Sis_Usuario.IdUsuario.ToUpper() == Helper.DecryptText(BE_Helper.oBE_Sis_Usuario.Contraseña).ToUpper())
                {
                    Frm_Sis_Contraseña fDet = new Frm_Sis_Contraseña(true);
                    fDet.ShowDialog();
                    if (fDet.bGrabo)
                    {
                        Application.Run(new Frm_Sis_Principal());
                    }
                }
                else
                {
                    Application.Run(new Frm_Sis_Principal());
                }
            }
        }
    }
}   