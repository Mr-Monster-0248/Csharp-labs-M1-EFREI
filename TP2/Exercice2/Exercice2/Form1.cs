using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercice2
{
    public partial class Form1 : Form
    {
        private readonly List<String> letterList = new List<String> { "A", "B", "C", "D", "E" };

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (String letter in letterList)
            {
                DisplayLetter disp = new DisplayLetter(letter);
                Thread t = new Thread(new ThreadStart(disp.PrintLetter));
                disp.Display += DisplayThreadLetter;
                t.Start();
            }
        }

        /////<summary>This is unsafe but should work</summary>
        //private void DisplayThreadLetter(object sender, string letter)
        //{
        //    textBox1.Text += letter;
        //}

        private void DisplayThreadLetter(object sender, string letter)
        {
            try
            {
                if (textBox1.IsHandleCreated)
                {
                    textBox1.Invoke((MethodInvoker)(() => textBox1.AppendText(letter)));
                }
            }
            catch (InvalidAsynchronousStateException _)
            {
                // Do nothing
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
