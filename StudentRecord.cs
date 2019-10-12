using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRecordApplication
{
    [Serializable]
    class StudentRecord
    {
        // полное имя студента
        public String fullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        // средняя отценка студента
        public Double averageScore
        {
            get { return averageScore; }
            set { averageScore = value; }
        }
    }
}