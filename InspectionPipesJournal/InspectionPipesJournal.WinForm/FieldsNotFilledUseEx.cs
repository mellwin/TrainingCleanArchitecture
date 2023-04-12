using InspectionPipesJournal.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InspectionPipesJournal
{
    class FieldsNotFilledUseEx : Exception, IUseEx
    {
        public string DefaultMessage => message;

        private readonly string message;

        public FieldsNotFilledUseEx(string notFilledField)
        {
            message = notFilledField;
        }
    }
}
