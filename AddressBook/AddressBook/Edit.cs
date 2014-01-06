using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook
{
  public partial class Edit : Form
  {
    public Edit()
    {
      InitializeComponent();
    }

    private void EditCancel_Button_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
