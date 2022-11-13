using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace QueuingSystem
{

    public partial class CashierWindowQueueForm : Form
    {

        public CashierWindowQueueForm()
        {
            InitializeComponent();
        }
        CustomerView customerView = new CustomerView();
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }
        private CustomerView GetCustomerView()
        {
            return customerView;
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            customerView.Show();
            try
            {
                customerView.UpdateService(CashierClass.CashierQueue.Peek());
            }
            catch
            {
                //Bye bye QueueEmpty :P
            }
            //dequeue
            if (CashierClass.CashierQueue.Count <= 0)
            {
                MessageBox.Show("Empty Queue", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CashierClass.CashierQueue.Dequeue();
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            btnRefresh.PerformClick();
        }
        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();
            foreach (Object obj in CashierList)
            {
                listCashierQueue.View = View.List; //addition to change the vertical
                listCashierQueue.Items.Add(obj.ToString());
            }
        }
        private void CashierWindowQueueForm_Load(object sender, EventArgs e)
        {
            //Timer
            Timer timer = new Timer();
            timer.Interval = (1 * 1000); // 1 sec
            timer.Tick += new EventHandler(Timer_Tick); //timer1_tick represents the name of Tick Event
            timer.Start(); //start the event timer, without it it will not auto refresh
        }
    }
}
