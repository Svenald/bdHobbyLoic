namespace wfa_hobby
{
    partial class LierHobbyEtudiant
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
            comboBox_Hobby = new ComboBox();
            comboBox_Etudiant = new ComboBox();
            label_Etudiant = new Label();
            label2 = new Label();
            button1 = new Button();
            dataGridView_Hobby = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Hobby).BeginInit();
            SuspendLayout();
            // 
            // comboBox_Hobby
            // 
            comboBox_Hobby.FormattingEnabled = true;
            comboBox_Hobby.Location = new Point(71, 42);
            comboBox_Hobby.Name = "comboBox_Hobby";
            comboBox_Hobby.Size = new Size(235, 23);
            comboBox_Hobby.TabIndex = 0;
            // 
            // comboBox_Etudiant
            // 
            comboBox_Etudiant.FormattingEnabled = true;
            comboBox_Etudiant.Location = new Point(71, 6);
            comboBox_Etudiant.Name = "comboBox_Etudiant";
            comboBox_Etudiant.Size = new Size(235, 23);
            comboBox_Etudiant.TabIndex = 1;
            comboBox_Etudiant.SelectionChangeCommitted += comboBox_Etudiant_SelectionChangeCommitted;
            // 
            // label_Etudiant
            // 
            label_Etudiant.AutoSize = true;
            label_Etudiant.Location = new Point(12, 9);
            label_Etudiant.Name = "label_Etudiant";
            label_Etudiant.Size = new Size(51, 15);
            label_Etudiant.TabIndex = 2;
            label_Etudiant.Text = "Etudiant";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 45);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 3;
            label2.Text = "Hobby";
            // 
            // button1
            // 
            button1.Location = new Point(71, 81);
            button1.Name = "button1";
            button1.Size = new Size(235, 23);
            button1.TabIndex = 4;
            button1.Text = "Associer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Associer_Click;
            // 
            // dataGridView_Hobby
            // 
            dataGridView_Hobby.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Hobby.Location = new Point(71, 125);
            dataGridView_Hobby.Name = "dataGridView_Hobby";
            dataGridView_Hobby.Size = new Size(235, 290);
            dataGridView_Hobby.TabIndex = 5;
            // 
            // LierHobbyEtudiant
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 472);
            Controls.Add(dataGridView_Hobby);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label_Etudiant);
            Controls.Add(comboBox_Etudiant);
            Controls.Add(comboBox_Hobby);
            Name = "LierHobbyEtudiant";
            Text = "LierHobbyEtudiant";
            ((System.ComponentModel.ISupportInitialize)dataGridView_Hobby).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox_Hobby;
        private ComboBox comboBox_Etudiant;
        private Label label_Etudiant;
        private Label label2;
        private Button button1;
        private DataGridView dataGridView_Hobby;
    }
}