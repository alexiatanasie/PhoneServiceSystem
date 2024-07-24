using PhoneServiceSystem_.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneServiceSystem_
{
    public partial class MainForm : Form
    {
        private List<Client> clientsList = new List<Client>();
        private List<Subscription> subscriptionsList = new List<Subscription>();
        public MainForm()
        {
            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnOpenClientForm_Click(object sender, EventArgs e)
        {
            ClientForm clientForm = new ClientForm(clientsList, subscriptionsList); 


            clientForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

       
    }
}
