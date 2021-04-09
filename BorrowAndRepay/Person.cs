﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorrowAndRepay
{
    class Person
    {
        public String Name;
        public int Money;

        public Person(String name, int money)
        {
            this.Name = name;
            this.Money = money;

        }

        public void borrow(Person lender, int money)
        {
            if(lender.Money >= money)
            {
                lender.Money -= money;
                this.Money += money;
            }

        }

        public void repay(Person lender, int money)
        {
            if(this.Money >= money)
            {
                this.Money -= money;
                lender.Money += money;
            }
          
        }
    }
}
