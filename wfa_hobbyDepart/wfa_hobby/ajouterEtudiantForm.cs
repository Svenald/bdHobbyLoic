using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfa_hobby
{
    public partial class ajouterEtudiantForm : Form
    {
        public ajouterEtudiantForm()
        {
            InitializeComponent();
        }
       
        private void ajouterEtudiantForm_Load(object sender, EventArgs e)
        {
           
        }

        private bool textBoxRemplis()
        {
            return(prenomTextBox.Text != "" && nomTextBox.Text != "" && cellulaireTextBox.Text != "");
        }
        private Etudiant RemplirColonneEtudiant()
        {
            Etudiant etudiant = new Etudiant();
            etudiant.Prenom = prenomTextBox.Text;
            etudiant.Nom = nomTextBox.Text;
            etudiant.Cellulaire = cellulaireTextBox.Text;
            etudiant.Humour = (int)humourNumericUpDown.Value;
            etudiant.No_provenance = 1;
            return etudiant;
        }

        private void ajouterButton_Click(object sender, EventArgs e)
        {
            ManagerEtudiant managerEtudiant = new ManagerEtudiant();
            Etudiant etudiant = new Etudiant();
            int nombreLignesAffectees = 0;
            try
            {
                if(textBoxRemplis())
                {
                    etudiant = RemplirColonneEtudiant();
                    nombreLignesAffectees = managerEtudiant.AjouterEtudiant(etudiant);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
