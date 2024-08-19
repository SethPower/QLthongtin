namespace Form_XEM
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbkhoa = new System.Windows.Forms.ComboBox();
            this.cbnganh = new System.Windows.Forms.ComboBox();
            this.cblop = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmasv = new System.Windows.Forms.TextBox();
            this.btnback = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(68, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khoa :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(68, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngành :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(456, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lớp :";
            // 
            // cbkhoa
            // 
            this.cbkhoa.FormattingEnabled = true;
            this.cbkhoa.Location = new System.Drawing.Point(166, 111);
            this.cbkhoa.Name = "cbkhoa";
            this.cbkhoa.Size = new System.Drawing.Size(222, 21);
            this.cbkhoa.TabIndex = 3;
            // 
            // cbnganh
            // 
            this.cbnganh.FormattingEnabled = true;
            this.cbnganh.Location = new System.Drawing.Point(166, 171);
            this.cbnganh.Name = "cbnganh";
            this.cbnganh.Size = new System.Drawing.Size(222, 21);
            this.cbnganh.TabIndex = 4;
            // 
            // cblop
            // 
            this.cblop.FormattingEnabled = true;
            this.cblop.Location = new System.Drawing.Point(552, 170);
            this.cblop.Name = "cblop";
            this.cblop.Size = new System.Drawing.Size(222, 21);
            this.cblop.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(456, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã SV :";
            // 
            // txtmasv
            // 
            this.txtmasv.Location = new System.Drawing.Point(552, 111);
            this.txtmasv.Name = "txtmasv";
            this.txtmasv.Size = new System.Drawing.Size(222, 20);
            this.txtmasv.TabIndex = 7;
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnback.Location = new System.Drawing.Point(228, 269);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(96, 37);
            this.btnback.TabIndex = 9;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            // 
            // btnsearch
            // 
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnsearch.Location = new System.Drawing.Point(445, 269);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(92, 37);
            this.btnsearch.TabIndex = 10;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.txtmasv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cblop);
            this.Controls.Add(this.cbnganh);
            this.Controls.Add(this.cbkhoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbkhoa;
        private System.Windows.Forms.ComboBox cbnganh;
        private System.Windows.Forms.ComboBox cblop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmasv;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnsearch;
    }
}

