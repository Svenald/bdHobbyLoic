namespace wfa_hobby
{
    partial class RegExForm
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
            components = new System.ComponentModel.Container();
            button_Execute = new Button();
            textBox_CodePostal = new TextBox();
            textBox_ISBN = new TextBox();
            label_CodePostal = new Label();
            label_ISBN = new Label();
            errorProvider_Typing = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider_Typing).BeginInit();
            SuspendLayout();
            // 
            // button_Execute
            // 
            button_Execute.Location = new Point(98, 115);
            button_Execute.Name = "button_Execute";
            button_Execute.Size = new Size(75, 23);
            button_Execute.TabIndex = 0;
            button_Execute.Text = "Exécuter";
            button_Execute.UseVisualStyleBackColor = true;
            button_Execute.Click += button_Execute_Click;
            // 
            // textBox_CodePostal
            // 
            textBox_CodePostal.Location = new Point(88, 29);
            textBox_CodePostal.Name = "textBox_CodePostal";
            textBox_CodePostal.Size = new Size(100, 23);
            textBox_CodePostal.TabIndex = 1;
            textBox_CodePostal.Validating += textBox_CodePostal_Validating;
            // 
            // textBox_ISBN
            // 
            textBox_ISBN.Location = new Point(88, 73);
            textBox_ISBN.Name = "textBox_ISBN";
            textBox_ISBN.Size = new Size(100, 23);
            textBox_ISBN.TabIndex = 2;
            textBox_ISBN.Validating += textBox_ISBN_Validating;
            // 
            // label_CodePostal
            // 
            label_CodePostal.AutoSize = true;
            label_CodePostal.Location = new Point(12, 32);
            label_CodePostal.Name = "label_CodePostal";
            label_CodePostal.Size = new Size(70, 15);
            label_CodePostal.TabIndex = 3;
            label_CodePostal.Text = "Code Postal";
            // 
            // label_ISBN
            // 
            label_ISBN.AutoSize = true;
            label_ISBN.Location = new Point(12, 76);
            label_ISBN.Name = "label_ISBN";
            label_ISBN.Size = new Size(32, 15);
            label_ISBN.TabIndex = 4;
            label_ISBN.Text = "ISBN";
            // 
            // errorProvider_Typing
            // 
            errorProvider_Typing.ContainerControl = this;
            // 
            // RegExForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(206, 159);
            Controls.Add(label_ISBN);
            Controls.Add(label_CodePostal);
            Controls.Add(textBox_ISBN);
            Controls.Add(textBox_CodePostal);
            Controls.Add(button_Execute);
            Name = "RegExForm";
            Text = "RegExForm";
            Load += RegExForm_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider_Typing).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Execute;
        private TextBox textBox_CodePostal;
        private TextBox textBox_ISBN;
        private Label label_CodePostal;
        private Label label_ISBN;
        private ErrorProvider errorProvider_Typing;
    }
}