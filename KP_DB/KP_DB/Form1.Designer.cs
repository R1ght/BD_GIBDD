namespace KP_DB
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.соединениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новоеСоединениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отключитьсяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfststus = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.selectOfavto = new System.Windows.Forms.GroupBox();
            this.selectInCode = new System.Windows.Forms.RadioButton();
            this.selectInAvto = new System.Windows.Forms.RadioButton();
            this.dataGridViewAvto = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.selectOfavto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvto)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.соединениеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(927, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // соединениеToolStripMenuItem
            // 
            this.соединениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новоеСоединениеToolStripMenuItem,
            this.отключитьсяToolStripMenuItem});
            this.соединениеToolStripMenuItem.Name = "соединениеToolStripMenuItem";
            this.соединениеToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.соединениеToolStripMenuItem.Text = "Соединение";
            // 
            // новоеСоединениеToolStripMenuItem
            // 
            this.новоеСоединениеToolStripMenuItem.Name = "новоеСоединениеToolStripMenuItem";
            this.новоеСоединениеToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.новоеСоединениеToolStripMenuItem.Text = "Новое соединение";
            this.новоеСоединениеToolStripMenuItem.Click += new System.EventHandler(this.новоеСоединениеToolStripMenuItem_Click);
            // 
            // отключитьсяToolStripMenuItem
            // 
            this.отключитьсяToolStripMenuItem.Name = "отключитьсяToolStripMenuItem";
            this.отключитьсяToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.отключитьсяToolStripMenuItem.Text = "Отключиться";
            this.отключитьсяToolStripMenuItem.Click += new System.EventHandler(this.отключитьсяToolStripMenuItem_Click);
            // 
            // listOfststus
            // 
            this.listOfststus.FormattingEnabled = true;
            this.listOfststus.Location = new System.Drawing.Point(3, 421);
            this.listOfststus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listOfststus.Name = "listOfststus";
            this.listOfststus.Size = new System.Drawing.Size(922, 69);
            this.listOfststus.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(927, 394);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtRegion);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtCode);
            this.tabPage1.Controls.Add(this.selectOfavto);
            this.tabPage1.Controls.Add(this.dataGridViewAvto);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtModel);
            this.tabPage1.Controls.Add(this.txtMarca);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(919, 368);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Угнанные авто";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Регион";
            // 
            // txtRegion
            // 
            this.txtRegion.Location = new System.Drawing.Point(302, 57);
            this.txtRegion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(161, 20);
            this.txtRegion.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "ГосНомер";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(302, 18);
            this.txtCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(161, 20);
            this.txtCode.TabIndex = 8;
            // 
            // selectOfavto
            // 
            this.selectOfavto.Controls.Add(this.selectInCode);
            this.selectOfavto.Controls.Add(this.selectInAvto);
            this.selectOfavto.Location = new System.Drawing.Point(36, 8);
            this.selectOfavto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.selectOfavto.Name = "selectOfavto";
            this.selectOfavto.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.selectOfavto.Size = new System.Drawing.Size(150, 75);
            this.selectOfavto.TabIndex = 7;
            this.selectOfavto.TabStop = false;
            this.selectOfavto.Text = "Выбор поиска";
            // 
            // selectInCode
            // 
            this.selectInCode.AutoSize = true;
            this.selectInCode.Location = new System.Drawing.Point(15, 42);
            this.selectInCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.selectInCode.Name = "selectInCode";
            this.selectInCode.Size = new System.Drawing.Size(79, 17);
            this.selectInCode.TabIndex = 1;
            this.selectInCode.TabStop = true;
            this.selectInCode.Text = "По номеру";
            this.selectInCode.UseVisualStyleBackColor = true;
            // 
            // selectInAvto
            // 
            this.selectInAvto.AutoSize = true;
            this.selectInAvto.Location = new System.Drawing.Point(15, 17);
            this.selectInAvto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.selectInAvto.Name = "selectInAvto";
            this.selectInAvto.Size = new System.Drawing.Size(82, 17);
            this.selectInAvto.TabIndex = 0;
            this.selectInAvto.TabStop = true;
            this.selectInAvto.Text = "По машине";
            this.selectInAvto.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAvto
            // 
            this.dataGridViewAvto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAvto.Location = new System.Drawing.Point(6, 101);
            this.dataGridViewAvto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewAvto.Name = "dataGridViewAvto";
            this.dataGridViewAvto.RowTemplate.Height = 24;
            this.dataGridViewAvto.Size = new System.Drawing.Size(909, 265);
            this.dataGridViewAvto.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(816, 38);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 27);
            this.button1.TabIndex = 5;
            this.button1.Text = "Найти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(539, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Модель";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(539, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Марка";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(606, 20);
            this.txtModel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(161, 20);
            this.txtModel.TabIndex = 1;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(606, 55);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(161, 20);
            this.txtMarca.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(919, 368);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Угнанные авто по гос.номеру";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Size = new System.Drawing.Size(919, 368);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Вывод штрафов по фамилии водителя";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 492);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.listOfststus);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "ГИБДД";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.selectOfavto.ResumeLayout(false);
            this.selectOfavto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem соединениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новоеСоединениеToolStripMenuItem;
        private System.Windows.Forms.ListBox listOfststus;
        private System.Windows.Forms.ToolStripMenuItem отключитьсяToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.GroupBox selectOfavto;
        private System.Windows.Forms.RadioButton selectInCode;
        private System.Windows.Forms.RadioButton selectInAvto;
        private System.Windows.Forms.DataGridView dataGridViewAvto;
    }
}

