
namespace LAB7LVUTINVER2
{
    partial class Prepodavatel
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.табельныйНомерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияПреподавателяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяПреподавателяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоПреподавателяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.должностьПреподавателяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стажРаботыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.идентификаторКафедрыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.преподавательBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lab7bdDataSet = new LAB7LVUTINVER2.lab7bdDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.преподавательTableAdapter = new LAB7LVUTINVER2.lab7bdDataSetTableAdapters.ПреподавательTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.преподавательBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab7bdDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.табельныйНомерDataGridViewTextBoxColumn,
            this.фамилияПреподавателяDataGridViewTextBoxColumn,
            this.имяПреподавателяDataGridViewTextBoxColumn,
            this.отчествоПреподавателяDataGridViewTextBoxColumn,
            this.должностьПреподавателяDataGridViewTextBoxColumn,
            this.стажРаботыDataGridViewTextBoxColumn,
            this.идентификаторКафедрыDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.преподавательBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(755, 223);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // табельныйНомерDataGridViewTextBoxColumn
            // 
            this.табельныйНомерDataGridViewTextBoxColumn.DataPropertyName = "Табельный номер";
            this.табельныйНомерDataGridViewTextBoxColumn.HeaderText = "Табельный номер";
            this.табельныйНомерDataGridViewTextBoxColumn.Name = "табельныйНомерDataGridViewTextBoxColumn";
            // 
            // фамилияПреподавателяDataGridViewTextBoxColumn
            // 
            this.фамилияПреподавателяDataGridViewTextBoxColumn.DataPropertyName = "Фамилия преподавателя";
            this.фамилияПреподавателяDataGridViewTextBoxColumn.HeaderText = "Фамилия преподавателя";
            this.фамилияПреподавателяDataGridViewTextBoxColumn.Name = "фамилияПреподавателяDataGridViewTextBoxColumn";
            // 
            // имяПреподавателяDataGridViewTextBoxColumn
            // 
            this.имяПреподавателяDataGridViewTextBoxColumn.DataPropertyName = "Имя преподавателя";
            this.имяПреподавателяDataGridViewTextBoxColumn.HeaderText = "Имя преподавателя";
            this.имяПреподавателяDataGridViewTextBoxColumn.Name = "имяПреподавателяDataGridViewTextBoxColumn";
            // 
            // отчествоПреподавателяDataGridViewTextBoxColumn
            // 
            this.отчествоПреподавателяDataGridViewTextBoxColumn.DataPropertyName = "Отчество преподавателя";
            this.отчествоПреподавателяDataGridViewTextBoxColumn.HeaderText = "Отчество преподавателя";
            this.отчествоПреподавателяDataGridViewTextBoxColumn.Name = "отчествоПреподавателяDataGridViewTextBoxColumn";
            // 
            // должностьПреподавателяDataGridViewTextBoxColumn
            // 
            this.должностьПреподавателяDataGridViewTextBoxColumn.DataPropertyName = "Должность преподавателя";
            this.должностьПреподавателяDataGridViewTextBoxColumn.HeaderText = "Должность преподавателя";
            this.должностьПреподавателяDataGridViewTextBoxColumn.Name = "должностьПреподавателяDataGridViewTextBoxColumn";
            // 
            // стажРаботыDataGridViewTextBoxColumn
            // 
            this.стажРаботыDataGridViewTextBoxColumn.DataPropertyName = "Стаж работы";
            this.стажРаботыDataGridViewTextBoxColumn.HeaderText = "Стаж работы";
            this.стажРаботыDataGridViewTextBoxColumn.Name = "стажРаботыDataGridViewTextBoxColumn";
            // 
            // идентификаторКафедрыDataGridViewTextBoxColumn
            // 
            this.идентификаторКафедрыDataGridViewTextBoxColumn.DataPropertyName = "Идентификатор кафедры";
            this.идентификаторКафедрыDataGridViewTextBoxColumn.HeaderText = "Идентификатор кафедры";
            this.идентификаторКафедрыDataGridViewTextBoxColumn.Name = "идентификаторКафедрыDataGridViewTextBoxColumn";
            // 
            // преподавательBindingSource
            // 
            this.преподавательBindingSource.DataMember = "Преподаватель";
            this.преподавательBindingSource.DataSource = this.lab7bdDataSet;
            // 
            // lab7bdDataSet
            // 
            this.lab7bdDataSet.DataSetName = "lab7bdDataSet";
            this.lab7bdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Укажите табельный номер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Укажите табельный номер";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(550, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Укажите новую фамилию преподавателя";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 293);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(326, 293);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(142, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(553, 293);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(214, 20);
            this.textBox3.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 75);
            this.button1.TabIndex = 7;
            this.button1.Text = "отправить на пенсию(сократить)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(326, 336);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(441, 75);
            this.button2.TabIndex = 8;
            this.button2.Text = "изменить табельный номер";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(773, 133);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(205, 99);
            this.button3.TabIndex = 9;
            this.button3.Text = "добавить преподавателя";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(773, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(205, 98);
            this.button4.TabIndex = 10;
            this.button4.Text = "обновить таблицу";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // преподавательTableAdapter
            // 
            this.преподавательTableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(773, 312);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(205, 99);
            this.button5.TabIndex = 11;
            this.button5.Text = "вернуться назад";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Prepodavatel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 435);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Prepodavatel";
            this.Text = "Преподаватель";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.преподавательBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab7bdDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private lab7bdDataSet lab7bdDataSet;
        private System.Windows.Forms.BindingSource преподавательBindingSource;
        private lab7bdDataSetTableAdapters.ПреподавательTableAdapter преподавательTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn табельныйНомерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияПреподавателяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяПреподавателяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоПреподавателяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn должностьПреподавателяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стажРаботыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn идентификаторКафедрыDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button5;
    }
}

