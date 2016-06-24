namespace ADGP125
{
    partial class RemoveTransition
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
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seeStatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seeTransitionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seeCurrentStateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeStateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.addStateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addStateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seeStatesToolStripMenuItem,
            this.seeTransitionsToolStripMenuItem,
            this.seeCurrentStateToolStripMenuItem,
            this.changeStateToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // seeStatesToolStripMenuItem
            // 
            this.seeStatesToolStripMenuItem.Name = "seeStatesToolStripMenuItem";
            this.seeStatesToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.seeStatesToolStripMenuItem.Text = "See States";
            this.seeStatesToolStripMenuItem.Click += new System.EventHandler(this.seeStatesToolStripMenuItem_Click);
            // 
            // seeTransitionsToolStripMenuItem
            // 
            this.seeTransitionsToolStripMenuItem.Name = "seeTransitionsToolStripMenuItem";
            this.seeTransitionsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.seeTransitionsToolStripMenuItem.Text = "See Transitions";
            this.seeTransitionsToolStripMenuItem.Click += new System.EventHandler(this.seeTransitionsToolStripMenuItem_Click);
            // 
            // seeCurrentStateToolStripMenuItem
            // 
            this.seeCurrentStateToolStripMenuItem.Name = "seeCurrentStateToolStripMenuItem";
            this.seeCurrentStateToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.seeCurrentStateToolStripMenuItem.Text = "See Current State";
            this.seeCurrentStateToolStripMenuItem.Click += new System.EventHandler(this.seeCurrentStateToolStripMenuItem_Click);
            // 
            // changeStateToolStripMenuItem
            // 
            this.changeStateToolStripMenuItem.Name = "changeStateToolStripMenuItem";
            this.changeStateToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.changeStateToolStripMenuItem.Text = "Change State";
            this.changeStateToolStripMenuItem.Click += new System.EventHandler(this.changeStateToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(89, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 25);
            this.button2.TabIndex = 6;
            this.button2.Text = "Done";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(151, 52);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 11;
            // 
            // addStateBindingSource
            // 
            this.addStateBindingSource.DataSource = typeof(ADGP125.AddState);
            // 
            // AddTransition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 202);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AddTransition";
            this.Text = "Add Transition";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addStateBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seeStatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seeTransitionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seeCurrentStateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeStateToolStripMenuItem;
        private System.Windows.Forms.BindingSource addStateBindingSource;
    }
}

