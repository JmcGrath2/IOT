namespace WindowsFormsApp1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.COMPORTBOX = new System.Windows.Forms.ComboBox();
            this.BAUDBOX = new System.Windows.Forms.ComboBox();
            this.DATABOX = new System.Windows.Forms.ComboBox();
            this.STOPBOX = new System.Windows.Forms.ComboBox();
            this.PARITYBOX = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.OPEN = new System.Windows.Forms.Button();
            this.CLOSE = new System.Windows.Forms.Button();
            this.SENDDATA = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // COMPORTBOX
            // 
            this.COMPORTBOX.FormattingEnabled = true;
            this.COMPORTBOX.Location = new System.Drawing.Point(207, 80);
            this.COMPORTBOX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.COMPORTBOX.Name = "COMPORTBOX";
            this.COMPORTBOX.Size = new System.Drawing.Size(180, 28);
            this.COMPORTBOX.TabIndex = 0;
            // 
            // BAUDBOX
            // 
            this.BAUDBOX.FormattingEnabled = true;
            this.BAUDBOX.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600"});
            this.BAUDBOX.Location = new System.Drawing.Point(207, 143);
            this.BAUDBOX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BAUDBOX.Name = "BAUDBOX";
            this.BAUDBOX.Size = new System.Drawing.Size(180, 28);
            this.BAUDBOX.TabIndex = 1;
            this.BAUDBOX.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // DATABOX
            // 
            this.DATABOX.FormattingEnabled = true;
            this.DATABOX.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.DATABOX.Location = new System.Drawing.Point(207, 198);
            this.DATABOX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DATABOX.Name = "DATABOX";
            this.DATABOX.Size = new System.Drawing.Size(180, 28);
            this.DATABOX.TabIndex = 2;
            // 
            // STOPBOX
            // 
            this.STOPBOX.FormattingEnabled = true;
            this.STOPBOX.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.STOPBOX.Location = new System.Drawing.Point(207, 255);
            this.STOPBOX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.STOPBOX.Name = "STOPBOX";
            this.STOPBOX.Size = new System.Drawing.Size(180, 28);
            this.STOPBOX.TabIndex = 3;
            // 
            // PARITYBOX
            // 
            this.PARITYBOX.FormattingEnabled = true;
            this.PARITYBOX.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.PARITYBOX.Location = new System.Drawing.Point(207, 312);
            this.PARITYBOX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PARITYBOX.Name = "PARITYBOX";
            this.PARITYBOX.Size = new System.Drawing.Size(180, 28);
            this.PARITYBOX.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "COMPORT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "BAUD RATE";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 211);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "DATA BITS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 268);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "STOP BITS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 325);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "PARITY BITS";
            // 
            // OPEN
            // 
            this.OPEN.Location = new System.Drawing.Point(74, 411);
            this.OPEN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OPEN.Name = "OPEN";
            this.OPEN.Size = new System.Drawing.Size(112, 35);
            this.OPEN.TabIndex = 10;
            this.OPEN.Text = "OPEN";
            this.OPEN.UseVisualStyleBackColor = true;
            this.OPEN.Click += new System.EventHandler(this.OPEN_Click);
            // 
            // CLOSE
            // 
            this.CLOSE.Location = new System.Drawing.Point(230, 411);
            this.CLOSE.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CLOSE.Name = "CLOSE";
            this.CLOSE.Size = new System.Drawing.Size(112, 35);
            this.CLOSE.TabIndex = 11;
            this.CLOSE.Text = "CLOSE";
            this.CLOSE.UseVisualStyleBackColor = true;
            this.CLOSE.Click += new System.EventHandler(this.CLOSE_Click);
            // 
            // SENDDATA
            // 
            this.SENDDATA.Location = new System.Drawing.Point(428, 335);
            this.SENDDATA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SENDDATA.Name = "SENDDATA";
            this.SENDDATA.Size = new System.Drawing.Size(140, 111);
            this.SENDDATA.TabIndex = 12;
            this.SENDDATA.Text = "SEND DATA";
            this.SENDDATA.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(602, 32);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(320, 412);
            this.textBox1.TabIndex = 13;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(74, 482);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(315, 35);
            this.progressBar1.TabIndex = 14;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(986, 82);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SENDDATA);
            this.Controls.Add(this.CLOSE);
            this.Controls.Add(this.OPEN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PARITYBOX);
            this.Controls.Add(this.STOPBOX);
            this.Controls.Add(this.DATABOX);
            this.Controls.Add(this.BAUDBOX);
            this.Controls.Add(this.COMPORTBOX);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox COMPORTBOX;
        private System.Windows.Forms.ComboBox BAUDBOX;
        private System.Windows.Forms.ComboBox DATABOX;
        private System.Windows.Forms.ComboBox STOPBOX;
        private System.Windows.Forms.ComboBox PARITYBOX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button OPEN;
        private System.Windows.Forms.Button CLOSE;
        private System.Windows.Forms.Button SENDDATA;
        private System.Windows.Forms.TextBox textBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

