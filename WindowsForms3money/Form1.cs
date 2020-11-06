using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsForms3money
{
    public partial class Form1 : Form
    {
        Class_Borrow i, friend;
        public Form1()
        {
            InitializeComponent();
        }


        private void button_con_Click(object sender, EventArgs e)
        {
            
          
        }

        private void button_borrow_Click(object sender, EventArgs e)
        {
            if (i.totalMoney >= 0 && friend.Money>0)
            {
                i.Borrow(friend, 1000);
                label_myTotal.Text = i.totalMoney.ToString();
                label_myMoney.Text = i.Money.ToString();
                label_friendMoney.Text = friend.Money.ToString();
            }
            
        }

        private void button_payBack_Click(object sender, EventArgs e)
        {
            if (i.totalMoney > 0 && i.Money > 0)
            {
                i.repay(friend, 1000);
                label_myTotal.Text = i.totalMoney.ToString();
                label_myMoney.Text = i.Money.ToString();
                label_friendMoney.Text = friend.Money.ToString();
            }
            
        }

        private void button_confirm_Click(object sender, EventArgs e)
        {
            i = new Class_Borrow(textBox_input_me.Text, 1000);
            friend = new Class_Borrow(textBox_input_friend.Text, 20000);

            label_myName.Text = i.Name;
            label_myMoney.Text = i.Money.ToString();
            label_friendName.Text = friend.Name;
            label_friendMoney.Text = friend.Money.ToString();
            button_payBack.Text = ($"還{friend.Name}1000");
            button_borrow.Text = "向" + friend.Name + "借1000";

            //控制按鈕的使用
            textBox_input_me.Enabled = false;
            textBox_input_friend.Enabled = false;
            button_confirm.Enabled = false;

            button_borrow.Enabled = true;
            button_payBack.Enabled = true;

        }
    }
}
