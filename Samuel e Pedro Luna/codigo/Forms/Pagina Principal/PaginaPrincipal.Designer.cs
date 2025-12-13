namespace Projeto
{
    partial class PaginaPrincipal
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(PaginaPrincipal));
            label_bemvindo = new Label();
            menuStrip1 = new MenuStrip();
            menu_profile = new ToolStripMenuItem();
            menu_cadastro = new ToolStripMenuItem();
            menu_login = new ToolStripMenuItem();
            menu_sair = new ToolStripMenuItem();
            menu_opcoes = new ToolStripMenuItem();
            menu_configuracoes = new ToolStripMenuItem();
            menu_preferencias = new ToolStripMenuItem();
            menu_fechar = new ToolStripMenuItem();
            menu_admin = new ToolStripMenuItem();
            button_futebolAmericano = new Button();
            button_basquete = new Button();
            button_futebol = new Button();
            button_baseball = new Button();
            button_cod = new Button();
            button_cs = new Button();
            button_atletismo = new Button();
            button_boxe = new Button();
            button_rocket = new Button();
            button_golfe = new Button();
            button_judo = new Button();
            button_natacao = new Button();
            button_formula1 = new Button();
            button_xadrez = new Button();
            button_valorant = new Button();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label_bemvindo
            // 
            label_bemvindo.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label_bemvindo.Location = new Point(573, 223);
            label_bemvindo.Name = "label_bemvindo";
            label_bemvindo.Size = new Size(661, 80);
            label_bemvindo.TabIndex = 0;
            label_bemvindo.Text = "Bem-vindo ao site";
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.Items.AddRange(new ToolStripItem[] { menu_profile, menu_opcoes, menu_fechar, menu_admin });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1584, 128);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // menu_profile
            // 
            menu_profile.DropDownItems.AddRange(new ToolStripItem[] { menu_cadastro, menu_login, menu_sair });
            menu_profile.Name = "menu_profile";
            menu_profile.Size = new Size(51, 124);
            menu_profile.Text = "Conta";
            // 
            // menu_cadastro
            // 
            menu_cadastro.Name = "menu_cadastro";
            menu_cadastro.Size = new Size(180, 22);
            menu_cadastro.Text = "Cadastro";
            menu_cadastro.Click += menu_cadastro_Click;
            // 
            // menu_login
            // 
            menu_login.Name = "menu_login";
            menu_login.Size = new Size(180, 22);
            menu_login.Text = "Login";
            menu_login.Click += menu_login_Click;
            // 
            // menu_sair
            // 
            menu_sair.Name = "menu_sair";
            menu_sair.Size = new Size(180, 22);
            menu_sair.Text = "Sair";
            menu_sair.Visible = false;
            menu_sair.Click += menu_sair_Click;
            // 
            // menu_opcoes
            // 
            menu_opcoes.DropDownItems.AddRange(new ToolStripItem[] { menu_configuracoes, menu_preferencias });
            menu_opcoes.Name = "menu_opcoes";
            menu_opcoes.Size = new Size(59, 124);
            menu_opcoes.Text = "Opções";
            menu_opcoes.Visible = false;
            // 
            // menu_configuracoes
            // 
            menu_configuracoes.Name = "menu_configuracoes";
            menu_configuracoes.Size = new Size(151, 22);
            menu_configuracoes.Text = "Configurações";
            menu_configuracoes.Click += menu_configuracoes_Click;
            // 
            // menu_preferencias
            // 
            menu_preferencias.Name = "menu_preferencias";
            menu_preferencias.Size = new Size(151, 22);
            menu_preferencias.Text = "Preferências";
            menu_preferencias.Click += menu_preferencias_Click;
            // 
            // menu_fechar
            // 
            menu_fechar.Name = "menu_fechar";
            menu_fechar.Size = new Size(54, 124);
            menu_fechar.Text = "Fechar";
            menu_fechar.Click += menu_fechar_Click;
            // 
            // menu_admin
            // 
            menu_admin.MergeAction = MergeAction.Insert;
            menu_admin.MergeIndex = 0;
            menu_admin.Name = "menu_admin";
            menu_admin.Size = new Size(95, 124);
            menu_admin.Text = "Administrador";
            menu_admin.Visible = false;
            menu_admin.Click += menu_admin_Click;
            // 
            // button_futebolAmericano
            // 
            button_futebolAmericano.Anchor = AnchorStyles.None;
            button_futebolAmericano.FlatStyle = FlatStyle.Flat;
            button_futebolAmericano.Location = new Point(892, 452);
            button_futebolAmericano.Name = "button_futebolAmericano";
            button_futebolAmericano.Size = new Size(189, 143);
            button_futebolAmericano.TabIndex = 2;
            button_futebolAmericano.Text = "Futebol Americano";
            button_futebolAmericano.UseVisualStyleBackColor = true;
            button_futebolAmericano.Click += button_futebolAmericano_Click;
            // 
            // button_basquete
            // 
            button_basquete.Anchor = AnchorStyles.None;
            button_basquete.FlatStyle = FlatStyle.Flat;
            button_basquete.Location = new Point(502, 305);
            button_basquete.Name = "button_basquete";
            button_basquete.Size = new Size(189, 143);
            button_basquete.TabIndex = 4;
            button_basquete.Text = "Basquete";
            button_basquete.UseVisualStyleBackColor = true;
            button_basquete.Click += button_basquete_Click;
            // 
            // button_futebol
            // 
            button_futebol.Anchor = AnchorStyles.None;
            button_futebol.FlatStyle = FlatStyle.Flat;
            button_futebol.Location = new Point(697, 452);
            button_futebol.Name = "button_futebol";
            button_futebol.Size = new Size(189, 143);
            button_futebol.TabIndex = 3;
            button_futebol.Text = "Futebol";
            button_futebol.UseVisualStyleBackColor = true;
            button_futebol.Click += button_futebol_Click;
            // 
            // button_baseball
            // 
            button_baseball.Anchor = AnchorStyles.None;
            button_baseball.FlatStyle = FlatStyle.Flat;
            button_baseball.Location = new Point(892, 305);
            button_baseball.Name = "button_baseball";
            button_baseball.Size = new Size(189, 143);
            button_baseball.TabIndex = 6;
            button_baseball.Text = "Baseball";
            button_baseball.UseVisualStyleBackColor = true;
            button_baseball.Click += button_baseball_Click;
            // 
            // button_cod
            // 
            button_cod.Anchor = AnchorStyles.None;
            button_cod.FlatStyle = FlatStyle.Flat;
            button_cod.Location = new Point(1087, 305);
            button_cod.Name = "button_cod";
            button_cod.Size = new Size(189, 143);
            button_cod.TabIndex = 7;
            button_cod.Text = "Call of Duty";
            button_cod.UseVisualStyleBackColor = true;
            button_cod.Click += button_cod_Click;
            // 
            // button_cs
            // 
            button_cs.Anchor = AnchorStyles.None;
            button_cs.FlatStyle = FlatStyle.Flat;
            button_cs.Location = new Point(307, 452);
            button_cs.Name = "button_cs";
            button_cs.Size = new Size(189, 143);
            button_cs.TabIndex = 8;
            button_cs.Text = "Counter-Strike";
            button_cs.UseVisualStyleBackColor = true;
            button_cs.Click += button_cs_Click;
            // 
            // button_atletismo
            // 
            button_atletismo.Anchor = AnchorStyles.None;
            button_atletismo.FlatStyle = FlatStyle.Flat;
            button_atletismo.Location = new Point(307, 303);
            button_atletismo.Name = "button_atletismo";
            button_atletismo.Size = new Size(189, 143);
            button_atletismo.TabIndex = 9;
            button_atletismo.Text = "Atletismo";
            button_atletismo.UseVisualStyleBackColor = true;
            button_atletismo.Click += button_atletismo_Click;
            // 
            // button_boxe
            // 
            button_boxe.Anchor = AnchorStyles.None;
            button_boxe.FlatStyle = FlatStyle.Flat;
            button_boxe.Location = new Point(697, 305);
            button_boxe.Name = "button_boxe";
            button_boxe.Size = new Size(189, 143);
            button_boxe.TabIndex = 10;
            button_boxe.Text = "Boxe";
            button_boxe.UseVisualStyleBackColor = true;
            button_boxe.Click += button_boxe_Click;
            // 
            // button_rocket
            // 
            button_rocket.Anchor = AnchorStyles.None;
            button_rocket.FlatStyle = FlatStyle.Flat;
            button_rocket.Location = new Point(697, 601);
            button_rocket.Name = "button_rocket";
            button_rocket.Size = new Size(189, 143);
            button_rocket.TabIndex = 11;
            button_rocket.Text = "Rocket League";
            button_rocket.UseVisualStyleBackColor = true;
            button_rocket.Click += button_rocket_Click;
            // 
            // button_golfe
            // 
            button_golfe.Anchor = AnchorStyles.None;
            button_golfe.FlatStyle = FlatStyle.Flat;
            button_golfe.Location = new Point(1087, 452);
            button_golfe.Name = "button_golfe";
            button_golfe.Size = new Size(189, 143);
            button_golfe.TabIndex = 12;
            button_golfe.Text = "Golfe";
            button_golfe.UseVisualStyleBackColor = true;
            button_golfe.Click += button_golf_Click;
            // 
            // button_judo
            // 
            button_judo.Anchor = AnchorStyles.None;
            button_judo.FlatStyle = FlatStyle.Flat;
            button_judo.Location = new Point(307, 601);
            button_judo.Name = "button_judo";
            button_judo.Size = new Size(189, 143);
            button_judo.TabIndex = 13;
            button_judo.Text = "Judô";
            button_judo.UseVisualStyleBackColor = true;
            button_judo.Click += button_judo_Click;
            // 
            // button_natacao
            // 
            button_natacao.Anchor = AnchorStyles.None;
            button_natacao.FlatStyle = FlatStyle.Flat;
            button_natacao.Location = new Point(502, 601);
            button_natacao.Name = "button_natacao";
            button_natacao.Size = new Size(189, 143);
            button_natacao.TabIndex = 14;
            button_natacao.Text = "Natação";
            button_natacao.UseVisualStyleBackColor = true;
            button_natacao.Click += button_natacao_Click;
            // 
            // button_formula1
            // 
            button_formula1.Anchor = AnchorStyles.None;
            button_formula1.FlatStyle = FlatStyle.Flat;
            button_formula1.Location = new Point(502, 452);
            button_formula1.Name = "button_formula1";
            button_formula1.Size = new Size(189, 143);
            button_formula1.TabIndex = 15;
            button_formula1.Text = "Fórmula 1";
            button_formula1.UseVisualStyleBackColor = true;
            button_formula1.Click += button_formula1_Click;
            // 
            // button_xadrez
            // 
            button_xadrez.Anchor = AnchorStyles.None;
            button_xadrez.FlatStyle = FlatStyle.Flat;
            button_xadrez.Location = new Point(1087, 601);
            button_xadrez.Name = "button_xadrez";
            button_xadrez.Size = new Size(189, 143);
            button_xadrez.TabIndex = 16;
            button_xadrez.Text = "Xadrez";
            button_xadrez.UseVisualStyleBackColor = true;
            button_xadrez.Click += button_xadrez_Click;
            // 
            // button_valorant
            // 
            button_valorant.Anchor = AnchorStyles.None;
            button_valorant.FlatStyle = FlatStyle.Flat;
            button_valorant.Location = new Point(892, 601);
            button_valorant.Name = "button_valorant";
            button_valorant.Size = new Size(189, 143);
            button_valorant.TabIndex = 17;
            button_valorant.Text = "Valorant";
            button_valorant.UseVisualStyleBackColor = true;
            button_valorant.Click += button_valorant_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(687, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(209, 182);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // PaginaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1584, 861);
            Controls.Add(pictureBox1);
            Controls.Add(button_valorant);
            Controls.Add(button_xadrez);
            Controls.Add(button_formula1);
            Controls.Add(button_natacao);
            Controls.Add(button_judo);
            Controls.Add(button_golfe);
            Controls.Add(button_rocket);
            Controls.Add(button_boxe);
            Controls.Add(button_futebol);
            Controls.Add(button_baseball);
            Controls.Add(button_cod);
            Controls.Add(button_cs);
            Controls.Add(button_basquete);
            Controls.Add(button_atletismo);
            Controls.Add(button_futebolAmericano);
            Controls.Add(menuStrip1);
            Controls.Add(label_bemvindo);
            ForeColor = Color.White;
            MainMenuStrip = menuStrip1;
            Name = "PaginaPrincipal";
            Text = "Página Principal";
            Load += PaginaPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label_bemvindo;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menu_profile;
        private ToolStripMenuItem menu_cadastro;
        private ToolStripMenuItem menu_login;
        private ToolStripMenuItem menu_opcoes;
        private ToolStripMenuItem menu_fechar;
        private ToolStripMenuItem menu_sair;
        private ToolStripMenuItem menu_preferencias;
        private ToolStripMenuItem menu_configuracoes;
        private Button button_futebolAmericano;
        private Button button_basquete;
        private Button button_futebol;
        private Button button_baseball;
        private Button button_cod;
        private Button button_cs;
        private Button button_atletismo;
        private Button button_boxe;
        private Button button_rocket;
        private Button button_natacao;
        private Button button_formula1;
        private Button button_xadrez;
        private Button button_valorant;
        private Button button_golfe;
        private Button button_judo;
        private PictureBox pictureBox1;
        private ToolStripMenuItem menu_admin;
    }
}
