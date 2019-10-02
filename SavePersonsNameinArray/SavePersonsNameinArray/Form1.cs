using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SavePersonsNameinArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> nameList = new List<string>();

        private void saveNamesButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text =="")
            {
                MessageBox.Show("Please Insert Name First");

            }

            else
            {
                nameList.Add(nameTextBox.Text);

                MessageBox.Show("Data Saved");
                nameTextBox.Clear();
            }

           
                
              
        }
        private void showAllNamesButton_Click(object sender, EventArgs e)
        {
            namesListBox.Items.Clear();

            foreach (var name in nameList)
            {

                namesListBox.Items.Add(name);
                nameTextBox.Clear();
            }
            totalNumberOfNameTextBox.Text = nameList.Count.ToString();
        }

     
    }
}
