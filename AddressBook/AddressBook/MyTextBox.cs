using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace AddressBook
{
  class MyTextBox : System.Windows.Forms.TextBox
  {
    private string defaultString {get; set; }
    private Home container;
    private int id;
    private static int next_id = 0;
    public MyTextBox(Home parent, string defaultValue) : base()
    {
      this.container = parent;
      this.defaultString = defaultValue;
      this.Text = this.defaultString;
      this.Enter += new System.EventHandler(this.EnterEnter);
      this.Leave += new System.EventHandler(this.LeaveLeave);
      this.id = next_id++;
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
      Contact c = this.container.getSelectedContact();
      if(c == null)
      {
        return;
      }
      switch(instance.Name)
      {
        case "FirstName_textBox":
          c.firstName = this.Text;
          break;
        case "MidName_textBox":
          c.middleName = this.Text;
          break;
        case "LastName_textBox":
          c.lastName = this.Text;
          break;
        case "Address_textBox":
          c.streetAddress = this.Text;
          break;
        case "Phone_textBox":
          c.phone = this.Text;
          break;
        case "Email_textBox":
          c.emailAddress = this.Text;
          break;
        default:
          return;
      }
      this.container.addModifyContact(c);
      this.container.refreshDataSources();
      this.container.update(true);
    }
  }
}
