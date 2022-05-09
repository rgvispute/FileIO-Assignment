namespace Firstformproject
{
    partial class Book
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtaname = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(425, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "Binary Write";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(634, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 47);
            this.button2.TabIndex = 1;
            this.button2.Text = "Binary Read";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(425, 108);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 68);
            this.button3.TabIndex = 2;
            this.button3.Text = "Soap Write";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(634, 98);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(162, 62);
            this.button4.TabIndex = 3;
            this.button4.Text = "Soap Read";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(425, 196);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(155, 64);
            this.button5.TabIndex = 4;
            this.button5.Text = "XML Write";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(634, 196);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(162, 64);
            this.button6.TabIndex = 5;
            this.button6.Text = "XML Read";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(425, 296);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(155, 70);
            this.button7.TabIndex = 6;
            this.button7.Text = "Json Write";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(634, 296);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(162, 70);
            this.button8.TabIndex = 7;
            this.button8.Text = "Json Read";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Book Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Book Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Author Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Book Price";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(144, 56);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(126, 26);
            this.txtid.TabIndex = 12;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(144, 126);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(126, 26);
            this.txtname.TabIndex = 13;
            // 
            // txtaname
            // 
            this.txtaname.Location = new System.Drawing.Point(144, 218);
            this.txtaname.Name = "txtaname";
            this.txtaname.Size = new System.Drawing.Size(126, 26);
            this.txtaname.TabIndex = 14;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(144, 303);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(120, 26);
            this.txtprice.TabIndex = 15;
            // 
            // Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 527);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtaname);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Book";
            this.Text = "Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtaname;
        private System.Windows.Forms.TextBox txtprice;
    }
}