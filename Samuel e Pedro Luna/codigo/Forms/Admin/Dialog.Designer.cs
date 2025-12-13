namespace Projeto.Forms;

partial class Dialog
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
        label1 = new Label();
        button_sair = new Button();
        button_loginAdmin = new Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(12, 44);
        label1.Name = "label1";
        label1.Size = new Size(309, 15);
        label1.TabIndex = 0;
        label1.Text = "O site está em manutenção. Tente novamente mais tarde.";
        // 
        // button_sair
        // 
        button_sair.Location = new Point(191, 104);
        button_sair.Name = "button_sair";
        button_sair.Size = new Size(95, 27);
        button_sair.TabIndex = 1;
        button_sair.Text = "Sair";
        button_sair.UseVisualStyleBackColor = true;
        // 
        // button_loginAdmin
        // 
        button_loginAdmin.Location = new Point(30, 104);
        button_loginAdmin.Name = "button_loginAdmin";
        button_loginAdmin.Size = new Size(129, 27);
        button_loginAdmin.TabIndex = 2;
        button_loginAdmin.Text = "Logar como admin";
        button_loginAdmin.UseVisualStyleBackColor = true;
        // 
        // Dialog
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(334, 166);
        Controls.Add(button_loginAdmin);
        Controls.Add(button_sair);
        Controls.Add(label1);
        Name = "Dialog";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Dialog";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Button button_sair;
    private Button button_loginAdmin;
}