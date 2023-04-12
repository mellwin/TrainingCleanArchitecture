
namespace InspectionPipesJournal
{
    partial class FormRecord
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
            this.txbPipeNumber = new System.Windows.Forms.TextBox();
            this.DDLNomenclatureId = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txbOutDiam1 = new System.Windows.Forms.TextBox();
            this.DDLTargetDiameter = new System.Windows.Forms.ComboBox();
            this.txbOutDiam2 = new System.Windows.Forms.TextBox();
            this.txbOutDiamCentre = new System.Windows.Forms.TextBox();
            this.txbDifferentDiam = new System.Windows.Forms.TextBox();
            this.txbNotes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер трубы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Номенклатура";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Целевой внешний диаметр";
            // 
            // txbPipeNumber
            // 
            this.txbPipeNumber.Location = new System.Drawing.Point(361, 19);
            this.txbPipeNumber.MaxLength = 10;
            this.txbPipeNumber.Name = "txbPipeNumber";
            this.txbPipeNumber.Size = new System.Drawing.Size(287, 20);
            this.txbPipeNumber.TabIndex = 3;
            // 
            // DDLNomenclatureId
            // 
            this.DDLNomenclatureId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DDLNomenclatureId.FormattingEnabled = true;
            this.DDLNomenclatureId.Location = new System.Drawing.Point(361, 45);
            this.DDLNomenclatureId.Name = "DDLNomenclatureId";
            this.DDLNomenclatureId.Size = new System.Drawing.Size(287, 21);
            this.DDLNomenclatureId.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(496, 269);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(577, 269);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // txbOutDiam1
            // 
            this.txbOutDiam1.Location = new System.Drawing.Point(361, 99);
            this.txbOutDiam1.Name = "txbOutDiam1";
            this.txbOutDiam1.Size = new System.Drawing.Size(287, 20);
            this.txbOutDiam1.TabIndex = 7;
            this.txbOutDiam1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberedTxb_KeyPress);
            this.txbOutDiam1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxbOutDiam_KeyUp);
            // 
            // DDLTargetDiameter
            // 
            this.DDLTargetDiameter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DDLTargetDiameter.FormattingEnabled = true;
            this.DDLTargetDiameter.Location = new System.Drawing.Point(361, 71);
            this.DDLTargetDiameter.Name = "DDLTargetDiameter";
            this.DDLTargetDiameter.Size = new System.Drawing.Size(287, 21);
            this.DDLTargetDiameter.TabIndex = 8;
            this.DDLTargetDiameter.SelectionChangeCommitted += new System.EventHandler(this.DdlTargetDiameter_SelectionChangeCommitted);
            // 
            // txbOutDiam2
            // 
            this.txbOutDiam2.Location = new System.Drawing.Point(361, 126);
            this.txbOutDiam2.Name = "txbOutDiam2";
            this.txbOutDiam2.Size = new System.Drawing.Size(287, 20);
            this.txbOutDiam2.TabIndex = 9;
            this.txbOutDiam2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberedTxb_KeyPress);
            this.txbOutDiam2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxbOutDiam_KeyUp);
            // 
            // txbOutDiamCentre
            // 
            this.txbOutDiamCentre.Location = new System.Drawing.Point(361, 152);
            this.txbOutDiamCentre.Name = "txbOutDiamCentre";
            this.txbOutDiamCentre.Size = new System.Drawing.Size(287, 20);
            this.txbOutDiamCentre.TabIndex = 10;
            this.txbOutDiamCentre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberedTxb_KeyPress);
            this.txbOutDiamCentre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxbOutDiam_KeyUp);
            // 
            // txbDifferentDiam
            // 
            this.txbDifferentDiam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbDifferentDiam.Location = new System.Drawing.Point(361, 178);
            this.txbDifferentDiam.Name = "txbDifferentDiam";
            this.txbDifferentDiam.ReadOnly = true;
            this.txbDifferentDiam.Size = new System.Drawing.Size(287, 20);
            this.txbDifferentDiam.TabIndex = 11;
            // 
            // txbNotes
            // 
            this.txbNotes.Location = new System.Drawing.Point(361, 204);
            this.txbNotes.Name = "txbNotes";
            this.txbNotes.Size = new System.Drawing.Size(287, 20);
            this.txbNotes.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Измеренный внешний диаметр по конце трубы 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(256, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Измеренный внешний диаметр по конце трубы 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(251, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Измеренный внешний диаметр по центру трубы";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(334, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Максимальное отклонение измеренных диаметров от целевого";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Примечание";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Дата";
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(361, 233);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(287, 20);
            this.dtpDate.TabIndex = 20;
            // 
            // FormRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 304);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbNotes);
            this.Controls.Add(this.txbDifferentDiam);
            this.Controls.Add(this.txbOutDiamCentre);
            this.Controls.Add(this.txbOutDiam2);
            this.Controls.Add(this.DDLTargetDiameter);
            this.Controls.Add(this.txbOutDiam1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.DDLNomenclatureId);
            this.Controls.Add(this.txbPipeNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormRecord";
            this.Text = "Редактирование";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbPipeNumber;
        private System.Windows.Forms.ComboBox DDLNomenclatureId;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txbOutDiam1;
        private System.Windows.Forms.ComboBox DDLTargetDiameter;
        private System.Windows.Forms.TextBox txbOutDiam2;
        private System.Windows.Forms.TextBox txbOutDiamCentre;
        private System.Windows.Forms.TextBox txbDifferentDiam;
        private System.Windows.Forms.TextBox txbNotes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpDate;
    }
}