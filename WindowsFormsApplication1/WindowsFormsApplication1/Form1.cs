using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    

    public partial class Form1 : Form
    {
        public class CoorStore
        {
            List<string> Storage = new List<string>();

            public CoorStore()
            {

            }

            public void ClickStore(string MouseClick)
            {
                Storage.Add(MouseClick);
                
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    //File.WriteAllText()
                    // Code to write the stream goes here.

                    myStream.Close();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CoorStore abc;
            if (e.GetType() == typeof(MouseEventArgs))
            {
                MouseEventArgs me = e as MouseEventArgs;
                textOutput.Text += me.Location.ToString();
                
            }
        }

        private void buttonExport_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textOutput.Text = "";
        }

        private void textOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
