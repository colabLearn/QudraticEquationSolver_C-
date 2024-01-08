using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TutorialPractice
{
    public partial class Form1 : Form
    {
        RootOfEquation calRoot;
        string messg2;
        public Form1()
        {
            InitializeComponent();
            calRoot = new RootOfEquation();
            messg2 = "0";
   
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void aValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void CalculateRoot_Click(object sender, EventArgs e)
        {
            calRoot.getABC_fromUser
                (
                    aValue.Text,
                    bValue.Text,
                    cValue.Text
                );

            string messg = $"a: { calRoot.getA().ToString()} \n" +
                           $"b:  {calRoot.getB().ToString()} \n" +
                           $"c:  {calRoot.getC().ToString()}";
            double x1 = Math.Round(calRoot.rootsOfEqua()[0], 2);
            double  x2 =Math.Round(calRoot.rootsOfEqua()[1], 2);
            messg2 = $"Roots of the equation x: {x1} or {x2}";
            output_TextChanged( sender, e );    

            
        }

        private void bValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void output_TextChanged(object sender, EventArgs e)
        {
            output.Text = messg2;
        
        }
    }
}
