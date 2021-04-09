using System;
using System.Windows.Forms;

namespace BorrowAndRepay
{
    public partial class Form1 : Form
    {
        Person i, friend;
        int myRowB, myRowR;

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


            myBorrowNUD.Enabled = true;
            myRepayNUD.Enabled = true;
            
            
            
            friendBorrowButton.Text = friend.Name + "跟" + i.Name + "借1000$";
            friendRepayBotton.Text = friend.Name + "還" + i.Name + "借的1000$";

            
            
            friendBorrowButton.Enabled = true;
            friendRepayBotton.Enabled = true;


            myNameLabel.Text = i.Name;
            frienfNameLabel.Text = friend.Name;
        }

        private void borrowButton_Click(object sender, EventArgs e)
        {
            i.borrow(friend, myRowB);
            updateMoney();
        }

        private void repayBotton_Click(object sender, EventArgs e)
        {
            if (i.BorroMoney <= myRowR)
            {
            MessageBox.Show(i.Name + "沒有借那麼多錢啊");
            }
            else
            {
               i.repay(friend, myRowR);
                updateMoney();
            }
           
        }

        private void friendBorrowButton_Click(object sender, EventArgs e)
        {
            friend.borrow(i, 1000);
            updateMoney();
        }

        private void friendRepayBotton_Click(object sender, EventArgs e)
        {
            if (friend.BorroMoney <= 0)
            {
                MessageBox.Show(friend.Name + "沒有借那麼多錢啊");
            }
            else
            {
            friend.repay(i, 1000);
            updateMoney();
            }

        }

        private void setMyMoneyNumBottom_Click(object sender, EventArgs e)
        {
            myRowB = (int)myBorrowNUD.Value;

            myBorrowButton.Text = i.Name + "跟" + friend.Name + "借" + myRowB + "$";
            myBorrowButton.Enabled = true;
        }

        private void SetMyRepayMoneyNumBottom_Click(object sender, EventArgs e)
        {
            myRowR = (int)myRepayNUD.Value;

            myRepayBotton.Text = i.Name + "還" + friend.Name + "借的 "+ myRowR + "$";
            myRepayBotton.Enabled = true;
        }


        private void updateMoney()
        {
            myMoneyLabel.Text = "" + i.Money;
            myBorrowMoneyLabel.Text = "" + i.BorroMoney;
            friendMoneyLabel.Text = "" + friend.Money;
            friendBorrowMoneyLabel.Text = "" + friend.BorroMoney;
        }


    }
}
