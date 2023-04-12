
namespace InspectionPipesJournal
{
    partial class FormMain
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
            this.dtDay = new System.Windows.Forms.DateTimePicker();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lvRecords = new System.Windows.Forms.ListView();
            this.columnHeader0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRemove = new System.Windows.Forms.Button();
            this.btdAdd = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtDay
            // 
            this.dtDay.Location = new System.Drawing.Point(12, 12);
            this.dtDay.Name = "dtDay";
            this.dtDay.Size = new System.Drawing.Size(200, 20);
            this.dtDay.TabIndex = 0;
            this.dtDay.ValueChanged += new System.EventHandler(this.DtDay_ValueChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(218, 11);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Обновить";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // lvRecords
            // 
            this.lvRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvRecords.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader0,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lvRecords.FullRowSelect = true;
            this.lvRecords.GridLines = true;
            this.lvRecords.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvRecords.HideSelection = false;
            this.lvRecords.Location = new System.Drawing.Point(12, 40);
            this.lvRecords.MultiSelect = false;
            this.lvRecords.Name = "lvRecords";
            this.lvRecords.Size = new System.Drawing.Size(942, 433);
            this.lvRecords.TabIndex = 5;
            this.lvRecords.UseCompatibleStateImageBehavior = false;
            this.lvRecords.View = System.Windows.Forms.View.Details;
            this.lvRecords.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LvRecords_MouseDoubleClick);
            // 
            // columnHeader0
            // 
            this.columnHeader0.Text = "id";
            this.columnHeader0.Width = 0;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Номер трубы";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Номенклатура трубы";
            this.columnHeader2.Width = 123;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Целевой внешний диаметр трубы";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 182;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Измеренный внешний диаметр по концу трубы 1";
            this.columnHeader4.Width = 95;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Измеренный внешний диаметр по концу трубы 2";
            this.columnHeader5.Width = 93;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Измеренный внешний диаметр по центру трубы";
            this.columnHeader6.Width = 91;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Максимальное отклонение измеренных диаметров от целевого";
            this.columnHeader7.Width = 103;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Примечание";
            this.columnHeader8.Width = 172;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Дата";
            this.columnHeader9.Width = 67;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Location = new System.Drawing.Point(880, 479);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Удалить";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // btdAdd
            // 
            this.btdAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btdAdd.Location = new System.Drawing.Point(713, 479);
            this.btdAdd.Name = "btdAdd";
            this.btdAdd.Size = new System.Drawing.Size(75, 23);
            this.btdAdd.TabIndex = 8;
            this.btdAdd.Text = "Добавить";
            this.btdAdd.UseVisualStyleBackColor = true;
            this.btdAdd.Click += new System.EventHandler(this.BtdAdd_Click);
            // 
            // btnChange
            // 
            this.btnChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChange.Location = new System.Drawing.Point(795, 479);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 9;
            this.btnChange.Text = "Изменить";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.BtnChange_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 514);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btdAdd);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lvRecords);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dtDay);
            this.Name = "FormMain";
            this.Text = "Журнал";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtDay;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ListView lvRecords;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btdAdd;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.ColumnHeader columnHeader0;
    }
}

