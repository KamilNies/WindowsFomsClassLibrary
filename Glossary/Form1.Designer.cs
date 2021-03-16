﻿
namespace Glossary
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addWordsTextBox = new System.Windows.Forms.TextBox();
            this.removeWordsButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.addWordsErrorLabel = new System.Windows.Forms.Label();
            this.removeWordsErrorLabel = new System.Windows.Forms.Label();
            this.removeWordsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.removeFromLangComboBox = new System.Windows.Forms.ComboBox();
            this.removeFromLangLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addWordsTextBox
            // 
            this.addWordsTextBox.Location = new System.Drawing.Point(188, 314);
            this.addWordsTextBox.Name = "addWordsTextBox";
            this.addWordsTextBox.Size = new System.Drawing.Size(125, 27);
            this.addWordsTextBox.TabIndex = 0;
            // 
            // removeWordsButton
            // 
            this.removeWordsButton.Location = new System.Drawing.Point(388, 397);
            this.removeWordsButton.Name = "removeWordsButton";
            this.removeWordsButton.Size = new System.Drawing.Size(119, 29);
            this.removeWordsButton.TabIndex = 2;
            this.removeWordsButton.Text = "Remove Words";
            this.removeWordsButton.UseVisualStyleBackColor = true;
            this.removeWordsButton.Click += new System.EventHandler(this.RemoveWords);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(188, 347);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(119, 29);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add Words";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddWords);
            // 
            // addWordsErrorLabel
            // 
            this.addWordsErrorLabel.AutoSize = true;
            this.addWordsErrorLabel.Location = new System.Drawing.Point(197, 267);
            this.addWordsErrorLabel.Name = "addWordsErrorLabel";
            this.addWordsErrorLabel.Size = new System.Drawing.Size(50, 20);
            this.addWordsErrorLabel.TabIndex = 4;
            this.addWordsErrorLabel.Text = "label1";
            // 
            // removeWordsErrorLabel
            // 
            this.removeWordsErrorLabel.AutoSize = true;
            this.removeWordsErrorLabel.Location = new System.Drawing.Point(388, 267);
            this.removeWordsErrorLabel.Name = "removeWordsErrorLabel";
            this.removeWordsErrorLabel.Size = new System.Drawing.Size(107, 20);
            this.removeWordsErrorLabel.TabIndex = 5;
            this.removeWordsErrorLabel.Text = "Remove words";
            // 
            // removeWordsCheckedListBox
            // 
            this.removeWordsCheckedListBox.FormattingEnabled = true;
            this.removeWordsCheckedListBox.Location = new System.Drawing.Point(388, 288);
            this.removeWordsCheckedListBox.Name = "removeWordsCheckedListBox";
            this.removeWordsCheckedListBox.ScrollAlwaysVisible = true;
            this.removeWordsCheckedListBox.Size = new System.Drawing.Size(194, 48);
            this.removeWordsCheckedListBox.TabIndex = 8;
            // 
            // removeFromLangComboBox
            // 
            this.removeFromLangComboBox.FormattingEnabled = true;
            this.removeFromLangComboBox.Location = new System.Drawing.Point(388, 363);
            this.removeFromLangComboBox.Name = "removeFromLangComboBox";
            this.removeFromLangComboBox.Size = new System.Drawing.Size(125, 28);
            this.removeFromLangComboBox.TabIndex = 9;
            // 
            // removeFromLangLabel
            // 
            this.removeFromLangLabel.AutoSize = true;
            this.removeFromLangLabel.Location = new System.Drawing.Point(388, 339);
            this.removeFromLangLabel.Name = "removeFromLangLabel";
            this.removeFromLangLabel.Size = new System.Drawing.Size(74, 20);
            this.removeFromLangLabel.TabIndex = 10;
            this.removeFromLangLabel.Text = "Language";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.removeFromLangLabel);
            this.Controls.Add(this.removeFromLangComboBox);
            this.Controls.Add(this.removeWordsCheckedListBox);
            this.Controls.Add(this.removeWordsErrorLabel);
            this.Controls.Add(this.addWordsErrorLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.removeWordsButton);
            this.Controls.Add(this.addWordsTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addWordsTextBox;
        private System.Windows.Forms.Button removeWordsButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label addWordsErrorLabel;
        private System.Windows.Forms.Label removeWordsErrorLabel;
        private System.Windows.Forms.CheckedListBox removeWordsCheckedListBox;
        private System.Windows.Forms.ComboBox removeFromLangComboBox;
        private System.Windows.Forms.Label removeFromLangLabel;
    }
}

