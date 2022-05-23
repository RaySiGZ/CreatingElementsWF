using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsControlLibrary1
{
    public partial class NumberBox : TextBox
    {
        public NumberBox()
        {
            InitializeComponent();
        }

        protected override void OnTextChanged(EventArgs e)
        {
            double x;
            if (!double.TryParse(Text, out x))
                ForeColor = Color.Red;
            else
                ForeColor = SystemColors.ControlText;

            base.OnTextChanged(e);
        }
    }
}
