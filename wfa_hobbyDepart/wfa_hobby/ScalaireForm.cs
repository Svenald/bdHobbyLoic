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
    public partial class ScalaireForm : Form
    {
        public ScalaireForm()
        {
            InitializeComponent();
            ManagerEtudiant managerEtudiant = new ManagerEtudiant();
            try
            {
                comboBox_ChoixEtudiant.DataSource = managerEtudiant.AfficherEtudiant();
                comboBox_ChoixEtudiant.DisplayMember = "NomComplet";
                comboBox_ChoixEtudiant.ValueMember = "No_Etudiant";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void button_CompterNbHobby_Click(object sender, EventArgs e)
        {
            var managerEtudiantHobby = new ManagerEtudiantHobby();
            int nombreDeHobby = managerEtudiantHobby.CompterNombreHobby((int)comboBox_ChoixEtudiant.SelectedValue);
            textBox_NombreDeHobby.Text = nombreDeHobby.ToString();
        }
    }
}
