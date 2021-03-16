using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            if (loadFileNameTxtBox.Text == "Enter file name with .dat extension" || loadFileNameTxtBox.Text == "")
            {
                MessageBox.Show("Textbox cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Program.currentList = WordList.LoadList(loadFileNameTxtBox.Text);
                if (Program.currentList == null)
                {
                    fileLoadedLabel.ForeColor = Color.DarkRed;
                    fileLoadedLabel.Text = "Cannot find file. File not loaded.";
                }
                else
                {
                    fileLoadedLabel.ForeColor = Color.Green;
                    fileLoadedLabel.Text = $"{Program.currentList.Name}.dat loaded. Contains: {Program.currentList.Count()} word objects";
                }
            }
        }

        private void Sort_Button_Click(object sender, EventArgs e)
        {
            if (SortListTxtBox.Text == "Enter file name with .dat extension" || SortListTxtBox.Text == "")
            {
                MessageBox.Show("Textbox cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                for (int i = 0; i < Program.currentList.Languages.Length; i++)
                {
                    if(SortListTxtBox.Text == Program.currentList.Languages[i])
                    {
                        Action<string[]> action = new Action<string[]>(ShowTranslations);
                        Program.currentList.List(i, action);
                    }
                }
            }
            
        }

        private void ShowTranslations(string[] words)
        {
            string newLine = Environment.NewLine;
            outputTxtBox.Text += string.Join(",", words) + newLine;
        }
    }
}
