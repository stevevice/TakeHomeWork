using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADGP125
{

    public partial class AddState : Form
    {
        FSM<string> WordSave = new FSM<string>();
        public AddState()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WordSave.AddState(textBox2.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void stateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveLoad<FSM<string>> sl = new SaveLoad<FSM<string>>();
            sl.Serialize("FiniteStateMachine", WordSave);
            MessageBox.Show("You just saved your Finite State Machine");
        }

        private void stateToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void transitionToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
