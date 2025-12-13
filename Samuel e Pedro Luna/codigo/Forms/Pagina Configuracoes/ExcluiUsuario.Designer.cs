namespace Projeto.Forms
{
    partial class ExcluiUsuario
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
            label_confirme = new Label();
            TxtSenha = new TextBox();
            button_apagar = new Button();
            SuspendLayout();
            // 
            // label_confirme
            // 
            label_confirme.AutoSize = true;
            label_confirme.Location = new Point(96, 113);
            label_confirme.Name = "label_confirme";
            label_confirme.Size = new Size(244, 15);
            label_confirme.TabIndex = 0;
            label_confirme.Text = "Para apagar seu usuário, confirme sua senha.";
            // 
            // TxtSenha
            // 
            TxtSenha.Location = new Point(142, 158);
            TxtSenha.Name = "TxtSenha";
            TxtSenha.Size = new Size(155, 23);
            TxtSenha.TabIndex = 1;
            // 
            // button_apagar
            // 
            button_apagar.Location = new Point(177, 249);
            button_apagar.Name = "button_apagar";
            button_apagar.Size = new Size(89, 33);
            button_apagar.TabIndex = 2;
            button_apagar.Text = "Apagar";
            button_apagar.UseVisualStyleBackColor = true;
            button_apagar.Click += button_apagar_Click;
            // 
            // ExcluiUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 424);
            Controls.Add(button_apagar);
            Controls.Add(TxtSenha);
            Controls.Add(label_confirme);
            Name = "ExcluiUsuario";
            Text = "ExcluiUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_confirme;
        private TextBox TxtSenha;
        private Button button_apagar;
    }
}