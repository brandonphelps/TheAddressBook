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
      this.Books_ListBox = new System.Windows.Forms.ListBox();
      this.AddBook_Button = new System.Windows.Forms.Button();
      this.Contacts_ListBox = new System.Windows.Forms.ListBox();
      this.ContactInfo_Panel = new System.Windows.Forms.Panel();
      this.AddContact_Button = new System.Windows.Forms.Button();
      this.Edit_Button = new System.Windows.Forms.Button();
      this.menuStrip1.SuspendLayout();
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
            this.newToolStripMenuItem});
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
      // Books_ListBox
      // 
      this.Books_ListBox.FormattingEnabled = true;
      this.Books_ListBox.Location = new System.Drawing.Point(12, 27);
      this.Books_ListBox.Name = "Books_ListBox";
      this.Books_ListBox.Size = new System.Drawing.Size(120, 381);
      this.Books_ListBox.TabIndex = 1;
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
      this.Contacts_ListBox.FormattingEnabled = true;
      this.Contacts_ListBox.Location = new System.Drawing.Point(138, 27);
      this.Contacts_ListBox.Name = "Contacts_ListBox";
      this.Contacts_ListBox.Size = new System.Drawing.Size(120, 381);
      this.Contacts_ListBox.TabIndex = 3;
      // 
      // ContactInfo_Panel
      // 
      this.ContactInfo_Panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.ContactInfo_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.ContactInfo_Panel.Location = new System.Drawing.Point(264, 27);
      this.ContactInfo_Panel.Name = "ContactInfo_Panel";
      this.ContactInfo_Panel.Size = new System.Drawing.Size(337, 381);
      this.ContactInfo_Panel.TabIndex = 4;
      this.ContactInfo_Panel.Visible = false;
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
      this.Edit_Button.Location = new System.Drawing.Point(264, 409);
      this.Edit_Button.Name = "Edit_Button";
      this.Edit_Button.Size = new System.Drawing.Size(53, 23);
      this.Edit_Button.TabIndex = 6;
      this.Edit_Button.Text = "Edit";
      this.Edit_Button.UseVisualStyleBackColor = true;
      this.Edit_Button.Click += new System.EventHandler(this.Edit_Button_Click);
      // 
      // Home
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(613, 444);
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
  }
}

