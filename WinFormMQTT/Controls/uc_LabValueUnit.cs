using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormMQTT.Controls
{
    public partial class uc_LabValueUnit : UserControl
    {
        public uc_LabValueUnit()
        {
            InitializeComponent();
            this.txt_Value.DoubleClick += Uc_LabValueUnit_DoubleClick;
        }

        public new event EventHandler? DoubleClick;

        private void Uc_LabValueUnit_DoubleClick(object? sender, EventArgs e)
        {
            DoubleClick?.Invoke(sender, e);
        }

        public string Title
        {
            get { return lab_Title.Text; }
            set { lab_Title.Text = value; }
        }
        public string Value
        {
            get { return txt_Value.Text; }
            set { txt_Value.Text = value; }
        }
        public string Unit
        {
            get { return lab_Unit.Text; }
            set { lab_Unit.Text = value; }
        }

  

    }
}
