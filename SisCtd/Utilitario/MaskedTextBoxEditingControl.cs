using System;
using System.Windows.Forms;

namespace SisCtd
{
    public class MaskedTextBoxEditingControl: MaskedTextBox, IDataGridViewEditingControl
    {
        protected int rowIndex;
        protected DataGridView dataGridView;
        protected bool valueChanged = false;

        public MaskedTextBoxEditingControl()
        {

        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            NotifyDataGridViewOfValueChange();
        }


        protected virtual void NotifyDataGridViewOfValueChange()
        {
            this.valueChanged = true;
            if (this.dataGridView != null)
            {
                this.dataGridView.NotifyCurrentCellDirty(true);
            }
        }

        #region IDataGridViewEditingControl Members
        
        public Cursor EditingPanelCursor
        {
            get
            {
                return Cursors.IBeam;
            }
        }
        public DataGridView EditingControlDataGridView
        {
            get
            {
                return this.dataGridView;
            }

            set
            {
                this.dataGridView = value;
            }
        }

        public object EditingControlFormattedValue
        {
            set
            {
                this.Text = value.ToString();
                NotifyDataGridViewOfValueChange();
            }
            get
            {
                return this.Text;
            }

        }
        public object GetEditingControlFormattedValue(DataGridViewDataErrorContexts context)        
        {
            return this.Text;
        }
        public bool EditingControlWantsInputKey(Keys keyData, bool dataGridViewWantsInputKey)
        {
            switch (keyData & Keys.KeyCode)
            {
                //case Keys.Right:                    
                //    if (!(this.SelectionLength == 0
                //          && this.SelectionStart == this.ToString().Length))
                //    {
                //        return true;
                //    }
                //    break;

                //case Keys.Left:                   
                //    if (!(this.SelectionLength == 0
                //          && this.SelectionStart == 0))
                //    {
                //        return true;
                //    }
                //    break;
                case Keys.Up:
                case Keys.Down:
                case Keys.Right:
                case Keys.Left:
                case Keys.Home:
                case Keys.End:
                    if (this.SelectionLength != this.ToString().Length)
                    {
                        return true;
                    }
                    break;
                case Keys.Prior:
                case Keys.Next:
                    if (this.valueChanged)
                    {
                        return true;
                    }
                    break;
                case Keys.Delete:
                    if (this.SelectionLength > 0 || this.SelectionStart < this.ToString().Length)
                    {
                        return true;
                    }
                    break;
            }
            if (keyData == Keys.Escape) Helper.bEsc = true; else Helper.bEsc = false;
            return !dataGridViewWantsInputKey;
        }
        
        public void PrepareEditingControlForEdit(bool selectAll)
        {
            if (selectAll)
            {
                SelectAll();
            }
            else
            {               
                this.SelectionStart = this.ToString().Length;
            }
        }       
        public bool RepositionEditingControlOnValueChange
        {
            get
            {
                return false;
            }
        }       
        public int EditingControlRowIndex
        {
            get
            {
                return this.rowIndex;
            }

            set
            {
                this.rowIndex = value;
            }
        }
      
        public void ApplyCellStyleToEditingControl(DataGridViewCellStyle dataGridViewCellStyle)
        {
            this.Font = dataGridViewCellStyle.Font;
            this.ForeColor = dataGridViewCellStyle.ForeColor;
            this.BackColor = dataGridViewCellStyle.BackColor;
            this.TextAlign = translateAlignment(dataGridViewCellStyle.Alignment);
        }
        
        public bool EditingControlValueChanged
        {
            get
            {
                return valueChanged;
            }

            set
            {
                this.valueChanged = value;
            }
        }
    
		#endregion // IDataGridViewEditingControl.		
        
        private static HorizontalAlignment translateAlignment(DataGridViewContentAlignment align)
        {
            switch (align)
            {
                case DataGridViewContentAlignment.TopLeft:
                case DataGridViewContentAlignment.MiddleLeft:
                case DataGridViewContentAlignment.BottomLeft:
                    return HorizontalAlignment.Left;

                case DataGridViewContentAlignment.TopCenter:
                case DataGridViewContentAlignment.MiddleCenter:
                case DataGridViewContentAlignment.BottomCenter:
                    return HorizontalAlignment.Center;

                case DataGridViewContentAlignment.TopRight:
                case DataGridViewContentAlignment.MiddleRight:
                case DataGridViewContentAlignment.BottomRight:
                    return HorizontalAlignment.Right;
            }

            throw new ArgumentException("Error: Invalid Content Alignment!");
        }


    }
}
