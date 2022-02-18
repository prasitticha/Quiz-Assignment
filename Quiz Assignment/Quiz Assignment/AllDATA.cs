using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Assignment
{
    internal class AllDATA
    {
        private string _id;
        private string _name;
        private string _major;

        private int NUM1 = 0;
        private int NUM2 = 0;
        private int NUM3 = 0;
        private int NUM4 = 0;

        //constructor
        public AllDATA(string id,string name, string major)
        {
            this._id = id;
            this._name = name;
            this._major = major;
        }

        public string getId() { return this._id; }
        public string getName() { return this._name; }
        public string getMajor() { return this._major; }

        public void addDATA(double gpa, string name)
        {
            this.NUM1 = NUM2 + NUM1;
            this.NUM3 = NUM4 + NUM3;
        }

        public double gatnum1()
        {
            return NUM1;
        }
        public double gatnum2()
        {
            return NUM2;
        }
        public double gatnum3()
        {
            return NUM3;
        }
        public double gatnum4()
        {
            return NUM4;
        }
    }
}
