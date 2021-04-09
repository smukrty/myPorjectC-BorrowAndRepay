using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BorrowAndRepay
{
    public partial class Form1 : Form
    {
        Person i, friend;

        public Form1()
        {
            InitializeComponent();
        }


        private void submitButton_Click(object sender, EventArgs e)
        {
            i = new Person(myNameInput.Text, 0);
            friend = new Person(friendNameInput.Text, 200000);

            myNameInput.Enabled = false;
            friendNameInput.Enabled = false;
            submitButton.Enabled = false;

            myBorrowButton.Text = i.Name + "跟" + friend.Name + "借1000$";
            myRepayBotton.Text = i.Name + "還" + friend.Name + "借1000$";
            friendBorrowButton.Text = friend.Name + "跟" + i.Name + "借1000$";
            friendRepayBotton.Text = friend.Name + "還" + i.Name + "借1000$";

            myBorrowButton.Enabled = true;
            myRepayBotton.Enabled = true;
            friendBorrowButton.Enabled = true;
            friendRepayBotton.Enabled = true;


            myNameLabel.Text = i.Name;
            frienfNameLabel.Text = friend.Name;
        }

        private void borrowButton_Click(object sender, EventArgs e)
        {
            i.borrow(friend, 1000);
            updateMoney();
        }

        private void repayBotton_Click(object sender, EventArgs e)
        {
            i.repay(friend, 1000);
            updateMoney();
        }

        private void friendBorrowButton_Click(object sender, EventArgs e)
        {
            friend.borrow(i, 1000);
            updateMoney();
        }

        private void friendRepayBotton_Click(object sender, EventArgs e)
        {
            friend.repay(i, 1000);
            updateMoney();
        }

        private void updateMoney()
        {
            myMoneyLabel.Text = "" + i.Money;
            friendMoneyLabel.Text = "" + friend.Money;
        }
    }
}
