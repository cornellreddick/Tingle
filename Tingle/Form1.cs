using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tingle
{
    public partial class Wingdings : Form
    {
        public Wingdings()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var results = textBox1.Text = "";
            resultsLabel.Text = results;
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstButton_Click(object sender, EventArgs e)
        {
            var results = textBox1.Text;
            resultsLabel.Text = results;
            textBox1.Clear();
        }
    }
}
