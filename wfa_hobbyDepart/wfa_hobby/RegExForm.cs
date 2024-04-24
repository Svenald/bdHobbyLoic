using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace wfa_hobby
{
    public partial class RegExForm : Form
    {
        public RegExForm()
        {
            InitializeComponent();
        }

        private void RegExForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox_CodePostal_Validating(object sender, CancelEventArgs e)
        {
            bool valid = Regex.IsMatch(textBox_CodePostal.Text, "^([a-zA-Z][0-9]){3}$");
            if (valid)
            {
                errorProvider_Typing.Clear();
            }
            else
            {
                errorProvider_Typing.SetError(textBox_CodePostal, "Mange tes mords");
                e.Cancel = true;//bloque dans le textbox

            }
        }
        private void textBox_ISBN_Validating(object sender, CancelEventArgs e)
        {
            bool valid = Regex.IsMatch(textBox_ISBN.Text, "^([a-zA-Z][0-9]){3}$");
            if (valid)
            {
                errorProvider_Typing.Clear();
            }
            else
            {
                errorProvider_Typing.SetError(textBox_ISBN, "Mange tes mords");
                e.Cancel = true;//bloque dans le textbox

            }
        }

        private void button_Execute_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                MessageBox.Show("Tout est beau, tout est super génial !");
            }
            else
            {
                MessageBox.Show("Superman est mort");
            }
        }


    }
}
