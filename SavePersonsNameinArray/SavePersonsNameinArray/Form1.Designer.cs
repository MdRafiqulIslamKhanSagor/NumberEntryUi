namespace SavePersonsNameinArray
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveNamesButton = new System.Windows.Forms.Button();
            this.showAllNamesButton = new System.Windows.Forms.Button();
            this.namesListBox = new System.Windows.Forms.ListBox();
            this.totalNumberOfNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(112, 66);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(217, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Name";
            // 
            // saveNamesButton
            // 
            this.saveNamesButton.Location = new System.Drawing.Point(371, 66);
            this.saveNamesButton.Name = "saveNamesButton";
            this.saveNamesButton.Size = new System.Drawing.Size(75, 23);
            this.saveNamesButton.TabIndex = 2;
            this.saveNamesButton.Text = "Save";
            this.saveNamesButton.UseVisualStyleBackColor = true;
            this.saveNamesButton.Click += new System.EventHandler(this.saveNamesButton_Click);
            // 
            // showAllNamesButton
            // 
            this.showAllNamesButton.Location = new System.Drawing.Point(371, 104);
            this.showAllNamesButton.Name = "showAllNamesButton";
            this.showAllNamesButton.Size = new System.Drawing.Size(75, 23);
            this.showAllNamesButton.TabIndex = 3;
            this.showAllNamesButton.Text = "Show All";
            this.showAllNamesButton.UseVisualStyleBackColor = true;
            this.showAllNamesButton.Click += new System.EventHandler(this.showAllNamesButton_Click);
            // 
            // namesListBox
            // 
            this.namesListBox.FormattingEnabled = true;
            this.namesListBox.Location = new System.Drawing.Point(112, 147);
            this.namesListBox.Name = "namesListBox";
            this.namesListBox.Size = new System.Drawing.Size(217, 134);
            this.namesListBox.TabIndex = 4;
            // 
            // totalNumberOfNameTextBox
            // 
            this.totalNumberOfNameTextBox.Location = new System.Drawing.Point(112, 313);
            this.totalNumberOfNameTextBox.Name = "totalNumberOfNameTextBox";
            this.totalNumberOfNameTextBox.Size = new System.Drawing.Size(217, 20);
            this.totalNumberOfNameTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 402);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.totalNumberOfNameTextBox);
            this.Controls.Add(this.namesListBox);
            this.Controls.Add(this.showAllNamesButton);
            this.Controls.Add(this.saveNamesButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTextBox);
            this.Name = "Form1";
            this.Text = "Save Names In Array UI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveNamesButton;
        private System.Windows.Forms.Button showAllNamesButton;
        private System.Windows.Forms.ListBox namesListBox;
        private System.Windows.Forms.TextBox totalNumberOfNameTextBox;
        private System.Windows.Forms.Label label2;
    }
}

