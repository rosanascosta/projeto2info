namespace Projeto.Forms;
partial class DeleteAdm
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
        combo_contas = new ComboBox();
        label_escolha = new Label();
        button_excluir = new Button();
        SuspendLayout();
        // 
        // combo_contas
        // 
        combo_contas.FormattingEnabled = true;
        combo_contas.Location = new Point(41, 93);
        combo_contas.Name = "combo_contas";
        combo_contas.Size = new Size(277, 23);
        combo_contas.TabIndex = 0;
        // 
        // label_escolha
        // 
        label_escolha.AutoSize = true;
        label_escolha.Font = new Font("Segoe UI", 16F);
        label_escolha.Location = new Point(41, 50);
        label_escolha.Name = "label_escolha";
        label_escolha.Size = new Size(277, 30);
        label_escolha.TabIndex = 1;
        label_escolha.Text = "Escolha a conta para excluir";
        // 
        // button_excluir
        // 
        button_excluir.Location = new Point(143, 181);
        button_excluir.Name = "button_excluir";
        button_excluir.Size = new Size(75, 23);
        button_excluir.TabIndex = 2;
        button_excluir.Text = "Apagar";
        button_excluir.UseVisualStyleBackColor = true;
        button_excluir.Click += button_excluir_Click;
        // 
        // DeleteAdm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(363, 397);
        Controls.Add(button_excluir);
        Controls.Add(label_escolha);
        Controls.Add(combo_contas);
        Name = "DeleteAdm";
        Text = "DeleteAdm";
        Load += DeleteAdm_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private ComboBox combo_contas;
    private Label label_escolha;
    private Button button_excluir;
}