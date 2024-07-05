namespace WindowsFormsApp1
{
    partial class ReadGraph
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.read = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 15);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(330, 279);
            this.textBox1.TabIndex = 0;
            // 
            // read
            // 
            this.read.Location = new System.Drawing.Point(14, 318);
            this.read.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.read.Name = "read";
            this.read.Size = new System.Drawing.Size(117, 58);
            this.read.TabIndex = 1;
            this.read.Text = "Ввод";
            this.read.UseVisualStyleBackColor = true;
            this.read.Click += new System.EventHandler(this.read_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(227, 318);
            this.close.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(117, 58);
            this.close.TabIndex = 1;
            this.close.Text = "Закрыть";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // ReadGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 394);
            this.Controls.Add(this.close);
            this.Controls.Add(this.read);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ReadGraph";
            this.Text = "Ввод графа";
            this.Load += new System.EventHandler(this.ReadGraph_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button read;
        private System.Windows.Forms.Button close;
    }
}