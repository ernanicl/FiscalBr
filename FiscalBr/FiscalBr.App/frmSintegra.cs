using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FiscalBr.Common;

namespace FiscalBr.App
{
    public partial class frmSintegra : Form
    {
        public frmSintegra()
        {
            InitializeComponent();

            sfMapBrazil.BorderStyle = BorderStyle.None;
        }

        private void frmSintegra_Load(object sender, EventArgs e)
        {
            var extensions = new[] {"dbf", "sbn", "sbx", "shp", "shx"};

            var rootPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Map");
            var filePath = Path.Combine(rootPath, "br.shp");

            for (int i = 0; i < extensions.Length; i++)
            {
                ExtractEmbeddedResource(rootPath, "FiscalBr.App.Map", "br." + extensions[i]);
            }

            EGIS.ShapeFileLib.ShapeFile sf = sfMapBrazil.AddShapeFile(filePath, "ptBr", "NAME");
        }

        private void ExtractEmbeddedResource(string outputDir, string resourceLocation, string file)
        {
            if (!Directory.Exists(outputDir))
                Directory.CreateDirectory(outputDir);

            using (
                System.IO.Stream stream =
                    System.Reflection.Assembly.GetExecutingAssembly()
                        .GetManifestResourceStream(resourceLocation + @"." + file))
            {
                using (
                    System.IO.FileStream fileStream =
                        new System.IO.FileStream(System.IO.Path.Combine(outputDir, file), System.IO.FileMode.Create, FileAccess.ReadWrite)
                    )
                {
                    for (int i = 0; i < stream.Length; i++)
                    {
                        fileStream.WriteByte((byte) stream.ReadByte());
                    }
                    fileStream.Close();
                }
            }
        }

        private void lnkBackTo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MdiHelper.MdiContainer.NovaInstanciaChildren(typeof(frmHome));
        }
    }
}