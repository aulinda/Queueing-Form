using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Queuing_Form
{
    public partial class Form1 : Form
    {
        private CashierClass cashier;
        public Form1()
        { 
        cashier = new CashierClass();
            InitializeComponent();
        }
        
        private void btnCashier_Click(object sender, EventArgs e)
        {
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CashierWindowQueueForm asb = new CashierWindowQueueForm();
            asb.Show();
        }
    }

        }
    

