namespace Pg382Exercise
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.moveToDeck2 = new System.Windows.Forms.Button();
            this.moveToDeck1 = new System.Windows.Forms.Button();
            this.resetDeck1 = new System.Windows.Forms.Button();
            this.shuffleDeck1 = new System.Windows.Forms.Button();
            this.resetDeck2 = new System.Windows.Forms.Button();
            this.shuffleDeck2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 238);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(222, 25);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 238);
            this.listBox2.TabIndex = 1;
            // 
            // moveToDeck2
            // 
            this.moveToDeck2.Location = new System.Drawing.Point(138, 104);
            this.moveToDeck2.Name = "moveToDeck2";
            this.moveToDeck2.Size = new System.Drawing.Size(75, 23);
            this.moveToDeck2.TabIndex = 2;
            this.moveToDeck2.Text = ">>";
            this.moveToDeck2.UseVisualStyleBackColor = true;
            this.moveToDeck2.Click += new System.EventHandler(this.moveToDeck2_Click);
            // 
            // moveToDeck1
            // 
            this.moveToDeck1.Location = new System.Drawing.Point(138, 162);
            this.moveToDeck1.Name = "moveToDeck1";
            this.moveToDeck1.Size = new System.Drawing.Size(75, 23);
            this.moveToDeck1.TabIndex = 3;
            this.moveToDeck1.Text = "<<";
            this.moveToDeck1.UseVisualStyleBackColor = true;
            this.moveToDeck1.Click += new System.EventHandler(this.moveToDeck1_Click);
            // 
            // resetDeck1
            // 
            this.resetDeck1.Location = new System.Drawing.Point(35, 269);
            this.resetDeck1.Name = "resetDeck1";
            this.resetDeck1.Size = new System.Drawing.Size(75, 23);
            this.resetDeck1.TabIndex = 4;
            this.resetDeck1.Text = "Reset Deck";
            this.resetDeck1.UseVisualStyleBackColor = true;
            this.resetDeck1.Click += new System.EventHandler(this.resetDeck1_Click);
            // 
            // shuffleDeck1
            // 
            this.shuffleDeck1.Location = new System.Drawing.Point(35, 298);
            this.shuffleDeck1.Name = "shuffleDeck1";
            this.shuffleDeck1.Size = new System.Drawing.Size(75, 23);
            this.shuffleDeck1.TabIndex = 5;
            this.shuffleDeck1.Text = "Shuffle";
            this.shuffleDeck1.UseVisualStyleBackColor = true;
            this.shuffleDeck1.Click += new System.EventHandler(this.shuffleDeck1_Click);
            // 
            // resetDeck2
            // 
            this.resetDeck2.Location = new System.Drawing.Point(245, 269);
            this.resetDeck2.Name = "resetDeck2";
            this.resetDeck2.Size = new System.Drawing.Size(75, 23);
            this.resetDeck2.TabIndex = 6;
            this.resetDeck2.Text = "Reset Deck";
            this.resetDeck2.UseVisualStyleBackColor = true;
            this.resetDeck2.Click += new System.EventHandler(this.resetDeck2_Click);
            // 
            // shuffleDeck2
            // 
            this.shuffleDeck2.Location = new System.Drawing.Point(245, 298);
            this.shuffleDeck2.Name = "shuffleDeck2";
            this.shuffleDeck2.Size = new System.Drawing.Size(75, 23);
            this.shuffleDeck2.TabIndex = 7;
            this.shuffleDeck2.Text = "Shuffle";
            this.shuffleDeck2.UseVisualStyleBackColor = true;
            this.shuffleDeck2.Click += new System.EventHandler(this.shuffleDeck2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Deck #1 (10 cards)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Deck #2 (52 cards)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 337);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shuffleDeck2);
            this.Controls.Add(this.resetDeck2);
            this.Controls.Add(this.shuffleDeck1);
            this.Controls.Add(this.resetDeck1);
            this.Controls.Add(this.moveToDeck1);
            this.Controls.Add(this.moveToDeck2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Two Decks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button moveToDeck2;
        private System.Windows.Forms.Button moveToDeck1;
        private System.Windows.Forms.Button resetDeck1;
        private System.Windows.Forms.Button shuffleDeck1;
        private System.Windows.Forms.Button resetDeck2;
        private System.Windows.Forms.Button shuffleDeck2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

