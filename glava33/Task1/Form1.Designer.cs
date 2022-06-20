
namespace Task1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.туристыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.турыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сезоныToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.путевкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оплатаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияОТуристахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(873, 171);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.туристыToolStripMenuItem,
            this.турыToolStripMenuItem,
            this.сезоныToolStripMenuItem,
            this.путевкиToolStripMenuItem,
            this.оплатаToolStripMenuItem,
            this.информацияОТуристахToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(899, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // туристыToolStripMenuItem
            // 
            this.туристыToolStripMenuItem.Name = "туристыToolStripMenuItem";
            this.туристыToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.туристыToolStripMenuItem.Text = "Туристы";
            this.туристыToolStripMenuItem.Click += new System.EventHandler(this.туристыToolStripMenuItem_Click);
            // 
            // турыToolStripMenuItem
            // 
            this.турыToolStripMenuItem.Name = "турыToolStripMenuItem";
            this.турыToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.турыToolStripMenuItem.Text = "Туры";
            this.турыToolStripMenuItem.Click += new System.EventHandler(this.турыToolStripMenuItem_Click);
            // 
            // сезоныToolStripMenuItem
            // 
            this.сезоныToolStripMenuItem.Name = "сезоныToolStripMenuItem";
            this.сезоныToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.сезоныToolStripMenuItem.Text = "Сезоны";
            this.сезоныToolStripMenuItem.Click += new System.EventHandler(this.сезоныToolStripMenuItem_Click);
            // 
            // путевкиToolStripMenuItem
            // 
            this.путевкиToolStripMenuItem.Name = "путевкиToolStripMenuItem";
            this.путевкиToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.путевкиToolStripMenuItem.Text = "Путевки";
            this.путевкиToolStripMenuItem.Click += new System.EventHandler(this.путевкиToolStripMenuItem_Click);
            // 
            // оплатаToolStripMenuItem
            // 
            this.оплатаToolStripMenuItem.Name = "оплатаToolStripMenuItem";
            this.оплатаToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.оплатаToolStripMenuItem.Text = "Оплата";
            this.оплатаToolStripMenuItem.Click += new System.EventHandler(this.оплатаToolStripMenuItem_Click);
            // 
            // информацияОТуристахToolStripMenuItem
            // 
            this.информацияОТуристахToolStripMenuItem.Name = "информацияОТуристахToolStripMenuItem";
            this.информацияОТуристахToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.информацияОТуристахToolStripMenuItem.Text = "Информация о туристах";
            this.информацияОТуристахToolStripMenuItem.Click += new System.EventHandler(this.информацияОТуристахToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 342);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Задание №1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem туристыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem турыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сезоныToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem путевкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оплатаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияОТуристахToolStripMenuItem;
    }
}

