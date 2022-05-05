namespace Firstformproject
{
    partial class Form3
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
            this.btnwrite = new System.Windows.Forms.Button();
            this.btnfile = new System.Windows.Forms.Button();
            this.btncreatefolder = new System.Windows.Forms.Button();
            this.btncreatefile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnwrite
            // 
            this.btnwrite.Location = new System.Drawing.Point(172, 239);
            this.btnwrite.Name = "btnwrite";
            this.btnwrite.Size = new System.Drawing.Size(129, 37);
            this.btnwrite.TabIndex = 0;
            this.btnwrite.Text = "Write to File";
            this.btnwrite.UseVisualStyleBackColor = true;
            this.btnwrite.Click += new System.EventHandler(this.btnwrite_Click);
            // 
            // btnfile
            // 
            this.btnfile.Location = new System.Drawing.Point(349, 239);
            this.btnfile.Name = "btnfile";
            this.btnfile.Size = new System.Drawing.Size(165, 37);
            this.btnfile.TabIndex = 1;
            this.btnfile.Text = "Read From Flie";
            this.btnfile.UseVisualStyleBackColor = true;
            this.btnfile.Click += new System.EventHandler(this.btnfile_Click);
            // 
            // btncreatefolder
            // 
            this.btncreatefolder.Location = new System.Drawing.Point(172, 332);
            this.btncreatefolder.Name = "btncreatefolder";
            this.btncreatefolder.Size = new System.Drawing.Size(134, 38);
            this.btncreatefolder.TabIndex = 2;
            this.btncreatefolder.Text = "Create Folder";
            this.btncreatefolder.UseVisualStyleBackColor = true;
            this.btncreatefolder.Click += new System.EventHandler(this.btncreatefolder_Click);
            // 
            // btncreatefile
            // 
            this.btncreatefile.Location = new System.Drawing.Point(349, 332);
            this.btncreatefile.Name = "btncreatefile";
            this.btncreatefile.Size = new System.Drawing.Size(130, 38);
            this.btncreatefile.TabIndex = 3;
            this.btncreatefile.Text = "Create File";
            this.btncreatefile.UseVisualStyleBackColor = true;
            this.btncreatefile.Click += new System.EventHandler(this.btncreatefile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Dept Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter Dept Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter Location";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(324, 85);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(155, 26);
            this.txtName.TabIndex = 7;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(324, 142);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(155, 26);
            this.txtLocation.TabIndex = 8;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(324, 32);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(155, 26);
            this.txtId.TabIndex = 9;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncreatefile);
            this.Controls.Add(this.btncreatefolder);
            this.Controls.Add(this.btnfile);
            this.Controls.Add(this.btnwrite);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnwrite;
        private System.Windows.Forms.Button btnfile;
        private System.Windows.Forms.Button btncreatefolder;
        private System.Windows.Forms.Button btncreatefile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtId;
    }
}