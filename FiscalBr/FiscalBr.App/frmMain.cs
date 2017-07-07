using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FiscalBr.Common;

namespace FiscalBr.App
{
    public partial class frmMain : Form
    {
        
        private bool _lightTheme = true;

        public frmMain()
        {
            InitializeComponent();

            MdiHelper.MdiContainer = this;
            this.NovaInstanciaChildren(typeof(frmHome));
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
