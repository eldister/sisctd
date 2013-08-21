using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SisCtd
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Helper.ConfigServidor();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Frm_Sis_Login fAcceso = new Frm_Sis_Login();
            if (fAcceso.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fAcceso.Close();
                if (Helper.oBE_Sis_Usuario.IdUsuario.ToUpper() == Helper.DecryptText(Helper.oBE_Sis_Usuario.Contraseña).ToUpper())
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