using LiveCharts.Wpf.Charts.Base;
using PhoneServiceSystem_.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace PhoneServiceSystem_
{
    public partial class SubscriptionForm : Form

    {
        private List<Subscription> subscriptions = new List<Subscription>();
        private List<Client> clients;
        private List<ExtraOption> extraOptionsList = new List<ExtraOption>();
        public event Action<Dictionary<SubType, int>> DistributionUpdated;
        public event Action<Dictionary<SubType, int>> SubscriptionSaved;

        private const string ConnectionString = "Data Source=datab.db";


        private Dictionary<SubType, Color> subscriptionColors = new Dictionary<SubType, Color>
    {
        { SubType.Basic, Color.Blue },
        { SubType.Premium, Color.Green },
        { SubType.Family, Color.Orange },
        { SubType.International, Color.Red },
        { SubType.Business, Color.Purple }
    };
        public SubscriptionForm(int selectedClient, List<Client> clients, List<Subscription> subscriptions)
        {
            InitializeComponent();
            this.clients = clients;
            InitializeSubscriptionListView();

            InitializeSubscriptions();

            this.subscriptions = subscriptions;
            comboBoxSubType.DataSource = Enum.GetValues(typeof(SubType));

            comboBoxClients.DataSource = clients;
            comboBoxClients.ValueMember = "Id";
            comboBoxClients.SelectedValue = selectedClient;

            PopulateClientsComboBox();
            InitializeSubscriptionListView();
            btnSave.DialogResult = DialogResult.None;
            textBoxDescriptionS.Enabled = false;
            textBoxMonthlyFee.Enabled = false;

            panelchart.Width = 100;
            panelchart.Height = 100;

            InitializeComponents(selectedClient);
        }

        private void InitializeComponents(int selectedClient)
        {
            InitializeSubscriptionListView();

            comboBoxSubType.DataSource = Enum.GetValues(typeof(SubType));
            comboBoxClients.DataSource = clients;
            comboBoxClients.ValueMember = "Id";
            comboBoxClients.SelectedValue = selectedClient;

            PopulateClientsComboBox();

            textBoxDescriptionS.Enabled = false;
            textBoxMonthlyFee.Enabled = false;



            UpdateTotalCounts();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                this.DialogResult = DialogResult.None;
            }
            else if (result == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void btnAddExtraOpt_Click(object sender, EventArgs e)
        {
            if (listViewSubscription.SelectedItems.Count > 0)
            {
                ExtraOptionForm extraOptionForm = new ExtraOptionForm(extraOptionsList);
                extraOptionForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a client from the list before adding an extra option.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (comboBoxClients.SelectedItem != null)
            {
                Client selectedClient = (Client)comboBoxClients.SelectedItem;
                SubType selectedSubType = (SubType)comboBoxSubType.SelectedItem;
                string description = textBoxDescriptionS.Text;
                float monthlyFee = float.Parse(textBoxMonthlyFee.Text);
                DateTime registrationDate = DateTime.Now;

                // Find existing subscription for the selected client
                var existingSubscription = subscriptions.FirstOrDefault(s => s.ClientId == selectedClient.Id);

                if (existingSubscription != null)
                {
                    // Update existing subscription
                    existingSubscription.type = selectedSubType;
                    existingSubscription.Name = description;
                    existingSubscription.MonthlyFee = monthlyFee;
                    existingSubscription.RegistrationDate = registrationDate;

                    // Update ListViewItem
                    foreach (ListViewItem item in listViewSubscription.Items)
                    {
                        if (item.SubItems[0].Text == selectedClient.Id.ToString())
                        {
                            item.SubItems[1].Text = selectedSubType.ToString();
                            item.SubItems[2].Text = description;
                            item.SubItems[3].Text = monthlyFee.ToString();
                            item.SubItems[4].Text = registrationDate.ToShortDateString();
                            break;
                        }
                    }
                }
                else
                {
                    // Add new subscription
                    Subscription newSubscription = new Subscription(selectedClient.Id, description, monthlyFee, registrationDate, selectedSubType);
                    subscriptions.Add(newSubscription);

                    // Add new ListViewItem
                    ListViewItem newItem = new ListViewItem(selectedClient.Id.ToString());
                    newItem.SubItems.Add(selectedSubType.ToString());
                    newItem.SubItems.Add(description);
                    newItem.SubItems.Add(monthlyFee.ToString());
                    newItem.SubItems.Add(registrationDate.ToShortDateString());
                    listViewSubscription.Items.Add(newItem);
                }

                UpdateTotalCounts();
                panelchart.Invalidate();

                MessageBox.Show("Subscription saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select a client.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void PopulateClientsComboBox()
        {
            comboBoxClients.DataSource = clients;
            comboBoxClients.ValueMember = "Id";

        }
        private void InitializeSubscriptions()
        {
            subscriptions = new List<Subscription>();
        }
        private void SubscriptionForm_Load(object sender, EventArgs e)
        {

        }
        private void UpdateSubscriptionDetails()
        {
            SubType selectedType = (SubType)comboBoxSubType.SelectedItem;

            switch (selectedType)
            {
                case SubType.Basic:
                    textBoxDescriptionS.Text = "A limited number of talk minutes for calls to national numbers,a limited number of included text messages, Mobile data, Emergenecy calls";
                    textBoxMonthlyFee.Text = "13.22";
                    break;
                case SubType.Premium:
                    textBoxDescriptionS.Text = "Unlimited talk minutes,unlimited text messages, international roaming, generous amount of mobile data";
                    textBoxMonthlyFee.Text = "32.19";
                    break;
                case SubType.Family:
                    textBoxDescriptionS.Text = "Includes all the benefits of Premium subscription along with Parental controls, shared data pool, multiple lines with support for up to five people";
                    textBoxMonthlyFee.Text = "41.89";
                    break;
                case SubType.International:
                    textBoxDescriptionS.Text = "Roaming services, International calling and texting, data usage abroad, global coverage";
                    textBoxMonthlyFee.Text = "60.29";
                    break;
                case SubType.Business:
                    textBoxDescriptionS.Text = "Security features, dedicated support, conference calling, multi-user accounts";
                    textBoxMonthlyFee.Text = "72.74";
                    break;
                default:
                    textBoxDescriptionS.Clear();
                    textBoxMonthlyFee.Clear();
                    break;
            }

        }


        private void AddSubscriptionToListView(Subscription subscription)
        {
            ListViewItem item = new ListViewItem(subscription.ClientId.ToString());
            item.SubItems.Add(subscription.type.ToString());
            item.SubItems.Add(subscription.Name);
            item.SubItems.Add(subscription.MonthlyFee.ToString());
            item.SubItems.Add(subscription.RegistrationDate.ToShortDateString());
            listViewSubscription.Items.Add(item);
        }

        private void comboBoxSubType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSubscriptionDetails();

        }

        private void listViewSubscription_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void UpdateTotalCounts()
        {
            labelTotalClients.Text = clients.Count.ToString();
            labelTotalSubscriptions.Text = subscriptions.Count.ToString();
        }
        private void btnUpdateSubscription_Click(object sender, EventArgs e)
        {
        }



        private void serializeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (subscriptions.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fs = File.Create(saveFileDialog.FileName))
                    {
                        XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Subscription>));
                        xmlSerializer.Serialize(fs, subscriptions);
                    }
                    MessageBox.Show("Subscriptions saved to XML file", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No subscriptions added", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void deserializeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = File.OpenRead(openFileDialog.FileName))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Subscription>));
                    subscriptions = (List<Subscription>)xmlSerializer.Deserialize(fs);

                    InitializeSubscriptionListView();
                    UpdateTotalCounts();
                    panelchart.Invalidate();

                    SaveDeserializedDataToTextFile(subscriptions);
                }
            }
        }
        private void SaveDeserializedDataToTextFile(List<Subscription> subscriptions)
        {
            string textFilePath = "DeserializedSubscriptions.txt";
            using (StreamWriter writer = new StreamWriter(textFilePath))
            {
                foreach (var subscription in subscriptions)
                {
                    writer.WriteLine($"Client ID: {subscription.ClientId}");
                    writer.WriteLine($"Subscription Type: {subscription.type}");
                    writer.WriteLine($"Description: {subscription.Name}");
                    writer.WriteLine($"Monthly Fee: {subscription.MonthlyFee}");
                    writer.WriteLine($"Registration Date: {subscription.RegistrationDate}");
                    writer.WriteLine();
                }
            }
            MessageBox.Show($"Deserialized data has been written to {textFilePath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private List<Subscription> GetSubscriptionsFromListView()
        {
            List<Subscription> subscriptions = new List<Subscription>();

            foreach (ListViewItem item in listViewSubscription.Items)
            {
                int clientId = int.Parse(item.SubItems[0].Text);
                SubType subType = (SubType)Enum.Parse(typeof(SubType), item.SubItems[1].Text);
                string description = item.SubItems[2].Text;
                float monthlyFee = float.Parse(item.SubItems[3].Text);
                DateTime registrationDate = DateTime.Parse(item.SubItems[4].Text);

                Subscription subscription = new Subscription(clientId, description, monthlyFee, registrationDate, subType);
                subscriptions.Add(subscription);
            }

            return subscriptions;
        }
        private void InitializeSubscriptionListView()
        {
            listViewSubscription.Clear();

            listViewSubscription.View = View.Details;
            listViewSubscription.FullRowSelect = true;
            listViewSubscription.Columns.Add("Client ID", 100);
            listViewSubscription.Columns.Add("Subscription Type", 150);
            listViewSubscription.Columns.Add("Description", 250);
            listViewSubscription.Columns.Add("Monthly Fee", 100);
            listViewSubscription.Columns.Add("Registration Date", 150);

            foreach (Subscription subscription in subscriptions)
            {
                AddSubscriptionToListView(subscription);
            }
        }

        private void deleteSubscriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewSubscription.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected subscription?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ListViewItem selectedItem = listViewSubscription.SelectedItems[0];
                    int clientId = int.Parse(selectedItem.SubItems[0].Text);

                    subscriptions.RemoveAll(s => s.ClientId == clientId);
                    listViewSubscription.Items.Remove(selectedItem);

                    UpdateTotalCounts();
                    panelchart.Invalidate();

                    MessageBox.Show("Subscription deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a subscription to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private Dictionary<SubType, int> CalculateSubscriptionDistribution(int clientId)
        {
            Dictionary<SubType, int> distribution = new Dictionary<SubType, int>
                {
           { SubType.Basic, 0 },
           { SubType.Premium, 0 },
           { SubType.Family, 0 },
           { SubType.International, 0 },
           { SubType.Business, 0 }
                };

            foreach (var subscription in subscriptions.Where(s => s.ClientId == clientId))
            {
                distribution[subscription.type]++;
            }

            return distribution;
        }

        private void panelchart_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            DrawChart(g);
        }
        private void DrawChart(Graphics g)
        {
            int totalClients = clients.Count;
            int totalSubscriptions = subscriptions.Count; 

            if (totalSubscriptions > 0)
            {
                float clientsPercentage = (float)totalClients / (totalClients + totalSubscriptions);
                float subscriptionsPercentage = 1 - clientsPercentage;

                Color[] colors = { Color.LightBlue, Color.LightCoral };

                float startAngle = 0;
                float sweepAngleClients = (float)(clientsPercentage * 360);
                g.FillPie(new SolidBrush(colors[0]), 0, 0, panelchart.Width, panelchart.Height, startAngle, sweepAngleClients);

                startAngle += sweepAngleClients;
                float sweepAngleSubscriptions = (float)(subscriptionsPercentage * 360);
                g.FillPie(new SolidBrush(colors[1]), 0, 0, panelchart.Width, panelchart.Height, startAngle, sweepAngleSubscriptions);

                g.DrawString($"Total clients: {totalClients}", new Font("Arial", 8), Brushes.Black, new PointF(panelchart.Width - 100, panelchart.Height - 20));
                g.DrawString($"Total subscriptions: {totalSubscriptions}", new Font("Arial", 8), Brushes.Black, new PointF(panelchart.Width - 100, panelchart.Height - 30)); // Move the label up by 10 pixels
            }
        }
    }
}
