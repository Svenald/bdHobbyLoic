namespace wfa_hobby
{
    public partial class menuForm : Form
    {
        public menuForm()
        {
            InitializeComponent();
        }

        private void menuForm_Load(object sender, EventArgs e)
        {

        }
        private void ajoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ajouterEtudiantForm maForme = new ajouterEtudiantForm();
            maForme.ShowDialog();
        }
        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modifierDetruireEtudiantForm maForme = new modifierDetruireEtudiantForm();
            maForme.ShowDialog();
        }

        private void hobbyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LierHobbyEtudiant maForme = new LierHobbyEtudiant();
            maForme.ShowDialog();
        }

        private void nombreDeHobbyDun…tudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScalaireForm scalaireForm = new ScalaireForm();
            scalaireForm.ShowDialog();
        }
    }
}