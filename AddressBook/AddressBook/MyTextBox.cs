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
    public MyTextBox(string defaultValue) : base()
    {
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
    }
  }
}
