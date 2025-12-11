namespace BDCsharp2
{
    partial class FrmPrinc
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
            menuStrip1 = new MenuStrip();
            Cadastro = new ToolStripMenuItem();
            loginToolStripMenuItem = new ToolStripMenuItem();
            aDMToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            capaquadrinho = new PictureBox();
            capaquadrinho2 = new PictureBox();
            capaquadrinho3 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Ha = new Label();
            Rb = new Label();
            GA = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)capaquadrinho).BeginInit();
            ((System.ComponentModel.ISupportInitialize)capaquadrinho2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)capaquadrinho3).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { Cadastro, loginToolStripMenuItem, aDMToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // Cadastro
            // 
            Cadastro.BackgroundImage = Properties.Resources.pessoas1;
            Cadastro.Image = Properties.Resources.pessoas;
            Cadastro.Name = "Cadastro";
            Cadastro.Size = new Size(82, 20);
            Cadastro.Text = "Cadastro";
            Cadastro.Click += cadastroToolStripMenuItem_Click;
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(49, 20);
            loginToolStripMenuItem.Text = "Login";
            loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
            // 
            // aDMToolStripMenuItem
            // 
            aDMToolStripMenuItem.Name = "aDMToolStripMenuItem";
            aDMToolStripMenuItem.Size = new Size(95, 20);
            aDMToolStripMenuItem.Text = "Administrador";
            aDMToolStripMenuItem.Click += aDMToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Image = Properties.Resources.sair;
            sairToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(54, 20);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // capaquadrinho
            // 
            capaquadrinho.Location = new Point(53, 124);
            capaquadrinho.Name = "capaquadrinho";
            capaquadrinho.Size = new Size(176, 227);
            capaquadrinho.SizeMode = PictureBoxSizeMode.StretchImage;
            capaquadrinho.TabIndex = 2;
            capaquadrinho.TabStop = false;
            // 
            // capaquadrinho2
            // 
            capaquadrinho2.Location = new Point(310, 124);
            capaquadrinho2.Name = "capaquadrinho2";
            capaquadrinho2.Size = new Size(176, 227);
            capaquadrinho2.SizeMode = PictureBoxSizeMode.StretchImage;
            capaquadrinho2.TabIndex = 3;
            capaquadrinho2.TabStop = false;
            // 
            // capaquadrinho3
            // 
            capaquadrinho3.Location = new Point(577, 124);
            capaquadrinho3.Name = "capaquadrinho3";
            capaquadrinho3.Size = new Size(176, 227);
            capaquadrinho3.SizeMode = PictureBoxSizeMode.StretchImage;
            capaquadrinho3.TabIndex = 4;
            capaquadrinho3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 94);
            label1.Name = "label1";
            label1.Size = new Size(240, 15);
            label1.TabIndex = 5;
            label1.Text = "Homem-Aranha: A última caçada de Kraven";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(308, 94);
            label2.Name = "label2";
            label2.Size = new Size(178, 15);
            label2.TabIndex = 6;
            label2.Text = "Robin III - O Dia da Caçadora # 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(588, 82);
            label3.Name = "label3";
            label3.Size = new Size(155, 30);
            label3.TabIndex = 7;
            label3.Text = "Gavião Arqueiro - Pequenos\r\n Acertos (Hawkeye #6 - #11)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(369, 24);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 8;
            label4.Text = "Quadrinhos";
            // 
            // Ha
            // 
            Ha.AutoSize = true;
            Ha.Location = new Point(101, 372);
            Ha.Name = "Ha";
            Ha.Size = new Size(10, 15);
            Ha.TabIndex = 10;
            Ha.Text = ".";
            // 
            // Rb
            // 
            Rb.AutoSize = true;
            Rb.Location = new Point(369, 372);
            Rb.Name = "Rb";
            Rb.Size = new Size(10, 15);
            Rb.TabIndex = 11;
            Rb.Text = ".";
            // 
            // GA
            // 
            GA.AutoSize = true;
            GA.Location = new Point(645, 372);
            GA.Name = "GA";
            GA.Size = new Size(10, 15);
            GA.TabIndex = 12;
            GA.Text = ".";
            // 
            // FrmPrinc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GA);
            Controls.Add(Rb);
            Controls.Add(Ha);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(capaquadrinho3);
            Controls.Add(capaquadrinho2);
            Controls.Add(capaquadrinho);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FrmPrinc";
            Text = "FrmPrinc";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)capaquadrinho).EndInit();
            ((System.ComponentModel.ISupportInitialize)capaquadrinho2).EndInit();
            ((System.ComponentModel.ISupportInitialize)capaquadrinho3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem Cadastro;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem aDMToolStripMenuItem;
        private ToolStripMenuItem loginToolStripMenuItem;
        private PictureBox capaquadrinho;
        private PictureBox capaquadrinho2;
        private PictureBox capaquadrinho3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label Ha;
        private Label Rb;
        private Label GA;
    }
}