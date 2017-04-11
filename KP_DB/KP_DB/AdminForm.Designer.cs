namespace KP_DB
{
    partial class AdminForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbPrava = new System.Windows.Forms.RadioButton();
            this.rbTableProt = new System.Windows.Forms.RadioButton();
            this.rbShtraf = new System.Windows.Forms.RadioButton();
            this.rbTableStrahComp = new System.Windows.Forms.RadioButton();
            this.rbTableStrah = new System.Windows.Forms.RadioButton();
            this.rbTableOner = new System.Windows.Forms.RadioButton();
            this.rbTableDriver = new System.Windows.Forms.RadioButton();
            this.rbTableAvto = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 10);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(795, 359);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(674, 416);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(116, 24);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbPrava);
            this.groupBox1.Controls.Add(this.rbTableProt);
            this.groupBox1.Controls.Add(this.rbShtraf);
            this.groupBox1.Controls.Add(this.rbTableStrahComp);
            this.groupBox1.Controls.Add(this.rbTableStrah);
            this.groupBox1.Controls.Add(this.rbTableOner);
            this.groupBox1.Controls.Add(this.rbTableDriver);
            this.groupBox1.Controls.Add(this.rbTableAvto);
            this.groupBox1.Location = new System.Drawing.Point(2, 385);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(560, 115);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор таблицы";
            this.groupBox1.EnabledChanged += new System.EventHandler(this.groupBox1_EnabledChanged);
            // 
            // rbPrava
            // 
            this.rbPrava.AutoSize = true;
            this.rbPrava.Location = new System.Drawing.Point(19, 79);
            this.rbPrava.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbPrava.Name = "rbPrava";
            this.rbPrava.Size = new System.Drawing.Size(176, 17);
            this.rbPrava.TabIndex = 7;
            this.rbPrava.TabStop = true;
            this.rbPrava.Text = "Водительское удостоверение";
            this.rbPrava.UseVisualStyleBackColor = true;
            // 
            // rbTableProt
            // 
            this.rbTableProt.AutoSize = true;
            this.rbTableProt.Location = new System.Drawing.Point(458, 79);
            this.rbTableProt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbTableProt.Name = "rbTableProt";
            this.rbTableProt.Size = new System.Drawing.Size(82, 17);
            this.rbTableProt.TabIndex = 6;
            this.rbTableProt.TabStop = true;
            this.rbTableProt.Text = "Протоколы";
            this.rbTableProt.UseVisualStyleBackColor = true;
            // 
            // rbShtraf
            // 
            this.rbShtraf.AutoSize = true;
            this.rbShtraf.Location = new System.Drawing.Point(458, 35);
            this.rbShtraf.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbShtraf.Name = "rbShtraf";
            this.rbShtraf.Size = new System.Drawing.Size(67, 17);
            this.rbShtraf.TabIndex = 5;
            this.rbShtraf.TabStop = true;
            this.rbShtraf.Text = "Штрафы";
            this.rbShtraf.UseVisualStyleBackColor = true;
            // 
            // rbTableStrahComp
            // 
            this.rbTableStrahComp.AutoSize = true;
            this.rbTableStrahComp.Location = new System.Drawing.Point(308, 79);
            this.rbTableStrahComp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbTableStrahComp.Name = "rbTableStrahComp";
            this.rbTableStrahComp.Size = new System.Drawing.Size(133, 17);
            this.rbTableStrahComp.TabIndex = 4;
            this.rbTableStrahComp.TabStop = true;
            this.rbTableStrahComp.Text = "Страховые компании";
            this.rbTableStrahComp.UseVisualStyleBackColor = true;
            // 
            // rbTableStrah
            // 
            this.rbTableStrah.AutoSize = true;
            this.rbTableStrah.Location = new System.Drawing.Point(308, 35);
            this.rbTableStrah.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbTableStrah.Name = "rbTableStrah";
            this.rbTableStrah.Size = new System.Drawing.Size(78, 17);
            this.rbTableStrah.TabIndex = 3;
            this.rbTableStrah.TabStop = true;
            this.rbTableStrah.Text = "Страховка";
            this.rbTableStrah.UseVisualStyleBackColor = true;
            // 
            // rbTableOner
            // 
            this.rbTableOner.AutoSize = true;
            this.rbTableOner.Location = new System.Drawing.Point(210, 35);
            this.rbTableOner.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbTableOner.Name = "rbTableOner";
            this.rbTableOner.Size = new System.Drawing.Size(74, 17);
            this.rbTableOner.TabIndex = 2;
            this.rbTableOner.TabStop = true;
            this.rbTableOner.Text = "Владелец";
            this.rbTableOner.UseVisualStyleBackColor = true;
            // 
            // rbTableDriver
            // 
            this.rbTableDriver.AutoSize = true;
            this.rbTableDriver.Location = new System.Drawing.Point(210, 79);
            this.rbTableDriver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbTableDriver.Name = "rbTableDriver";
            this.rbTableDriver.Size = new System.Drawing.Size(73, 17);
            this.rbTableDriver.TabIndex = 1;
            this.rbTableDriver.TabStop = true;
            this.rbTableDriver.Text = "Водитель";
            this.rbTableDriver.UseVisualStyleBackColor = true;
            // 
            // rbTableAvto
            // 
            this.rbTableAvto.AutoSize = true;
            this.rbTableAvto.Location = new System.Drawing.Point(19, 35);
            this.rbTableAvto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbTableAvto.Name = "rbTableAvto";
            this.rbTableAvto.Size = new System.Drawing.Size(87, 17);
            this.rbTableAvto.TabIndex = 0;
            this.rbTableAvto.TabStop = true;
            this.rbTableAvto.Text = "Автомобиль";
            this.rbTableAvto.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(674, 460);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 24);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(674, 374);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(116, 24);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Обновить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 510);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminForm";
            this.Text = "Администратор";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbShtraf;
        private System.Windows.Forms.RadioButton rbTableStrahComp;
        private System.Windows.Forms.RadioButton rbTableStrah;
        private System.Windows.Forms.RadioButton rbTableOner;
        private System.Windows.Forms.RadioButton rbTableDriver;
        private System.Windows.Forms.RadioButton rbTableAvto;
        private System.Windows.Forms.RadioButton rbTableProt;
        private System.Windows.Forms.RadioButton rbPrava;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
    }
}