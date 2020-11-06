using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;


namespace WindowsForms3money
{
    class Class_Borrow
    {
        public string Name;
        public int Money;
        public int totalMoney;

        public Class_Borrow(string name, int money)
        {
            this.Name = name;
            this.Money = money;
            this.totalMoney = 0;
        }
        
        public void Borrow(Class_Borrow lender, int money)
        {
            lender.Money -= money;
            this.Money += money;
            this.totalMoney += money;
        }
        public void repay(Class_Borrow lender, int money)
        {
            this.Money -= money;
            lender.Money += money;
            this.totalMoney -= money;
        }
    }
}
