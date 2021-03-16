
namespace Glossary
{
    partial class Form2
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
            this.addWordsGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addWordsGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addWordsTextBox
            // 
            this.addWordsTextBox.Location = new System.Drawing.Point(57, 58);
            this.addWordsTextBox.Name = "addWordsTextBox";
            this.addWordsTextBox.Size = new System.Drawing.Size(125, 27);
            this.addWordsTextBox.TabIndex = 0;
            // 
            // removeWordsButton
            // 
            this.removeWordsButton.BackColor = System.Drawing.Color.Yellow;
            this.removeWordsButton.Location = new System.Drawing.Point(62, 179);
            this.removeWordsButton.Name = "removeWordsButton";
            this.removeWordsButton.Size = new System.Drawing.Size(119, 29);
            this.removeWordsButton.TabIndex = 2;
            this.removeWordsButton.Text = "Remove Words";
            this.removeWordsButton.UseVisualStyleBackColor = false;
            this.removeWordsButton.Click += new System.EventHandler(this.RemoveWords);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Yellow;
            this.addButton.Location = new System.Drawing.Point(57, 91);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(119, 29);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add Words";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.AddWords);
            // 
            // addWordsErrorLabel
            // 
            this.addWordsErrorLabel.AutoSize = true;
            this.addWordsErrorLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addWordsErrorLabel.Location = new System.Drawing.Point(57, 32);
            this.addWordsErrorLabel.Name = "addWordsErrorLabel";
            this.addWordsErrorLabel.Size = new System.Drawing.Size(81, 20);
            this.addWordsErrorLabel.TabIndex = 4;
            this.addWordsErrorLabel.Text = "Add words";
            // 
            // removeWordsErrorLabel
            // 
            this.removeWordsErrorLabel.AutoSize = true;
            this.removeWordsErrorLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.removeWordsErrorLabel.Location = new System.Drawing.Point(62, 9);
            this.removeWordsErrorLabel.Name = "removeWordsErrorLabel";
            this.removeWordsErrorLabel.Size = new System.Drawing.Size(107, 20);
            this.removeWordsErrorLabel.TabIndex = 5;
            this.removeWordsErrorLabel.Text = "Remove words";
            // 
            // removeWordsCheckedListBox
            // 
            this.removeWordsCheckedListBox.FormattingEnabled = true;
            this.removeWordsCheckedListBox.Location = new System.Drawing.Point(62, 48);
            this.removeWordsCheckedListBox.Name = "removeWordsCheckedListBox";
            this.removeWordsCheckedListBox.ScrollAlwaysVisible = true;
            this.removeWordsCheckedListBox.Size = new System.Drawing.Size(150, 70);
            this.removeWordsCheckedListBox.TabIndex = 8;
            this.removeWordsCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.removeWordsCheckedListBox_SelectedIndexChanged);
            // 
            // removeFromLangComboBox
            // 
            this.removeFromLangComboBox.FormattingEnabled = true;
            this.removeFromLangComboBox.Location = new System.Drawing.Point(62, 145);
            this.removeFromLangComboBox.Name = "removeFromLangComboBox";
            this.removeFromLangComboBox.Size = new System.Drawing.Size(150, 28);
            this.removeFromLangComboBox.TabIndex = 9;
            this.removeFromLangComboBox.SelectedIndexChanged += new System.EventHandler(this.removeFromLangComboBox_SelectedIndexChanged);
            // 
            // removeFromLangLabel
            // 
            this.removeFromLangLabel.AutoSize = true;
            this.removeFromLangLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.removeFromLangLabel.Location = new System.Drawing.Point(62, 121);
            this.removeFromLangLabel.Name = "removeFromLangLabel";
            this.removeFromLangLabel.Size = new System.Drawing.Size(74, 20);
            this.removeFromLangLabel.TabIndex = 10;
            this.removeFromLangLabel.Text = "Language";
            // 
            // addWordsGroupBox
            // 
            this.addWordsGroupBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addWordsGroupBox.Controls.Add(this.addWordsTextBox);
            this.addWordsGroupBox.Controls.Add(this.addButton);
            this.addWordsGroupBox.Controls.Add(this.addWordsErrorLabel);
            this.addWordsGroupBox.Location = new System.Drawing.Point(86, 111);
            this.addWordsGroupBox.Name = "addWordsGroupBox";
            this.addWordsGroupBox.Size = new System.Drawing.Size(250, 155);
            this.addWordsGroupBox.TabIndex = 11;
            this.addWordsGroupBox.TabStop = false;
            this.addWordsGroupBox.Text = "Add words";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Controls.Add(this.removeWordsCheckedListBox);
            this.groupBox1.Controls.Add(this.removeWordsButton);
            this.groupBox1.Controls.Add(this.removeFromLangLabel);
            this.groupBox1.Controls.Add(this.removeWordsErrorLabel);
            this.groupBox1.Controls.Add(this.removeFromLangComboBox);
            this.groupBox1.Location = new System.Drawing.Point(424, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 225);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.addWordsGroupBox);
            this.Name = "Form2";
            this.Text = "Form1";
            this.addWordsGroupBox.ResumeLayout(false);
            this.addWordsGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox addWordsGroupBox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}