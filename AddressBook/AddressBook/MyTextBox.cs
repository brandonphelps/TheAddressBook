using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
  class MyTextBox : System.Windows.Forms.TextBox
  {
    private string defaultString {get; set; }
    private Home container;
    public MyTextBox(Home parent, string defaultValue) : base()
    {
      this.container = parent;
      this.defaultString = defaultValue;
      this.Text = this.defaultString;
      this.Enter += new System.EventHandler(this.EnterEnter);
      this.Leave += new System.EventHandler(this.LeaveLeave);
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
      c.name = this.Text;
      this.container.addModifyContact(c);
      this.container.refreshDataSources();
    }
  }
}
