using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deposit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtdeposit.Text = Properties.Settings.Default.deposit.ToString();
            txtpercentDeposit.Text = Properties.Settings.Default.percentDeposit.ToString();
            txtsumm.Text = Properties.Settings.Default.summ.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal deposit;
            decimal percentDeposit;
            decimal summ;
            try { 
                deposit = Convert.ToDecimal(this.txtdeposit.Text);
                percentDeposit = Convert.ToDecimal(this.txtpercentDeposit.Text);
                summ = Convert.ToDecimal(this.txtsumm.Text);
            }
            catch 
            {
                return;
            }

            Properties.Settings.Default.deposit = deposit;
            Properties.Settings.Default.percentDeposit = percentDeposit;
            Properties.Settings.Default.summ = summ;
            Properties.Settings.Default.Save();

            Result res = Logic.Exceed(deposit, percentDeposit, summ);
            MessageBox.Show("Через " + res.monthCntPercent +
                " месяцев величина ежемесячного увеличения вклада превысит B руб и сставит " + res.percent +
                ", " + "\n" + "через " + res.monthCntDeposit + " месяцев размер вклада превысит C руб и составит " + res.deposit);
        }
    }
    public struct Result
    {
        public int monthCntPercent;
        public decimal percent;
        public int monthCntDeposit;
        public decimal deposit;

        public void Print()
        {
            Console.WriteLine($"{monthCntPercent} {percent} {monthCntDeposit} {deposit}");
        }
    }

    public class Logic
    {
        public static Result Exceed(decimal deposit, decimal percentDeposit, decimal summ)
        {
            int monthCntPercentEx = 0;
            int monthCntDepositEx = 0;
            decimal depositEx = deposit;
            decimal percentEx = 0;
            for (monthCntPercentEx = 0; percentEx < percentDeposit; monthCntPercentEx++)
            {
                percentEx = (deposit / 100) * 2;
                deposit += percentEx;
            }


            for (monthCntDepositEx = 0; depositEx < summ; monthCntDepositEx++)
            {
                depositEx += (depositEx / 100) * 2;
            }

            return new Result { monthCntPercent = monthCntPercentEx, percent = percentEx, monthCntDeposit = monthCntDepositEx, deposit = depositEx };
        }
    }
}
