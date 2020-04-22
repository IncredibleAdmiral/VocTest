using System;
using System.Collections.Generic;

namespace ASPVocTrain.Models.BaseModel.Voc
{
    public partial class WordsTable
    {
        public WordsTable()
        {
            ContextTable = new HashSet<ContextTable>();
        }

        public int IdWord { get; set; }
        public string Word { get; set; }
        public string WordTranslation { get; set; }
        public string PartOfSpeech { get; set; }

        public virtual IrregularVerbsTable IrregularVerbsTable { get; set; }
        public virtual ICollection<ContextTable> ContextTable { get; set; }
    }
}
