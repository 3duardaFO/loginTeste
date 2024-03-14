namespace login
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbLogin = new TextBox();
            checkBox1 = new CheckBox();
            bLogin = new Button();
            MtbSenha = new MaskedTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(267, 9);
            label1.Name = "label1";
            label1.Size = new Size(224, 30);
            label1.TabIndex = 0;
            label1.Text = "Sistema de login teste";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 63);
            label2.Name = "label2";
            label2.Size = new Size(55, 21);
            label2.TabIndex = 1;
            label2.Text = "Login:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 104);
            label3.Name = "label3";
            label3.Size = new Size(58, 21);
            label3.TabIndex = 2;
            label3.Text = "Senha:";
            // 
            // tbLogin
            // 
            tbLogin.Location = new Point(73, 61);
            tbLogin.Name = "tbLogin";
            tbLogin.Size = new Size(100, 23);
            tbLogin.TabIndex = 3;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(179, 108);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(89, 19);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Exibir senha";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // bLogin
            // 
            bLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bLogin.Location = new Point(85, 146);
            bLogin.Name = "bLogin";
            bLogin.Size = new Size(75, 31);
            bLogin.TabIndex = 7;
            bLogin.Text = "Entrar";
            bLogin.UseVisualStyleBackColor = true;
            bLogin.Click += bLogin_Click;
            // 
            // MtbSenha
            // 
            MtbSenha.Location = new Point(73, 106);
            MtbSenha.Name = "MtbSenha";
            MtbSenha.PasswordChar = '*';
            MtbSenha.Size = new Size(100, 23);
            MtbSenha.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 450);
            Controls.Add(MtbSenha);
            Controls.Add(bLogin);
            Controls.Add(checkBox1);
            Controls.Add(tbLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbLogin;
        private CheckBox checkBox1;
        private Button bLogin;
        private MaskedTextBox MtbSenha;
    }
}
