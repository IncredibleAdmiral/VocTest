using System;
using System.Collections.Generic;

namespace ASPVocTrain.Models.BaseModel.Voc
{
    public partial class ExamplesTable
    {
        public ExamplesTable()
        {
            ContextTable = new HashSet<ContextTable>();
        }

        public int IdExample { get; set; }
        public string Example { get; set; }
        public string ExampleTranslation { get; set; }

        public virtual ICollection<ContextTable> ContextTable { get; set; }
    }
}
