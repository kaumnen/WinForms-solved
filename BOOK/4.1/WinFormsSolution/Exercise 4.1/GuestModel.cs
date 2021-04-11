using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4._1
{
    class GuestModel
    {
        public string Surname { get; set; }
        public int Members { get; set; }
        public string Meals { get; set; }

        public override string ToString() =>
            $"Family {Surname} has reserved hotel for {Members} members. Available meals are: \r\n{Meals}\r\n------------------------------------------------\r\n";
    }
}
