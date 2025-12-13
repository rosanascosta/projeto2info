namespace Projeto.Forms
{
    partial class Senha
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
            label_alterarsenha = new Label();
            TxtAtual = new TextBox();
            label_atual = new Label();
            label_nova = new Label();
            TxtNova = new TextBox();
            button_alterar = new Button();
            button_cancelar = new Button();
            SuspendLayout();
            // 
            // label_alterarsenha
            // 
            label_alterarsenha.AutoSize = true;
            label_alterarsenha.Font = new Font("Segoe UI", 15F);
            label_alterarsenha.Location = new Point(118, 60);
            label_alterarsenha.Name = "label_alterarsenha";
            label_alterarsenha.Size = new Size(153, 28);
            label_alterarsenha.TabIndex = 0;
            label_alterarsenha.Text = "Altere sua senha";
            // 
            // TxtAtual
            // 
            TxtAtual.Location = new Point(188, 153);
            TxtAtual.Name = "TxtAtual";
            TxtAtual.Size = new Size(124, 23);
            TxtAtual.TabIndex = 1;
            TxtAtual.UseSystemPasswordChar = true;
            // 
            // label_atual
            // 
            label_atual.AutoSize = true;
            label_atual.Location = new Point(60, 156);
            label_atual.Name = "label_atual";
            label_atual.Size = new Size(122, 15);
            label_atual.TabIndex = 2;
            label_atual.Text = "Insira sua senha atual:";
            // 
            // label_nova
            // 
            label_nova.AutoSize = true;
            label_nova.Location = new Point(72, 202);
            label_nova.Name = "label_nova";
            label_nova.Size = new Size(110, 15);
            label_nova.TabIndex = 3;
            label_nova.Text = "Insira a nova senha:";
            // 
            // TxtNova
            // 
            TxtNova.Location = new Point(188, 199);
            TxtNova.Name = "TxtNova";
            TxtNova.Size = new Size(124, 23);
            TxtNova.TabIndex = 4;
            TxtNova.UseSystemPasswordChar = true;
            // 
            // button_alterar
            // 
            button_alterar.Location = new Point(90, 266);
            button_alterar.Name = "button_alterar";
            button_alterar.Size = new Size(92, 27);
            button_alterar.TabIndex = 5;
            button_alterar.Text = "Alterar";
            button_alterar.UseVisualStyleBackColor = true;
            button_alterar.Click += button_alterar_Click;
            // 
            // button_cancelar
            // 
            button_cancelar.Location = new Point(205, 266);
            button_cancelar.Name = "button_cancelar";
            button_cancelar.Size = new Size(92, 27);
            button_cancelar.TabIndex = 6;
            button_cancelar.Text = "Cancelar";
            button_cancelar.UseVisualStyleBackColor = true;
            button_cancelar.Click += button_cancelar_Click;
            // 
            // Senha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 400);
            Controls.Add(button_cancelar);
            Controls.Add(button_alterar);
            Controls.Add(TxtNova);
            Controls.Add(label_nova);
            Controls.Add(label_atual);
            Controls.Add(TxtAtual);
            Controls.Add(label_alterarsenha);
            Name = "Senha";
            Text = "Senha";
            Load += Senha_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_alterarsenha;
        private TextBox TxtAtual;
        private Label label_atual;
        private Label label_nova;
        private TextBox TxtNova;
        private Button button_alterar;
        private Button button_cancelar;
    }
}