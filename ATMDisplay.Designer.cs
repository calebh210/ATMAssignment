
namespace ATMSimulator
{
    public partial class ATMDisplay
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
            this.txtBoxInput = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblScreen = new System.Windows.Forms.Label();
            this.btnNum1 = new System.Windows.Forms.Button();
            this.btnNum2 = new System.Windows.Forms.Button();
            this.btnNum3 = new System.Windows.Forms.Button();
            this.btnNum7 = new System.Windows.Forms.Button();
            this.btnNum4 = new System.Windows.Forms.Button();
            this.btnNum5 = new System.Windows.Forms.Button();
            this.btnNum6 = new System.Windows.Forms.Button();
            this.btnNum8 = new System.Windows.Forms.Button();
            this.btnNum9 = new System.Windows.Forms.Button();
            this.btnNumZero = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxInput
            // 
            this.txtBoxInput.Location = new System.Drawing.Point(271, 139);
            this.txtBoxInput.Name = "txtBoxInput";
            this.txtBoxInput.Size = new System.Drawing.Size(235, 20);
            this.txtBoxInput.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(539, 323);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(96, 37);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblScreen
            // 
            this.lblScreen.AutoSize = true;
            this.lblScreen.Enabled = false;
            this.lblScreen.Location = new System.Drawing.Point(325, 44);
            this.lblScreen.Name = "lblScreen";
            this.lblScreen.Size = new System.Drawing.Size(135, 13);
            this.lblScreen.TabIndex = 2;
            this.lblScreen.Text = "Enter your account number";
            // 
            // btnNum1
            // 
            this.btnNum1.Location = new System.Drawing.Point(293, 191);
            this.btnNum1.Name = "btnNum1";
            this.btnNum1.Size = new System.Drawing.Size(50, 50);
            this.btnNum1.TabIndex = 3;
            this.btnNum1.Text = "1";
            this.btnNum1.UseVisualStyleBackColor = true;
            this.btnNum1.Click += new System.EventHandler(this.btnNum1_Click);
            // 
            // btnNum2
            // 
            this.btnNum2.Location = new System.Drawing.Point(361, 191);
            this.btnNum2.Name = "btnNum2";
            this.btnNum2.Size = new System.Drawing.Size(50, 50);
            this.btnNum2.TabIndex = 4;
            this.btnNum2.Text = "2";
            this.btnNum2.UseVisualStyleBackColor = true;
            this.btnNum2.Click += new System.EventHandler(this.btnNum2_Click);
            // 
            // btnNum3
            // 
            this.btnNum3.Location = new System.Drawing.Point(431, 191);
            this.btnNum3.Name = "btnNum3";
            this.btnNum3.Size = new System.Drawing.Size(50, 50);
            this.btnNum3.TabIndex = 5;
            this.btnNum3.Text = "3";
            this.btnNum3.UseVisualStyleBackColor = true;
            this.btnNum3.Click += new System.EventHandler(this.btnNum3_Click);
            // 
            // btnNum7
            // 
            this.btnNum7.Location = new System.Drawing.Point(293, 323);
            this.btnNum7.Name = "btnNum7";
            this.btnNum7.Size = new System.Drawing.Size(50, 50);
            this.btnNum7.TabIndex = 6;
            this.btnNum7.Text = "7";
            this.btnNum7.UseVisualStyleBackColor = true;
            this.btnNum7.Click += new System.EventHandler(this.btnNum7_Click);
            // 
            // btnNum4
            // 
            this.btnNum4.Location = new System.Drawing.Point(293, 258);
            this.btnNum4.Name = "btnNum4";
            this.btnNum4.Size = new System.Drawing.Size(50, 50);
            this.btnNum4.TabIndex = 7;
            this.btnNum4.Text = "4";
            this.btnNum4.UseVisualStyleBackColor = true;
            this.btnNum4.Click += new System.EventHandler(this.btnNum4_Click);
            // 
            // btnNum5
            // 
            this.btnNum5.Location = new System.Drawing.Point(361, 258);
            this.btnNum5.Name = "btnNum5";
            this.btnNum5.Size = new System.Drawing.Size(50, 50);
            this.btnNum5.TabIndex = 8;
            this.btnNum5.Text = "5";
            this.btnNum5.UseVisualStyleBackColor = true;
            this.btnNum5.Click += new System.EventHandler(this.btnNum5_Click);
            // 
            // btnNum6
            // 
            this.btnNum6.Location = new System.Drawing.Point(431, 258);
            this.btnNum6.Name = "btnNum6";
            this.btnNum6.Size = new System.Drawing.Size(50, 50);
            this.btnNum6.TabIndex = 9;
            this.btnNum6.Text = "6";
            this.btnNum6.UseVisualStyleBackColor = true;
            this.btnNum6.Click += new System.EventHandler(this.btnNum6_Click);
            // 
            // btnNum8
            // 
            this.btnNum8.Location = new System.Drawing.Point(361, 323);
            this.btnNum8.Name = "btnNum8";
            this.btnNum8.Size = new System.Drawing.Size(50, 50);
            this.btnNum8.TabIndex = 10;
            this.btnNum8.Text = "8";
            this.btnNum8.UseVisualStyleBackColor = true;
            this.btnNum8.Click += new System.EventHandler(this.btnNum8_Click);
            // 
            // btnNum9
            // 
            this.btnNum9.Location = new System.Drawing.Point(431, 323);
            this.btnNum9.Name = "btnNum9";
            this.btnNum9.Size = new System.Drawing.Size(50, 50);
            this.btnNum9.TabIndex = 11;
            this.btnNum9.Text = "9";
            this.btnNum9.UseVisualStyleBackColor = true;
            this.btnNum9.Click += new System.EventHandler(this.btnNum9_Click);
            // 
            // btnNumZero
            // 
            this.btnNumZero.Location = new System.Drawing.Point(361, 388);
            this.btnNumZero.Name = "btnNumZero";
            this.btnNumZero.Size = new System.Drawing.Size(50, 50);
            this.btnNumZero.TabIndex = 12;
            this.btnNumZero.Text = "0";
            this.btnNumZero.UseVisualStyleBackColor = true;
            this.btnNumZero.Click += new System.EventHandler(this.btnNumZero_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(539, 258);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 37);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(539, 198);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 37);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ATMDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnNumZero);
            this.Controls.Add(this.btnNum9);
            this.Controls.Add(this.btnNum8);
            this.Controls.Add(this.btnNum6);
            this.Controls.Add(this.btnNum5);
            this.Controls.Add(this.btnNum4);
            this.Controls.Add(this.btnNum7);
            this.Controls.Add(this.btnNum3);
            this.Controls.Add(this.btnNum2);
            this.Controls.Add(this.btnNum1);
            this.Controls.Add(this.lblScreen);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtBoxInput);
            this.Name = "ATMDisplay";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxInput;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblScreen;
        private System.Windows.Forms.Button btnNum1;
        private System.Windows.Forms.Button btnNum2;
        private System.Windows.Forms.Button btnNum3;
        private System.Windows.Forms.Button btnNum7;
        private System.Windows.Forms.Button btnNum4;
        private System.Windows.Forms.Button btnNum5;
        private System.Windows.Forms.Button btnNum6;
        private System.Windows.Forms.Button btnNum8;
        private System.Windows.Forms.Button btnNum9;
        private System.Windows.Forms.Button btnNumZero;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCancel;
    }
}

