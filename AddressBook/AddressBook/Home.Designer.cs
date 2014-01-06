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
      this.AddContact_Button = new System.Windows.Forms.Button();
      this.Edit_Button = new System.Windows.Forms.Button();
      this.AddInfo_Button = new System.Windows.Forms.Button();
      this.BookDelete_button = new System.Windows.Forms.Button();
      this.ContactDelete_button = new System.Windows.Forms.Button();
      this.myTextBox1 = new AddressBook.MyTextBox();
      this.myTextBox2 = new AddressBook.MyTextBox();
      this.myTextBox3 = new AddressBook.MyTextBox();
      this.myTextBox4 = new AddressBook.MyTextBox();
      this.myTextBox5 = new AddressBook.MyTextBox();
      this.myTextBox6 = new AddressBook.MyTextBox();
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
      this.menuStrip1.Size = new System.Drawing.Size(615, 24);
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
      this.ContactInfo_Panel.Controls.Add(this.myTextBox6);
      this.ContactInfo_Panel.Controls.Add(this.myTextBox5);
      this.ContactInfo_Panel.Controls.Add(this.myTextBox4);
      this.ContactInfo_Panel.Controls.Add(this.myTextBox3);
      this.ContactInfo_Panel.Controls.Add(this.myTextBox2);
      this.ContactInfo_Panel.Controls.Add(this.myTextBox1);
      this.ContactInfo_Panel.Controls.Add(this.dateTimePicker1);
      this.ContactInfo_Panel.Controls.Add(this.ContactPicture_pictureBox);
      this.ContactInfo_Panel.Controls.Add(this.BDay_Label);
      this.ContactInfo_Panel.Controls.Add(this.Email_Label);
      this.ContactInfo_Panel.Controls.Add(this.Phone_Label);
      this.ContactInfo_Panel.Controls.Add(this.Address_Label);
      this.ContactInfo_Panel.Controls.Add(this.ContactName_label);
      this.ContactInfo_Panel.Location = new System.Drawing.Point(264, 27);
      this.ContactInfo_Panel.Name = "ContactInfo_Panel";
      this.ContactInfo_Panel.Size = new System.Drawing.Size(337, 379);
      this.ContactInfo_Panel.TabIndex = 10;
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
      this.ContactPicture_pictureBox.Location = new System.Drawing.Point(100, 24);
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
      // myTextBox1
      // 
      this.myTextBox1.Location = new System.Drawing.Point(58, 191);
      this.myTextBox1.Name = "myTextBox1";
      this.myTextBox1.Size = new System.Drawing.Size(57, 20);
      this.myTextBox1.TabIndex = 12;
      this.myTextBox1.Text = "First";
      // 
      // myTextBox2
      // 
      this.myTextBox2.Location = new System.Drawing.Point(121, 191);
      this.myTextBox2.Name = "myTextBox2";
      this.myTextBox2.Size = new System.Drawing.Size(100, 20);
      this.myTextBox2.TabIndex = 13;
      // 
      // myTextBox3
      // 
      this.myTextBox3.Location = new System.Drawing.Point(227, 191);
      this.myTextBox3.Name = "myTextBox3";
      this.myTextBox3.Size = new System.Drawing.Size(100, 20);
      this.myTextBox3.TabIndex = 14;
      // 
      // myTextBox4
      // 
      this.myTextBox4.Location = new System.Drawing.Point(58, 218);
      this.myTextBox4.Name = "myTextBox4";
      this.myTextBox4.Size = new System.Drawing.Size(269, 20);
      this.myTextBox4.TabIndex = 15;
      // 
      // myTextBox5
      // 
      this.myTextBox5.Location = new System.Drawing.Point(61, 245);
      this.myTextBox5.Name = "myTextBox5";
      this.myTextBox5.Size = new System.Drawing.Size(266, 20);
      this.myTextBox5.TabIndex = 16;
      // 
      // myTextBox6
      // 
      this.myTextBox6.Location = new System.Drawing.Point(55, 269);
      this.myTextBox6.Name = "myTextBox6";
      this.myTextBox6.Size = new System.Drawing.Size(272, 20);
      this.myTextBox6.TabIndex = 17;
      // 
      // Home
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(615, 444);
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
    private System.Windows.Forms.Button AddInfo_Button;
    private System.Windows.Forms.Button BookDelete_button;
    private System.Windows.Forms.Button ContactDelete_button;
    private System.Windows.Forms.DateTimePicker dateTimePicker1;
    private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    private MyTextBox myTextBox1;
    private MyTextBox myTextBox6;
    private MyTextBox myTextBox5;
    private MyTextBox myTextBox4;
    private MyTextBox myTextBox3;
    private MyTextBox myTextBox2;
  
    private void InitializeTextBoxes()
    {

    }

  }
}

