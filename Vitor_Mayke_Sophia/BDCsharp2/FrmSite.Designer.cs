namespace BDCsharp2
{
    partial class FrmSite
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
            Superman = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            label3 = new Label();
            Lgn = new TextBox();
            button2 = new Button();
            MsMarvel = new PictureBox();
            Batman = new PictureBox();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)Superman).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MsMarvel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Batman).BeginInit();
            SuspendLayout();
            // 
            // Superman
            // 
            Superman.Location = new Point(303, 121);
            Superman.Name = "Superman";
            Superman.Size = new Size(188, 241);
            Superman.SizeMode = PictureBoxSizeMode.Zoom;
            Superman.TabIndex = 0;
            Superman.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 29);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 1;
            label1.Text = "Principais Quadrinhos";
            // 
            // button1
            // 
            button1.Location = new Point(713, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Deslogar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(612, 229);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 4;
            label3.Text = "Buscar";
            // 
            // Lgn
            // 
            Lgn.Location = new Point(595, 247);
            Lgn.Name = "Lgn";
            Lgn.Size = new Size(110, 23);
            Lgn.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(603, 279);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "Pesquisar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // MsMarvel
            // 
            MsMarvel.Location = new Point(566, 121);
            MsMarvel.Name = "MsMarvel";
            MsMarvel.Size = new Size(188, 241);
            MsMarvel.SizeMode = PictureBoxSizeMode.Zoom;
            MsMarvel.TabIndex = 7;
            MsMarvel.TabStop = false;
            // 
            // Batman
            // 
            Batman.Location = new Point(43, 121);
            Batman.Name = "Batman";
            Batman.Size = new Size(188, 241);
            Batman.SizeMode = PictureBoxSizeMode.Zoom;
            Batman.TabIndex = 8;
            Batman.TabStop = false;
            // 
            // button3
            // 
            button3.Location = new Point(91, 368);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 9;
            button3.Text = "Visualizar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(359, 368);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 10;
            button4.Text = "Visualizar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(620, 368);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 11;
            button5.Text = "Visualizar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // FrmSite
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(Batman);
            Controls.Add(MsMarvel);
            Controls.Add(button2);
            Controls.Add(Lgn);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(Superman);
            Name = "FrmSite";
            Text = "FrmSite";
            ((System.ComponentModel.ISupportInitialize)Superman).EndInit();
            ((System.ComponentModel.ISupportInitialize)MsMarvel).EndInit();
            ((System.ComponentModel.ISupportInitialize)Batman).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Superman;
        private Label label1;
        private Button button1;
        private Label label3;
        private TextBox Lgn;
        private Button button2;
        private PictureBox MsMarvel;
        private PictureBox Batman;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}