using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WinFormsPractice.Model;

namespace WinFormsPractice.View
{
    public partial class CellPhonesControl : UserControl
    {
        private List<TextBox> cellphonesTextBox;
        public CellPhonesControl()
        {
            InitializeComponent();
            cellphonesTextBox = new List<TextBox>();
        }


        public CellPhonesControl(List<string> cellPhones, bool isReadOnly) : this()
        {
            SetCellPhones(cellPhones, isReadOnly);
        }

        private void SetCellPhones(List<string> cellphones, bool isReadOnly = true)
        {
            foreach (Control control in this.cellphonesTextBox)
            {
                this.Controls.Remove(control);
            }

            if (cellphones != null)
            {
                int count = !isReadOnly ? Settings.MaxCellphoneNumber : cellphones.Count();

                for (int i = 0; i < count; i++)
                {
                    TextBox cellphone = new TextBox();
                    cellphone.Size = new Size(259, 20);
                    cellphone.Location = new Point(18, 50 + i * 30);
                    cellphone.Text = (i < cellphones.Count()) ? cellphones[i] : String.Empty;
                    this.cellphonesTextBox.Add(cellphone);
                }

                this.Controls.AddRange(cellphonesTextBox.ToArray());
            }
            else
            {
                SetEmptyCellPhones();
            }
        }

        private void SetEmptyCellPhones()
        {
            foreach (Control control in this.cellphonesTextBox)
            {
                this.Controls.Remove(control);
            }

            for (int i = 0; i < Settings.MaxCellphoneNumber; i++)
            {
                TextBox cellphone = new TextBox();
                cellphone.Size = new Size(259, 20);
                cellphone.Location = new Point(18, 50 + i * 30);
                this.cellphonesTextBox.Add(cellphone);
            }

            this.Controls.AddRange(cellphonesTextBox.ToArray());
        }


        public Cellphones GetCellphones()
        {
            Cellphones cellphones = new Cellphones();

            foreach(TextBox cellphone in this.cellphonesTextBox)
            {
                if (cellphone.Text != String.Empty)
                    cellphones.Add(cellphone.Text);
            }

            return cellphones;
        }

    }
}
