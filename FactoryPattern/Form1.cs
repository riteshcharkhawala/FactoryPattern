using FactoryPattern.DataObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FactoryPattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                IPlay objPlay = null;
                if (comboBox1.Text == "DekTec101")
                {
                    objPlay = new DekTec101();
                }
                else if (comboBox1.Text == "DekTec102")
                {
                    objPlay = new DekTec102();
                }
                else if (comboBox1.Text == "DekTec103")
                {
                    objPlay = new DekTec103();
                }
                lblResult.Text = objPlay.Play();
            }
            catch
            {
                lblResult.Text = "Invalid selection";
            }
        }
    }
}
