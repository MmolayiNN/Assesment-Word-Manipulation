using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assesment_Word_Manipulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                string wordToAdd = textBox1.Text.Trim();
                if (!string.IsNullOrEmpty(wordToAdd))
                {
                    listBox1.Items.Add(wordToAdd);
                    textBox1.Clear();
                }
                else
                {
                    MessageBox.Show("Please enter a word or phrase to add.");
                }



            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string wordToChange = textBox1.Text.Trim();
            string newWord = textBox2.Text.Trim();

            if (!string.IsNullOrEmpty(wordToChange) && !string.IsNullOrEmpty(newWord))
            {
                if (listBox1.Items.Contains(wordToChange))
                {
                    int index = listBox1.Items.IndexOf(wordToChange);
                    listBox1.Items[index] = newWord;
                }
                else
                {
                    MessageBox.Show("Word or phrase not found in the list.");
                }
                textBox1.Clear();
                textBox2.Clear();
            }
            else
            {
                MessageBox.Show("Please enter both word to change and new word.");

            }



        }

        private void button3_Click(object sender, EventArgs e)       

            {
                listBox1.Items.Clear();
            }

        private void button4_Click(object sender, EventArgs e)
        {
            string wordToRemove = textBox1.Text.Trim();

            if (!string.IsNullOrEmpty(wordToRemove))
            {
                if (listBox1.Items.Contains(wordToRemove))
                {
                    listBox1.Items.Remove(wordToRemove);
                }
                else
                {
                    MessageBox.Show("Word or phrase not found in the list.");
                }
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a word or phrase to remove.");
            }



        }
    }


}
