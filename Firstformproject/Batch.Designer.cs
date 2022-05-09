namespace Firstformproject
{
    partial class Batch
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtsdate = new System.Windows.Forms.TextBox();
            this.txtedate = new System.Windows.Forms.TextBox();
            this.txtlocation = new System.Windows.Forms.TextBox();
            this.txttname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(156, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 73);
            this.button1.TabIndex = 0;
            this.button1.Text = "Binary Write";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(393, 396);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 73);
            this.button2.TabIndex = 1;
            this.button2.Text = "Binary Read";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Batch Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Batch Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Start Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "End Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Location";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(283, 9);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(234, 26);
            this.txtid.TabIndex = 7;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(283, 67);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(234, 26);
            this.txtname.TabIndex = 8;
            // 
            // txtsdate
            // 
            this.txtsdate.Location = new System.Drawing.Point(283, 134);
            this.txtsdate.Name = "txtsdate";
            this.txtsdate.Size = new System.Drawing.Size(234, 26);
            this.txtsdate.TabIndex = 9;
            // 
            // txtedate
            // 
            this.txtedate.Location = new System.Drawing.Point(283, 202);
            this.txtedate.Name = "txtedate";
            this.txtedate.Size = new System.Drawing.Size(234, 26);
            this.txtedate.TabIndex = 10;
            // 
            // txtlocation
            // 
            this.txtlocation.Location = new System.Drawing.Point(283, 264);
            this.txtlocation.Name = "txtlocation";
            this.txtlocation.Size = new System.Drawing.Size(234, 26);
            this.txtlocation.TabIndex = 11;
            // 
            // txttname
            // 
            this.txttname.Location = new System.Drawing.Point(284, 325);
            this.txttname.Name = "txttname";
            this.txttname.Size = new System.Drawing.Size(233, 26);
            this.txttname.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(166, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Trainer Name";
            // 
            // Batch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 503);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txttname);
            this.Controls.Add(this.txtlocation);
            this.Controls.Add(this.txtedate);
            this.Controls.Add(this.txtsdate);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Batch";
            this.Text = "Batch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtsdate;
        private System.Windows.Forms.TextBox txtedate;
        private System.Windows.Forms.TextBox txtlocation;
        private System.Windows.Forms.TextBox txttname;
        private System.Windows.Forms.Label label6;
    }
}