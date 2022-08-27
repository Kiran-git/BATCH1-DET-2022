using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BATCH1_DET_2022
{
    internal class emp1
    {
        int rollno;
        string name;
        string address;
        int pincode;
        int phoneno;
        int grosssal;
        int pf;

        public emp1(int rollno, string name, string address, int pincode, int phoneno, int grosssal)
        {
            this.rollno = rollno;
            this.name = name;
            this.address = address;
            this.pincode = pincode;
            this.phoneno = phoneno;
            this.grosssal = grosssal;
          
        } 
        
        public int GetEmpNetSalary()
        {
            int pf = 12 * grosssal / 100;
            int netsalary = grosssal - pf;
            return netsalary;
        }
        public char GetEmpGrade()
        {
            int netsalary = grosssal - pf;
            if (netsalary > 10000)
            {
                return 'A';
            }
            else if (netsalary > 5000)
            {
                return 'B';
            }
            else
                return 'c';
        }
    }
}
