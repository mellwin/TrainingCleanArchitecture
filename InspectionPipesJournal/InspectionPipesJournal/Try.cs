using InspectionPipesJournal.DAL;
using InspectionPipesJournal.Domain;
using System;
using System.Windows.Forms;

namespace InspectionPipesJournal
{
    public class Try
    {
        private readonly Logging log = new Logging();

        public bool TryExecute(Action action)
        {
            try
            {
                action();
                return true;
            }
            catch (Exception ex)
            {
                if (ex is IUseEx useEx)
                {
                    MessageBox.Show(useEx.DefaultMessage);
                }
                else
                {
                    log.Info(ex.Message);

                    MessageBox.Show("Что-то пошло не так. Обратитесь в службу поддержки");
                }
                return false;
            }
        }
    }
}
