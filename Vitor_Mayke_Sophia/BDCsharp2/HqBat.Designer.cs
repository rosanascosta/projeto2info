namespace BDCsharp2
{
    partial class HqBat
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
            capaquadrinho = new PictureBox();
            LblTxt = new Label();
            groupBox1 = new GroupBox();
            name = new Label();
            Tip = new Label();
            BtnVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)capaquadrinho).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // capaquadrinho
            // 
            capaquadrinho.Location = new Point(23, 41);
            capaquadrinho.Name = "capaquadrinho";
            capaquadrinho.Size = new Size(262, 323);
            capaquadrinho.SizeMode = PictureBoxSizeMode.Zoom;
            capaquadrinho.TabIndex = 1;
            capaquadrinho.TabStop = false;
            capaquadrinho.Click += capaquadrinho_Click;
            // 
            // LblTxt
            // 
            LblTxt.AutoSize = true;
            LblTxt.Location = new Point(6, 28);
            LblTxt.Name = "LblTxt";
            LblTxt.Size = new Size(10, 15);
            LblTxt.TabIndex = 4;
            LblTxt.Text = ".";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(LblTxt);
            groupBox1.Location = new Point(308, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(480, 270);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(24, 13);
            name.Name = "name";
            name.Size = new Size(38, 15);
            name.TabIndex = 7;
            name.Text = "label1";
            // 
            // Tip
            // 
            Tip.AutoSize = true;
            Tip.Location = new Point(208, 13);
            Tip.Name = "Tip";
            Tip.Size = new Size(10, 15);
            Tip.TabIndex = 8;
            Tip.Text = ".";
            // 
            // BtnVoltar
            // 
            BtnVoltar.Location = new Point(24, 408);
            BtnVoltar.Name = "BtnVoltar";
            BtnVoltar.Size = new Size(102, 30);
            BtnVoltar.TabIndex = 9;
            BtnVoltar.Text = "Voltar";
            BtnVoltar.UseVisualStyleBackColor = true;
            BtnVoltar.Click += BtnVoltar_Click;
            // 
            // HqBat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnVoltar);
            Controls.Add(Tip);
            Controls.Add(name);
            Controls.Add(groupBox1);
            Controls.Add(capaquadrinho);
            Name = "HqBat";
            Text = "FrmHq";
          //  Load += FrmHq_Load;
            ((System.ComponentModel.ISupportInitialize)capaquadrinho).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox capaquadrinho;
        private Label LblTxt;
        private GroupBox groupBox1;
        private Label name;
        private Label Tip;
        private Button BtnVoltar;
    }
}