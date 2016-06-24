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

    public partial class RemoveState : Form
    {
        public FSM<string> WordSave = new FSM<string>();
        public bool StateRemDone = false;
        public RemoveState()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StateRemDone = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
