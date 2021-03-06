﻿namespace ADGP125
{
    partial class AddState
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.transitionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seeStatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seeTransitionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seeCurrentStateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeStateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(40, 59);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(133, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.dataToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.addToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(234, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stateToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // stateToolStripMenuItem
            // 
            this.stateToolStripMenuItem.Name = "stateToolStripMenuItem";
            this.stateToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.stateToolStripMenuItem.Text = "Transition";
            this.stateToolStripMenuItem.Click += new System.EventHandler(this.stateToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stateToolStripMenuItem1,
            this.transitionToolStripMenuItem1});
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.removeToolStripMenuItem.Text = "Remove";
            // 
            // stateToolStripMenuItem1
            // 
            this.stateToolStripMenuItem1.Name = "stateToolStripMenuItem1";
            this.stateToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.stateToolStripMenuItem1.Text = "State";
            this.stateToolStripMenuItem1.Click += new System.EventHandler(this.stateToolStripMenuItem1_Click);
            // 
            // transitionToolStripMenuItem1
            // 
            this.transitionToolStripMenuItem1.Name = "transitionToolStripMenuItem1";
            this.transitionToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.transitionToolStripMenuItem1.Text = "Transition";
            this.transitionToolStripMenuItem1.Click += new System.EventHandler(this.transitionToolStripMenuItem1_Click);
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
            this.button2.Location = new System.Drawing.Point(53, 116);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 25);
            this.button2.TabIndex = 6;
            this.button2.Text = "Done";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 194);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AddState";
            this.Text = "Add State";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stateToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem transitionToolStripMenuItem1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem stateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seeStatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seeTransitionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seeCurrentStateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeStateToolStripMenuItem;
    }
}

