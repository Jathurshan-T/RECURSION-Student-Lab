namespace RecursionProblemSet
{
    partial class UseRecursion
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
            this.btnExpand = new System.Windows.Forms.Button();
            this.btnGCD = new System.Windows.Forms.Button();
            this.btmCompact = new System.Windows.Forms.Button();
            this.btnPalindrome = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnExpand
            // 
            this.btnExpand.Location = new System.Drawing.Point(27, 53);
            this.btnExpand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Size = new System.Drawing.Size(112, 35);
            this.btnExpand.TabIndex = 1;
            this.btnExpand.Text = "Expand";
            this.btnExpand.UseVisualStyleBackColor = true;
            this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click);
            // 
            // btnGCD
            // 
            this.btnGCD.Location = new System.Drawing.Point(209, 85);
            this.btnGCD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGCD.Name = "btnGCD";
            this.btnGCD.Size = new System.Drawing.Size(112, 35);
            this.btnGCD.TabIndex = 2;
            this.btnGCD.Text = "GCD";
            this.btnGCD.UseVisualStyleBackColor = true;
            this.btnGCD.Click += new System.EventHandler(this.btnGCD_Click);
            // 
            // btmCompact
            // 
            this.btmCompact.Location = new System.Drawing.Point(27, 96);
            this.btmCompact.Name = "btmCompact";
            this.btmCompact.Size = new System.Drawing.Size(112, 37);
            this.btmCompact.TabIndex = 3;
            this.btmCompact.Text = "Compact";
            this.btmCompact.UseVisualStyleBackColor = true;
            this.btmCompact.Click += new System.EventHandler(this.btmCompact_Click);
            // 
            // btnPalindrome
            // 
            this.btnPalindrome.Location = new System.Drawing.Point(27, 139);
            this.btnPalindrome.Name = "btnPalindrome";
            this.btnPalindrome.Size = new System.Drawing.Size(112, 37);
            this.btnPalindrome.TabIndex = 4;
            this.btnPalindrome.Text = "Palindrome";
            this.btnPalindrome.UseVisualStyleBackColor = true;
            this.btnPalindrome.Click += new System.EventHandler(this.btnPalindrome_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(23, 244);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(58, 20);
            this.lblOutput.TabIndex = 5;
            this.lblOutput.Text = "Output";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(27, 19);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(112, 26);
            this.txtA.TabIndex = 6;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(209, 19);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(112, 26);
            this.txtB.TabIndex = 7;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(209, 51);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(112, 26);
            this.txtC.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 288);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnPalindrome);
            this.Controls.Add(this.btmCompact);
            this.Controls.Add(this.btnGCD);
            this.Controls.Add(this.btnExpand);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recursion Problem Set";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExpand;
        private System.Windows.Forms.Button btnGCD;
        private System.Windows.Forms.Button btmCompact;
        private System.Windows.Forms.Button btnPalindrome;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
    }
}

