namespace IT_Calculator
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.number1txt = new System.Windows.Forms.TextBox();
            this.number2txt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numComboBox = new System.Windows.Forms.ComboBox();
            this.resultTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.resultComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.clearBtn1 = new ePOSOne.btnProduct.Button_WOC();
            this.subBtn1 = new ePOSOne.btnProduct.Button_WOC();
            this.sumBtn1 = new ePOSOne.btnProduct.Button_WOC();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_WOC1 = new ePOSOne.btnProduct.Button_WOC();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number 01:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number 10:";
            // 
            // number1txt
            // 
            this.number1txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.number1txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number1txt.Location = new System.Drawing.Point(135, 20);
            this.number1txt.Multiline = true;
            this.number1txt.Name = "number1txt";
            this.number1txt.Size = new System.Drawing.Size(325, 30);
            this.number1txt.TabIndex = 2;
            // 
            // number2txt
            // 
            this.number2txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.number2txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number2txt.Location = new System.Drawing.Point(135, 61);
            this.number2txt.Multiline = true;
            this.number2txt.Name = "number2txt";
            this.number2txt.Size = new System.Drawing.Size(325, 28);
            this.number2txt.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.number1txt);
            this.groupBox1.Controls.Add(this.numComboBox);
            this.groupBox1.Controls.Add(this.number2txt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(6, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 130);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inputs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Type:";
            // 
            // numComboBox
            // 
            this.numComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numComboBox.FormattingEnabled = true;
            this.numComboBox.Items.AddRange(new object[] {
            "Binary (2)",
            "Octal (8)\t",
            "Decimal (10)\t"});
            this.numComboBox.Location = new System.Drawing.Point(135, 95);
            this.numComboBox.Name = "numComboBox";
            this.numComboBox.Size = new System.Drawing.Size(325, 28);
            this.numComboBox.TabIndex = 4;
            this.numComboBox.SelectedIndexChanged += new System.EventHandler(this.numComboBox_SelectedIndexChanged);
            // 
            // resultTxt
            // 
            this.resultTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTxt.Location = new System.Drawing.Point(85, 18);
            this.resultTxt.Multiline = true;
            this.resultTxt.Name = "resultTxt";
            this.resultTxt.Size = new System.Drawing.Size(325, 30);
            this.resultTxt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Result:";
            // 
            // resultComboBox
            // 
            this.resultComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resultComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultComboBox.FormattingEnabled = true;
            this.resultComboBox.Items.AddRange(new object[] {
            "Binary (2)",
            "Octal (8)\t",
            "Decimal (10)\t"});
            this.resultComboBox.Location = new System.Drawing.Point(416, 19);
            this.resultComboBox.Name = "resultComboBox";
            this.resultComboBox.Size = new System.Drawing.Size(135, 28);
            this.resultComboBox.TabIndex = 6;
            this.resultComboBox.SelectedIndexChanged += new System.EventHandler(this.resultComboBox_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.resultComboBox);
            this.groupBox2.Controls.Add(this.resultTxt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(6, 204);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(563, 57);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // clearBtn1
            // 
            this.clearBtn1.BorderColor = System.Drawing.Color.White;
            this.clearBtn1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.clearBtn1.FlatAppearance.BorderSize = 0;
            this.clearBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn1.Location = new System.Drawing.Point(252, 267);
            this.clearBtn1.Name = "clearBtn1";
            this.clearBtn1.OnHoverBorderColor = System.Drawing.Color.DarkOrange;
            this.clearBtn1.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.clearBtn1.OnHoverTextColor = System.Drawing.Color.DarkOrange;
            this.clearBtn1.Size = new System.Drawing.Size(117, 62);
            this.clearBtn1.TabIndex = 13;
            this.clearBtn1.Text = "Clear";
            this.clearBtn1.TextColor = System.Drawing.Color.White;
            this.clearBtn1.UseVisualStyleBackColor = true;
            this.clearBtn1.Click += new System.EventHandler(this.clearBtn1_Click);
            // 
            // subBtn1
            // 
            this.subBtn1.BorderColor = System.Drawing.Color.White;
            this.subBtn1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.subBtn1.FlatAppearance.BorderSize = 0;
            this.subBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subBtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subBtn1.Location = new System.Drawing.Point(129, 267);
            this.subBtn1.Name = "subBtn1";
            this.subBtn1.OnHoverBorderColor = System.Drawing.Color.DarkOrange;
            this.subBtn1.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.subBtn1.OnHoverTextColor = System.Drawing.Color.DarkOrange;
            this.subBtn1.Size = new System.Drawing.Size(117, 62);
            this.subBtn1.TabIndex = 12;
            this.subBtn1.Text = "Sub";
            this.subBtn1.TextColor = System.Drawing.Color.White;
            this.subBtn1.UseVisualStyleBackColor = true;
            this.subBtn1.Click += new System.EventHandler(this.subBtn1_Click);
            // 
            // sumBtn1
            // 
            this.sumBtn1.BorderColor = System.Drawing.Color.White;
            this.sumBtn1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.sumBtn1.FlatAppearance.BorderSize = 0;
            this.sumBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sumBtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumBtn1.Location = new System.Drawing.Point(6, 267);
            this.sumBtn1.Name = "sumBtn1";
            this.sumBtn1.OnHoverBorderColor = System.Drawing.Color.DarkOrange;
            this.sumBtn1.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.sumBtn1.OnHoverTextColor = System.Drawing.Color.DarkOrange;
            this.sumBtn1.Size = new System.Drawing.Size(117, 62);
            this.sumBtn1.TabIndex = 11;
            this.sumBtn1.Text = "Sum";
            this.sumBtn1.TextColor = System.Drawing.Color.White;
            this.sumBtn1.UseVisualStyleBackColor = true;
            this.sumBtn1.Click += new System.EventHandler(this.sumBtn1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(541, 660);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mac";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1, 581);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(492, 92);
            this.label6.TabIndex = 14;
            this.label6.Text = "Attention: \r\nPlease press clear button after every calculation! \r\nIf you don\'t, c" +
    "alculator may work wrong.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(49, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(477, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Welcome to macans first programming calculator";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_WOC1
            // 
            this.button_WOC1.BorderColor = System.Drawing.Color.White;
            this.button_WOC1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.button_WOC1.FlatAppearance.BorderSize = 0;
            this.button_WOC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC1.Location = new System.Drawing.Point(375, 267);
            this.button_WOC1.Name = "button_WOC1";
            this.button_WOC1.OnHoverBorderColor = System.Drawing.Color.DarkOrange;
            this.button_WOC1.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.button_WOC1.OnHoverTextColor = System.Drawing.Color.DarkOrange;
            this.button_WOC1.Size = new System.Drawing.Size(117, 62);
            this.button_WOC1.TabIndex = 16;
            this.button_WOC1.Text = "Exit";
            this.button_WOC1.TextColor = System.Drawing.Color.White;
            this.button_WOC1.UseVisualStyleBackColor = true;
            this.button_WOC1.Click += new System.EventHandler(this.button_WOC1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(577, 682);
            this.Controls.Add(this.button_WOC1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.clearBtn1);
            this.Controls.Add(this.subBtn1);
            this.Controls.Add(this.sumBtn1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox number1txt;
        private System.Windows.Forms.TextBox number2txt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox numComboBox;
        private System.Windows.Forms.TextBox resultTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox resultComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private ePOSOne.btnProduct.Button_WOC sumBtn1;
        private ePOSOne.btnProduct.Button_WOC subBtn1;
        private ePOSOne.btnProduct.Button_WOC clearBtn1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private ePOSOne.btnProduct.Button_WOC button_WOC1;
    }
}

