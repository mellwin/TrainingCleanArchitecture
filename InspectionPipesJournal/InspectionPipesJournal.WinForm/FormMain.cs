using InspectionPipesJournal.App.FormMain.Delete;
using InspectionPipesJournal.App.FormMain.Load;
using InspectionPipesJournal.DAL;
using InspectionPipesJournal.Domain;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace InspectionPipesJournal
{
    public partial class FormMain : Form, IViewForLoad, IViewForDelete
    {
        private readonly Try tryEx = new Try();
        private readonly LoadUseCase loadUseCase;
        private readonly DeleteUseCase deleteUseCase;

        public FormMain()
        {
            InitializeComponent();
            this.loadUseCase = new LoadUseCase(this, new JournalRecordRepo());
            this.deleteUseCase = new DeleteUseCase(this, new JournalRecordRepo());
            loadUseCase.RefillFormTable();
            loadUseCase.CreateRecordsListByDate();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            tryEx.TryExecute(() => loadUseCase.RefillFormTable());
        }

        private void BtdAdd_Click(object sender, EventArgs e)
        {
            tryEx.TryExecute(() =>
            {
                using (FormRecord formRecord = new FormRecord())
                {
                    formRecord.ShowDialog();
                }
                loadUseCase.RefillFormTable();
            });
        }

        private void BtnChange_Click(object sender, EventArgs e)
        {
            tryEx.TryExecute(OpenFormForChangeRercod);
        }

        private void LvRecords_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tryEx.TryExecute(OpenFormForChangeRercod);
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            tryEx.TryExecute(() =>
            {
                DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить запись?",
                                                      "Подтверждение",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Information,
                                                      MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    deleteUseCase.Execute(new DeleteUseCase.Values { });
                    loadUseCase.RefillFormTable();
                }
            });
        }

        private void DtDay_ValueChanged(object sender, EventArgs e)
        {
            tryEx.TryExecute(() => loadUseCase.RefillFormTable());
        }

        public DtoDataForRestore CreateDataFromTableRow()
        {
            if (lvRecords.SelectedItems.Count == 0)
            {
                throw new RecordNotSelectedUseEx();
            }

            var selectedRow = lvRecords.SelectedItems[0];
            return new DtoDataForRestore(

                Guid.Parse(selectedRow.SubItems[0].Text),
                selectedRow.SubItems[1].Text,
                Convert.ToInt32(selectedRow.SubItems[2].Text),
                Convert.ToDouble(selectedRow.SubItems[3].Text),
                Convert.ToDouble(selectedRow.SubItems[4].Text),
                Convert.ToDouble(selectedRow.SubItems[5].Text),
                Convert.ToDouble(selectedRow.SubItems[6].Text == "" ? "0" : selectedRow.SubItems[6].Text),
                Convert.ToDouble(selectedRow.SubItems[7].Text),
                selectedRow.SubItems[8].Text,
                DateTime.ParseExact(selectedRow.SubItems[9].Text, "MM.dd.yyyy HH:mm", null)
            );
        }

        public void OpenFormForChangeRercod()
        {
            JournalRecord record = loadUseCase.CreateRecordFromTableRow();

            using (FormRecord formRecord = new FormRecord())
            {
                formRecord.RefillFields(record);
                formRecord.ShowDialog();
            }
            loadUseCase.RefillFormTable();
        }

        public DateTime GetJournalDate()
        {
            return dtDay.Value;
        }

        public void RefillTableFromStorage(List<JournalRecord> records)
        {
            lvRecords.Items.Clear();
            foreach (JournalRecord row in records)
            {
                lvRecords.Items.Add(new ListViewItem(new[] {
                    row.Id.ToString(),
                    row.PipeNumber.ToString(),
                    row.NomenclatureId.ToString(),
                    row.PipeTargetDiameter.ToString(),
                    row.PipeFactDiameterTeil1.ToString(),
                    row.PipeFactDiameterTeil2.ToString(),
                    row.PipeFactDiameterTeilCentre == 0 ? "" : row.PipeFactDiameterTeilCentre.ToString(),
                    row.PipeFactDifferentDiameter.ToString(),
                    row.Notes.ToString(),
                    row.DateTimeRecord.ToString("MM.dd.yyyy HH:mm")
                }));

                foreach (ListViewItem lvw in lvRecords.Items)
                {
                    lvw.UseItemStyleForSubItems = false;

                    if (Convert.ToDouble(lvw.SubItems[7].Text) > row.PipeMaxDifferentDiameterOnCreate)
                    {
                        lvw.SubItems[7].BackColor = Color.Red;
                        lvw.SubItems[7].ForeColor = Color.White;
                    }
                    else
                    {
                        lvw.SubItems[7].BackColor = Color.White;
                        lvw.SubItems[7].ForeColor = Color.Black;
                    }
                }
            }
        }
    }
}