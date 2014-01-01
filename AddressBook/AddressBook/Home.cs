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
    private List<string> _contacts = new List<string>();
    private DataManager DManager;

    public Home() 
    {
      InitializeComponent();

      DManager = new DataManager("MyDatabase.sqlite");
      DManager.createTable("contacts", "(name varchar(20))");

      //DManager.insertIntoTable("contacts", "(name)", "('brad')");
      //DManager.insertIntoTable("contacts", "(name)", "('sean')");
      //DManager.insertIntoTable("contacts", "(name)", "('bradley')");

      string sql = "select * from contacts";
      SQLiteCommand ttCommand = new SQLiteCommand(sql, DManager.getSQLConn());
      Console.WriteLine("reading contacts table");
      SQLiteDataReader readert = ttCommand.ExecuteReader();
      while (readert.Read())
      {
        Console.WriteLine("Name: " + readert["name"]);
      }
      loadData();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void loadData()
    {
      DManager = new DataManager("MyDatabase.sqlite");
      string sql = "select * from contacts";
      SQLiteCommand command = new SQLiteCommand(sql, DManager.getSQLConn());
      SQLiteDataReader reader = command.ExecuteReader();
      while(reader.Read())
      {
        _contacts.Add((string)reader["name"]);
      }
      Contacts_ListBox.DataSource = _contacts;

      books.Add(new Book());
      Books_ListBox.DataSource = books;
    }

    private void saveData()
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
      _contacts.Add("new contact");
      Contacts_ListBox.DataSource = null;
      Contacts_ListBox.DataSource = _contacts;
      Contacts_ListBox.SelectedIndex = _contacts.Count - 1;
    }

    private void Edit_Button_Click(object sender, EventArgs e)
    {

    }
  }
}
