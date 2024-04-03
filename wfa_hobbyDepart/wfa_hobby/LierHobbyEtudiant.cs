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
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
