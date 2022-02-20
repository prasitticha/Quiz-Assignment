using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Quiz_Assignment
{
    internal class AllDATA
    {








        private string _List;
        private string _Income;
        private string _Expenses;

        private int NUM1 = 0;
        private int NUM2 = 0;
        private int NUM3 = 0;
        private int NUM4 = 0;

        //constructor
        public AllDATA(string List, string Income, string Expenses)
        {
            this._List = List;
            this._Income = Income;
            this._Expenses = Expenses;
        }

        public string getList() { return this._List; }
        public string getIncome() { return this._Income; }
        public string getExpenses() { return this._Expenses; }



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
