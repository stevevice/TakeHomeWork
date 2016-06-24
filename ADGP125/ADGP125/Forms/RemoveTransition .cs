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
    public partial class RemoveTransition : Form
    {
        public FSM<string> WordSave = new FSM<string>();
        public bool TransitionDone = false;
        public RemoveTransition()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TransitionDone = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveLoad<FSM<string>> sl = new SaveLoad<FSM<string>>();
            sl.Serialize("FiniteStateMachine", WordSave);
            MessageBox.Show("You just saved your Finite State Machine");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void seeStatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WordSave.ListStates();
        }

        private void seeTransitionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WordSave.ListTransitions();
        }

        private void seeCurrentStateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(WordSave.CurrentState);
        }

        private void changeStateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
