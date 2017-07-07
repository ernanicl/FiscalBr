using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FiscalBr.Common;

namespace FiscalBr.App
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void btnMotorTributarioIbpt_Click(object sender, EventArgs e)
        {
            MdiHelper.MdiContainer.NovaInstanciaChildren(typeof(frmMotorTributario));
        }
    }
}
