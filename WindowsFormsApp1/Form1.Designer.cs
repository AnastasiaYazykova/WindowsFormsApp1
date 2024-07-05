namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			this.load = new System.Windows.Forms.Button();
			this.read = new System.Windows.Forms.Button();
			this.find = new System.Windows.Forms.Button();
			this.prev = new System.Windows.Forms.Button();
			this.next = new System.Windows.Forms.Button();
			this.curState = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.cправкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dgv1 = new System.Windows.Forms.DataGridView();
			this.pic = new System.Windows.Forms.PictureBox();
			this.save = new System.Windows.Forms.Button();
			this.clear = new System.Windows.Forms.Button();
			this.saveGraph = new System.Windows.Forms.Button();
			this.loadState = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
			this.SuspendLayout();
			// 
			// load
			// 
			this.load.Location = new System.Drawing.Point(19, 26);
			this.load.Margin = new System.Windows.Forms.Padding(2);
			this.load.Name = "load";
			this.load.Size = new System.Drawing.Size(170, 38);
			this.load.TabIndex = 0;
			this.load.Text = "Загрузить граф из файла";
			this.load.UseVisualStyleBackColor = true;
			this.load.Click += new System.EventHandler(this.load_Click);
			// 
			// read
			// 
			this.read.Location = new System.Drawing.Point(19, 68);
			this.read.Margin = new System.Windows.Forms.Padding(2);
			this.read.Name = "read";
			this.read.Size = new System.Drawing.Size(170, 50);
			this.read.TabIndex = 0;
			this.read.Text = "Ввод графа\r\nс клавиатуры";
			this.read.UseVisualStyleBackColor = true;
			this.read.Click += new System.EventHandler(this.read_Click);
			// 
			// find
			// 
			this.find.Location = new System.Drawing.Point(19, 122);
			this.find.Margin = new System.Windows.Forms.Padding(2);
			this.find.Name = "find";
			this.find.Size = new System.Drawing.Size(170, 38);
			this.find.TabIndex = 1;
			this.find.Text = "Поиск в ширину\r\n";
			this.find.UseVisualStyleBackColor = true;
			this.find.Click += new System.EventHandler(this.find_Click);
			// 
			// prev
			// 
			this.prev.Enabled = false;
			this.prev.Location = new System.Drawing.Point(453, 310);
			this.prev.Margin = new System.Windows.Forms.Padding(2);
			this.prev.Name = "prev";
			this.prev.Size = new System.Drawing.Size(56, 35);
			this.prev.TabIndex = 3;
			this.prev.Text = "<<";
			this.prev.UseVisualStyleBackColor = true;
			this.prev.Click += new System.EventHandler(this.prev_Click);
			// 
			// next
			// 
			this.next.Enabled = false;
			this.next.Location = new System.Drawing.Point(514, 310);
			this.next.Margin = new System.Windows.Forms.Padding(2);
			this.next.Name = "next";
			this.next.Size = new System.Drawing.Size(56, 35);
			this.next.TabIndex = 3;
			this.next.Text = ">>";
			this.next.UseVisualStyleBackColor = true;
			this.next.Click += new System.EventHandler(this.next_Click);
			// 
			// curState
			// 
			this.curState.AutoSize = true;
			this.curState.Location = new System.Drawing.Point(347, 321);
			this.curState.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.curState.Name = "curState";
			this.curState.Size = new System.Drawing.Size(76, 13);
			this.curState.TabIndex = 4;
			this.curState.Text = "Состояние: ...";
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cправкаToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(588, 24);
			this.menuStrip1.TabIndex = 5;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// cправкаToolStripMenuItem
			// 
			this.cправкаToolStripMenuItem.Name = "cправкаToolStripMenuItem";
			this.cправкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
			this.cправкаToolStripMenuItem.Text = "Cправка";
			this.cправкаToolStripMenuItem.Click += new System.EventHandler(this.cправкаToolStripMenuItem_Click);
			// 
			// dgv1
			// 
			this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv1.Location = new System.Drawing.Point(217, 25);
			this.dgv1.Margin = new System.Windows.Forms.Padding(2);
			this.dgv1.Name = "dgv1";
			this.dgv1.RowHeadersWidth = 51;
			this.dgv1.RowTemplate.Height = 24;
			this.dgv1.Size = new System.Drawing.Size(353, 223);
			this.dgv1.TabIndex = 2;
			// 
			// pic
			// 
			this.pic.Location = new System.Drawing.Point(19, 350);
			this.pic.Name = "pic";
			this.pic.Size = new System.Drawing.Size(551, 347);
			this.pic.TabIndex = 6;
			this.pic.TabStop = false;
			// 
			// save
			// 
			this.save.Location = new System.Drawing.Point(19, 165);
			this.save.Name = "save";
			this.save.Size = new System.Drawing.Size(170, 39);
			this.save.TabIndex = 7;
			this.save.Text = "Сохранить состояния в файл";
			this.save.UseVisualStyleBackColor = true;
			this.save.Click += new System.EventHandler(this.save_Click);
			// 
			// clear
			// 
			this.clear.Location = new System.Drawing.Point(19, 210);
			this.clear.Name = "clear";
			this.clear.Size = new System.Drawing.Size(170, 38);
			this.clear.TabIndex = 8;
			this.clear.Text = "Очистить";
			this.clear.UseVisualStyleBackColor = true;
			this.clear.Click += new System.EventHandler(this.clear_Click);
			// 
			// saveGraph
			// 
			this.saveGraph.Location = new System.Drawing.Point(19, 254);
			this.saveGraph.Name = "saveGraph";
			this.saveGraph.Size = new System.Drawing.Size(170, 39);
			this.saveGraph.TabIndex = 9;
			this.saveGraph.Text = "Сохранить граф в файл";
			this.saveGraph.UseVisualStyleBackColor = true;
			this.saveGraph.Click += new System.EventHandler(this.saveGraph_Click);
			// 
			// loadState
			// 
			this.loadState.Location = new System.Drawing.Point(19, 299);
			this.loadState.Name = "loadState";
			this.loadState.Size = new System.Drawing.Size(170, 39);
			this.loadState.TabIndex = 9;
			this.loadState.Text = "Загрузить состояния из файла";
			this.loadState.UseVisualStyleBackColor = true;
			this.loadState.Click += new System.EventHandler(this.loadState_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(588, 709);
			this.Controls.Add(this.loadState);
			this.Controls.Add(this.saveGraph);
			this.Controls.Add(this.clear);
			this.Controls.Add(this.save);
			this.Controls.Add(this.pic);
			this.Controls.Add(this.curState);
			this.Controls.Add(this.next);
			this.Controls.Add(this.prev);
			this.Controls.Add(this.dgv1);
			this.Controls.Add(this.find);
			this.Controls.Add(this.read);
			this.Controls.Add(this.load);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Form1";
			this.Text = "Поиск в ширину";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button load;
        private System.Windows.Forms.Button read;
        private System.Windows.Forms.Button find;
        private System.Windows.Forms.Button prev;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Label curState;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cправкаToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgv1;
		private System.Windows.Forms.PictureBox pic;
		private System.Windows.Forms.Button save;
		private System.Windows.Forms.Button clear;
		private System.Windows.Forms.Button saveGraph;
		private System.Windows.Forms.Button loadState;
	}
}

