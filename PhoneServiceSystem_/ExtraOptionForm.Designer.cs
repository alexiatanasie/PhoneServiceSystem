namespace PhoneServiceSystem_
{
    partial class ExtraOptionForm
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
            this.btnSaveEO = new System.Windows.Forms.Button();
            this.btnCloselEO = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderEOID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderprice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editExtraOptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteExtraOptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSaveEO
            // 
            this.btnSaveEO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSaveEO.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveEO.Location = new System.Drawing.Point(644, 36);
            this.btnSaveEO.Name = "btnSaveEO";
            this.btnSaveEO.Size = new System.Drawing.Size(91, 45);
            this.btnSaveEO.TabIndex = 3;
            this.btnSaveEO.Text = "Save";
            this.btnSaveEO.UseVisualStyleBackColor = false;
            this.btnSaveEO.Click += new System.EventHandler(this.btnSaveEO_Click);
            // 
            // btnCloselEO
            // 
            this.btnCloselEO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCloselEO.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCloselEO.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloselEO.Location = new System.Drawing.Point(644, 118);
            this.btnCloselEO.Name = "btnCloselEO";
            this.btnCloselEO.Size = new System.Drawing.Size(91, 46);
            this.btnCloselEO.TabIndex = 4;
            this.btnCloselEO.Text = "Close";
            this.btnCloselEO.UseVisualStyleBackColor = false;
            this.btnCloselEO.Click += new System.EventHandler(this.btnCloselEO_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Extra Option";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Extra Option Id";
            // 
            // comboBoxName
            // 
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Location = new System.Drawing.Point(189, 103);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(355, 24);
            this.comboBoxName.TabIndex = 10;
            this.comboBoxName.SelectedIndexChanged += new System.EventHandler(this.comboBoxName_SelectedIndexChanged);
            // 
            // textBoxid
            // 
            this.textBoxid.Location = new System.Drawing.Point(189, 47);
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.Size = new System.Drawing.Size(355, 22);
            this.textBoxid.TabIndex = 11;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(189, 160);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(355, 22);
            this.textBoxPrice.TabIndex = 12;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderEOID,
            this.columnHeaderName,
            this.columnHeaderprice});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(47, 188);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(688, 256);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeaderEOID
            // 
            this.columnHeaderEOID.Text = "Extra Option  Id";
            this.columnHeaderEOID.Width = 105;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Extra Option";
            this.columnHeaderName.Width = 243;
            // 
            // columnHeaderprice
            // 
            this.columnHeaderprice.Text = "Price";
            this.columnHeaderprice.Width = 129;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editExtraOptionToolStripMenuItem,
            this.deleteExtraOptionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 28);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editExtraOptionToolStripMenuItem
            // 
            this.editExtraOptionToolStripMenuItem.Name = "editExtraOptionToolStripMenuItem";
            this.editExtraOptionToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.editExtraOptionToolStripMenuItem.Text = "Edit Extra Option";
            this.editExtraOptionToolStripMenuItem.Click += new System.EventHandler(this.editExtraOptionToolStripMenuItem_Click);
            // 
            // deleteExtraOptionToolStripMenuItem
            // 
            this.deleteExtraOptionToolStripMenuItem.Name = "deleteExtraOptionToolStripMenuItem";
            this.deleteExtraOptionToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.deleteExtraOptionToolStripMenuItem.Text = "Delete Extra Option";
            this.deleteExtraOptionToolStripMenuItem.Click += new System.EventHandler(this.deleteExtraOptionToolStripMenuItem_Click);
            // 
            // ExtraOptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(782, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxid);
            this.Controls.Add(this.comboBoxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCloselEO);
            this.Controls.Add(this.btnSaveEO);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ExtraOptionForm";
            this.Text = "ExtraOptionForm";
            this.Load += new System.EventHandler(this.ExtraOptionForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSaveEO;
        private System.Windows.Forms.Button btnCloselEO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxName;
        private System.Windows.Forms.TextBox textBoxid;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderEOID;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderprice;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editExtraOptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteExtraOptionToolStripMenuItem;
    }
}