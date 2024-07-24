namespace PhoneServiceSystem_
{
    partial class ClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.numClientId = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEditClient = new System.Windows.Forms.Button();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.btnSubDetails = new System.Windows.Forms.Button();
            this.listViewClientForm = new System.Windows.Forms.ListView();
            this.columnHeaderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeadername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderemail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.errorProviderclientid = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvidername = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonprint = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelTotalClients = new System.Windows.Forms.ToolStripStatusLabel();
            this.clearableTextBox1 = new PhoneServiceSystem_.ClearableTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numClientId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderclientid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvidername)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(695, 228);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 47);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(695, 346);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 47);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // numClientId
            // 
            this.numClientId.Location = new System.Drawing.Point(176, 54);
            this.numClientId.Name = "numClientId";
            this.numClientId.Size = new System.Drawing.Size(243, 22);
            this.numClientId.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label1.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Client Id";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(176, 102);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(243, 22);
            this.textBoxName.TabIndex = 4;
            this.textBoxName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxName_Validating);
            this.textBoxName.Validated += new System.EventHandler(this.textBoxName_Validated);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(176, 142);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(243, 22);
            this.textBoxEmail.TabIndex = 5;
            this.textBoxEmail.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEmail_Validating);
            this.textBoxEmail.Validated += new System.EventHandler(this.textBoxName_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Lavender;
            this.label2.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Client Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.AliceBlue;
            this.label3.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email";
            // 
            // btnEditClient
            // 
            this.btnEditClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEditClient.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditClient.Location = new System.Drawing.Point(628, 76);
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.Size = new System.Drawing.Size(156, 28);
            this.btnEditClient.TabIndex = 13;
            this.btnEditClient.Text = "&Edit Client";
            this.btnEditClient.UseVisualStyleBackColor = false;
            this.btnEditClient.Click += new System.EventHandler(this.btnEditClient_Click);
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDeleteClient.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteClient.Location = new System.Drawing.Point(628, 37);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(156, 33);
            this.btnDeleteClient.TabIndex = 14;
            this.btnDeleteClient.Text = "&Delete Client";
            this.btnDeleteClient.UseVisualStyleBackColor = false;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // btnSubDetails
            // 
            this.btnSubDetails.BackColor = System.Drawing.Color.Yellow;
            this.btnSubDetails.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubDetails.Location = new System.Drawing.Point(582, 118);
            this.btnSubDetails.Name = "btnSubDetails";
            this.btnSubDetails.Size = new System.Drawing.Size(202, 46);
            this.btnSubDetails.TabIndex = 15;
            this.btnSubDetails.Text = "&Add Subscription";
            this.btnSubDetails.UseVisualStyleBackColor = false;
            this.btnSubDetails.Click += new System.EventHandler(this.btnSubDetails_Click);
            // 
            // listViewClientForm
            // 
            this.listViewClientForm.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderId,
            this.columnHeadername,
            this.columnHeaderemail});
            this.listViewClientForm.FullRowSelect = true;
            this.listViewClientForm.HideSelection = false;
            this.listViewClientForm.Location = new System.Drawing.Point(51, 190);
            this.listViewClientForm.Name = "listViewClientForm";
            this.listViewClientForm.Size = new System.Drawing.Size(625, 267);
            this.listViewClientForm.TabIndex = 17;
            this.listViewClientForm.UseCompatibleStateImageBehavior = false;
            this.listViewClientForm.View = System.Windows.Forms.View.Details;
            this.listViewClientForm.SelectedIndexChanged += new System.EventHandler(this.listViewClientForm_SelectedIndexChanged);
            // 
            // columnHeaderId
            // 
            this.columnHeaderId.Text = "Client Id";
            // 
            // columnHeadername
            // 
            this.columnHeadername.Text = "Client Name";
            this.columnHeadername.Width = 244;
            // 
            // columnHeaderemail
            // 
            this.columnHeaderemail.Text = "Email";
            this.columnHeaderemail.Width = 326;
            // 
            // errorProviderclientid
            // 
            this.errorProviderclientid.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvidername
            // 
            this.errorProvidername.ContainerControl = this;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonFile,
            this.toolStripButtonprint});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(791, 27);
            this.toolStrip1.TabIndex = 18;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButtonFile
            // 
            this.toolStripButtonFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFile.Image")));
            this.toolStripButtonFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFile.Name = "toolStripButtonFile";
            this.toolStripButtonFile.Size = new System.Drawing.Size(36, 24);
            this.toolStripButtonFile.Text = "File";
            this.toolStripButtonFile.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButtonprint
            // 
            this.toolStripButtonprint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonprint.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonprint.Image")));
            this.toolStripButtonprint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonprint.Name = "toolStripButtonprint";
            this.toolStripButtonprint.Size = new System.Drawing.Size(43, 24);
            this.toolStripButtonprint.Text = "Print";
            this.toolStripButtonprint.Click += new System.EventHandler(this.toolStripButtonprint_Click_1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelTotalClients});
            this.statusStrip1.Location = new System.Drawing.Point(0, 460);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(791, 26);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelTotalClients
            // 
            this.toolStripStatusLabelTotalClients.Name = "toolStripStatusLabelTotalClients";
            this.toolStripStatusLabelTotalClients.Size = new System.Drawing.Size(97, 20);
            this.toolStripStatusLabelTotalClients.Text = "Total Clients: ";
            this.toolStripStatusLabelTotalClients.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // clearableTextBox1
            // 
            this.clearableTextBox1.Location = new System.Drawing.Point(425, 37);
            this.clearableTextBox1.Name = "clearableTextBox1";
            this.clearableTextBox1.Size = new System.Drawing.Size(150, 143);
            this.clearableTextBox1.TabIndex = 20;
            this.clearableTextBox1.Load += new System.EventHandler(this.clearableTextBox1_Load);
            // 
            // ClientForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(791, 486);
            this.Controls.Add(this.clearableTextBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.listViewClientForm);
            this.Controls.Add(this.btnSubDetails);
            this.Controls.Add(this.btnDeleteClient);
            this.Controls.Add(this.btnEditClient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numClientId);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.ClientForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.ClientForm_DragEnter);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClientForm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.numClientId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderclientid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvidername)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown numClientId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEditClient;
        private System.Windows.Forms.Button btnDeleteClient;
        private System.Windows.Forms.Button btnSubDetails;
        private System.Windows.Forms.ListView listViewClientForm;
        private System.Windows.Forms.ColumnHeader columnHeaderId;
        private System.Windows.Forms.ColumnHeader columnHeadername;
        private System.Windows.Forms.ColumnHeader columnHeaderemail;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProviderclientid;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvidername;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonFile;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTotalClients;
        private System.Windows.Forms.ToolStripButton toolStripButtonprint;
        private ClearableTextBox clearableTextBox1;
    }
}