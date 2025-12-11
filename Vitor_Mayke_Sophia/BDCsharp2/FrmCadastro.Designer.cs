
namespace BDCsharp2
{
    partial class FrmCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastro));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Nm = new TextBox();
            Usnm = new TextBox();
            Email = new TextBox();
            Senha = new TextBox();
            Gravar = new Button();
            button2 = new Button();
            button3 = new Button();
            openFileDialog1 = new OpenFileDialog();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 97);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 134);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 1;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 175);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(73, 214);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 3;
            label4.Text = "Senha:";
            // 
            // Nm
            // 
            Nm.Location = new Point(138, 94);
            Nm.Name = "Nm";
            Nm.Size = new Size(100, 23);
            Nm.TabIndex = 4;
            // 
            // Usnm
            // 
            Usnm.Location = new Point(138, 131);
            Usnm.Name = "Usnm";
            Usnm.Size = new Size(100, 23);
            Usnm.TabIndex = 5;
            // 
            // Email
            // 
            Email.Location = new Point(138, 172);
            Email.Name = "Email";
            Email.Size = new Size(100, 23);
            Email.TabIndex = 6;
            // 
            // Senha
            // 
            Senha.Location = new Point(138, 211);
            Senha.Name = "Senha";
            Senha.Size = new Size(100, 23);
            Senha.TabIndex = 7;
            // 
            // Gravar
            // 
            Gravar.BackColor = SystemColors.WindowFrame;
            Gravar.BackgroundImage = Properties.Resources.salve_;
            Gravar.BackgroundImageLayout = ImageLayout.Zoom;
            Gravar.ImageAlign = ContentAlignment.TopCenter;
            Gravar.Location = new Point(90, 295);
            Gravar.Name = "Gravar";
            Gravar.Size = new Size(45, 45);
            Gravar.TabIndex = 8;
            Gravar.UseVisualStyleBackColor = false;
            Gravar.Click += Gravar_Click;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.BackgroundImage = Properties.Resources.sair;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.ForeColor = Color.CornflowerBlue;
            button2.ImageAlign = ContentAlignment.BottomCenter;
            button2.Location = new Point(158, 295);
            button2.Name = "button2";
            button2.Size = new Size(49, 45);
            button2.TabIndex = 9;
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = true;
            button2.UseWaitCursor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Location = new Point(229, 295);
            button3.Name = "button3";
            button3.Size = new Size(50, 45);
            button3.TabIndex = 10;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(158, 37);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 11;
            label5.Text = "Cadastrar";
            // 
            // FrmCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 376);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(Gravar);
            Controls.Add(Senha);
            Controls.Add(Email);
            Controls.Add(Usnm);
            Controls.Add(Nm);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmCadastro";
            Text = "0";
            WindowState = FormWindowState.Minimized;
            ResumeLayout(false);
            PerformLayout();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion


        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox Nm;
        private TextBox Usnm;
        private TextBox Email;
        private TextBox Senha;
        private Button Gravar;
        private Button button2;
        private Button button3;
        private OpenFileDialog openFileDialog1;
        private Label label5;
    }
}