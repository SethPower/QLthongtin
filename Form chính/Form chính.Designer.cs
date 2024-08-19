namespace Form_chính
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btncaidat = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(36, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 120);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnadd.Location = new System.Drawing.Point(66, 213);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(139, 29);
            this.btnadd.TabIndex = 2;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = true;
            // 
            // btnedit
            // 
            this.btnedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnedit.Location = new System.Drawing.Point(66, 264);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(139, 32);
            this.btnedit.TabIndex = 3;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btndelete.Location = new System.Drawing.Point(66, 319);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(139, 31);
            this.btndelete.TabIndex = 4;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            // 
            // btncaidat
            // 
            this.btncaidat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btncaidat.Location = new System.Drawing.Point(66, 378);
            this.btncaidat.Name = "btncaidat";
            this.btncaidat.Size = new System.Drawing.Size(139, 33);
            this.btncaidat.TabIndex = 5;
            this.btncaidat.Text = "Cài đặt";
            this.btncaidat.UseVisualStyleBackColor = true;
            // 
            // btntimkiem
            // 
            this.btntimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btntimkiem.Location = new System.Drawing.Point(436, 44);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(253, 53);
            this.btntimkiem.TabIndex = 6;
            this.btntimkiem.Text = "Tìm kiếm/Search";
            this.btntimkiem.UseVisualStyleBackColor = true;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(169, 157);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(200, 20);
            this.txtusername.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(62, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Username :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.btncaidat);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btncaidat;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label label1;
    }
}

