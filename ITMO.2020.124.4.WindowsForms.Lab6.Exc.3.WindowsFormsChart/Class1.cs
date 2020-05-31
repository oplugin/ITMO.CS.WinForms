using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO._2020._124._4.WindowsForms.Lab6.Exc._3.WindowsFormsChart
{
    class dat
    {
        Random r;
        public dat()
        {
            r = new Random();
        }
        public dat(int t)
        {
            r = new Random(t);
        }
        public int random(int t)
        {
            int res = r.Next(t);
            return res;
        }
    }
}
