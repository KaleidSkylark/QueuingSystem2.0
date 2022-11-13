namespace QueuingSystem
{
    public partial class QueuingForm : Form
    {
        private CashierClass cashier = new CashierClass();
        public QueuingForm()
        {
            InitializeComponent();
            cashier = new CashierClass();
            CashierWindowQueueForm obj = new CashierWindowQueueForm();
            obj.Show();
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            //lblQueue text will be equal to what the method returns    
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            //get the value of lblQueue and adds it to queue
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
        }
    }
}