using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace AddressBook
{
  public partial class Home : Form
  {
    private List<Book> books = new List<Book>();
    private DataManager DManager;

    public Home() 
    {
      InitializeComponent();

      DManager = new DataManager("MyDatabase.sqlite");
      DManager.createTable("contacts", "(name varchar(20))");

      DManager.insertIntoTable("contacts", "(name)", "('brad')");
      DManager.insertIntoTable("contacts", "(name)", "('sean')");
      DManager.insertIntoTable("contacts", "(name)", "('bradley')");

      string sql = "select * from contacts";
      SQLiteCommand ttCommand = new SQLiteCommand(sql, DManager.getSQLConn());
      Console.WriteLine("reading contacts table");
      SQLiteDataReader readert = ttCommand.ExecuteReader();
      while (readert.Read())
      {
        Console.WriteLine("Name: " + readert["name"]);
      }
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    public void displayBook()
    { 
          
    }
    
    private void AddBook_Button_Click(object sender, EventArgs e)
    {

    }

    private void AddContact_Button_Click(object sender, EventArgs e)
    {

    }

    private void Edit_Button_Click(object sender, EventArgs e)
    {

    }
  }
}
