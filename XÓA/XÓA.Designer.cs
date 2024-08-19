namespace XÓA
{
    partial class XÓA
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
            this.dgvxoa = new System.Windows.Forms.DataGridView();
            this.btndelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvxoa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvxoa
            // 
            this.dgvxoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvxoa.Location = new System.Drawing.Point(72, 94);
            this.dgvxoa.Name = "dgvxoa";
            this.dgvxoa.Size = new System.Drawing.Size(617, 168);
            this.dgvxoa.TabIndex = 0;
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btndelete.Location = new System.Drawing.Point(292, 329);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(156, 44);
            this.btndelete.TabIndex = 1;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            // 
            // XÓA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.dgvxoa);
            this.Name = "XÓA";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvxoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvxoa;
        private System.Windows.Forms.Button btndelete;
    }
}

