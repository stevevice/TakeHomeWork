namespace WindowsFormsApplication1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonExport = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textOutput = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.listOutput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(485, 295);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(75, 23);
            this.buttonExport.TabIndex = 0;
            this.buttonExport.Text = "Export";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.button1_Click);
            this.buttonExport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buttonExport_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(413, 581);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textOutput
            // 
            this.textOutput.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textOutput.Location = new System.Drawing.Point(430, 25);
            this.textOutput.Multiline = true;
            this.textOutput.Name = "textOutput";
            this.textOutput.Size = new System.Drawing.Size(313, 198);
            this.textOutput.TabIndex = 2;
            this.textOutput.TextChanged += new System.EventHandler(this.textOutput_TextChanged);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(625, 295);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Clear!";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // listOutput
            // 
            this.listOutput.BackColor = System.Drawing.Color.Lime;
            this.listOutput.Location = new System.Drawing.Point(485, 414);
            this.listOutput.Multiline = true;
            this.listOutput.Name = "listOutput";
            this.listOutput.Size = new System.Drawing.Size(214, 65);
            this.listOutput.TabIndex = 4;
            this.listOutput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 635);
            this.Controls.Add(this.listOutput);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.textOutput);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonExport);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.button1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textOutput;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox listOutput;
    }
}

