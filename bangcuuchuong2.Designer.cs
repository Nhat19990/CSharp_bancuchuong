namespace CSharp_bancuchuong
{
    partial class bangcuuchuong2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtso = new TextBox();
            numericUpDown1 = new NumericUpDown();
            btnxem = new Button();
            lblketqua = new Label();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(134, 60);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // txtso
            // 
            txtso.Location = new Point(298, 77);
            txtso.Name = "txtso";
            txtso.Size = new Size(100, 23);
            txtso.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(433, 78);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 2;
            // 
            // btnxem
            // 
            btnxem.Location = new Point(588, 78);
            btnxem.Name = "btnxem";
            btnxem.Size = new Size(75, 23);
            btnxem.TabIndex = 3;
            btnxem.Text = "XEM";
            btnxem.UseVisualStyleBackColor = true;
            btnxem.Click += btnxem_Click_1;
            // 
            // lblketqua
            // 
            lblketqua.AutoSize = true;
            lblketqua.Location = new Point(298, 179);
            lblketqua.Name = "lblketqua";
            lblketqua.Size = new Size(54, 15);
            lblketqua.TabIndex = 4;
            lblketqua.Text = "KẾT QUẢ";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(562, 312);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 15);
            linkLabel1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(linkLabel1);
            Controls.Add(lblketqua);
            Controls.Add(btnxem);
            Controls.Add(numericUpDown1);
            Controls.Add(txtso);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtso;
        private NumericUpDown numericUpDown1;
        private Button btnxem;
        private Label lblketqua;
        private LinkLabel linkLabel1;
    }
}
