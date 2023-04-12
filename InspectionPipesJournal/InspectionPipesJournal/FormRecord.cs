using InspectionPipesJournal.App.FormRecord;
using InspectionPipesJournal.App.FormRecord.InitDdl;
using InspectionPipesJournal.App.FormRecord.Save;
using InspectionPipesJournal.DAL;
using InspectionPipesJournal.Domain;
using InspectionPipesJournal.Domain.Spravochniki;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace InspectionPipesJournal
{
    public partial class FormRecord : Form, IViewForSave, IViewInitialDdl
    {
        private readonly Try tryEx = new Try();
        private OpenMode openMode = OpenMode.Add;
        private Guid recordId;

        public FormRecord()
        {
            InitializeComponent();

            //заполнение DDL из справочников
            InitialDdlUseCase useCase = new InitialDdlUseCase(this, new SprRepo());
            useCase.Execute(new InitialDdlUseCase.Values { });
        }

        public void InitDdlOptions(List<SprNomenclatures> ddlNomList, List<SprDiameters> ddlDiamList)
        {
            foreach (var a in ddlNomList)
            {
                DDLNomenclatureId.Items.Add(new DdlOption(a.NomenclatureId.ToString(), a.NomenclatureId.ToString()));
            };
            foreach (var a in ddlDiamList)
            {
                DDLTargetDiameter.Items.Add(new DdlOption(a.Diameter.ToString(), a.Diameter.ToString()));
            };
        }

        internal void RefillFields(JournalRecord record)
        {
            recordId = record.Id;
            txbPipeNumber.Text = record.PipeNumber;
            DDLNomenclatureId.Text = record.NomenclatureId.ToString();
            DDLTargetDiameter.Text = record.PipeTargetDiameter.ToString();
            txbOutDiam1.Text = record.PipeFactDiameterTeil1.ToString();
            txbOutDiam2.Text = record.PipeFactDiameterTeil2.ToString();
            txbOutDiamCentre.Text = record.PipeFactDiameterTeilCentre.ToString() == "0" ? "" : record.PipeFactDiameterTeilCentre.ToString();
            txbDifferentDiam.Text = record.PipeFactDifferentDiameter.ToString();
            txbNotes.Text = record.Notes;
            openMode = OpenMode.Edit;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            tryEx.TryExecute(() =>
            {
                var useCase = new SaveUseCase(this, new JournalRecordRepo());

                string fillingError = FillingCheck();
                if (!string.IsNullOrWhiteSpace(fillingError))
                    throw new FieldsNotFilledUseEx(fillingError);

                useCase.Execute(new SaveUseCase.Values
                {
                    OpenMode = openMode,
                    RecordId = recordId
                });
                Close();
            });
        }

        public DataForEdit CreateDataForEdit()
        {
            return new DataForEdit(
                                            txbPipeNumber.Text,
                                            Convert.ToInt32(DDLNomenclatureId.Text),
                                            Convert.ToDouble(DDLTargetDiameter.Text),
                                            Convert.ToDouble(txbOutDiam1.Text == "" ? "0" : txbOutDiam1.Text),
                                            Convert.ToDouble(txbOutDiam2.Text == "" ? "0" : txbOutDiam2.Text),
                                            Convert.ToDouble(txbOutDiamCentre.Text == "" ? "0" : txbOutDiamCentre.Text),
                                            txbNotes.Text,
                                            Convert.ToDateTime(dtpDate.Text)
                                        );
        }

        public DataForCreate CreateDataForAdd()
        {
            return new DataForCreate(
                                            txbPipeNumber.Text,
                                            Convert.ToInt32(DDLNomenclatureId.Text),
                                            Convert.ToDouble(DDLTargetDiameter.Text),
                                            Convert.ToDouble(txbOutDiam1.Text == "" ? "0" : txbOutDiam1.Text),
                                            Convert.ToDouble(txbOutDiam2.Text == "" ? "0" : txbOutDiam2.Text),
                                            Convert.ToDouble(txbOutDiamCentre.Text == "" ? "0" : txbOutDiamCentre.Text),
                                            Convert.ToDouble(txbDifferentDiam.Text),
                                            txbNotes.Text,
                                            Convert.ToDateTime(dtpDate.Text)
                                        );
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NumberedTxb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CheckInputNumber(sender, e);
        }

        private bool CheckInputNumber(object _sender, KeyPressEventArgs _e)
        {
            bool handled = false;
            if (!char.IsControl(_e.KeyChar) && !char.IsDigit(_e.KeyChar) && (_e.KeyChar != ',' || (_e.KeyChar == ',' && ((TextBox)_sender).Text.IndexOf(',') >= 0)))
                handled = true;
            return handled;
        }

        private void DdlTargetDiameter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            tryEx.TryExecute(() =>
            {
                FillMaxDifferendDiam();
            });
        }

        private void TxbOutDiam_KeyUp(object sender, KeyEventArgs e)
        {
            tryEx.TryExecute(() =>
            {
                FillMaxDifferendDiam();
            });
        }

        private void FillMaxDifferendDiam()
        {
            List<string> diamList = new List<string>()
            {
                txbOutDiam1.Text,
                txbOutDiam2.Text,
                txbOutDiamCentre.Text
            };

            var newDiamList = diamList.Where(d => d != "").ToList();

            double maxDifferrent = 0;

            if (DDLTargetDiameter.Text != "")
                foreach (var element in newDiamList)
                {
                    if (Math.Abs(Convert.ToDouble(element) - Convert.ToDouble(DDLTargetDiameter.Text)) > maxDifferrent)
                        maxDifferrent = Math.Abs(Convert.ToDouble(element) - Convert.ToDouble(DDLTargetDiameter.Text));
                }
            else throw new FieldsNotFilledUseEx("Заполните поле \"Целевой внешний диаметр\"");

            if (maxDifferrent > 0)
                txbDifferentDiam.Text = maxDifferrent.ToString();
            else
                txbDifferentDiam.Text = "";
        }

        private string FillingCheck()
        {
            if (txbPipeNumber.Text == "") return "Не заполнено поле \"Номер трубы\"";
            if (DDLNomenclatureId.Text == "") return "Не заполнено поле \"Номенклатура\"";
            if (DDLTargetDiameter.Text == "") return "Не заполнено поле \"Целевой внешний диаметр\"";
            if (txbOutDiam1.Text == "") return "Не заполнено поле \"Измеренный внешний диаметр по конце трубы 1\"";
            if (txbOutDiam2.Text == "") return "Не заполнено поле \"Измеренный внешний диаметр по конце трубы 2\"";
            return "";
        }
    }
}