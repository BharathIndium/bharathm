using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOB
{
    class joob : IComparable
    {
       
        string location;
        int exp;
        double sal;
        private string empname;

        public joob()
        {
        }

        public joob(string empname, string location, int exp, double sal)
        {
            this.empname = empname;
            this.location = location;
            this.exp = exp;
            this.sal = sal;
        }

        public joob(string location, int exp, double sal)
        {
            Location = location;
            Exp = exp;
            Sal = sal;
        }


        public string Location { get => location; set => location = value; }
        public int Exp { get => exp; set => exp = value; }
        public double Sal { get => sal; set => sal = value; }

        public int CompareTo(object obj)
        {
            joob j1 = (joob)obj;
            return this.Exp.CompareTo(j1.Exp);
        }

        public override string ToString()
        {
            return string.Format("Role : {0}\nSkillset : {1}\nEmptype : {2}\nLocation: {3}\nExp: {4}\nSal: {5}", Location);
        }
    }
}

