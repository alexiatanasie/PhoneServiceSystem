namespace PhoneServiceSystem_
{
    partial class SubscriptionForm
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
            this.btnAddExtraOpt = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdateSubscription = new System.Windows.Forms.Button();
            this.textBoxDescriptionS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMonthlyFee = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSubType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateRegDate = new System.Windows.Forms.DateTimePicker();
            this.listViewSubscription = new System.Windows.Forms.ListView();
            this.columnHeaderclientid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeadersubtype = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderdescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeadermonfee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderregdate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxClients = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.serializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.deleteSubscriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelchart = new System.Windows.Forms.Panel();
            this.labelTotalClients = new System.Windows.Forms.Label();
            this.labelTotalSubscriptions = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddExtraOpt
            // 
            this.btnAddExtraOpt.BackColor = System.Drawing.Color.Yellow;
            this.btnAddExtraOpt.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddExtraOpt.Location = new System.Drawing.Point(449, 232);
            this.btnAddExtraOpt.Name = "btnAddExtraOpt";
            this.btnAddExtraOpt.Size = new System.Drawing.Size(207, 46);
            this.btnAddExtraOpt.TabIndex = 0;
            this.btnAddExtraOpt.Text = "Add Extra &Option";
            this.btnAddExtraOpt.UseVisualStyleBackColor = false;
            this.btnAddExtraOpt.Click += new System.EventHandler(this.btnAddExtraOpt_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(480, 99);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 39);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(480, 168);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 34);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdateSubscription
            // 
            this.btnUpdateSubscription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnUpdateSubscription.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateSubscription.Location = new System.Drawing.Point(480, 39);
            this.btnUpdateSubscription.Name = "btnUpdateSubscription";
            this.btnUpdateSubscription.Size = new System.Drawing.Size(109, 36);
            this.btnUpdateSubscription.TabIndex = 3;
            this.btnUpdateSubscription.Text = "Update";
            this.btnUpdateSubscription.UseVisualStyleBackColor = false;
            this.btnUpdateSubscription.Click += new System.EventHandler(this.btnUpdateSubscription_Click);
            // 
            // textBoxDescriptionS
            // 
            this.textBoxDescriptionS.Location = new System.Drawing.Point(181, 127);
            this.textBoxDescriptionS.Name = "textBoxDescriptionS";
            this.textBoxDescriptionS.Size = new System.Drawing.Size(243, 22);
            this.textBoxDescriptionS.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Azure;
            this.label1.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Description";
            // 
            // textBoxMonthlyFee
            // 
            this.textBoxMonthlyFee.Location = new System.Drawing.Point(181, 180);
            this.textBoxMonthlyFee.Name = "textBoxMonthlyFee";
            this.textBoxMonthlyFee.Size = new System.Drawing.Size(243, 22);
            this.textBoxMonthlyFee.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Azure;
            this.label2.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Monthly Fee";
            // 
            // comboBoxSubType
            // 
            this.comboBoxSubType.FormattingEnabled = true;
            this.comboBoxSubType.Location = new System.Drawing.Point(181, 82);
            this.comboBoxSubType.Name = "comboBoxSubType";
            this.comboBoxSubType.Size = new System.Drawing.Size(243, 24);
            this.comboBoxSubType.TabIndex = 8;
            this.comboBoxSubType.SelectedIndexChanged += new System.EventHandler(this.comboBoxSubType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Azure;
            this.label3.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-4, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Subscription Type";
            // 
            // dateRegDate
            // 
            this.dateRegDate.Location = new System.Drawing.Point(181, 230);
            this.dateRegDate.Name = "dateRegDate";
            this.dateRegDate.Size = new System.Drawing.Size(243, 22);
            this.dateRegDate.TabIndex = 10;
            // 
            // listViewSubscription
            // 
            this.listViewSubscription.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderclientid,
            this.columnHeadersubtype,
            this.columnHeaderdescription,
            this.columnHeadermonfee,
            this.columnHeaderregdate});
            this.listViewSubscription.FullRowSelect = true;
            this.listViewSubscription.HideSelection = false;
            this.listViewSubscription.Location = new System.Drawing.Point(-5, 296);
            this.listViewSubscription.Name = "listViewSubscription";
            this.listViewSubscription.Size = new System.Drawing.Size(1075, 243);
            this.listViewSubscription.TabIndex = 11;
            this.listViewSubscription.UseCompatibleStateImageBehavior = false;
            this.listViewSubscription.View = System.Windows.Forms.View.Details;
            this.listViewSubscription.SelectedIndexChanged += new System.EventHandler(this.listViewSubscription_SelectedIndexChanged);
            // 
            // columnHeaderclientid
            // 
            this.columnHeaderclientid.Text = "Client Id";
            this.columnHeaderclientid.Width = 62;
            // 
            // columnHeadersubtype
            // 
            this.columnHeadersubtype.Text = "Subscription Type";
            this.columnHeadersubtype.Width = 156;
            // 
            // columnHeaderdescription
            // 
            this.columnHeaderdescription.Text = "Description";
            this.columnHeaderdescription.Width = 278;
            // 
            // columnHeadermonfee
            // 
            this.columnHeadermonfee.Text = "Monthly Fee";
            this.columnHeadermonfee.Width = 116;
            // 
            // columnHeaderregdate
            // 
            this.columnHeaderregdate.Text = "Registration Date";
            this.columnHeaderregdate.Width = 273;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Azure;
            this.label4.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Registration Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Azure;
            this.label5.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(77, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Client Id";
            // 
            // comboBoxClients
            // 
            this.comboBoxClients.FormattingEnabled = true;
            this.comboBoxClients.Location = new System.Drawing.Point(181, 39);
            this.comboBoxClients.Name = "comboBoxClients";
            this.comboBoxClients.Size = new System.Drawing.Size(243, 24);
            this.comboBoxClients.TabIndex = 15;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializeToolStripMenuItem,
            this.deserializeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(152, 52);
            // 
            // serializeToolStripMenuItem
            // 
            this.serializeToolStripMenuItem.Name = "serializeToolStripMenuItem";
            this.serializeToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.serializeToolStripMenuItem.Text = "Serialize";
            this.serializeToolStripMenuItem.Click += new System.EventHandler(this.serializeToolStripMenuItem_Click);
            // 
            // deserializeToolStripMenuItem
            // 
            this.deserializeToolStripMenuItem.Name = "deserializeToolStripMenuItem";
            this.deserializeToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.deserializeToolStripMenuItem.Text = "Deserialize";
            this.deserializeToolStripMenuItem.Click += new System.EventHandler(this.deserializeToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteSubscriptionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // deleteSubscriptionToolStripMenuItem
            // 
            this.deleteSubscriptionToolStripMenuItem.Name = "deleteSubscriptionToolStripMenuItem";
            this.deleteSubscriptionToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.deleteSubscriptionToolStripMenuItem.Text = "Delete Subscription";
            this.deleteSubscriptionToolStripMenuItem.Click += new System.EventHandler(this.deleteSubscriptionToolStripMenuItem_Click);
            // 
            // panelchart
            // 
            this.panelchart.Location = new System.Drawing.Point(686, 31);
            this.panelchart.Name = "panelchart";
            this.panelchart.Size = new System.Drawing.Size(256, 259);
            this.panelchart.TabIndex = 18;
            this.panelchart.Paint += new System.Windows.Forms.PaintEventHandler(this.panelchart_Paint);
            // 
            // labelTotalClients
            // 
            this.labelTotalClients.AutoSize = true;
            this.labelTotalClients.Location = new System.Drawing.Point(964, 168);
            this.labelTotalClients.Name = "labelTotalClients";
            this.labelTotalClients.Size = new System.Drawing.Size(81, 16);
            this.labelTotalClients.TabIndex = 19;
            this.labelTotalClients.Text = "Total Clients";
            // 
            // labelTotalSubscriptions
            // 
            this.labelTotalSubscriptions.AutoSize = true;
            this.labelTotalSubscriptions.Location = new System.Drawing.Point(945, 207);
            this.labelTotalSubscriptions.Name = "labelTotalSubscriptions";
            this.labelTotalSubscriptions.Size = new System.Drawing.Size(122, 16);
            this.labelTotalSubscriptions.TabIndex = 20;
            this.labelTotalSubscriptions.Text = "Total Subscriptions";
            // 
            // SubscriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkMagenta;
            this.ClientSize = new System.Drawing.Size(1067, 484);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.labelTotalSubscriptions);
            this.Controls.Add(this.labelTotalClients);
            this.Controls.Add(this.panelchart);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.comboBoxClients);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listViewSubscription);
            this.Controls.Add(this.dateRegDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxSubType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxMonthlyFee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDescriptionS);
            this.Controls.Add(this.btnUpdateSubscription);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddExtraOpt);
            this.Name = "SubscriptionForm";
            this.Text = "SubscriptionForm";
            this.Load += new System.EventHandler(this.SubscriptionForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddExtraOpt;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdateSubscription;
        private System.Windows.Forms.TextBox textBoxDescriptionS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMonthlyFee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSubType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateRegDate;
        private System.Windows.Forms.ListView listViewSubscription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader columnHeaderclientid;
        private System.Windows.Forms.ColumnHeader columnHeadersubtype;
        private System.Windows.Forms.ColumnHeader columnHeaderdescription;
        private System.Windows.Forms.ColumnHeader columnHeadermonfee;
        private System.Windows.Forms.ColumnHeader columnHeaderregdate;
        private System.Windows.Forms.ComboBox comboBoxClients;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem serializeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializeToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteSubscriptionToolStripMenuItem;
        private System.Windows.Forms.Panel panelchart;
        private System.Windows.Forms.Label labelTotalClients;
        private System.Windows.Forms.Label labelTotalSubscriptions;
    }
}