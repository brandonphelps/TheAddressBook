using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AddressBook
{
  class CueTextBox : TextBox
  {
    [Localizable(true)]
    public string Cue
    {
      get { return mCue; }
      set { mCue = value; updateCue(); }
    }

    private void updateCue()
    {

    }

    protected override void OnHandleCreated(EventArgs e)
    {
 	    base.OnHandleCreated(e);
    }

    private string mCue;
  }

  
}
