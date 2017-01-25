using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FR.Domin
{
    public class FaceRecognizer
    {
       public string PersonId { get; set; }
       public DateTime TimeIn { get; set; }
       public DateTime TimeOut { get; set; }
        public Enums.EAlgo Algo { get; set; }
    }
}
