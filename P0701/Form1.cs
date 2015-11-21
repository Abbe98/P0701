using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace P0701
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            // two list to act as containers for input items
            List<string> stringList = new List<string>();
            List<int> intList = new List<int>();
            // bool to track possible parse failture
            bool error = false;

            // add items to List<string> to make foreach() possible
            stringList.Add(textBox1.Text);
            stringList.Add(textBox2.Text);
            stringList.Add(textBox3.Text);
            stringList.Add(textBox4.Text);
            stringList.Add(textBox5.Text);

            foreach(string stringItem in stringList)
            {
                // add to List<int> if parsing is successful otherwise trigger error, set error, and break out of loop
                int intItem;
                if(int.TryParse(stringItem, out intItem))
                {
                    intList.Add(intItem);
                } else
                {
                    MessageBox.Show("Ange fem heltal!", "Hoppsan!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    error = true;
                    break;
                }
            }

            if (!error)
            {
                // get maximum value from List<int> and output result
                resultLabel.Text = intList.Max().ToString();
            }
        }
    }
}
