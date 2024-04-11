namespace wfa_hobby
{
    partial class ScalaireForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox_ChoixEtudiant = new ComboBox();
            textBox_NombreDeHobby = new TextBox();
            button_CompterNbHobby = new Button();
            SuspendLayout();
            // 
            // comboBox_ChoixEtudiant
            // 
            comboBox_ChoixEtudiant.FormattingEnabled = true;
            comboBox_ChoixEtudiant.Location = new Point(72, 42);
            comboBox_ChoixEtudiant.Name = "comboBox_ChoixEtudiant";
            comboBox_ChoixEtudiant.Size = new Size(344, 23);
            comboBox_ChoixEtudiant.TabIndex = 0;
            // 
            // textBox_NombreDeHobby
            // 
            textBox_NombreDeHobby.Location = new Point(72, 130);
            textBox_NombreDeHobby.Name = "textBox_NombreDeHobby";
            textBox_NombreDeHobby.Size = new Size(344, 23);
            textBox_NombreDeHobby.TabIndex = 1;
            // 
            // button_CompterNbHobby
            // 
            button_CompterNbHobby.Location = new Point(72, 85);
            button_CompterNbHobby.Name = "button_CompterNbHobby";
            button_CompterNbHobby.Size = new Size(344, 23);
            button_CompterNbHobby.TabIndex = 2;
            button_CompterNbHobby.Text = "Calculer";
            button_CompterNbHobby.UseVisualStyleBackColor = true;
            button_CompterNbHobby.Click += button_CompterNbHobby_Click;
            // 
            // ScalaireForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_CompterNbHobby);
            Controls.Add(textBox_NombreDeHobby);
            Controls.Add(comboBox_ChoixEtudiant);
            Name = "ScalaireForm";
            Text = "ScalaireForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox_ChoixEtudiant;
        private TextBox textBox_NombreDeHobby;
        private Button button_CompterNbHobby;
    }
}