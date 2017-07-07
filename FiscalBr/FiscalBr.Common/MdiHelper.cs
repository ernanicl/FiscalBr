using System;
using System.Linq;
using System.Windows.Forms;

namespace FiscalBr.Common
{
    public static class MdiHelper
    {
        public static Form MdiContainer;

        public static void NovaInstanciaChildren(this Form formContainer, Type tipoFormAbrir,
            FormWindowState estadoJanela = FormWindowState.Maximized)
        {
            var nomeClasse = tipoFormAbrir.Name;
            if (formContainer.MdiChildren.Any(f => f.Name == nomeClasse))
            {
                var formAtivar = formContainer.MdiChildren.First(f => f.Name == nomeClasse);
                var formCast = (formContainer as IMdiContainer);

                if (formCast != null)
                    formCast.AtivarMdiChildren(formAtivar);
                formAtivar.Focus();
            }
            else
            {
                var formabrir = (Form)Activator.CreateInstance(tipoFormAbrir);
                formabrir.MdiParent = formContainer;
                formabrir.WindowState = estadoJanela;
                formabrir.Show();
            }
        }
    }

    public interface IMdiContainer
    {
        void AtivarMdiChildren(Form formAtivar);
    }
}
