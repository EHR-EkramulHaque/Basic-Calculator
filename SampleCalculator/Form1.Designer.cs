
namespace SampleCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_EQUAL = new System.Windows.Forms.Button();
            this.btn_ZERO = new System.Windows.Forms.Button();
            this.btn_Addition = new System.Windows.Forms.Button();
            this.btn_DOT = new System.Windows.Forms.Button();
            this.btn_Subtraction = new System.Windows.Forms.Button();
            this.btn_THREE = new System.Windows.Forms.Button();
            this.btn_TWO = new System.Windows.Forms.Button();
            this.btn_ONE = new System.Windows.Forms.Button();
            this.btn_Multiplication = new System.Windows.Forms.Button();
            this.btn_SIX = new System.Windows.Forms.Button();
            this.btn_FIVE = new System.Windows.Forms.Button();
            this.btn_FOUR = new System.Windows.Forms.Button();
            this.btn_Division = new System.Windows.Forms.Button();
            this.btn_NINE = new System.Windows.Forms.Button();
            this.btn_EIGHT = new System.Windows.Forms.Button();
            this.btn_SEVEN = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.lbl_Operation = new System.Windows.Forms.Label();
            this.txt_Expression = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_EQUAL
            // 
            this.btn_EQUAL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_EQUAL.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_EQUAL.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EQUAL.ForeColor = System.Drawing.Color.White;
            this.btn_EQUAL.Location = new System.Drawing.Point(12, 522);
            this.btn_EQUAL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_EQUAL.Name = "btn_EQUAL";
            this.btn_EQUAL.Size = new System.Drawing.Size(97, 68);
            this.btn_EQUAL.TabIndex = 3;
            this.btn_EQUAL.Text = "=";
            this.btn_EQUAL.UseVisualStyleBackColor = false;
            this.btn_EQUAL.Click += new System.EventHandler(this.btn_EQUAL_Click);
            // 
            // btn_ZERO
            // 
            this.btn_ZERO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ZERO.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ZERO.Location = new System.Drawing.Point(112, 522);
            this.btn_ZERO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ZERO.Name = "btn_ZERO";
            this.btn_ZERO.Size = new System.Drawing.Size(97, 68);
            this.btn_ZERO.TabIndex = 4;
            this.btn_ZERO.Text = "0";
            this.btn_ZERO.UseVisualStyleBackColor = true;
            this.btn_ZERO.Click += new System.EventHandler(this.btn_Number_Click);
            // 
            // btn_Addition
            // 
            this.btn_Addition.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Addition.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Addition.Location = new System.Drawing.Point(315, 522);
            this.btn_Addition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Addition.Name = "btn_Addition";
            this.btn_Addition.Size = new System.Drawing.Size(97, 68);
            this.btn_Addition.TabIndex = 6;
            this.btn_Addition.Text = "+";
            this.btn_Addition.UseVisualStyleBackColor = true;
            this.btn_Addition.Click += new System.EventHandler(this.Operation_Click);
            // 
            // btn_DOT
            // 
            this.btn_DOT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_DOT.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DOT.Location = new System.Drawing.Point(213, 522);
            this.btn_DOT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_DOT.Name = "btn_DOT";
            this.btn_DOT.Size = new System.Drawing.Size(97, 68);
            this.btn_DOT.TabIndex = 5;
            this.btn_DOT.Text = ".";
            this.btn_DOT.UseVisualStyleBackColor = true;
            this.btn_DOT.Click += new System.EventHandler(this.btn_Number_Click);
            // 
            // btn_Subtraction
            // 
            this.btn_Subtraction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Subtraction.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Subtraction.Location = new System.Drawing.Point(315, 448);
            this.btn_Subtraction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Subtraction.Name = "btn_Subtraction";
            this.btn_Subtraction.Size = new System.Drawing.Size(97, 68);
            this.btn_Subtraction.TabIndex = 10;
            this.btn_Subtraction.Text = "_";
            this.btn_Subtraction.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Subtraction.UseVisualStyleBackColor = true;
            this.btn_Subtraction.Click += new System.EventHandler(this.Operation_Click);
            // 
            // btn_THREE
            // 
            this.btn_THREE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_THREE.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_THREE.Location = new System.Drawing.Point(213, 448);
            this.btn_THREE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_THREE.Name = "btn_THREE";
            this.btn_THREE.Size = new System.Drawing.Size(97, 68);
            this.btn_THREE.TabIndex = 9;
            this.btn_THREE.Text = "3";
            this.btn_THREE.UseVisualStyleBackColor = true;
            this.btn_THREE.Click += new System.EventHandler(this.btn_Number_Click);
            // 
            // btn_TWO
            // 
            this.btn_TWO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_TWO.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TWO.Location = new System.Drawing.Point(112, 448);
            this.btn_TWO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TWO.Name = "btn_TWO";
            this.btn_TWO.Size = new System.Drawing.Size(97, 68);
            this.btn_TWO.TabIndex = 8;
            this.btn_TWO.Text = "2";
            this.btn_TWO.UseVisualStyleBackColor = true;
            this.btn_TWO.Click += new System.EventHandler(this.btn_Number_Click);
            // 
            // btn_ONE
            // 
            this.btn_ONE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ONE.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ONE.Location = new System.Drawing.Point(12, 448);
            this.btn_ONE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ONE.Name = "btn_ONE";
            this.btn_ONE.Size = new System.Drawing.Size(97, 68);
            this.btn_ONE.TabIndex = 7;
            this.btn_ONE.Text = "1";
            this.btn_ONE.UseVisualStyleBackColor = true;
            this.btn_ONE.Click += new System.EventHandler(this.btn_Number_Click);
            // 
            // btn_Multiplication
            // 
            this.btn_Multiplication.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Multiplication.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Multiplication.Location = new System.Drawing.Point(315, 374);
            this.btn_Multiplication.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Multiplication.Name = "btn_Multiplication";
            this.btn_Multiplication.Size = new System.Drawing.Size(97, 68);
            this.btn_Multiplication.TabIndex = 14;
            this.btn_Multiplication.Text = "X";
            this.btn_Multiplication.UseVisualStyleBackColor = true;
            this.btn_Multiplication.Click += new System.EventHandler(this.Operation_Click);
            // 
            // btn_SIX
            // 
            this.btn_SIX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_SIX.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SIX.Location = new System.Drawing.Point(213, 374);
            this.btn_SIX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_SIX.Name = "btn_SIX";
            this.btn_SIX.Size = new System.Drawing.Size(97, 68);
            this.btn_SIX.TabIndex = 13;
            this.btn_SIX.Text = "6";
            this.btn_SIX.UseVisualStyleBackColor = true;
            this.btn_SIX.Click += new System.EventHandler(this.btn_Number_Click);
            // 
            // btn_FIVE
            // 
            this.btn_FIVE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_FIVE.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FIVE.Location = new System.Drawing.Point(112, 374);
            this.btn_FIVE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_FIVE.Name = "btn_FIVE";
            this.btn_FIVE.Size = new System.Drawing.Size(97, 68);
            this.btn_FIVE.TabIndex = 12;
            this.btn_FIVE.Text = "5";
            this.btn_FIVE.UseVisualStyleBackColor = true;
            this.btn_FIVE.Click += new System.EventHandler(this.btn_Number_Click);
            // 
            // btn_FOUR
            // 
            this.btn_FOUR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_FOUR.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FOUR.Location = new System.Drawing.Point(12, 374);
            this.btn_FOUR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_FOUR.Name = "btn_FOUR";
            this.btn_FOUR.Size = new System.Drawing.Size(97, 68);
            this.btn_FOUR.TabIndex = 11;
            this.btn_FOUR.Text = "4";
            this.btn_FOUR.UseVisualStyleBackColor = true;
            this.btn_FOUR.Click += new System.EventHandler(this.btn_Number_Click);
            // 
            // btn_Division
            // 
            this.btn_Division.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Division.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Division.Location = new System.Drawing.Point(315, 300);
            this.btn_Division.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Division.Name = "btn_Division";
            this.btn_Division.Size = new System.Drawing.Size(97, 68);
            this.btn_Division.TabIndex = 18;
            this.btn_Division.Text = "/";
            this.btn_Division.UseVisualStyleBackColor = true;
            this.btn_Division.Click += new System.EventHandler(this.Operation_Click);
            // 
            // btn_NINE
            // 
            this.btn_NINE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_NINE.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NINE.Location = new System.Drawing.Point(213, 300);
            this.btn_NINE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_NINE.Name = "btn_NINE";
            this.btn_NINE.Size = new System.Drawing.Size(97, 68);
            this.btn_NINE.TabIndex = 17;
            this.btn_NINE.Text = "9";
            this.btn_NINE.UseVisualStyleBackColor = true;
            this.btn_NINE.Click += new System.EventHandler(this.btn_Number_Click);
            // 
            // btn_EIGHT
            // 
            this.btn_EIGHT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_EIGHT.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EIGHT.Location = new System.Drawing.Point(112, 300);
            this.btn_EIGHT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_EIGHT.Name = "btn_EIGHT";
            this.btn_EIGHT.Size = new System.Drawing.Size(97, 68);
            this.btn_EIGHT.TabIndex = 16;
            this.btn_EIGHT.Text = "8";
            this.btn_EIGHT.UseVisualStyleBackColor = true;
            this.btn_EIGHT.Click += new System.EventHandler(this.btn_Number_Click);
            // 
            // btn_SEVEN
            // 
            this.btn_SEVEN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_SEVEN.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SEVEN.Location = new System.Drawing.Point(12, 300);
            this.btn_SEVEN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_SEVEN.Name = "btn_SEVEN";
            this.btn_SEVEN.Size = new System.Drawing.Size(97, 68);
            this.btn_SEVEN.TabIndex = 15;
            this.btn_SEVEN.Text = "7";
            this.btn_SEVEN.UseVisualStyleBackColor = true;
            this.btn_SEVEN.Click += new System.EventHandler(this.btn_Number_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Clear.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Location = new System.Drawing.Point(315, 226);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(97, 68);
            this.btn_Clear.TabIndex = 22;
            this.btn_Clear.Text = "CLR";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.Operation_Click);
            // 
            // lbl_Operation
            // 
            this.lbl_Operation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Operation.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Operation.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Operation.Location = new System.Drawing.Point(2, 120);
            this.lbl_Operation.Name = "lbl_Operation";
            this.lbl_Operation.Size = new System.Drawing.Size(421, 104);
            this.lbl_Operation.TabIndex = 2;
            // 
            // txt_Expression
            // 
            this.txt_Expression.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Expression.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Expression.Location = new System.Drawing.Point(0, 11);
            this.txt_Expression.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Expression.Multiline = true;
            this.txt_Expression.Name = "txt_Expression";
            this.txt_Expression.Size = new System.Drawing.Size(423, 107);
            this.txt_Expression.TabIndex = 1;
            this.txt_Expression.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Expression.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxes_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 602);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Division);
            this.Controls.Add(this.btn_NINE);
            this.Controls.Add(this.btn_EIGHT);
            this.Controls.Add(this.btn_SEVEN);
            this.Controls.Add(this.btn_Multiplication);
            this.Controls.Add(this.btn_SIX);
            this.Controls.Add(this.btn_FIVE);
            this.Controls.Add(this.btn_FOUR);
            this.Controls.Add(this.btn_Subtraction);
            this.Controls.Add(this.btn_THREE);
            this.Controls.Add(this.btn_TWO);
            this.Controls.Add(this.btn_ONE);
            this.Controls.Add(this.btn_Addition);
            this.Controls.Add(this.btn_DOT);
            this.Controls.Add(this.btn_ZERO);
            this.Controls.Add(this.btn_EQUAL);
            this.Controls.Add(this.lbl_Operation);
            this.Controls.Add(this.txt_Expression);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_EQUAL;
        private System.Windows.Forms.Button btn_ZERO;
        private System.Windows.Forms.Button btn_Addition;
        private System.Windows.Forms.Button btn_DOT;
        private System.Windows.Forms.Button btn_Subtraction;
        private System.Windows.Forms.Button btn_THREE;
        private System.Windows.Forms.Button btn_TWO;
        private System.Windows.Forms.Button btn_ONE;
        private System.Windows.Forms.Button btn_Multiplication;
        private System.Windows.Forms.Button btn_SIX;
        private System.Windows.Forms.Button btn_FIVE;
        private System.Windows.Forms.Button btn_FOUR;
        private System.Windows.Forms.Button btn_Division;
        private System.Windows.Forms.Button btn_NINE;
        private System.Windows.Forms.Button btn_EIGHT;
        private System.Windows.Forms.Button btn_SEVEN;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label lbl_Operation;
        private System.Windows.Forms.TextBox txt_Expression;
    }
}

