﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace Glossary
{
    public partial class Form1 : Form
    {
        static List<WordList> loadedWordListObjects = new List<WordList>();

        public Form1()
        {
            InitializeComponent();
        }

        private void getListButton_Click(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            if (inputTxtBox.Text == "Input text here" || inputTxtBox.Text == "" || inputTxtBox.Text == " ")
            {
                MessageBox.Show("Textbox cannot be empty.");
                return;
            }
            textBox1.Text = null;
            string[] parameters = inputTxtBox.Text
                .Split(new char[] { ' ', '.', ',', ';', '<', '>' }, StringSplitOptions.RemoveEmptyEntries);
            if (parameters.Length > 2)
            {
                loadedWordListObjects.Add(new WordList(parameters[0], parameters[1..(parameters.Length)]));
                textBox1.Text = "Awaiting input...";
                inputTxtBox.Text = "Input all the languages here";
                label1.Text = "Lists loaded: " + loadedWordListObjects.Count();
            }
            else
            {
                throw new ArgumentException("parameters.Length < 3. Not enough parameters: <file name> <language 1> .. <language n>");
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string[] wordlistName = inputTxtBox.Text.Split(new char[] { ' ', '.', ',', ';', '<', '>' }, StringSplitOptions.RemoveEmptyEntries);
            string nameOfWordList = Convert.ToString(wordlistName[0]);
            var wordLists = WordList.LoadList(nameOfWordList);
            label1.Text ="List loaded: " +  wordLists.Name;

            string amountOfWords = Convert.ToString(wordLists.Count());

            CountLable.Text = $"\"{wordLists.Name}\" contains {amountOfWords} words.";

        }

        private void Count_Click(object sender, EventArgs e)
        {
            loadedWordListObjects.Count();

        }

        private void CountLable_Click(object sender, EventArgs e)
        {

        }

        private void sortList_Click(object sender, EventArgs e)
        {
            string[] wordlistName = inputTxtBox.Text.Split(new char[] { ' ', '.', ',', ';', '<', '>' }, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
