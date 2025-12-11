namespace BDCsharp2
{
    partial class FrmLogin
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
            Senha = new TextBox();
            Email = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            BtnLogar = new Button();
            SN = new Label();
            Btnsair = new Button();
            SuspendLayout();
            // 
            // Senha
            // 
            Senha.Location = new Point(175, 174);
            Senha.Name = "Senha";
            Senha.Size = new Size(100, 23);
            Senha.TabIndex = 11;
            // 
            // Email
            // 
            Email.Location = new Point(175, 135);
            Email.Name = "Email";
            Email.Size = new Size(100, 23);
            Email.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(110, 177);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 9;
            label4.Text = "Senha:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(110, 138);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 8;
            label3.Text = "Email:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(160, 81);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 12;
            label1.Text = "Fazer Login";
            // 
            // BtnLogar
            // 
            BtnLogar.Location = new Point(136, 222);
            BtnLogar.Name = "BtnLogar";
            BtnLogar.Size = new Size(128, 36);
            BtnLogar.TabIndex = 13;
            BtnLogar.Text = "Logar";
            BtnLogar.UseVisualStyleBackColor = true;
            BtnLogar.Click += BtnLogar_Click;
            // 
            // SN
            // 
            SN.AutoSize = true;
            SN.Location = new Point(110, 351);
            SN.Name = "SN";
            SN.Size = new Size(10, 15);
            SN.TabIndex = 14;
            SN.Text = ".";
            // 
            // Btnsair
            // 
            Btnsair.Location = new Point(136, 264);
            Btnsair.Name = "Btnsair";
            Btnsair.Size = new Size(128, 37);
            Btnsair.TabIndex = 15;
            Btnsair.Text = "Sair";
            Btnsair.UseVisualStyleBackColor = true;
            Btnsair.Click += button1_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 450);
            Controls.Add(Btnsair);
            Controls.Add(SN);
            Controls.Add(BtnLogar);
            Controls.Add(label1);
            Controls.Add(Senha);
            Controls.Add(Email);
            Controls.Add(label4);
            Controls.Add(label3);
            Name = "FrmLogin";
            Text = "FrmLogin";
            Load += FrmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Senha;
        private TextBox Email;
        private Label label4;
        private Label label3;
        private Label label1;
        private Button BtnLogar;
        private Label SN;
        private Button Btnsair;
    }
}