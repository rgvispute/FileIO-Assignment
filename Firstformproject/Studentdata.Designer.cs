namespace Firstformproject
{
    partial class Studentdata
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtroll = new System.Windows.Forms.TextBox();
            this.txtstream = new System.Windows.Forms.TextBox();
            this.txtcity = new System.Windows.Forms.TextBox();
            this.txtpercentage = new System.Windows.Forms.TextBox();
            this.Write = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Roll No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stream";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Percentage";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(298, 16);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(190, 26);
            this.txtname.TabIndex = 5;
            // 
            // txtroll
            // 
            this.txtroll.Location = new System.Drawing.Point(298, 64);
            this.txtroll.Name = "txtroll";
            this.txtroll.Size = new System.Drawing.Size(190, 26);
            this.txtroll.TabIndex = 6;
            // 
            // txtstream
            // 
            this.txtstream.Location = new System.Drawing.Point(298, 112);
            this.txtstream.Name = "txtstream";
            this.txtstream.Size = new System.Drawing.Size(190, 26);
            this.txtstream.TabIndex = 7;
            // 
            // txtcity
            // 
            this.txtcity.Location = new System.Drawing.Point(298, 149);
            this.txtcity.Name = "txtcity";
            this.txtcity.Size = new System.Drawing.Size(190, 26);
            this.txtcity.TabIndex = 8;
            // 
            // txtpercentage
            // 
            this.txtpercentage.Location = new System.Drawing.Point(298, 201);
            this.txtpercentage.Name = "txtpercentage";
            this.txtpercentage.Size = new System.Drawing.Size(201, 26);
            this.txtpercentage.TabIndex = 9;
            // 
            // Write
            // 
            this.Write.Location = new System.Drawing.Point(156, 301);
            this.Write.Name = "Write";
            this.Write.Size = new System.Drawing.Size(146, 67);
            this.Write.TabIndex = 10;
            this.Write.Text = "Write";
            this.Write.UseVisualStyleBackColor = true;
            this.Write.Click += new System.EventHandler(this.Write_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(401, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 67);
            this.button2.TabIndex = 11;
            this.button2.Text = "Read";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Studentdata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Write);
            this.Controls.Add(this.txtpercentage);
            this.Controls.Add(this.txtcity);
            this.Controls.Add(this.txtstream);
            this.Controls.Add(this.txtroll);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Studentdata";
            this.Text = "Studentdata";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtroll;
        private System.Windows.Forms.TextBox txtstream;
        private System.Windows.Forms.TextBox txtcity;
        private System.Windows.Forms.TextBox txtpercentage;
        private System.Windows.Forms.Button Write;
        private System.Windows.Forms.Button button2;
    }
}