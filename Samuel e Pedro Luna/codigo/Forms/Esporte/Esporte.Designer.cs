namespace Projeto.Forms;
partial class Esporte
{
    /// <summary>
    /// Required designer variable.
    /// </summary>

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    
    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            foreach (var img in _ownedImages)
                img.Dispose();
            _ownedImages.Clear();
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
        group_jogador1 = new GroupBox();
        flowLayoutPanel1 = new FlowLayoutPanel();
        panel_foto1 = new Panel();
        group_jogador2 = new GroupBox();
        flowLayoutPanel2 = new FlowLayoutPanel();
        panel_foto2 = new Panel();
        group_jogador3 = new GroupBox();
        flowLayoutPanel3 = new FlowLayoutPanel();
        panel_foto3 = new Panel();
        group_jogador4 = new GroupBox();
        flowLayoutPanel4 = new FlowLayoutPanel();
        panel_foto4 = new Panel();
        group_jogador5 = new GroupBox();
        flowLayoutPanel5 = new FlowLayoutPanel();
        panel_foto5 = new Panel();
        group_jogador1.SuspendLayout();
        group_jogador2.SuspendLayout();
        group_jogador3.SuspendLayout();
        group_jogador4.SuspendLayout();
        group_jogador5.SuspendLayout();
        SuspendLayout();
        // 
        // group_jogador1
        // 
        group_jogador1.Controls.Add(flowLayoutPanel1);
        group_jogador1.Controls.Add(panel_foto1);
        group_jogador1.Location = new Point(12, 12);
        group_jogador1.Name = "group_jogador1";
        group_jogador1.Size = new Size(624, 387);
        group_jogador1.TabIndex = 1;
        group_jogador1.TabStop = false;
        group_jogador1.Text = "Jogador 1";
        // 
        // flowLayoutPanel1
        // 
        flowLayoutPanel1.Location = new Point(372, 22);
        flowLayoutPanel1.Name = "flowLayoutPanel1";
        flowLayoutPanel1.Size = new Size(246, 359);
        flowLayoutPanel1.TabIndex = 2;
        // 
        // panel_foto1
        // 
        panel_foto1.Location = new Point(6, 22);
        panel_foto1.Name = "panel_foto1";
        panel_foto1.Size = new Size(360, 359);
        panel_foto1.TabIndex = 0;
        // 
        // group_jogador2
        // 
        group_jogador2.Controls.Add(flowLayoutPanel2);
        group_jogador2.Controls.Add(panel_foto2);
        group_jogador2.Location = new Point(643, 12);
        group_jogador2.Name = "group_jogador2";
        group_jogador2.Size = new Size(624, 387);
        group_jogador2.TabIndex = 2;
        group_jogador2.TabStop = false;
        group_jogador2.Text = "Jogador 2";
        // 
        // flowLayoutPanel2
        // 
        flowLayoutPanel2.Location = new Point(372, 22);
        flowLayoutPanel2.Name = "flowLayoutPanel2";
        flowLayoutPanel2.Size = new Size(246, 359);
        flowLayoutPanel2.TabIndex = 3;
        // 
        // panel_foto2
        // 
        panel_foto2.Location = new Point(6, 22);
        panel_foto2.Name = "panel_foto2";
        panel_foto2.Size = new Size(360, 359);
        panel_foto2.TabIndex = 0;
        // 
        // group_jogador3
        // 
        group_jogador3.Controls.Add(flowLayoutPanel3);
        group_jogador3.Controls.Add(panel_foto3);
        group_jogador3.Location = new Point(1273, 12);
        group_jogador3.Name = "group_jogador3";
        group_jogador3.Size = new Size(624, 387);
        group_jogador3.TabIndex = 3;
        group_jogador3.TabStop = false;
        group_jogador3.Text = "Jogador 3";
        // 
        // flowLayoutPanel3
        // 
        flowLayoutPanel3.Location = new Point(372, 22);
        flowLayoutPanel3.Name = "flowLayoutPanel3";
        flowLayoutPanel3.Size = new Size(246, 359);
        flowLayoutPanel3.TabIndex = 4;
        // 
        // panel_foto3
        // 
        panel_foto3.Location = new Point(6, 22);
        panel_foto3.Name = "panel_foto3";
        panel_foto3.Size = new Size(360, 359);
        panel_foto3.TabIndex = 0;
        // 
        // group_jogador4
        // 
        group_jogador4.Controls.Add(this.flowLayoutPanel4);
        group_jogador4.Controls.Add(panel_foto4);
        group_jogador4.Location = new Point(12, 552);
        group_jogador4.Name = "group_jogador4";
        group_jogador4.Size = new Size(833, 387);
        group_jogador4.TabIndex = 2;
        group_jogador4.TabStop = false;
        group_jogador4.Text = "Jogador 4";
        // 
        // flowLayoutPanel4
        // 
        this.flowLayoutPanel4.Location = new Point(452, 22);
        this.flowLayoutPanel4.Name = "flowLayoutPanel4";
        this.flowLayoutPanel4.Size = new Size(375, 359);
        this.flowLayoutPanel4.TabIndex = 1;
        // 
        // panel_foto4
        // 
        panel_foto4.Location = new Point(6, 22);
        panel_foto4.Name = "panel_foto4";
        panel_foto4.Size = new Size(360, 359);
        panel_foto4.TabIndex = 0;
        // 
        // group_jogador5
        // 
        group_jogador5.Controls.Add(flowLayoutPanel5);
        group_jogador5.Controls.Add(panel_foto5);
        group_jogador5.Location = new Point(1059, 552);
        group_jogador5.Name = "group_jogador5";
        group_jogador5.Size = new Size(833, 387);
        group_jogador5.TabIndex = 3;
        group_jogador5.TabStop = false;
        group_jogador5.Text = "Jogador 5";
        // 
        // flowLayoutPanel5
        // 
        flowLayoutPanel5.Location = new Point(452, 22);
        flowLayoutPanel5.Name = "flowLayoutPanel5";
        flowLayoutPanel5.Size = new Size(375, 359);
        flowLayoutPanel5.TabIndex = 2;
        // 
        // panel_foto5
        // 
        panel_foto5.Location = new Point(6, 22);
        panel_foto5.Name = "panel_foto5";
        panel_foto5.Size = new Size(360, 359);
        panel_foto5.TabIndex = 0;
        // 
        // Esporte
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1904, 1041);
        Controls.Add(group_jogador5);
        Controls.Add(group_jogador4);
        Controls.Add(group_jogador3);
        Controls.Add(group_jogador2);
        Controls.Add(group_jogador1);
        Name = "Esporte";
        Text = "Esporte";
        WindowState = FormWindowState.Maximized;
        Load += Esporte_Load;
        group_jogador1.ResumeLayout(false);
        group_jogador2.ResumeLayout(false);
        group_jogador3.ResumeLayout(false);
        group_jogador4.ResumeLayout(false);
        group_jogador5.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion
    private GroupBox group_jogador1;
    private Panel panel_foto1;
    private GroupBox group_jogador2;
    private Panel panel_foto2;
    private GroupBox group_jogador3;
    private Panel panel_foto3;
    private GroupBox group_jogador4;
    private Panel panel_foto4;
    private GroupBox group_jogador5;
    private Panel panel_foto5;
    private FlowLayoutPanel flowLayoutPanel1;
    private FlowLayoutPanel flowLayoutPanel2;
    private FlowLayoutPanel flowLayoutPanel3;
    private FlowLayoutPanel flowLayoutPanel4;
    private FlowLayoutPanel flowLayoutPanel5;
}