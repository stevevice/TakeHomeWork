namespace ADGP125
{
    partial class RemoveState
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
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transitionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.seeTransitionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seeCurrentStatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeStateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 85);
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
            this.removeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(218, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transitionToolStripMenuItem1,
            this.seeTransitionsToolStripMenuItem,
            this.seeCurrentStatesToolStripMenuItem,
            this.changeStateToolStripMenuItem});
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.removeToolStripMenuItem.Text = "Data";
            // 
            // transitionToolStripMenuItem1
            // 
            this.transitionToolStripMenuItem1.Name = "transitionToolStripMenuItem1";
            this.transitionToolStripMenuItem1.Size = new System.Drawing.Size(169, 22);
            this.transitionToolStripMenuItem1.Text = "See States";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(56, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 25);
            this.button2.TabIndex = 6;
            this.button2.Text = "Done";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(38, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // seeTransitionsToolStripMenuItem
            // 
            this.seeTransitionsToolStripMenuItem.Name = "seeTransitionsToolStripMenuItem";
            this.seeTransitionsToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.seeTransitionsToolStripMenuItem.Text = "See Transitions";
            // 
            // seeCurrentStatesToolStripMenuItem
            // 
            this.seeCurrentStatesToolStripMenuItem.Name = "seeCurrentStatesToolStripMenuItem";
            this.seeCurrentStatesToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.seeCurrentStatesToolStripMenuItem.Text = "See Current States";
            // 
            // changeStateToolStripMenuItem
            // 
            this.changeStateToolStripMenuItem.Name = "changeStateToolStripMenuItem";
            this.changeStateToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.changeStateToolStripMenuItem.Text = "Change State";
            // 
            // RemoveState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 172);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RemoveState";
            this.Text = "Remove State";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transitionToolStripMenuItem1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ToolStripMenuItem seeTransitionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seeCurrentStatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeStateToolStripMenuItem;
    }
}

