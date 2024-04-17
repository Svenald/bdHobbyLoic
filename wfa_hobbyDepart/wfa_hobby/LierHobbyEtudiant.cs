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
    public partial class LierHobbyEtudiant : Form
    {
        public LierHobbyEtudiant()
        {
            InitializeComponent();
            ManagerHobby managerHobby = new ManagerHobby();
            try
            {
                comboBox_Hobby.DataSource = managerHobby.ListerHobby();
                comboBox_Hobby.DisplayMember = "nomHobby";
                comboBox_Hobby.ValueMember = "no_hobby";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ManagerEtudiant managerEtudiant = new ManagerEtudiant();
            try
            {
                comboBox_Etudiant.DataSource = managerEtudiant.AfficherEtudiant();
                comboBox_Etudiant.DisplayMember = "NomComplet";
                comboBox_Etudiant.ValueMember = "no_etudiant";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Associer_Click(object sender, EventArgs e)
        {
            Etudiant etudiant = comboBox_Etudiant.SelectedItem as Etudiant;
            Hobby hobby = comboBox_Hobby.SelectedItem as Hobby;

            if (etudiant == null || hobby == null)
            {
                MessageBox.Show("Veuillez choisir un étudiant ou un hobby");
                return;
            }
            try
            {
                ManagerEtudiantHobby managerLierEtudiantHobby = new ManagerEtudiantHobby();
                int nombreLignesAffectees = 0;
                nombreLignesAffectees = managerLierEtudiantHobby.LierHobbyAvecEtudiant(etudiant, hobby);
                if (nombreLignesAffectees > 0)
                {
                    dataGridView_Hobby.DataSource = managerLierEtudiantHobby.ListerLesHobbyDeLEtudiant((int)comboBox_Etudiant.SelectedValue);
                    MessageBox.Show("Ajout réussi");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RemplirHoobyDeLEtudiant()
        {
            try
            {
                ManagerEtudiantHobby managerEtudiantHobby = new ManagerEtudiantHobby();
                dataGridView_Hobby.DataSource = managerEtudiantHobby.ListerLesHobbyDeLEtudiant((int)comboBox_Etudiant.SelectedValue);
                dataGridView_Hobby.RowHeadersVisible = false;
                dataGridView_Hobby.Columns["no_hobby"].Visible = false;
                dataGridView_Hobby.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void comboBox_Etudiant_SelectionChangeCommitted(object sender, EventArgs e)
        {
            RemplirHoobyDeLEtudiant();
        }
    }
}
