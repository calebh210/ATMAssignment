
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ATMDisplay));
            this.txtBoxInput = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
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
            this.btnSetRace = new System.Windows.Forms.CheckBox();
            this.richTxtBoxScreen = new System.Windows.Forms.RichTextBox();
            this.btnNum1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxInput
            // 
            this.txtBoxInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxInput.Location = new System.Drawing.Point(62, 130);
            this.txtBoxInput.Name = "txtBoxInput";
            this.txtBoxInput.ReadOnly = true;
            this.txtBoxInput.Size = new System.Drawing.Size(342, 13);
            this.txtBoxInput.TabIndex = 0;
            this.txtBoxInput.TextChanged += new System.EventHandler(this.txtBoxInput_TextChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Green;
            this.btnSubmit.BackgroundImage = global::ATMSimulator.Properties.Resources.btnEnter;
            this.btnSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubmit.Location = new System.Drawing.Point(308, 333);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(96, 50);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnNum2
            // 
            this.btnNum2.BackgroundImage = global::ATMSimulator.Properties.Resources.btn2;
            this.btnNum2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNum2.Location = new System.Drawing.Point(143, 188);
            this.btnNum2.Name = "btnNum2";
            this.btnNum2.Size = new System.Drawing.Size(60, 60);
            this.btnNum2.TabIndex = 4;
            this.btnNum2.UseVisualStyleBackColor = true;
            this.btnNum2.Click += new System.EventHandler(this.btnNum2_Click);
            // 
            // btnNum3
            // 
            this.btnNum3.BackgroundImage = global::ATMSimulator.Properties.Resources.btn3;
            this.btnNum3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNum3.Location = new System.Drawing.Point(223, 188);
            this.btnNum3.Name = "btnNum3";
            this.btnNum3.Size = new System.Drawing.Size(60, 60);
            this.btnNum3.TabIndex = 5;
            this.btnNum3.UseVisualStyleBackColor = true;
            this.btnNum3.Click += new System.EventHandler(this.btnNum3_Click);
            // 
            // btnNum7
            // 
            this.btnNum7.BackgroundImage = global::ATMSimulator.Properties.Resources.btn7;
            this.btnNum7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNum7.Location = new System.Drawing.Point(62, 333);
            this.btnNum7.Name = "btnNum7";
            this.btnNum7.Size = new System.Drawing.Size(60, 60);
            this.btnNum7.TabIndex = 6;
            this.btnNum7.UseVisualStyleBackColor = true;
            this.btnNum7.Click += new System.EventHandler(this.btnNum7_Click);
            // 
            // btnNum4
            // 
            this.btnNum4.BackgroundImage = global::ATMSimulator.Properties.Resources.btn4;
            this.btnNum4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNum4.Location = new System.Drawing.Point(62, 262);
            this.btnNum4.Name = "btnNum4";
            this.btnNum4.Size = new System.Drawing.Size(60, 60);
            this.btnNum4.TabIndex = 7;
            this.btnNum4.UseVisualStyleBackColor = true;
            this.btnNum4.Click += new System.EventHandler(this.btnNum4_Click);
            // 
            // btnNum5
            // 
            this.btnNum5.BackgroundImage = global::ATMSimulator.Properties.Resources.btn5;
            this.btnNum5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNum5.Location = new System.Drawing.Point(143, 262);
            this.btnNum5.Name = "btnNum5";
            this.btnNum5.Size = new System.Drawing.Size(60, 60);
            this.btnNum5.TabIndex = 8;
            this.btnNum5.UseVisualStyleBackColor = true;
            this.btnNum5.Click += new System.EventHandler(this.btnNum5_Click);
            // 
            // btnNum6
            // 
            this.btnNum6.BackgroundImage = global::ATMSimulator.Properties.Resources.btn6;
            this.btnNum6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNum6.Location = new System.Drawing.Point(223, 262);
            this.btnNum6.Name = "btnNum6";
            this.btnNum6.Size = new System.Drawing.Size(60, 60);
            this.btnNum6.TabIndex = 9;
            this.btnNum6.UseVisualStyleBackColor = true;
            this.btnNum6.Click += new System.EventHandler(this.btnNum6_Click);
            // 
            // btnNum8
            // 
            this.btnNum8.BackgroundImage = global::ATMSimulator.Properties.Resources.btn8;
            this.btnNum8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNum8.Location = new System.Drawing.Point(143, 333);
            this.btnNum8.Name = "btnNum8";
            this.btnNum8.Size = new System.Drawing.Size(60, 60);
            this.btnNum8.TabIndex = 10;
            this.btnNum8.UseVisualStyleBackColor = true;
            this.btnNum8.Click += new System.EventHandler(this.btnNum8_Click);
            // 
            // btnNum9
            // 
            this.btnNum9.BackgroundImage = global::ATMSimulator.Properties.Resources.btn9;
            this.btnNum9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNum9.Location = new System.Drawing.Point(223, 333);
            this.btnNum9.Name = "btnNum9";
            this.btnNum9.Size = new System.Drawing.Size(60, 60);
            this.btnNum9.TabIndex = 11;
            this.btnNum9.UseVisualStyleBackColor = true;
            this.btnNum9.Click += new System.EventHandler(this.btnNum9_Click);
            // 
            // btnNumZero
            // 
            this.btnNumZero.BackgroundImage = global::ATMSimulator.Properties.Resources.btn0;
            this.btnNumZero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNumZero.Location = new System.Drawing.Point(143, 403);
            this.btnNumZero.Name = "btnNumZero";
            this.btnNumZero.Size = new System.Drawing.Size(60, 60);
            this.btnNumZero.TabIndex = 12;
            this.btnNumZero.UseVisualStyleBackColor = true;
            this.btnNumZero.Click += new System.EventHandler(this.btnNumZero_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClear.BackgroundImage = global::ATMSimulator.Properties.Resources.btnClear;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.Location = new System.Drawing.Point(308, 262);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 50);
            this.btnClear.TabIndex = 13;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.BackgroundImage = global::ATMSimulator.Properties.Resources.btnCancel;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.Location = new System.Drawing.Point(308, 188);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 50);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSetRace
            // 
            this.btnSetRace.AutoSize = true;
            this.btnSetRace.Location = new System.Drawing.Point(308, 403);
            this.btnSetRace.Name = "btnSetRace";
            this.btnSetRace.Size = new System.Drawing.Size(106, 17);
            this.btnSetRace.TabIndex = 15;
            this.btnSetRace.Text = "Allow Data Race";
            this.btnSetRace.UseVisualStyleBackColor = true;
            this.btnSetRace.CheckedChanged += new System.EventHandler(this.btnSetRace_CheckedChanged);
            // 
            // richTxtBoxScreen
            // 
            this.richTxtBoxScreen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTxtBoxScreen.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTxtBoxScreen.Location = new System.Drawing.Point(62, 30);
            this.richTxtBoxScreen.Name = "richTxtBoxScreen";
            this.richTxtBoxScreen.ReadOnly = true;
            this.richTxtBoxScreen.Size = new System.Drawing.Size(342, 100);
            this.richTxtBoxScreen.TabIndex = 16;
            this.richTxtBoxScreen.Text = "Please Enter Your Account Number";
            // 
            // btnNum1
            // 
            this.btnNum1.BackgroundImage = global::ATMSimulator.Properties.Resources.btn1;
            this.btnNum1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNum1.Location = new System.Drawing.Point(62, 188);
            this.btnNum1.Name = "btnNum1";
            this.btnNum1.Size = new System.Drawing.Size(60, 60);
            this.btnNum1.TabIndex = 3;
            this.btnNum1.UseVisualStyleBackColor = true;
            this.btnNum1.Click += new System.EventHandler(this.btnNum1_Click);
            // 
            // ATMDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(451, 476);
            this.Controls.Add(this.richTxtBoxScreen);
            this.Controls.Add(this.btnSetRace);
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
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtBoxInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ATMDisplay";
            this.Text = "ATM";
            this.Load += new System.EventHandler(this.ATMDisplay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxInput;
        private System.Windows.Forms.Button btnSubmit;
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
        private System.Windows.Forms.CheckBox btnSetRace;
        private System.Windows.Forms.RichTextBox richTxtBoxScreen;
        

    }
}

