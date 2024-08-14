using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorrowAndRepay
{
    internal class Person
    {
        public String Name;
        public int Money;
        public int Loan;

        public Person(String name, int money)
        {
            this.Name = name;
            this.Money = money;
            this.Loan = 0;
        }

        public void borrow(Person lender, int money)
        {
            if (lender.Money >= money)
            {
                lender.Money -= money;
                this.Money += money;
                this.Loan += money;
            }

            //如果借貸人有借過錢，則會扣除借貸人的借款
            if (lender.Loan > 0)
            {
                lender.Loan -= money;
                //因為借貣人有借過錢，所以原本在之前增加過的借款會被扣除
                this.Loan -= money;
            }
        }

        public void repay(Person lender, int money)
        {
            if ((this.Money >= money) && (this.Loan > 0))
            {
                this.Money -= money;
                lender.Money += money;
                this.Loan -= money;
            }
        }
    }
}
