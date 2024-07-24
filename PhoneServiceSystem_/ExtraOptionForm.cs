using PhoneServiceSystem_.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PhoneServiceSystem_.Entities.ExtraOption;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace PhoneServiceSystem_
{
  
    public partial class ExtraOptionForm : Form
    {
        private List<ExtraOption> extraOptionsList;
        private List<Client> clientsList;
        private ExtraOption selectedOption;
        private Client selectedClient;
        private ExtraOption optionToEdit;
        private const string ConnectionString = "Data Source=databEO.db";

        private void LoadExtraOptions()
        {
            const string query = "SELECT * FROM ExtraOptions";
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                var command = new SQLiteCommand(query, connection);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int extraOptionId = Convert.ToInt32(reader["ExtraOptionId"]);
                        string name = reader["Name"].ToString();
                        double price = Convert.ToDouble(reader["Price"]);
                        string type = reader["TypeExtraOption"].ToString();
                        ExtraOption.SubTypee typeExtraOption = (ExtraOption.SubTypee)Enum.Parse(typeof(ExtraOption.SubTypee), type);
                        int clientId = Convert.ToInt32(reader["ClientId"]);

                        
                    }
                }
            }
        }
        private void CreateExtraOption(ExtraOption extraOption)
        {
            const string query = "INSERT INTO ExtraOptions (Name, Price, TypeExtraOption, ClientId) VALUES (@Name, @Price, @TypeExtraOption, @ClientId)";
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                var command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@Name", extraOption.Name);
                command.Parameters.AddWithValue("@Price", extraOption.Price);
                command.Parameters.AddWithValue("@TypeExtraOption", extraOption.TypeExtraOption.ToString());

                command.ExecuteNonQuery();
            }
        }

        private void UpdateExtraOption(ExtraOption extraOption)
        {
            const string query = "UPDATE ExtraOptions SET Name = @Name, Price = @Price, TypeExtraOption = @TypeExtraOption, ClientId = @ClientId WHERE ExtraOptionId = @ExtraOptionId";
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                var command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@Name", extraOption.Name);
                command.Parameters.AddWithValue("@Price", extraOption.Price);
                command.Parameters.AddWithValue("@TypeExtraOption", extraOption.TypeExtraOption.ToString());
                command.Parameters.AddWithValue("@ExtraOptionId", extraOption.ExtraOptionId);

                command.ExecuteNonQuery();
            }
        }

        private void DeleteExtraOption(int extraOptionId)
        {
            const string query = "DELETE FROM ExtraOptions WHERE ExtraOptionId = @ExtraOptionId";
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                var command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@ExtraOptionId", extraOptionId);

                command.ExecuteNonQuery();
            }
        }
        private void deleteExtraOptionToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                int extraOptionId = int.Parse(selectedItem.Text);

                const string query = "DELETE FROM ExtraOptions WHERE ExtraOptionId = @ExtraOptionId";

                using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();

                    var command = new SQLiteCommand(query, connection);
                    command.Parameters.AddWithValue("@ExtraOptionId", extraOptionId);

                    command.ExecuteNonQuery();
                }

                extraOptionsList.RemoveAll(option => option.ExtraOptionId == extraOptionId);
                PopulateListView();
            }
            else
            {
                MessageBox.Show("Please select an extra option to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public ExtraOptionForm(List<ExtraOption> extraOptionsList)
        {
            InitializeComponent();
            this.extraOptionsList = extraOptionsList;
            PopulateSubTypeComboBox();
            InitializeListView();
            SetTextBoxesReadOnly();
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            this.Load += ExtraOptionForm_Load;
            btnSaveEO.Click += btnSaveEO_Click;
            PopulateListView();
        }
        private void PopulateSubTypeComboBox()
        {
            comboBoxName.DataSource = Enum.GetValues(typeof(ExtraOption.SubTypee));
        }

        private void PopulateListView()
        {
            listView1.Items.Clear();
            foreach (var option in extraOptionsList)
            {
                ListViewItem item = new ListViewItem(option.ExtraOptionId.ToString());
                item.SubItems.Add(option.TypeExtraOption.ToString());
                item.SubItems.Add(option.Price.ToString("F2"));
                listView1.Items.Add(item);
            }


        }
       
        private void ExtraOptionForm_Load(object sender, EventArgs e)
        {
            PopulateListView();
       
        }
        
        private void UpdateSelectedOption()
        {
            if (comboBoxName.SelectedItem is ExtraOption.SubTypee selectedSubType)
            {
                selectedOption = extraOptionsList.FirstOrDefault(option => option.TypeExtraOption == selectedSubType);

                if (selectedOption == null)
                {
                    selectedOption = new ExtraOption(0, string.Empty, 0.0, selectedSubType);
                }

                textBoxid.Text = selectedOption.ExtraOptionId.ToString();
                textBoxPrice.Text = selectedOption.Price.ToString("F2");
            }
        }
        private void btnCloselEO_Click(object sender, EventArgs e)
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

        private void btnSaveEO_Click(object sender, EventArgs e)
        {

            if (comboBoxName.SelectedItem is ExtraOption.SubTypee selectedSubType && double.TryParse(textBoxPrice.Text, out double price))
            {
                if (isEditMode && optionToEdit != null)
                {
                    optionToEdit.TypeExtraOption = selectedSubType;
                    optionToEdit.Price = price;
                }
                else
                {
                    int newId = extraOptionsList.Count > 0 ? extraOptionsList.Max(opt => opt.ExtraOptionId) + 1 : 1;
                    selectedOption = new ExtraOption(newId, selectedSubType.ToString(), price, selectedSubType);
                    extraOptionsList.Add(selectedOption);
                }

                PopulateListView();
                ResetFormForEditing();
            }

        }
        private bool isEditMode = false;

        private void comboBoxName_SelectedIndexChanged(object sender, EventArgs e)
        {

            UpdateSelectedOption();

        }
        private void SetTextBoxesReadOnly()
        {
            textBoxid.ReadOnly = true;
            textBoxPrice.ReadOnly = true;
        }
        private void InitializeListView()
        {
            listView1.View = View.Details;
            
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                int extraOptionId = int.Parse(selectedItem.Text);
                selectedOption = extraOptionsList.FirstOrDefault(option => option.ExtraOptionId == extraOptionId);

                if (selectedOption != null)
                {
                    comboBoxName.SelectedItem = selectedOption.TypeExtraOption;
                    textBoxid.Text = selectedOption.ExtraOptionId.ToString();
                    textBoxPrice.Text = selectedOption.Price.ToString("F2");
                }
            }
            else
            {
                comboBoxName.SelectedIndex = -1;
                textBoxid.Clear();
                textBoxPrice.Clear();
            }
        }

        private void deleteExtraOptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                int extraOptionId = int.Parse(selectedItem.Text);

                ExtraOption optionToDelete = extraOptionsList.FirstOrDefault(opt => opt.ExtraOptionId == extraOptionId);
                if (optionToDelete != null)
                {
                    extraOptionsList.Remove(optionToDelete);
                    PopulateListView();
                }
            }
            else
            {
                MessageBox.Show("Please select an extra option to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editExtraOptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                int extraOptionId = int.Parse(selectedItem.Text);

                optionToEdit = extraOptionsList.FirstOrDefault(opt => opt.ExtraOptionId == extraOptionId);
                if (optionToEdit != null)
                {
                    isEditMode = true;
                    comboBoxName.SelectedItem = optionToEdit.TypeExtraOption;
                    textBoxPrice.Text = optionToEdit.Price.ToString("F2");

                    comboBoxName.Enabled = true;  //allow selecting another subtype
                    textBoxPrice.ReadOnly = false; //make price editable

                    btnSaveEO.Text = "Save";
                }
            }
            else
            {
                MessageBox.Show("Please select an extra option to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetFormForEditing()
        {
            comboBoxName.SelectedIndex = -1;
            textBoxid.Clear();
            textBoxPrice.Clear();

            comboBoxName.Enabled = true;
            textBoxPrice.ReadOnly = false;
            optionToEdit = null;
            isEditMode = false;

            btnSaveEO.Text = "Save";
        }

        private void addExToolStripMenuItem_Click(object sender, EventArgs e) //add extra option 
        {
            if (comboBoxName.SelectedItem is ExtraOption.SubTypee selectedSubType && double.TryParse(textBoxPrice.Text, out double price))
            {
                ExtraOption newOption = new ExtraOption(0, selectedSubType.ToString(), price, selectedSubType);
                extraOptionsList.Add(newOption);
                CreateExtraOption(newOption);
                PopulateListView();
                ResetFormForEditing();
            }
        }
    }
}
