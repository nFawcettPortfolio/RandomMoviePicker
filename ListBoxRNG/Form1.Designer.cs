namespace ListBoxRNG
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.rngButton = new System.Windows.Forms.Button();
            this.Label = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.addBox = new System.Windows.Forms.TextBox();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(12, 53);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(260, 186);
            this.listBox.TabIndex = 0;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 245);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(124, 23);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // rngButton
            // 
            this.rngButton.Location = new System.Drawing.Point(148, 245);
            this.rngButton.Name = "rngButton";
            this.rngButton.Size = new System.Drawing.Size(124, 23);
            this.rngButton.TabIndex = 2;
            this.rngButton.Text = "Random";
            this.rngButton.UseVisualStyleBackColor = true;
            this.rngButton.Click += new System.EventHandler(this.rngButton_Click);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(9, 274);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(114, 13);
            this.Label.TabIndex = 3;
            this.Label.Text = "Your random movie is: ";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(218, 24);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(54, 23);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addBox
            // 
            this.addBox.Location = new System.Drawing.Point(12, 24);
            this.addBox.Name = "addBox";
            this.addBox.Size = new System.Drawing.Size(200, 20);
            this.addBox.TabIndex = 5;
            // 
            // resultsLabel
            // 
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsLabel.Location = new System.Drawing.Point(13, 310);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(13, 20);
            this.resultsLabel.TabIndex = 6;
            this.resultsLabel.Text = " ";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(17, 343);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(255, 23);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "Delete Selected Movie(s)";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 378);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.addBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.rngButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.listBox);
            this.Name = "Form1";
            this.Text = "Random Movie Picker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button rngButton;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox addBox;
        private System.Windows.Forms.Label resultsLabel;
        private System.Windows.Forms.Button deleteButton;
    }
}

