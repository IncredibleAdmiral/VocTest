using System;
using System.Collections.Generic;

namespace ASPVocTrain.Models.BaseModel.Voc
{
    public partial class IrregularVerbsTable
    {
        public int IdWord { get; set; }
        public string PastSimple { get; set; }
        public string PastParticiple { get; set; }

        public virtual WordsTable IdWordNavigation { get; set; }
    }
}
