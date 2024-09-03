namespace Senac.ConversorMoedas
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            panel4 = new Panel();
            label7 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            panel6 = new Panel();
            comboBoxMoedaDestino = new ComboBox();
            pictureBoxImagemDestino = new PictureBox();
            label3 = new Label();
            panel3 = new Panel();
            label6 = new Label();
            label4 = new Label();
            textBoxValor = new TextBox();
            panel5 = new Panel();
            comboBoxMoedaOrigem = new ComboBox();
            label2 = new Label();
            pictureBoxImagemOrigem = new PictureBox();
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagemDestino).BeginInit();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagemOrigem).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(824, 50);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(334, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(149, 21);
            label1.TabIndex = 0;
            label1.Text = "Converter Moedas";
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumTurquoise;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 50);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(824, 395);
            panel2.TabIndex = 0;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(381, 137);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(50, 50);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gainsboro;
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(textBox2);
            panel4.Controls.Add(panel6);
            panel4.Location = new Point(498, 38);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(313, 250);
            panel4.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 216);
            label7.Name = "label7";
            label7.Size = new Size(59, 25);
            label7.TabIndex = 4;
            label7.Text = "label5";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(23, 372);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(59, 25);
            label5.TabIndex = 3;
            label5.Text = "label5";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.LightSkyBlue;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            textBox2.Location = new Point(25, 135);
            textBox2.Margin = new Padding(4, 5, 4, 5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(269, 29);
            textBox2.TabIndex = 3;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(comboBoxMoedaDestino);
            panel6.Controls.Add(pictureBoxImagemDestino);
            panel6.Controls.Add(label3);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Margin = new Padding(4, 5, 4, 5);
            panel6.Name = "panel6";
            panel6.Size = new Size(313, 83);
            panel6.TabIndex = 0;
            // 
            // comboBoxMoedaDestino
            // 
            comboBoxMoedaDestino.FormattingEnabled = true;
            comboBoxMoedaDestino.Location = new Point(226, 21);
            comboBoxMoedaDestino.Margin = new Padding(4, 5, 4, 5);
            comboBoxMoedaDestino.Name = "comboBoxMoedaDestino";
            comboBoxMoedaDestino.Size = new Size(83, 33);
            comboBoxMoedaDestino.TabIndex = 5;
            comboBoxMoedaDestino.SelectedIndexChanged += comboBoxMoedaDestino_SelectedIndexChanged;
            // 
            // pictureBoxImagemDestino
            // 
            pictureBoxImagemDestino.Location = new Point(4, 12);
            pictureBoxImagemDestino.Margin = new Padding(4, 5, 4, 5);
            pictureBoxImagemDestino.Name = "pictureBoxImagemDestino";
            pictureBoxImagemDestino.Size = new Size(57, 67);
            pictureBoxImagemDestino.TabIndex = 3;
            pictureBoxImagemDestino.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(70, 27);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(124, 21);
            label3.TabIndex = 4;
            label3.Text = "Moeda destino";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gainsboro;
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(textBoxValor);
            panel3.Controls.Add(panel5);
            panel3.Location = new Point(17, 38);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 250);
            panel3.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 217);
            label6.Name = "label6";
            label6.Size = new Size(59, 25);
            label6.TabIndex = 3;
            label6.Text = "label4";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(24, 372);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 2;
            label4.Text = "label4";
            // 
            // textBoxValor
            // 
            textBoxValor.BackColor = Color.NavajoWhite;
            textBoxValor.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            textBoxValor.Location = new Point(14, 135);
            textBoxValor.Margin = new Padding(4, 5, 4, 5);
            textBoxValor.Name = "textBoxValor";
            textBoxValor.Size = new Size(269, 29);
            textBoxValor.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(comboBoxMoedaOrigem);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(pictureBoxImagemOrigem);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Margin = new Padding(4, 5, 4, 5);
            panel5.Name = "panel5";
            panel5.Size = new Size(300, 83);
            panel5.TabIndex = 0;
            // 
            // comboBoxMoedaOrigem
            // 
            comboBoxMoedaOrigem.FormattingEnabled = true;
            comboBoxMoedaOrigem.Location = new Point(213, 21);
            comboBoxMoedaOrigem.Margin = new Padding(4, 5, 4, 5);
            comboBoxMoedaOrigem.Name = "comboBoxMoedaOrigem";
            comboBoxMoedaOrigem.Size = new Size(83, 33);
            comboBoxMoedaOrigem.TabIndex = 2;
            comboBoxMoedaOrigem.SelectedIndexChanged += comboBoxMoedaOrigem_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(70, 27);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(122, 21);
            label2.TabIndex = 1;
            label2.Text = "Moeda origem";
            // 
            // pictureBoxImagemOrigem
            // 
            pictureBoxImagemOrigem.Location = new Point(4, 12);
            pictureBoxImagemOrigem.Margin = new Padding(4, 5, 4, 5);
            pictureBoxImagemOrigem.Name = "pictureBoxImagemOrigem";
            pictureBoxImagemOrigem.Size = new Size(57, 67);
            pictureBoxImagemOrigem.TabIndex = 0;
            pictureBoxImagemOrigem.TabStop = false;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1 });
            toolStrip1.Location = new Point(0, 417);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(824, 28);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(131, 25);
            toolStripLabel1.Text = "toolStripLabel1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 445);
            Controls.Add(toolStrip1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Senac - Conversor de Moedas";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagemDestino).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagemOrigem).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private ToolStrip toolStrip1;
        private Label label1;
        private Panel panel4;
        private Panel panel6;
        private Panel panel3;
        private Panel panel5;
        private ComboBox comboBoxMoedaDestino;
        private PictureBox pictureBoxImagemDestino;
        private Label label3;
        private ComboBox comboBoxMoedaOrigem;
        private Label label2;
        private PictureBox pictureBoxImagemOrigem;
        private Button button1;
        private Label label5;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBoxValor;
        private ToolStripLabel toolStripLabel1;
        private Label label7;
        private Label label6;
    }
}
