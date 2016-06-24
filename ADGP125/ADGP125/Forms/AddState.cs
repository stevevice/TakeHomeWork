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
        AddTransition ATWindow = new AddTransition();
        RemoveState RSWindow = new RemoveState();
        RemoveTransition RTWindow = new RemoveTransition();
        new public void Update() // still testing
        {
            if(ATWindow.TransitionDone == true)
            {
                WordSave = ATWindow.WordSave;
                ATWindow.TransitionDone = false;
            }
            else if (RSWindow.StateRemDone == true)
            {
                WordSave = RSWindow.WordSave;
                RSWindow.StateRemDone = false;
            }
            else if (RTWindow.TransitionDone == true)
            {
                WordSave = RTWindow.WordSave;
                RTWindow.TransitionDone = false;
            }
        }

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
        {            ATWindow.WordSave = WordSave;            ATWindow.Show();
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
            RemoveState RSWindow = new RemoveState();            RSWindow.Show();
        }

        private void transitionToolStripMenuItem1_Click(object sender, EventArgs e)
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
