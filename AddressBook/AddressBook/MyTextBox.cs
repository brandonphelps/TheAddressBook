using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace AddressBook
{

  class MyTextBox : TextBox
  {
    private string defaultString { get; set; }
    private Home container { get; set; }
    private int id;
    private static int next_id = 0;
    private bool hasInitalized = false;

    public MyTextBox() : base()
    {
      id = next_id++;
      Console.WriteLine("Creating my textbox with id: " + id);
      this.Enter += new System.EventHandler(this.EnterEnter);
      this.Leave += new System.EventHandler(this.LeaveLeave);
      hasInitalized = false;
    }

    public void init(Home parent, string defaultString)
    {
      //should only be called once. this would be the perfect use for a constructor but well....
      if(hasInitalized)
      {
        return;
      }
      this.container = parent;
      this.defaultString = defaultString;
      this.Text = this.defaultString;
      hasInitalized = true;
    }

    private void EnterEnter(object sender, EventArgs args)
    {
      if(this.Text == this.defaultString)
      {
        this.Clear();
        this.ForeColor = System.Drawing.Color.Black;
      }
    }

    private void LeaveLeave(object sender, EventArgs args)
     {
      MyTextBox instance = (MyTextBox)sender;
      //Console.WriteLine(instance.id);
      if(this.Text == "")
      {
        this.ForeColor = System.Drawing.Color.DimGray;
        this.Text = defaultString;
      }
      if(this.container == null)
      {
        return;
      }

      Contact c = this.container.getSelectedContact();
      if(c == null)
      {
        return;
      }
      switch(instance.Name)
      {
        case "FirstName_TextBox":
          c.firstName = this.Text;
          break;
        case "MidName_TextBox":
          c.middleName = this.Text;
          break;
        case "LastName_TextBox":
          c.lastName = this.Text;
          break;
        case "Address_TextBox":
          c.streetAddress = this.Text;
          break;
        case "Phone_TextBox":
          c.phone = this.Text;
          break;
        case "Email_TextBox":
          c.emailAddress = this.Text;
          break;
      }
     // this.container.addModifyContact(c);
      this.container.refreshContacts();
      this.container.update(true);
    }
    
  }
}
