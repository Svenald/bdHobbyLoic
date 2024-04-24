namespace wfa_hobby
{
    partial class menuForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            étudiantToolStripMenuItem = new ToolStripMenuItem();
            ajoutToolStripMenuItem = new ToolStripMenuItem();
            modifierToolStripMenuItem = new ToolStripMenuItem();
            hobbyToolStripMenuItem = new ToolStripMenuItem();
            nombreDeHobbyDunÉtudiantToolStripMenuItem = new ToolStripMenuItem();
            regularExpressionToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 12F);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { étudiantToolStripMenuItem, regularExpressionToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 3, 0, 3);
            menuStrip1.Size = new Size(505, 31);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // étudiantToolStripMenuItem
            // 
            étudiantToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ajoutToolStripMenuItem, modifierToolStripMenuItem, hobbyToolStripMenuItem, nombreDeHobbyDunÉtudiantToolStripMenuItem });
            étudiantToolStripMenuItem.Name = "étudiantToolStripMenuItem";
            étudiantToolStripMenuItem.Size = new Size(79, 25);
            étudiantToolStripMenuItem.Text = "Étudiant";
            // 
            // ajoutToolStripMenuItem
            // 
            ajoutToolStripMenuItem.Name = "ajoutToolStripMenuItem";
            ajoutToolStripMenuItem.Size = new Size(305, 26);
            ajoutToolStripMenuItem.Text = "Ajouter";
            ajoutToolStripMenuItem.Click += ajoutToolStripMenuItem_Click;
            // 
            // modifierToolStripMenuItem
            // 
            modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            modifierToolStripMenuItem.Size = new Size(305, 26);
            modifierToolStripMenuItem.Text = "Modifier/détruire";
            modifierToolStripMenuItem.Click += modifierToolStripMenuItem_Click;
            // 
            // hobbyToolStripMenuItem
            // 
            hobbyToolStripMenuItem.Name = "hobbyToolStripMenuItem";
            hobbyToolStripMenuItem.Size = new Size(305, 26);
            hobbyToolStripMenuItem.Text = "Hobby";
            hobbyToolStripMenuItem.Click += hobbyToolStripMenuItem_Click;
            // 
            // nombreDeHobbyDunÉtudiantToolStripMenuItem
            // 
            nombreDeHobbyDunÉtudiantToolStripMenuItem.Name = "nombreDeHobbyDunÉtudiantToolStripMenuItem";
            nombreDeHobbyDunÉtudiantToolStripMenuItem.Size = new Size(305, 26);
            nombreDeHobbyDunÉtudiantToolStripMenuItem.Text = "Nombre de Hobby d'un étudiant";
            nombreDeHobbyDunÉtudiantToolStripMenuItem.Click += nombreDeHobbyDunÉtudiantToolStripMenuItem_Click;
            // 
            // regularExpressionToolStripMenuItem
            // 
            regularExpressionToolStripMenuItem.Name = "regularExpressionToolStripMenuItem";
            regularExpressionToolStripMenuItem.Size = new Size(154, 25);
            regularExpressionToolStripMenuItem.Text = "Regular Expression";
            regularExpressionToolStripMenuItem.Click += regularExpressionToolStripMenuItem_Click;
            // 
            // menuForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 283);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 12F);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "menuForm";
            Text = "Menu";
            Load += menuForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem étudiantToolStripMenuItem;
        private ToolStripMenuItem ajoutToolStripMenuItem;
        private ToolStripMenuItem modifierToolStripMenuItem;
        private ToolStripMenuItem hobbyToolStripMenuItem;
        private ToolStripMenuItem nombreDeHobbyDunÉtudiantToolStripMenuItem;
        private ToolStripMenuItem regularExpressionToolStripMenuItem;
    }
}