using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizzAndTest.Model
{
    public class SousFormulaire
    {
        public Panel PanelsousFormulaire;
        public Form activeForm = null;

        public SousFormulaire(Panel panelenvoit)
        {
            PanelsousFormulaire = panelenvoit;
        }

        public void openChildForm(Form formEnfant)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = formEnfant;
            formEnfant.TopLevel = false;
            formEnfant.FormBorderStyle = FormBorderStyle.None;
            formEnfant.Dock = DockStyle.Fill;
            PanelsousFormulaire.Controls.Add(formEnfant);
            PanelsousFormulaire.Tag = formEnfant;
            formEnfant.BringToFront();
            formEnfant.Show();
        }
    }
}
