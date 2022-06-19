
namespace CardDealer
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
            this.label1 = new System.Windows.Forms.Label();
            this.numCardsBox = new System.Windows.Forms.TextBox();
            this.dealBtn = new System.Windows.Forms.Button();
            this.dealtCardsBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.valueLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cardsLeftLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Cards to Deal:";
            // 
            // numCardsBox
            // 
            this.numCardsBox.Font = new System.Drawing.Font("Mongolian Baiti", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCardsBox.Location = new System.Drawing.Point(457, 49);
            this.numCardsBox.Name = "numCardsBox";
            this.numCardsBox.Size = new System.Drawing.Size(136, 39);
            this.numCardsBox.TabIndex = 1;
            this.numCardsBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dealBtn
            // 
            this.dealBtn.Font = new System.Drawing.Font("Mongolian Baiti", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealBtn.Location = new System.Drawing.Point(226, 114);
            this.dealBtn.Name = "dealBtn";
            this.dealBtn.Size = new System.Drawing.Size(198, 50);
            this.dealBtn.TabIndex = 2;
            this.dealBtn.Text = "Deal Cards";
            this.dealBtn.UseVisualStyleBackColor = true;
            this.dealBtn.Click += new System.EventHandler(this.dealBtn_Click);
            // 
            // dealtCardsBox
            // 
            this.dealtCardsBox.Font = new System.Drawing.Font("Mongolian Baiti", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealtCardsBox.FormattingEnabled = true;
            this.dealtCardsBox.ItemHeight = 29;
            this.dealtCardsBox.Location = new System.Drawing.Point(106, 206);
            this.dealtCardsBox.Name = "dealtCardsBox";
            this.dealtCardsBox.Size = new System.Drawing.Size(487, 265);
            this.dealtCardsBox.TabIndex = 3;
            this.dealtCardsBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(193, 500);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Value of Hand:";
            // 
            // valueLabel
            // 
            this.valueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valueLabel.Font = new System.Drawing.Font("Mongolian Baiti", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueLabel.Location = new System.Drawing.Point(418, 491);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(175, 46);
            this.valueLabel.TabIndex = 5;
            this.valueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(140, 576);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cards Left in Deck:";
            // 
            // cardsLeftLabel
            // 
            this.cardsLeftLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardsLeftLabel.Font = new System.Drawing.Font("Mongolian Baiti", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardsLeftLabel.Location = new System.Drawing.Point(418, 575);
            this.cardsLeftLabel.Name = "cardsLeftLabel";
            this.cardsLeftLabel.Size = new System.Drawing.Size(175, 46);
            this.cardsLeftLabel.TabIndex = 7;
            this.cardsLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AcceptButton = this.dealBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 646);
            this.Controls.Add(this.cardsLeftLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dealtCardsBox);
            this.Controls.Add(this.dealBtn);
            this.Controls.Add(this.numCardsBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Card Dealer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numCardsBox;
        private System.Windows.Forms.Button dealBtn;
        private System.Windows.Forms.ListBox dealtCardsBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label cardsLeftLabel;
    }
}

