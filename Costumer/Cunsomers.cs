using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costumer
{
    public class Cunsomers
    {
        static public List<Cunsomer> ConsumerList = new List<Cunsomer>();

        public bool Add(Cunsomer cunsomer)
        {
            ConsumerList.Add(cunsomer);
            return true;
        }
    }
}
