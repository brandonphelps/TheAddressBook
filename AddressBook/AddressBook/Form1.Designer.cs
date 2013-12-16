namespace AddressBook
{
  partial class Form1
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
      this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.Books_ListBox = new System.Windows.Forms.ListBox();
      this.AddBook_Button = new System.Windows.Forms.Button();
      this.Contacts_ListBox = new System.Windows.Forms.ListBox();
      this.ContactInfo_Panel = new System.Windows.Forms.Panel();
      this.AddContact_Button = new System.Windows.Forms.Button();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem});
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
      this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.newToolStripMenuItem.Text = "New";
      // 
      // personToolStripMenuItem
      // 
      this.personToolStripMenuItem.Name = "personToolStripMenuItem";
      this.personToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.personToolStripMenuItem.Text = "Person";
      // 
      // editToolStripMenuItem
      // 
      this.editToolStripMenuItem.Name = "editToolStripMenuItem";
      this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
      this.editToolStripMenuItem.Text = "Edit";
      // 
      // viewToolStripMenuItem
      // 
      this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
      this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
      this.viewToolStripMenuItem.Text = "View";
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
      // 
      // Contacts_ListBox
      // 
      this.Contacts_ListBox.FormattingEnabled = true;
      this.Contacts_ListBox.Location = new System.Drawing.Point(138, 26);
      this.Contacts_ListBox.Name = "Contacts_ListBox";
      this.Contacts_ListBox.Size = new System.Drawing.Size(120, 381);
      this.Contacts_ListBox.TabIndex = 3;
      // 
      // ContactInfo_Panel
      // 
      this.ContactInfo_Panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.ContactInfo_Panel.Location = new System.Drawing.Point(276, 26);
      this.ContactInfo_Panel.Name = "ContactInfo_Panel";
      this.ContactInfo_Panel.Size = new System.Drawing.Size(325, 381);
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
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(613, 444);
      this.Controls.Add(this.AddContact_Button);
      this.Controls.Add(this.ContactInfo_Panel);
      this.Controls.Add(this.Contacts_ListBox);
      this.Controls.Add(this.AddBook_Button);
      this.Controls.Add(this.Books_ListBox);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
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
    private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
    private System.Windows.Forms.ListBox Books_ListBox;
    private System.Windows.Forms.Button AddBook_Button;
    private System.Windows.Forms.ListBox Contacts_ListBox;
    private System.Windows.Forms.Panel ContactInfo_Panel;
    private System.Windows.Forms.Button AddContact_Button;
  }
}

