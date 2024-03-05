using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqApp
{
    internal class Student
    {
        public int Id { get; set; }
        public int GroupID { get; set; }
        public string Name { get; set; }
        public List<int> Marks { get; set; }


        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"Student: {Id} {GroupID} {Name} Marks - ");
            foreach( var item in Marks ) 
            {
                sb.Append( $"{item} ");
            }
            return sb.ToString();
        }
    }
}
