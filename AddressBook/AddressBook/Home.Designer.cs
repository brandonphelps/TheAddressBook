namespace AddressBook
{
  partial class Home
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
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.personToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.Books_ListBox = new System.Windows.Forms.ListBox();
      this.AddBook_Button = new System.Windows.Forms.Button();
      this.Contacts_ListBox = new System.Windows.Forms.ListBox();
      this.ContactInfo_Panel = new System.Windows.Forms.Panel();
      this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
      this.ContactPicture_pictureBox = new System.Windows.Forms.PictureBox();
      this.BDay_Label = new System.Windows.Forms.Label();
      this.Email_Label = new System.Windows.Forms.Label();
      this.Phone_Label = new System.Windows.Forms.Label();
      this.Address_Label = new System.Windows.Forms.Label();
      this.ContactName_label = new System.Windows.Forms.Label();
      this.LastName_textBox = new System.Windows.Forms.TextBox();
      this.MidName_textBox = new System.Windows.Forms.TextBox();
      this.Address_textBox = new System.Windows.Forms.TextBox();
      this.Phone_textBox = new System.Windows.Forms.TextBox();
      this.Email_textBox = new System.Windows.Forms.TextBox();
      this.FirstName_textBox = new System.Windows.Forms.TextBox();
      this.AddContact_Button = new System.Windows.Forms.Button();
      this.Edit_Button = new System.Windows.Forms.Button();
      this.AddInfo_Button = new System.Windows.Forms.Button();
      this.BookDelete_button = new System.Windows.Forms.Button();
      this.ContactDelete_button = new System.Windows.Forms.Button();
      this.menuStrip1.SuspendLayout();
      this.ContactInfo_Panel.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ContactPicture_pictureBox)).BeginInit();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(613, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem.Text = "File";
      // 
      // newToolStripMenuItem
      // 
      this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personToolStripMenuItem});
      this.newToolStripMenuItem.Name = "newToolStripMenuItem";
      this.newToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
      this.newToolStripMenuItem.Text = "New";
      // 
      // personToolStripMenuItem
      // 
      this.personToolStripMenuItem.Name = "personToolStripMenuItem";
      this.personToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
      this.personToolStripMenuItem.Text = "Person";
      // 
      // saveToolStripMenuItem
      // 
      this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
      this.saveToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
      this.saveToolStripMenuItem.Text = "Save";
      this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
      // 
      // Books_ListBox
      // 
      this.Books_ListBox.BackColor = System.Drawing.SystemColors.ControlDark;
      this.Books_ListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Books_ListBox.FormattingEnabled = true;
      this.Books_ListBox.Location = new System.Drawing.Point(12, 27);
      this.Books_ListBox.Name = "Books_ListBox";
      this.Books_ListBox.Size = new System.Drawing.Size(120, 379);
      this.Books_ListBox.TabIndex = 1;
      this.Books_ListBox.SelectedIndexChanged += new System.EventHandler(this.Books_ListBox_SelectedIndexChanged);
      // 
      // AddBook_Button
      // 
      this.AddBook_Button.Location = new System.Drawing.Point(13, 409);
      this.AddBook_Button.Name = "AddBook_Button";
      this.AddBook_Button.Size = new System.Drawing.Size(53, 23);
      this.AddBook_Button.TabIndex = 2;
      this.AddBook_Button.Text = "Add";
      this.AddBook_Button.UseVisualStyleBackColor = true;
      this.AddBook_Button.Click += new System.EventHandler(this.AddBook_Button_Click);
      // 
      // Contacts_ListBox
      // 
      this.Contacts_ListBox.BackColor = System.Drawing.SystemColors.ControlDark;
      this.Contacts_ListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Contacts_ListBox.FormattingEnabled = true;
      this.Contacts_ListBox.Location = new System.Drawing.Point(138, 27);
      this.Contacts_ListBox.Name = "Contacts_ListBox";
      this.Contacts_ListBox.Size = new System.Drawing.Size(120, 379);
      this.Contacts_ListBox.TabIndex = 3;
      this.Contacts_ListBox.SelectedIndexChanged += new System.EventHandler(this.displayContactInfo);
      // 
      // ContactInfo_Panel
      // 
      this.ContactInfo_Panel.BackColor = System.Drawing.SystemColors.ControlDark;
      this.ContactInfo_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.ContactInfo_Panel.Controls.Add(this.dateTimePicker1);
      this.ContactInfo_Panel.Controls.Add(this.ContactPicture_pictureBox);
      this.ContactInfo_Panel.Controls.Add(this.BDay_Label);
      this.ContactInfo_Panel.Controls.Add(this.Email_Label);
      this.ContactInfo_Panel.Controls.Add(this.Phone_Label);
      this.ContactInfo_Panel.Controls.Add(this.Address_Label);
      this.ContactInfo_Panel.Controls.Add(this.ContactName_label);
      this.ContactInfo_Panel.Controls.Add(this.LastName_textBox);
      this.ContactInfo_Panel.Controls.Add(this.MidName_textBox);
      this.ContactInfo_Panel.Controls.Add(this.Address_textBox);
      this.ContactInfo_Panel.Controls.Add(this.Phone_textBox);
      this.ContactInfo_Panel.Controls.Add(this.Email_textBox);
      this.ContactInfo_Panel.Controls.Add(this.FirstName_textBox);
      this.ContactInfo_Panel.Location = new System.Drawing.Point(264, 27);
      this.ContactInfo_Panel.Name = "ContactInfo_Panel";
      this.ContactInfo_Panel.Size = new System.Drawing.Size(337, 379);
      this.ContactInfo_Panel.TabIndex = 4;
      // 
      // dateTimePicker1
      // 
      this.dateTimePicker1.Location = new System.Drawing.Point(100, 292);
      this.dateTimePicker1.Name = "dateTimePicker1";
      this.dateTimePicker1.Size = new System.Drawing.Size(213, 20);
      this.dateTimePicker1.TabIndex = 6;
      // 
      // ContactPicture_pictureBox
      // 
      this.ContactPicture_pictureBox.BackColor = System.Drawing.SystemColors.ControlDark;
      this.ContactPicture_pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.ContactPicture_pictureBox.Location = new System.Drawing.Point(100, 17);
      this.ContactPicture_pictureBox.Name = "ContactPicture_pictureBox";
      this.ContactPicture_pictureBox.Size = new System.Drawing.Size(164, 135);
      this.ContactPicture_pictureBox.TabIndex = 0;
      this.ContactPicture_pictureBox.TabStop = false;
      // 
      // BDay_Label
      // 
      this.BDay_Label.AutoSize = true;
      this.BDay_Label.Location = new System.Drawing.Point(14, 298);
      this.BDay_Label.Name = "BDay_Label";
      this.BDay_Label.Size = new System.Drawing.Size(48, 13);
      this.BDay_Label.TabIndex = 11;
      this.BDay_Label.Text = "Birthday:";
      // 
      // Email_Label
      // 
      this.Email_Label.AutoSize = true;
      this.Email_Label.Location = new System.Drawing.Point(14, 269);
      this.Email_Label.Name = "Email_Label";
      this.Email_Label.Size = new System.Drawing.Size(35, 13);
      this.Email_Label.TabIndex = 10;
      this.Email_Label.Text = "Email:";
      // 
      // Phone_Label
      // 
      this.Phone_Label.AutoSize = true;
      this.Phone_Label.Location = new System.Drawing.Point(14, 243);
      this.Phone_Label.Name = "Phone_Label";
      this.Phone_Label.Size = new System.Drawing.Size(41, 13);
      this.Phone_Label.TabIndex = 9;
      this.Phone_Label.Text = "Phone:";
      // 
      // Address_Label
      // 
      this.Address_Label.AutoSize = true;
      this.Address_Label.Location = new System.Drawing.Point(14, 217);
      this.Address_Label.Name = "Address_Label";
      this.Address_Label.Size = new System.Drawing.Size(48, 13);
      this.Address_Label.TabIndex = 8;
      this.Address_Label.Text = "Address:";
      // 
      // ContactName_label
      // 
      this.ContactName_label.AutoSize = true;
      this.ContactName_label.Location = new System.Drawing.Point(14, 194);
      this.ContactName_label.Name = "ContactName_label";
      this.ContactName_label.Size = new System.Drawing.Size(38, 13);
      this.ContactName_label.TabIndex = 7;
      this.ContactName_label.Text = "Name:";
      // 
      // LastName_textBox
      // 
      this.LastName_textBox.ForeColor = System.Drawing.Color.DimGray;
      this.LastName_textBox.Location = new System.Drawing.Point(246, 191);
      this.LastName_textBox.Name = "LastName_textBox";
      this.LastName_textBox.Size = new System.Drawing.Size(67, 20);
      this.LastName_textBox.TabIndex = 2;
      this.LastName_textBox.Text = "Last";
      this.LastName_textBox.Enter += new System.EventHandler(this.LastName_textBox_Enter);
      this.LastName_textBox.Leave += new System.EventHandler(this.LastName_textBox_Leave);
      // 
      // MidName_textBox
      // 
      this.MidName_textBox.ForeColor = System.Drawing.Color.DimGray;
      this.MidName_textBox.Location = new System.Drawing.Point(173, 191);
      this.MidName_textBox.Name = "MidName_textBox";
      this.MidName_textBox.Size = new System.Drawing.Size(67, 20);
      this.MidName_textBox.TabIndex = 1;
      this.MidName_textBox.Text = "Middle";
      this.MidName_textBox.Enter += new System.EventHandler(this.MidName_textBox_Enter);
      this.MidName_textBox.Leave += new System.EventHandler(this.MidName_textBox_Leave);
      // 
      // Address_textBox
      // 
      this.Address_textBox.ForeColor = System.Drawing.Color.DimGray;
      this.Address_textBox.Location = new System.Drawing.Point(100, 217);
      this.Address_textBox.Name = "Address_textBox";
      this.Address_textBox.Size = new System.Drawing.Size(213, 20);
      this.Address_textBox.TabIndex = 3;
      this.Address_textBox.Text = "1234 N Sample St. Sample City, Sample 12345";
      this.Address_textBox.Enter += new System.EventHandler(this.Address_textBox_Enter);
      this.Address_textBox.Leave += new System.EventHandler(this.Address_textBox_Leave);
      // 
      // Phone_textBox
      // 
      this.Phone_textBox.ForeColor = System.Drawing.Color.DimGray;
      this.Phone_textBox.Location = new System.Drawing.Point(100, 243);
      this.Phone_textBox.Name = "Phone_textBox";
      this.Phone_textBox.Size = new System.Drawing.Size(213, 20);
      this.Phone_textBox.TabIndex = 4;
      this.Phone_textBox.Text = "(123) 456-7890";
      this.Phone_textBox.Enter += new System.EventHandler(this.Phone_textBox_Enter);
      this.Phone_textBox.Leave += new System.EventHandler(this.Phone_textBox_Leave);
      // 
      // Email_textBox
      // 
      this.Email_textBox.ForeColor = System.Drawing.Color.DimGray;
      this.Email_textBox.Location = new System.Drawing.Point(100, 269);
      this.Email_textBox.Name = "Email_textBox";
      this.Email_textBox.Size = new System.Drawing.Size(213, 20);
      this.Email_textBox.TabIndex = 5;
      this.Email_textBox.Text = "sample@sample.com";
      this.Email_textBox.Enter += new System.EventHandler(this.Email_textBox_Enter);
      this.Email_textBox.Leave += new System.EventHandler(this.Email_textBox_Leave);
      // 
      // FirstName_textBox
      // 
      this.FirstName_textBox.BackColor = System.Drawing.Color.White;
      this.FirstName_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FirstName_textBox.ForeColor = System.Drawing.Color.DimGray;
      this.FirstName_textBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.FirstName_textBox.Location = new System.Drawing.Point(100, 191);
      this.FirstName_textBox.Name = "FirstName_textBox";
      this.FirstName_textBox.Size = new System.Drawing.Size(67, 20);
      this.FirstName_textBox.TabIndex = 0;
      this.FirstName_textBox.Text = "First";
      this.FirstName_textBox.Enter += new System.EventHandler(this.FirstName_textBox_Enter);
      this.FirstName_textBox.Leave += new System.EventHandler(this.FirstName_textBox_Leave);
      // 
      // AddContact_Button
      // 
      this.AddContact_Button.Location = new System.Drawing.Point(138, 409);
      this.AddContact_Button.Name = "AddContact_Button";
      this.AddContact_Button.Size = new System.Drawing.Size(53, 23);
      this.AddContact_Button.TabIndex = 5;
      this.AddContact_Button.Text = "Add";
      this.AddContact_Button.UseVisualStyleBackColor = true;
      this.AddContact_Button.Click += new System.EventHandler(this.AddContact_Button_Click);
      // 
      // Edit_Button
      // 
      this.Edit_Button.Location = new System.Drawing.Point(548, 409);
      this.Edit_Button.Name = "Edit_Button";
      this.Edit_Button.Size = new System.Drawing.Size(53, 23);
      this.Edit_Button.TabIndex = 6;
      this.Edit_Button.Text = "Edit";
      this.Edit_Button.UseVisualStyleBackColor = true;
      this.Edit_Button.Click += new System.EventHandler(this.Edit_Button_Click);
      // 
      // AddInfo_Button
      // 
      this.AddInfo_Button.Location = new System.Drawing.Point(264, 409);
      this.AddInfo_Button.Name = "AddInfo_Button";
      this.AddInfo_Button.Size = new System.Drawing.Size(53, 23);
      this.AddInfo_Button.TabIndex = 7;
      this.AddInfo_Button.Text = "Add";
      this.AddInfo_Button.UseVisualStyleBackColor = true;
      this.AddInfo_Button.Click += new System.EventHandler(this.AddInfo_Button_Click);
      // 
      // BookDelete_button
      // 
      this.BookDelete_button.Location = new System.Drawing.Point(79, 409);
      this.BookDelete_button.Name = "BookDelete_button";
      this.BookDelete_button.Size = new System.Drawing.Size(53, 23);
      this.BookDelete_button.TabIndex = 8;
      this.BookDelete_button.Text = "Delete";
      this.BookDelete_button.UseVisualStyleBackColor = true;
      this.BookDelete_button.Click += new System.EventHandler(this.BookDelete_button_Click);
      // 
      // ContactDelete_button
      // 
      this.ContactDelete_button.Location = new System.Drawing.Point(205, 409);
      this.ContactDelete_button.Name = "ContactDelete_button";
      this.ContactDelete_button.Size = new System.Drawing.Size(53, 23);
      this.ContactDelete_button.TabIndex = 9;
      this.ContactDelete_button.Text = "Delete";
      this.ContactDelete_button.UseVisualStyleBackColor = true;
      this.ContactDelete_button.Click += new System.EventHandler(this.ContactDelete_button_Click);
      // 
      // Home
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(613, 444);
      this.Controls.Add(this.ContactDelete_button);
      this.Controls.Add(this.BookDelete_button);
      this.Controls.Add(this.AddInfo_Button);
      this.Controls.Add(this.Edit_Button);
      this.Controls.Add(this.AddContact_Button);
      this.Controls.Add(this.ContactInfo_Panel);
      this.Controls.Add(this.Contacts_ListBox);
      this.Controls.Add(this.AddBook_Button);
      this.Controls.Add(this.Books_ListBox);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Home";
      this.Text = "Address Book";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ContactInfo_Panel.ResumeLayout(false);
      this.ContactInfo_Panel.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ContactPicture_pictureBox)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem personToolStripMenuItem;
    private System.Windows.Forms.ListBox Books_ListBox;
    private System.Windows.Forms.Button AddBook_Button;
    private System.Windows.Forms.ListBox Contacts_ListBox;
    private System.Windows.Forms.Panel ContactInfo_Panel;
    private System.Windows.Forms.Button AddContact_Button;
    private System.Windows.Forms.Button Edit_Button;
    private System.Windows.Forms.PictureBox ContactPicture_pictureBox;
    private System.Windows.Forms.Label BDay_Label;
    private System.Windows.Forms.Label Email_Label;
    private System.Windows.Forms.Label Phone_Label;
    private System.Windows.Forms.Label Address_Label;
    private System.Windows.Forms.Label ContactName_label;
    private System.Windows.Forms.TextBox LastName_textBox;
    private System.Windows.Forms.TextBox MidName_textBox;
    private System.Windows.Forms.TextBox Address_textBox;
    private System.Windows.Forms.TextBox Phone_textBox;
    private System.Windows.Forms.TextBox Email_textBox;
    private System.Windows.Forms.TextBox FirstName_textBox;
    private System.Windows.Forms.Button AddInfo_Button;
    private System.Windows.Forms.Button BookDelete_button;
    private System.Windows.Forms.Button ContactDelete_button;
    private System.Windows.Forms.DateTimePicker dateTimePicker1;
    private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
  }
}

