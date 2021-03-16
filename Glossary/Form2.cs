using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            Program.currentList = WordList.LoadList("lang3");

            for (int i = 0; i < Program.currentList.Count(); i++)
            {
                removeWordsCheckedListBox.Items.Add(Program.currentList[i].Translations[0], false);
            }

            removeFromLangComboBox.Items.AddRange(Program.currentList.Languages);

            removeFromLangComboBox.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 
        }

        /// <summary>
        /// Frågar användaren efter ett nytt ord(på listans första språk), och frågar därefter i /tur och ordning efter översättningar till alla språk i listan.
        /// Sedan fortsätter den att fråga efter nya ord tills användaren avbryter genom att mata in en tom rad. Sparar slutligen listan om det går.
        /// </summary>
        /// <param name="wordList">Listan att addera ord till.</param>
        public void AddWords(object sender, EventArgs e)
        {
            var wordList = Program.currentList;

            if (wordList == null)
            {
                addWordsErrorLabel.Text = "Fail! You must first load a Word List.";
                return;
            }

            string[] addedTranslations = addWordsTextBox.Text.Split(new char[] { ',', '.', ' ', '<', '>' }, StringSplitOptions.RemoveEmptyEntries);

            if (addedTranslations.Length == 0 || addedTranslations.Length % wordList.Languages.Length != 0)
            {
                addWordsErrorLabel.Text = "Fail! You must enter at least one word for every language.";
                return;
            }

            int wordCount = addedTranslations.Length / wordList.Languages.Length;

            for (var i = 0; i < wordCount; i++)
            {
                wordList.Add(addedTranslations.Skip(i * wordList.Languages.Length).Take(wordList.Languages.Length).ToArray());
            }

            wordList.Save();

            addWordsErrorLabel.Text = "Words were successfully added to the list!";

            UpdateRemoveWordsCheckedListBox();

        }

        /// <summary>
        /// Raderar angivna ord från namngiven lista och språk.
        /// </summary>
        /// <param name="args">Måste innehålla parametrarna "list name", "language", "word 1", "word 2" .. "word n"</param>
        /// <returns>True om kommandot är skrivet i rätt format, annars false.</returns>
        public void RemoveWords(object sender, EventArgs e)
        {
            var wordList = Program.currentList;

            if (wordList == null)
            {
                removeWordsErrorLabel.Text = "Fail! You must first load a Word List.";
                return;
            }

            string language = removeFromLangComboBox.Text;
            var wordItemsToBeRemoved = removeWordsCheckedListBox.CheckedItems;

            if (wordItemsToBeRemoved.Count == 0)
            {
                removeWordsErrorLabel.Text = "Fail! You must enter at least one word.";
                return;
            }

            while (wordItemsToBeRemoved.Count > 0)
            {
                wordList.Remove(removeFromLangComboBox.SelectedIndex, wordItemsToBeRemoved[0].ToString());
                removeWordsCheckedListBox.Items.Remove(wordItemsToBeRemoved[0]);
            }

            wordList.Save();
            removeWordsErrorLabel.Text = "Words were successfully removed!";
        }

        private void removeFromLangComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateRemoveWordsCheckedListBox();
        }

        private void UpdateRemoveWordsCheckedListBox()
        {
            removeWordsCheckedListBox.Items.Clear();
            for (int i = 0; i < Program.currentList.Count(); i++)
            {
                removeWordsCheckedListBox.Items.Add(Program.currentList[i].Translations[removeFromLangComboBox.SelectedIndex], false);
            }
        }

        private void removeWordsCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
