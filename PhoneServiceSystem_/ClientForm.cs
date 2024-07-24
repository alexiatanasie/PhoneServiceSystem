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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing.Printing;
using System.IdentityModel.Protocols.WSTrust;

namespace PhoneServiceSystem_
{
    public partial class ClientForm : Form
    {
        private List<Client> clients;
        private List<Subscription> subscriptions;
        public delegate void DataUpdated(Dictionary<SubType, int> distribution);
        public event DataUpdated DataSent;
        public event Action ClientSaved;

        private bool isEditing = false;
        private int editedClientId = -1;
        public Client client { get; set; }
        public ClientForm(List<Client> clientsList, List<Subscription> subscriptionsList)

        {
            InitializeComponent();
            this.clients = clientsList;
            this.subscriptions = subscriptionsList;
            InitializeNumericUpDown();
            clients = new List<Client>(); 
            subscriptions = new List<Subscription>();
            DisplayClients();
            UpdateStatusStrip();
            var clearableTextBox = new ClearableTextBox
            {
                Location = new Point(50, 100) 
            };
            this.Controls.Add(clearableTextBox);

            clearableTextBox1.TextChanged += clearableTextBox1_Load;
            this.AllowDrop = true;

        }
        private void InitializeNumericUpDown()
        {
            numClientId.ReadOnly = true; 
            numClientId.InterceptArrowKeys = false;
            numClientId.Controls[0].Enabled = false;
            numClientId.Value = GenerateNewClientId(); 
        }
        private void ClientForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                Client editedClient = clients.FirstOrDefault(c => c.Id == editedClientId);
                if (editedClient != null)
                {
                    editedClient.Id = (int)numClientId.Value;
                    editedClient.Name = textBoxName.Text;
                    editedClient.Email = textBoxEmail.Text;
                    DisplayClients();
                    isEditing = false;
                    editedClientId = -1;
                    numClientId.Value = GenerateNewClientId(); 
                }
            }
            else
            {
                int newId = GenerateNewClientId();

                string name = textBoxName.Text;
                string email = textBoxEmail.Text;

                Client newClient = new Client(newId, name, email);
                clients.Add(newClient);
                DisplayClients();
                numClientId.Value = GenerateNewClientId(); 
            }
            DisplayClients();
            ClearFields();
        }
        private int GenerateNewClientId()
        {
            return clients.Count == 0 ? 1 : clients.Max(c => c.Id) + 1;
        }
        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            if (listViewClientForm.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewClientForm.SelectedItems[0];
                int clientId = (int)selectedItem.Tag;
                clients.RemoveAll(c => c.Id == clientId);

                DisplayClients();
                ClearFields();
                numClientId.Value = GenerateNewClientId();
            }
            else
            {
                MessageBox.Show("Please select a client to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayClients()
        {
            listViewClientForm.Items.Clear();
            var sortedClients = clients.OrderBy(c => c.Id);

            foreach (Client client in sortedClients)
            {
                ListViewItem item = new ListViewItem(client.Id.ToString());
                item.SubItems.Add(client.Name);
                item.SubItems.Add(client.Email);
                item.Tag = client.Id;
                listViewClientForm.Items.Add(item);
            }
            UpdateStatusStrip();
        }

        private void ClearFields()
        {

            textBoxName.Clear();
            textBoxEmail.Clear();
            isEditing = false;

            editedClientId = -1;
            numClientId.Value = GenerateNewClientId();
            UpdateStatusStrip();
        }
        private void btnEditClient_Click(object sender, EventArgs e)
        {
            if (listViewClientForm.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewClientForm.SelectedItems[0];
                int clientId = (int)selectedItem.Tag;

                Client clientToEdit = clients.FirstOrDefault(c => c.Id == clientId);
                if (clientToEdit != null)
                {
                    textBoxName.Text = clientToEdit.Name;
                    textBoxEmail.Text = clientToEdit.Email;
                    numClientId.Value = clientToEdit.Id;

                    isEditing = true;
                    editedClientId = clientId;
                }
            }
            else
            {
                MessageBox.Show("Please select a client to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSubDetails_Click(object sender, EventArgs e) // add subscription
        {
            if (listViewClientForm.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewClientForm.SelectedItems[0];
                int selectedClientId = (int)selectedItem.Tag;

                SubscriptionForm subscriptionForm = new SubscriptionForm(selectedClientId, clients, subscriptions);
                subscriptionForm.SubscriptionSaved += OnSubscriptionSaved;
                subscriptionForm.ShowDialog();

            }
            else
            {
                MessageBox.Show("Please select a client to add subscription.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void OnSubscriptionSaved(Dictionary<SubType, int> distribution)
        {
            DataSent?.Invoke(distribution);
        }

        private Dictionary<SubType, int> CalculateSubscriptionDistribution()
        {
            Dictionary<SubType, int> distribution = new Dictionary<SubType, int>();

            foreach (SubType type in Enum.GetValues(typeof(SubType)))
            {
                distribution[type] = 0;
            }

            foreach (Client client in clients)
            {
                foreach (Subscription subscription in subscriptions.Where(s => s.ClientId == client.Id))
                {
                    distribution[subscription.type]++;
                }
            }

            return distribution;
        }

        private void DrawPieChart(Graphics g, Dictionary<SubType, int> distribution)
        {
            Color[] colors = { Color.Blue, Color.Green, Color.Red, Color.Yellow, Color.Orange };

            int totalSubscriptions = distribution.Values.Sum();

            float startAngle = -90;

            foreach (var kvp in distribution)
            {
                float sweepAngle = (float)(360 * kvp.Value) / totalSubscriptions;

                using (SolidBrush brush = new SolidBrush(colors[(int)kvp.Key]))
                {
                    g.FillPie(brush, 100, 100, 200, 200, startAngle, sweepAngle);
                }

                startAngle += sweepAngle;
            }
        }

        private void listViewClientForm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void numClientId_Validated(object sender, EventArgs e)
        {
            errorProviderclientid.SetError(numClientId, "");
        }

        private void textBoxName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                e.Cancel = true;
                errorProvidername.SetError(textBoxName, "Name cannot be empty");
            }
        }

        private void textBoxName_Validated(object sender, EventArgs e)
        {
            errorProvidername.SetError(textBoxName, "");
        }


        private void textBoxEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxEmail.Text) || !textBoxEmail.Text.Contains("@"))
            {
                e.Cancel = true;
                errorProvider3.SetError(textBoxEmail, "Invalid email format, you have to use @");
            }
        }

        private void textBoxEmail_Validated(object sender, EventArgs e)
        {
            errorProvider3.SetError(textBoxEmail, "");
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void UpdateStatusStrip()
        {
            toolStripStatusLabelTotalClients.Text = $"Total Clients: {clients.Count}";
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //button for File

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Text files (*.txt)|*.txt",
                Title = "Save report as"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    writer.WriteLine("Client Report");

                    foreach (var client in clients)
                    {
                        writer.WriteLine($"ID: {client.Id}, Name: {client.Name}, Email: {client.Email}");
                    }
                    if (clients.Count == 0)
                    {
                        writer.WriteLine("No clients found");
                    }
                }
                MessageBox.Show("Report saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Text files (*.txt)|*.txt",
                Title = "Save report as"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    writer.WriteLine("Client Report");
                    foreach (var client in clients)
                    {
                        writer.WriteLine($"ID: {client.Id}, Name: {client.Name}, Email: {client.Email}");
                    }
                    if (clients.Count == 0)
                    {
                        writer.WriteLine("No clients found");
                    }
                }
                MessageBox.Show("Report saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toolStripButtonprint_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_2(object sender, EventArgs e)
        {

        }

        private void toolStripButtonprint_Click_1(object sender, EventArgs e)
        {
            DisplayClients();

            PrintDocument printDocument = new PrintDocument();

            printDocument.PrintPage += (s, ev) =>
            {
                Font font = new Font("Arial", 12);
                SolidBrush brush = new SolidBrush(Color.Black);

                float y = 20;

                for (int i = 0; i < listViewClientForm.Columns.Count; i++)
                {
                    ev.Graphics.DrawString(listViewClientForm.Columns[i].Text, font, brush, i * 100, y);
                }

                y += 20;
                foreach (ListViewItem item in listViewClientForm.Items)
                {
                    for (int i = 0; i < item.SubItems.Count; i++)
                    {
                        ev.Graphics.DrawString(item.SubItems[i].Text, font, brush, i * 100, y);
                    }
                    y += 20;
                }
            };

            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }

        private bool isTextModified = false;

        private void clearableTextBox1_Load(object sender, EventArgs e)
        {
            if (clearableTextBox1.Text != "Hello, Client!" && isTextModified == false)
            {
                clearableTextBox1.Text = "Hello, Client!";
                isTextModified = true;
            }
        }

        private void ClientForm_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                string text = (string)e.Data.GetData(DataFormats.Text);
                MessageBox.Show(text, "Drag & Drop");
            }
        }

        private void ClientForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void ClientForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxName.Text)) 
            {
                this.DoDragDrop(textBoxName.Text, DragDropEffects.Copy);
            }
        }
    }
    
}
