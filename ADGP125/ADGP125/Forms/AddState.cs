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
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void stateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ///what does this do? also why do i need to wrap the type in paranthesis 
            //ComboBox comboBox = (ComboBox) sender;

            //I believe this gives my variable the string value of the item i played.
            string varPicked = (string)comboBox1.SelectedItem;

            //Integer
            //Float
            //Double
            //Character
            //String
            //Boolean
            switch (varPicked)
            {
                case "Integer":

                    break;
                case "Float":
                    break;
                case "Double":
                    break;
                case "Character":
                    break;
                case "String":
                    break;
                case "Boolean":
                    break;
                default:
                    break;

            }
                
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
