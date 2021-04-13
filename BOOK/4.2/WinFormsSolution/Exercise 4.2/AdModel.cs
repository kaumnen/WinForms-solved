using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4._2
{
    class AdModel
    {
        public string Position { get; private set; }
        public int Yoe { get; private set; }
        public string AcademicLevel { get; private set; }

        public AdModel(string position, int YOE, string academicLevel)
        {
            Position = position;
            Yoe = YOE;
            AcademicLevel = academicLevel;
        }

        public override string ToString()
        {
            return $"Position: {Position} - YOE: {Yoe} - Academic level: {AcademicLevel}\r\n";
        }
    }
}
