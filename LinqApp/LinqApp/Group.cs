using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqApp
{
    internal class Group
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string Faculty { get; set; }
        public string Speciality { get; set; }

        public override string ToString()
        {
            return $"Group: id={Id} num={Number} fac={Faculty} sp={Speciality}";
        }

    }
}
