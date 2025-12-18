using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCsv.models
{
    public class StroomData
    {
        public DateTime OpnameDatum { get; set; }
        public int StandNormaal { get; set; }
        public int StandDal { get; set; }
        public int TerugleveringNormaal { get; set; } = 0;
        public int TerugleveringDal { get; set; } = 0;


    }
}
