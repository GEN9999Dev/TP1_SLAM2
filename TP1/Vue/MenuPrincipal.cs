using QuizzAndTest.Model;
using System;
using System.Windows.Forms;

namespace TP1.Model
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }
        public Form activeForm = null;
        public void openChildForm(Form formEnfant)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = formEnfant;
            formEnfant.TopLevel = false;
            formEnfant.FormBorderStyle = FormBorderStyle.None;
            formEnfant.Dock = DockStyle.Fill;
            pnlSf.Controls.Add(formEnfant);
            pnlSf.Tag = formEnfant;
            formEnfant.BringToFront();
            formEnfant.Show();
        }

        private void démarrerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SousFormulaire SF = new SousFormulaire(pnlSf);
            SF.openChildForm(new Form1());
        }

        /*private void affichageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SousFormulaire SF = new SousFormulaire(pnlSf);
            SF.openChildForm(new affDonnee());
        }*/
    }
}
