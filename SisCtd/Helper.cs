using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Configuration;
using System.IO;
using System.Drawing;
using System.Security.Cryptography;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows;
using System.Data.SqlClient;
using System.Web;
using Microsoft.Win32;
using BESisCtd;
using BLSisCtd;
namespace SisCtd
{
    public class Helper
    {
        public static string sAcceso;

        public static int nForm;
        public static string sRutaImagenesSQL = "";

        public static bool bEsc = false;

        private Helper()
        {

        }

        public enum eOpcion
        {
            Nuevo, Modificar, Consultar
            //, Eliminar, Exportar, Reportar
        }


        public enum eListar
        {
            Grilla, Excel, Reporte
        }

        public enum eTipoFiles
        {
            NUEVO = 0,
            INDEX = 1,
            INDEXINSERT = 2,
            INDEXIN = 3
        }

        public enum eTablas
        {
            Posiciones = 0,
            Gerencias = 1,
            Areas = 2,
            Empleados= 3,
            Territorios= 4,
            Oficinas= 5,
            Estados= 6,
            Actividades= 7,
            Rutas= 8,
            Datos= 9,
            TiposDocumento= 10
        }

        //funciones

        public static void Buscar_ListView(ListView LV, string sValor, Boolean bSubItems)
        {
            ListViewItem foundItem = new ListViewItem();
            foundItem = LV.FindItemWithText(sValor, bSubItems, 0, true);
            if (foundItem != null)
            {
                LV.HideSelection = false;
                LV.Items[foundItem.Index].Selected = true;
                LV.Items[foundItem.Index].EnsureVisible();
            }
        }


        public static void Load_ListView(ListView LV, DataTable miDT, bool bSel)
        {
            LV.Items.Clear();
            LV.Columns.Clear();
            LV.View = View.Details;
            for (int i = 0; i < miDT.Columns.Count; i++)
            {
                LV.Columns.Add(miDT.Columns[i].ToString());
            }
            for (int f = 0; f <= miDT.Rows.Count - 1; f++)
            {
                ListViewItem Dato = new ListViewItem(miDT.Rows[f][0].ToString());
                for (int c = 1; c < miDT.Columns.Count; c++)
                {
                    Dato.SubItems.Add(miDT.Rows[f][c].ToString());
                }
                LV.Items.Add(Dato);
            }
            Colorear_ListView(LV);
            if (miDT.Rows.Count > 0 && bSel == true) LV.Items[0].Selected = true;
        }

        public static void Colorear_ListView(ListView LV)
        {
            int res = 0;
            Color Shaded = Color.Ivory;
            foreach (ListViewItem nF in LV.Items)
            {
                if (res++ % 2 == 1)
                {
                    nF.BackColor = Shaded;
                }
                else
                {
                    nF.BackColor = Color.White;
                }
            }     
        }

        public static int nMesAnterior()
        {
            int nMes = DateTime.Now.Month;
            if (nMes == 1)
            { return 11; }
            else
            {
                return nMes - 2;
            }
        }
        public static int nAnioAnterior()
        {
            int nMes = DateTime.Now.Month;
            int nAnio = DateTime.Now.Year;
            if (nMes == 1)
            { return nAnio - 1; }
            else
            {
                return nAnio;
            }
        }
        public static void Borrar_Filas(DataGridView DG)
        {
            int nFilas = DG.Rows.Count;
            if (nFilas <= 0) { return; }
            for (int i = 0; i <= nFilas - 1; i++)
            {
                DG.Rows.Remove(DG.Rows[0]);
            }
        }
        public static void Borra_Fila(DataGridView DG, int Ind)
        {
            DG.Rows.Remove(DG.Rows[Ind]);
        }
        public static void Buscar_Grilla(DataGridView DG, string sDato, int nCol)
        {
            foreach (DataGridViewRow Fila in DG.Rows)
            {
                if (Fila.Cells[nCol].Value.ToString().IndexOf(sDato) >= 0)
                {
                    Fila.Selected = true;
                    if (Fila.Displayed == false)
                    {
                        DG.FirstDisplayedScrollingRowIndex = Fila.Index;
                    }
                    if (Fila.Cells[nCol].Visible)
                        DG.CurrentCell = Fila.Cells[nCol];
                    else
                        DG.CurrentCell = Fila.Cells[nCol + 1];
                    return;
                }
            }
        }
        public static string Left(string param, int length)
        {
            //we start at 0 since we want to get the characters starting from the
            //left and with the specified lenght and assign it to a variable
            string result = param.Substring(0, length);
            //return the result of the operation
            return result;
        }
        public static string Right(string param, int length)
        {
            //start at the index based on the lenght of the sting minus
            //the specified lenght and assign it a variable
            string result = param.Substring(param.Length - length, length);
            //return the result of the operation
            return result;
        }
        public static string Mid(string param, int startIndex, int length)
        {
            //start at the specified index in the string ang get N number of
            //characters depending on the lenght and assign it to a variable
            string result = param.Substring(startIndex, length);
            //return the result of the operation
            return result;
        }
        public static string Mid(string param, int startIndex)
        {
            //start at the specified index and return all characters after it
            //and assign it to a variable
            string result = param.Substring(startIndex);
            //return the result of the operation
            return result;
        }
        public static void LLenar_Combobox(DataTable DT, ComboBox CBO, int nCol)
        {
            try
            {
                CBO.Items.Clear();
                System.Object[] ItemObject = new System.Object[DT.Rows.Count];
                for (int i = 0; i <= DT.Rows.Count - 1; i++)
                {
                    ItemObject[i] = DT.Rows[i][nCol].ToString();
                }
                CBO.Items.AddRange(ItemObject);
                CBO.Text = "";
            }
            catch (Exception ex) { throw ex; }
            finally { if (DT != null) { DT = null; } }
        }
        public static void LLenar_Listbox(DataTable DT, ListBox LST, int nCol)
        {
            try
            {
                LST.Items.Clear();
                System.Object[] ItemObject = new System.Object[DT.Rows.Count];
                for (int i = 0; i <= DT.Rows.Count - 1; i++)
                {
                    ItemObject[i] = DT.Rows[i][nCol].ToString();
                }
                LST.Items.AddRange(ItemObject);
                LST.Text = "";
            }
            catch (Exception ex) { throw ex; }
            finally { if (DT != null) { DT = null; } }
        }
        public static void LLenar_Campos_Text(DataTable DT, TextBox Txt)
        {
            try
            {
                Txt.AutoCompleteCustomSource.Clear();
                for (int i = 0; i <= DT.Rows.Count - 1; i++)
                {
                    Txt.AutoCompleteCustomSource.Add(DT.Rows[i][0].ToString());
                }
            }
            catch (Exception ex) { throw ex; }
            finally { if (DT != null) { DT = null; } }
        }
        public static void LLenar_Combobox(DataTable DT, ComboBox CBO, string sTexto, string sValor)
        {
            try
            {
                CBO.DataSource = DT;
                CBO.DisplayMember = sTexto;
                CBO.ValueMember = sValor;
                CBO.SelectedIndex = -1;
            }
            catch (Exception ex) { throw ex; }
            finally { if (DT != null) { DT = null; } }
        }
        public static void LLenar_Listbox(DataTable DT, ListBox LST, string sTexto, string sValor)
        {
            try
            {
                LST.DataSource = DT;
                LST.DisplayMember = sTexto;
                LST.ValueMember = sValor;
                LST.SelectedIndex = -1;
            }
            catch (Exception ex) { throw ex; }
            finally { if (DT != null) { DT = null; } }
        }
        public static void FormatoGrilla(DataGridView DG)
        {
            DG.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Courier New", 8);
            DG.AutoResizeColumns();
        }
        public static void FormatoGrilla(DataGridView DG, Boolean bAutoSize)
        {
            DG.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Courier New", 8);
            if (bAutoSize) DG.AutoResizeColumns();
        }

        public static string EncryptText(string strText)
        {
            return Encrypt(strText, "&%#*@,:?");
        }
        public static string DecryptText(string strText)
        {
            return Decrypt(strText, "&%#*@,:?");
        }

        private static string Decrypt(string stringToDecrypt, string sEncryptionKey)
        {
            byte[] key = { };
            byte[] IV = { 0x12, 0xCD, 0x56, 0x34, 0x90, 0xAB, 0xEF, 0x78 };
            byte[] inputByteArray = new byte[stringToDecrypt.Length];

            key = System.Text.Encoding.UTF8.GetBytes(sEncryptionKey.Substring(0, 8));
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            inputByteArray = Convert.FromBase64String(stringToDecrypt);
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(key, IV), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();

            System.Text.Encoding encoding = System.Text.Encoding.UTF8;
            return encoding.GetString(ms.ToArray());
        }

        private static string Encrypt(string stringToEncrypt, string sEncryptionKey)
        {
            byte[] key = { };
            byte[] IV = { 0x12, 0xCD, 0x56, 0x34, 0x90, 0xAB, 0xEF, 0x78 };
            key = System.Text.Encoding.UTF8.GetBytes(sEncryptionKey.Substring(0, 8));
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            byte[] inputByteArray = Encoding.UTF8.GetBytes(stringToEncrypt);
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(key, IV), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();
            return Convert.ToBase64String(ms.ToArray());
        }

        public static void Cargar_menu(DataTable DT, string sindicePadre, TreeNode nodePadre, TreeView TreOpc, Boolean bExpande)
        {
            DataView dataViewHijos = new DataView(DT);
            dataViewHijos.RowFilter = DT.Columns["sIdMenuPadre"].ColumnName + " = '" + sindicePadre + "'" ;
            foreach (DataRowView dataRowCurrent in dataViewHijos)
            {
                TreeNode nuevoNodo = new TreeNode();
                nuevoNodo.Text = dataRowCurrent["descripcion"].ToString().Trim();
                nuevoNodo.Name = dataRowCurrent["IdMenu"].ToString().Trim();
                string sIdMenuPadre = dataRowCurrent["sIdMenuPadre"].ToString().Trim();
                Boolean bAgrupador = (Boolean)dataRowCurrent["Agrupador"];

                switch (bAgrupador)
                {
                    case true:
                        nuevoNodo.ImageIndex = 0; nuevoNodo.SelectedImageIndex = 0;
                        break;
                    case false:
                        nuevoNodo.ImageIndex = 1; nuevoNodo.SelectedImageIndex = 1;
                        break;
                }

                if (nodePadre == null)
                {
                    TreOpc.Nodes.Add(nuevoNodo);
                }
                else
                {
                    nodePadre.Nodes.Add(nuevoNodo);
                    if (bExpande == true) nodePadre.ExpandAll();
                }
                Cargar_menu(DT, dataRowCurrent["IdMenu"].ToString(), nuevoNodo, TreOpc, bExpande);
            }
        }

        public static void Exportar(DataTable Dt, params string[] sNombres)
        {
            try
            {
                if (Dt.Rows.Count <= 0)
                {
                    MessageBox.Show("No hay Registros a Exportar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                }
                string sNombre = "";
                if (sNombres.Length == 1) sNombre = sNombres[0];
                SaveFileDialog CD = new SaveFileDialog();
                CD.Filter = "Libro de Microsoft Office Excel (*.xls) |*.xls";
                CD.FileName = sNombre;
                CD.Title = " Ingrese un Nombre para el Archivo Excel";
                string sRuta = "";
                if (CD.ShowDialog() == DialogResult.Cancel) return;
                if (CD.FileName != "")
                {
                    sRuta = CD.FileName;
                    System.IO.File.Delete(sRuta);
                    CD = null;
                }
                else
                {
                    return;
                }

                System.IO.StreamWriter excelDoc;

                excelDoc = new System.IO.StreamWriter(sRuta);
                const string startExcelXML = "<xml version>\r\n<Workbook " +
                      "xmlns=\"urn:schemas-microsoft-com:office:spreadsheet\"\r\n" +
                      " xmlns:o=\"urn:schemas-microsoft-com:office:office\"\r\n " +
                      "xmlns:x=\"urn:schemas-    microsoft-com:office:" +
                      "excel\"\r\n xmlns:ss=\"urn:schemas-microsoft-com:" +
                      "office:spreadsheet\">\r\n <Styles>\r\n " +
                      "<Style ss:ID=\"Default\" ss:Name=\"Normal\">\r\n " +
                      "<Alignment ss:Vertical=\"Bottom\"/>\r\n <Borders/>" +
                      "\r\n <Font/>\r\n <Interior/>\r\n <NumberFormat/>" +
                      "\r\n <Protection/>\r\n </Style>\r\n " +
                      "<Style ss:ID=\"BoldColumn\">\r\n <Font " +
                      "x:Family=\"Swiss\" ss:Bold=\"1\"/>\r\n </Style>\r\n " +
                      "<Style     ss:ID=\"StringLiteral\">\r\n <NumberFormat" +
                      " ss:Format=\"@\"/>\r\n </Style>\r\n <Style " +
                      "ss:ID=\"Decimal\">\r\n <NumberFormat " +
                      "ss:Format=\"0.0000\"/>\r\n </Style>\r\n " +
                      "<Style ss:ID=\"Integer\">\r\n <NumberFormat " +
                      "ss:Format=\"0\"/>\r\n </Style>\r\n <Style " +
                      "ss:ID=\"DateLiteral\">\r\n <NumberFormat " +
                      "ss:Format=\"mm/dd/yyyy;@\"/>\r\n </Style>\r\n " +
                      "</Styles>\r\n ";
                const string endExcelXML = "</Workbook>";

                int rowCount = 0;
                int sheetCount = 1;

                excelDoc.Write(startExcelXML);
                excelDoc.Write("<Worksheet ss:Name=\"Sheet" + sheetCount + "\">");
                excelDoc.Write("<Table>");
                excelDoc.Write("<Row>");
                for (int x = 0; x < Dt.Columns.Count; x++)
                {
                    excelDoc.Write("<Cell ss:StyleID=\"BoldColumn\"><Data ss:Type=\"String\">");
                    excelDoc.Write(Dt.Columns[x].ColumnName);
                    excelDoc.Write("</Data></Cell>");
                }
                excelDoc.Write("</Row>");
                foreach (DataRow x in Dt.Rows)
                {
                    rowCount++;
                    //if the number of rows is > 64000 create a new page to continue output
                    if (rowCount == 64000)
                    {
                        rowCount = 0;
                        sheetCount++;
                        excelDoc.Write("</Table>");
                        excelDoc.Write(" </Worksheet>");
                        excelDoc.Write("<Worksheet ss:Name=\"Sheet" + sheetCount + "\">");
                        excelDoc.Write("<Table>");
                    }
                    excelDoc.Write("<Row>"); //ID=" + rowCount + "
                    for (int y = 0; y < Dt.Columns.Count; y++)
                    {
                        System.Type rowType;
                        rowType = x[y].GetType();
                        switch (rowType.ToString())
                        {
                            case "System.String":
                                string XMLstring = x[y].ToString();
                                XMLstring = XMLstring.Trim();
                                XMLstring = XMLstring.Replace("&", "&");
                                XMLstring = XMLstring.Replace(">", " ");
                                XMLstring = XMLstring.Replace("<", " ");
                                XMLstring = XMLstring.Replace("+", " ");
                                excelDoc.Write("<Cell ss:StyleID=\"StringLiteral\">" +
                                               "<Data ss:Type=\"String\">");
                                excelDoc.Write(XMLstring);
                                excelDoc.Write("</Data></Cell>");
                                break;
                            case "System.DateTime":
                                //Excel has a specific Date Format of YYYY-MM-DD followed by  
                                //the letter 'T' then hh:mm:sss.lll Example 2005-01-31T24:01:21.000
                                //The Following Code puts the date stored in XMLDate 
                                //to the format above
                                DateTime XMLDate = (DateTime)x[y];
                                string XMLDatetoString = ""; //Excel Converted Date
                                //XMLDatetoString = XMLDate.Year.ToString() +
                                //     "-" +
                                //     (XMLDate.Month < 10 ? "0" +
                                //     XMLDate.Month.ToString() : XMLDate.Month.ToString()) +
                                //     "-" +
                                //     (XMLDate.Day < 10 ? "0" +
                                //     XMLDate.Day.ToString() : XMLDate.Day.ToString()) +
                                //     "T" +
                                //     (XMLDate.Hour < 10 ? "0" +
                                //     XMLDate.Hour.ToString() : XMLDate.Hour.ToString()) +
                                //     ":" +
                                //     (XMLDate.Minute < 10 ? "0" +
                                //     XMLDate.Minute.ToString() : XMLDate.Minute.ToString()) +
                                //     ":" +
                                //     (XMLDate.Second < 10 ? "0" +
                                //     XMLDate.Second.ToString() : XMLDate.Second.ToString()) +
                                //     ".000";
                                //excelDoc.Write("<Cell ss:StyleID=\"DateLiteral\">" +
                                //             "<Data ss:Type=\"DateTime\">");
                                //excelDoc.Write(XMLDatetoString);
                                //excelDoc.Write("</Data></Cell>");

                                excelDoc.Write("<Cell ss:StyleID=\"StringLiteral\">" +
                                               "<Data ss:Type=\"String\">");
                                excelDoc.Write(XMLDate.ToString("dd/MM/yyyy"));
                                excelDoc.Write("</Data></Cell>");

                                break;
                            case "System.Boolean":
                                excelDoc.Write("<Cell ss:StyleID=\"StringLiteral\">" +
                                            "<Data ss:Type=\"String\">");
                                excelDoc.Write(x[y].ToString());
                                excelDoc.Write("</Data></Cell>");
                                break;
                            case "System.Int16":
                            case "System.Int32":
                            case "System.Int64":
                            case "System.Byte":
                                excelDoc.Write("<Cell ss:StyleID=\"Integer\">" +
                                        "<Data ss:Type=\"Number\">");
                                excelDoc.Write(x[y].ToString());
                                excelDoc.Write("</Data></Cell>");
                                break;
                            case "System.Decimal":
                            case "System.Double":
                                excelDoc.Write("<Cell ss:StyleID=\"Decimal\">" +
                                      "<Data ss:Type=\"Number\">");
                                excelDoc.Write(x[y].ToString());
                                excelDoc.Write("</Data></Cell>");
                                break;
                            case "System.DBNull":
                                excelDoc.Write("<Cell ss:StyleID=\"StringLiteral\">" +
                                      "<Data ss:Type=\"String\">");
                                excelDoc.Write("");
                                excelDoc.Write("</Data></Cell>");
                                break;
                            default:
                                throw (new Exception(rowType.ToString() + " not handled."));
                        }
                    }
                    excelDoc.Write("</Row>");
                }
                excelDoc.Write("</Table>");
                excelDoc.Write(" </Worksheet>");
                excelDoc.Write(endExcelXML);

                excelDoc.Close();

                System.Diagnostics.Process pExcel = new System.Diagnostics.Process();
                pExcel.StartInfo.FileName = sRuta;
                pExcel.Start();

            }
            catch (Exception ex) { throw ex; }
        }


        public static void MostrarReporte(string sTitulo, string nombrereporte, DataTable Dt, params string[] matriz)
        {
            Frm_Sis_ReportesView forma = new Frm_Sis_ReportesView();
            ReportDocument rpt = new ReportDocument();
            try
            {
                string rutaRpt = Helper.fRutaReporte();
                rpt.Load(rutaRpt + nombrereporte + ".rpt", OpenReportMethod.OpenReportByDefault);
                rpt.SetDataSource(Dt);
                for (int c = 0; c < matriz.Length; c++)
                {
                    rpt.DataDefinition.FormulaFields[c].Text = "'" + matriz[c].ToString() + "'";
                }
                forma.Report.ReportSource = rpt;
                forma.Text = sTitulo;
                forma.ShowDialog();
                forma.Dispose();
                rpt.Dispose();
            }
            catch (Exception ex) { throw ex; }
            finally { forma = null; rpt = null; }
        }
        public static void LoadReporte()
        {
            Frm_Sis_ReportesView forma = new Frm_Sis_ReportesView();
            ReportDocument rpt = new ReportDocument();
            try
            {
                string rutaRpt = Helper.fRutaReporte();
                rpt.Load(rutaRpt + "usuarios.rpt", OpenReportMethod.OpenReportByDefault);
                forma.Report.ReportSource = rpt;
                forma.Dispose();
                rpt.Dispose();
            }
            catch (Exception ex) { throw ex; }
            finally { forma = null; rpt = null; }
        }

        public static void LLenar_Meses(ComboBox CBO)
        {
            try
            {
                CBO.Items.Clear();
                System.Object[] ItemObject = new System.Object[12];
                ItemObject[0] = "Enero";
                ItemObject[1] = "Febrero";
                ItemObject[2] = "Marzo";
                ItemObject[3] = "Abril";
                ItemObject[4] = "Mayo";
                ItemObject[5] = "Junio";
                ItemObject[6] = "Julio";
                ItemObject[7] = "Agosto";
                ItemObject[8] = "Septiembre";
                ItemObject[9] = "Octubre";
                ItemObject[10] = "Noviembre";
                ItemObject[11] = "Diciembre";
                CBO.Items.AddRange(ItemObject);
                CBO.Text = "";
            }
            catch (Exception ex) { throw ex; }
        }

        public static string NombreMes(string sMes)
        {
            try
            {
                string sNombre = "";
                switch (sMes)
                {
                    case "1":
                    case "01": sNombre = "Enero"; break;
                    case "2":
                    case "02": sNombre = "Febrero"; break;
                    case "3":
                    case "03": sNombre = "Marzo"; break;
                    case "4":
                    case "04": sNombre = "Abril"; break;
                    case "5":
                    case "05": sNombre = "Mayo"; break;
                    case "6":
                    case "06": sNombre = "Junio"; break;
                    case "7":
                    case "07": sNombre = "Julio"; break;
                    case "8":
                    case "08": sNombre = "Agosto"; break;
                    case "9":
                    case "09": sNombre = "Septiembre"; break;
                    case "10": sNombre = "Octubre"; break;
                    case "11": sNombre = "Noviembre"; break;
                    case "12": sNombre = "Diciembre"; break;
                }
                return sNombre;
            }

            catch (Exception ex) { throw ex; }
        }

        public static Boolean GenImagen = false;

        public static void GrabarConfig(string sNombre, string sValor, string sRuta)
        {
            System.Configuration.Configuration config =
            System.Configuration.ConfigurationManager.OpenExeConfiguration(sRuta);

            KeyValueConfigurationElement Element =
                (KeyValueConfigurationElement)config.AppSettings.Settings[sNombre];
            Element.Value = sValor;

            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }
        public static string fRutaReporte()
        {
            ConfigurationManager.RefreshSection("appSettings");
            string sRuta = ConfigurationManager.AppSettings["RutaReportes"]; ;
            if (sRuta == "") { sRuta = System.Windows.Forms.Application.StartupPath + "\\reportes\\"; }
            return sRuta;
        }

        public static string fRutaImagenes(Boolean bGenerar)
        {
            try
            {
                string sRuta = "";

                sRuta = "\\\\10.50.92.141\\Imagenes\\";

                if (bGenerar)
                {
                    string sAño = DateTime.Now.Year.ToString();
                    string sMes = Helper.Right("0" + DateTime.Now.Month.ToString(), 2);

                    sRuta += "\\" + sAño + "\\" + sMes;
                    if (System.IO.Directory.Exists(sRuta) == false)
                    {
                        System.IO.Directory.CreateDirectory(sRuta);
                    }
                }
                return sRuta + "\\";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string fCorreoOrden(string sRuta)
        {
            ConfigurationManager.RefreshSection("appSettings");
            return ConfigurationManager.AppSettings["CorreoOrden"];
        }
        public static string fServidorCorreo()
        {
            ConfigurationManager.RefreshSection("appSettings");
            return ConfigurationManager.AppSettings["ServidorCorreo"]; ;
        }


        //Convirtiendo
        public static string EnLetras(string num, string tip)
        {
            string res = "", dec = "";
            Int64 entero;
            int decimales;
            double nro;
            try
            {
                nro = Convert.ToDouble(num);
            }
            catch { return ""; }
            entero = Convert.ToInt64(Math.Truncate(nro));
            decimales = Convert.ToInt32(Math.Round((nro - entero) * 100, 2));
            if (decimales > 0)
            {
                dec = " CON " + decimales.ToString() + "/100";
            }
            if (tip == "MN")
            {
                res = toText(Convert.ToDouble(entero)) + dec + " NUEVOS SOLES";
            }
            else if (tip == "US")
            {
                res = toText(Convert.ToDouble(entero)) + dec + " DOLARES AMERICANOS";
            }
            return res;
        }
        private static string toText(double value)
        {
            string Num2Text = "";
            value = Math.Truncate(value);
            if (value == 0) Num2Text = "CERO";
            else if (value == 1) Num2Text = "UNO";
            else if (value == 2) Num2Text = "DOS";
            else if (value == 3) Num2Text = "TRES";
            else if (value == 4) Num2Text = "CUATRO";
            else if (value == 5) Num2Text = "CINCO";
            else if (value == 6) Num2Text = "SEIS";
            else if (value == 7) Num2Text = "SIETE";
            else if (value == 8) Num2Text = "OCHO";
            else if (value == 9) Num2Text = "NUEVE";
            else if (value == 10) Num2Text = "DIEZ";
            else if (value == 11) Num2Text = "ONCE";
            else if (value == 12) Num2Text = "DOCE";
            else if (value == 13) Num2Text = "TRECE";
            else if (value == 14) Num2Text = "CATORCE";
            else if (value == 15) Num2Text = "QUINCE";
            else if (value < 20) Num2Text = "DIECI" + toText(value - 10);
            else if (value == 20) Num2Text = "VEINTE";
            else if (value < 30) Num2Text = "VEINTI" + toText(value - 20);
            else if (value == 30) Num2Text = "TREINTA";
            else if (value == 40) Num2Text = "CUARENTA";
            else if (value == 50) Num2Text = "CINCUENTA";
            else if (value == 60) Num2Text = "SESENTA";
            else if (value == 70) Num2Text = "SETENTA";
            else if (value == 80) Num2Text = "OCHENTA";
            else if (value == 90) Num2Text = "NOVENTA";
            else if (value < 100) Num2Text = toText(Math.Truncate(value / 10) * 10) + " Y " + toText(value % 10);
            else if (value == 100) Num2Text = "CIEN";
            else if (value < 200) Num2Text = "CIENTO " + toText(value - 100);
            else if ((value == 200) || (value == 300) || (value == 400) || (value == 600) || (value == 800)) Num2Text = toText(Math.Truncate(value / 100)) + "CIENTOS";
            else if (value == 500) Num2Text = "QUINIENTOS";
            else if (value == 700) Num2Text = "SETECIENTOS";
            else if (value == 900) Num2Text = "NOVECIENTOS";
            else if (value < 1000) Num2Text = toText(Math.Truncate(value / 100) * 100) + " " + toText(value % 100);
            else if (value == 1000) Num2Text = "MIL";
            else if (value < 2000) Num2Text = "MIL " + toText(value % 1000);
            else if (value < 1000000)
            {
                Num2Text = toText(Math.Truncate(value / 1000)) + " MIL";
                if ((value % 1000) > 0) Num2Text = Num2Text + " " + toText(value % 1000);
            }
            else if (value == 1000000) Num2Text = "UN MILLON";
            else if (value < 2000000) Num2Text = "UN MILLON " + toText(value % 1000000);
            else if (value < 1000000000000)
            {
                Num2Text = toText(Math.Truncate(value / 1000000)) + " MILLONES ";
                if ((value - Math.Truncate(value / 1000000) * 1000000) > 0) Num2Text = Num2Text + " " + toText(value - Math.Truncate(value / 1000000) * 1000000);
            }
            else if (value == 1000000000000) Num2Text = "UN BILLON";
            else if (value < 2000000000000) Num2Text = "UN BILLON " + toText(value - Math.Truncate(value / 1000000000000) * 1000000000000);
            else
            {
                Num2Text = toText(Math.Truncate(value / 1000000000000)) + " BILLONES";
                if ((value - Math.Truncate(value / 1000000000000) * 1000000000000) > 0) Num2Text = Num2Text + " " + toText(value - Math.Truncate(value / 1000000000000) * 1000000000000);
            }
            return Num2Text;

        }

        public static void LLenar_Años(ComboBox CBO)
        {
            try
            {
                CBO.Items.Clear();
                int nAñoini = 2000;
                int nAñofin = DateTime.Now.Year + 1;
                int nAños = (nAñofin - nAñoini) + 1;
                System.Object[] ItemObject = new System.Object[nAños];
                for (int i = 0; i < nAños; i++)
                {
                    ItemObject[i] = nAñoini.ToString();
                    nAñoini += 1;
                }
                CBO.Items.AddRange(ItemObject);
                CBO.Text = Convert.ToString(nAñofin - 1);

            }
            catch (Exception ex) { throw ex; }
        }
        public static Boolean AutoCompletar(ComboBox CBO, DataTable Dt, Boolean VoF)
        {
            try
            {
                int intSel;
                if ((VoF == true) | (CBO.Text.Length == 0)) { VoF = false; return VoF; }
                for (int i = 0; i < CBO.Items.Count; i++)
                {
                    if (CBO.Text == Dt.Rows[i][0].ToString().Substring(0, CBO.Text.Length))
                    {
                        intSel = CBO.SelectionStart;
                        CBO.Text = Dt.Rows[i][0].ToString();
                        CBO.SelectionStart = intSel;
                        CBO.SelectionLength = CBO.Text.Length - intSel;
                        break;
                    }
                }
                return VoF;
            }
            catch (Exception ex) { throw ex; }
        }

        public static DataTable paginarDatagridview(DataTable dtPaginar, Int32 inicial, Int32 final)
        {
            DataTable dtnew = new DataTable();
            dtnew = dtPaginar.Clone();
            for (int i = 0; inicial < final; i++)
            {
                if (dtPaginar.Rows.Count != i + 1)
                    dtnew.ImportRow(dtPaginar.Rows[i]);
                else break;
                inicial += 1;
            }
            return dtnew;
        }

        public static bool IsDate(string sCadena)
        {
            string msg;
            try
            {
                if (sCadena == "/  /" | sCadena == "") { return true; }
                string ss = sCadena.Substring(sCadena.Length - 2, 2);

                sCadena = sCadena.Replace(" ", "");
                if (sCadena.Length != 8)
                {
                    msg = "La fecha no tiene el formato correcto, debe ser dd/mm/yy";
                    MessageBox.Show(msg, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                DateTime dFecha = Convert.ToDateTime(sCadena);
                Int32 nAño = dFecha.Year;
                if (nAño < 1900 | nAño > 2050)
                {
                    msg = "La fecha debe ser mayor que 01/01/1900 y menor que 31/12/2050";
                    return false;
                }
                return true;
            }
            catch
            {
                msg = "Ingrese una fecha válida";
                MessageBox.Show(msg, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        //******       
        public static void MostrarImagen(byte[] text, string sExt)
        {
            string ruta = Application.StartupPath + "\\tmp." + sExt;
            if (!Directory.Exists(ruta))
            { File.Delete(ruta); }

            FileStream fs = new FileStream(ruta, FileMode.OpenOrCreate, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);

            try
            {
                for (int i = 0; i < text.Length; i++)
                {
                    bw.Write(text[i]);
                    //if (i == text.Length - 1) MessageBox.Show("sip completo");
                }
                System.Diagnostics.Process.Start("AcroRd32.exe", ruta);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
            finally
            {
                fs.Close();
                fs = null;
                bw = null;
                ruta = "";
            }
        }

        public static void MostrarImagenFisico(string sIdimagen, string sImaMes, string sImaAño)
        {
            string sRuta = Helper.fRutaImagenes(false) + sImaAño + "\\" + sImaMes + "\\" + sIdimagen + ".pdf";
            try
            {
                if (File.Exists(sRuta))
                {
                    System.Diagnostics.Process.Start("AcroRd32.exe", sRuta);
                }
                else
                {
                    MessageBox.Show("No se encontró la Imagen en el Servidor. Verificar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }

        public static byte[] Convertir_Binario(string sNombreArchivo)
        {
            //string sBase64 = "";
            // Declaramos fs para tener acceso a la imagen residente en la maquina cliente. 
            FileStream fs = new FileStream(sNombreArchivo, FileMode.Open);

            // Declaramos un Leector Binario para accesar a los datos de la imagen pasarlos a un arreglo de bytes 
            BinaryReader br = new BinaryReader(fs);
            byte[] bytes = new byte[(int)fs.Length];

            try
            {
                br.Read(bytes, 0, bytes.Length);
                // base64 es la cadena en donde se guarda el arreglo de bytes ya convertido 
                //sBase64 = Convert.ToBase64String(bytes);
                return bytes;
            }
            catch
            {
                MessageBox.Show("Ocurrió un error al cargar el Archivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                return null;
            }

            // Se cierran los archivos para liberar memoria. 
            finally
            {
                fs.Close();
                fs = null;
                br = null;
                bytes = null;
            }
        }

        public static DateTime CFecha(string sFecha)
        {
            if (sFecha != "")
                return Convert.ToDateTime(sFecha);
            else
                return Convert.ToDateTime("01/01/1900");
        }

        public static ToolStripComboBox ComboCliente;

        public static void Cerrar_Ventana(Form mForm, TabControl mTab)
        {
            mForm.Close(); mForm.Dispose();
            mTab.TabPages.Remove(mTab.SelectedTab);
            if (mTab.TabPages.Count <= 0)
            {
                mTab.Visible = false;
                ComboCliente.Enabled = true;
            }
        }

        public static void Buscar(TextBox txt,DataTable Dt)
        {
            Frm_Sis_Busquedas fBus = new Frm_Sis_Busquedas(Dt);
            fBus.ShowDialog();
            if (fBus.sValor != "") txt.Text = fBus.sValor;
            fBus.Dispose();
        }
        public static string Buscar(DataTable Dt)
        {
            string sValor = "";
            Frm_Sis_Busquedas fBus = new Frm_Sis_Busquedas(Dt);
            fBus.ShowDialog();
            if (fBus.sValor != "") sValor = fBus.sValor;
            fBus.Dispose();
            return sValor;
        }

        public static double Sumar_Columna(DataGridView Dg, string sNombreColumna)
        {
            double nPeso = 0;
            foreach (DataGridViewRow Fila in Dg.Rows)
            {
                if (Fila.Cells[sNombreColumna].Value.ToString() != "")
                    nPeso += Convert.ToInt64(Fila.Cells[sNombreColumna].Value.ToString());
            }
            return nPeso;
        }
        public static DialogResult InputBox(string _title, string _promptText, int _maxlength, bool _multiline, ref string _value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = _title;
            label.Text = _promptText;
            textBox.Text = _value;
            textBox.MaxLength = _maxlength;
            textBox.Multiline = _multiline;



            buttonOk.Text = "Aceptar";
            buttonCancel.Text = "Cancelar";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            _value = textBox.Text;
            return dialogResult;
        }

        public static void Cargar_Grilla(List<TmpSeparadora> oSeparadoras, DataGridView DgRrhh,string sTipoLegajo, string sCodigoIM, string sNroOperacion)
        {
            DgRrhh.Rows.Clear();
            int nFila = 0;
            Boolean bPrimerSeparador = true;
            foreach (TmpSeparadora Separadora in oSeparadoras)
            {
                if (!bPrimerSeparador)
                {
                    DgRrhh.Rows.Add("","");
                }
                DgRrhh.Rows.Add(Separadora.Descripcion);
                Boolean bPrimerDocumento = true;
                foreach (TmpDocumento Documento in Separadora.Documentos)
                {
                    if (bPrimerDocumento)
                    {
                        nFila = DgRrhh.Rows.Count - 1;
                        DgRrhh.Rows[nFila].Cells["IDTipoDocumento"].Value = Documento.IdTipoDocumento;
                        DgRrhh.Rows[nFila].Cells["DescripcionDoc"].Value = Documento.Descripcion;
                        DgRrhh.Rows[nFila].Cells["numeroDoc"].Value = Documento.Numero;
                        DgRrhh.Rows[nFila].Cells["VerificableDoc"].Value = Documento.Verificable;
                        DgRrhh.Rows[nFila].Cells["CriticoDoc"].Value = Documento.Critico;
                        DgRrhh.Rows[nFila].Cells["DigitalizableDoc"].Value = Documento.Digitalizable;
                        DgRrhh.Rows[nFila].Cells["FechaDoc"].Value = Documento.Fecha;
                        DgRrhh.Rows[nFila].Cells["DetalleDoc"].Value = Documento.Detalle;
                        DgRrhh.Rows[nFila].Cells["IN"].Value = Documento.OrigenIndex? "X": "";
                        DgRrhh.Rows[nFila].Cells["Index"].Value = Documento.OrigenIndex;
                        DgRrhh.Rows[nFila].Cells["TipoLegajo"].Value = Documento.TipoLegajo;
                        DgRrhh.Rows[nFila].Cells["CodigoIM"].Value = Documento.CodigoIM;
                        DgRrhh.Rows[nFila].Cells["NroOperacion"].Value = Documento.NroOperacion;
                        DgRrhh.Rows[nFila].Cells["NroSecuencia"].Value = Documento.NroSecuencia;
                    }
                    else
                    {
                        DgRrhh.Rows.Add(Separadora.Descripcion, Documento.IdTipoDocumento, Documento.Descripcion, Documento.Numero, Documento.Verificable,Documento.Critico,Documento.Digitalizable, Documento.Fecha, Documento.Detalle, "", "", Documento.OrigenIndex == true ? "X" : "", Documento.OrigenIndex, Documento.TipoLegajo, Documento.CodigoIM, Documento.NroOperacion, Documento.NroSecuencia);
                        nFila = DgRrhh.Rows.Count - 1;
                    }

                    Color vColorDetalle;
                    if (DgRrhh.Rows[nFila].Cells["TipoLegajo"].Value.ToString() == sTipoLegajo &&   DgRrhh.Rows[nFila].Cells["CodigoIM"].Value.ToString() == sCodigoIM &&
                        DgRrhh.Rows[nFila].Cells["NroOperacion"].Value.ToString() == sNroOperacion) { vColorDetalle = Color.LightBlue; }
                    else { vColorDetalle = Color.LightGray; }

                    DgRrhh.Rows[nFila].Cells["IDTipoDocumento"].Style.BackColor = vColorDetalle;
                    DgRrhh.Rows[nFila].Cells["DescripcionDoc"].Style.BackColor = vColorDetalle;
                    DgRrhh.Rows[nFila].Cells["numeroDoc"].Style.BackColor = vColorDetalle;
                    DgRrhh.Rows[nFila].Cells["VerificableDoc"].Style.BackColor = vColorDetalle;
                    DgRrhh.Rows[nFila].Cells["CriticoDoc"].Style.BackColor = vColorDetalle;
                    DgRrhh.Rows[nFila].Cells["DigitalizableDoc"].Style.BackColor = vColorDetalle;
                    DgRrhh.Rows[nFila].Cells["FechaDoc"].Style.BackColor = vColorDetalle;
                    DgRrhh.Rows[nFila].Cells["DetalleDoc"].Style.BackColor = vColorDetalle;
                    DgRrhh.Rows[nFila].Cells["IN"].Style.BackColor = vColorDetalle;

                    Boolean bPrimerDato = true;
                    foreach (TmpDocumentoDatos Dato in Documento.Datos)
                    {
                        if (bPrimerDato)
                        {
                            DgRrhh.Rows[nFila].Cells["Iddato"].Value = Dato.Iddato;
                            DgRrhh.Rows[nFila].Cells["DetalleDato"].Value = Dato.Detalle;
                        }
                        else
                        {
                            DgRrhh.Rows.Add(Separadora.Descripcion, "", "", "", "", "", "", "", "", Dato.Iddato, Dato.Detalle, (bool)DgRrhh.Rows[nFila].Cells["Index"].Value ? "X" : "", DgRrhh.Rows[nFila].Cells["Index"].Value, DgRrhh.Rows[nFila].Cells["TipoLegajo"].Value, DgRrhh.Rows[nFila].Cells["CodigoIM"].Value, DgRrhh.Rows[nFila].Cells["NroOperacion"].Value, DgRrhh.Rows[nFila].Cells["NroSecuencia"].Value);
                            nFila = DgRrhh.Rows.Count - 1;
                        }
                        DgRrhh.Rows[nFila].Cells["Iddato"].Style.BackColor = Color.LightGray;
                        DgRrhh.Rows[nFila].Cells["DetalleDato"].Style.BackColor = Color.LightGray;
                        bPrimerDato = false;
                    }
                    bPrimerDocumento = false;
                }
                bPrimerSeparador = false;
            }
            string sSepaNuevo = "", sSepa = "";
            foreach (DataGridViewRow Fila in DgRrhh.Rows)
            {
                sSepa = Fila.Cells[0].Value.ToString();
                if (sSepa != "")
                {
                    if (sSepa != sSepaNuevo)
                    {
                        Fila.Cells[0].Style.BackColor = Color.Wheat;
                        sSepaNuevo = Fila.Cells[0].Value.ToString();
                    }
                    else
                    {
                        Fila.Cells[0].Value = "";
                    }
                }
            }

        }
    }

}