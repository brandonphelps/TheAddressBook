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
      Book b = new Book("First");

      while(reader.Read())
      {
        b.addPerson(new Contact((string)reader["name"]));
      }
      books.Add(b);
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
      Book b = new Book("new book");
      books.Add(b);
      Books_ListBox.DataSource = null;
      Books_ListBox.DataSource = books;
      Books_ListBox.SelectedIndex = books.Count() - 1;
    }

    private void AddContact_Button_Click(object sender, EventArgs e)
    {
      Book b = (Book)Books_ListBox.SelectedItem;  
      b.addPerson(new Contact("new contact"));
      Contacts_ListBox.DataSource = null;
      Contacts_ListBox.DataSource = b.getContacts();
      Contacts_ListBox.SelectedIndex = b.getContacts().Count - 1;
    }

    private void Edit_Button_Click(object sender, EventArgs e)
    {

    }

    private void AddInfo_Button_Click(object sender, EventArgs e)
    {

    }

    private void Books_ListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      Book b = (Book)Books_ListBox.SelectedItem;
      if(b == null)
      {
        return;
      }
      Contacts_ListBox.DataSource = b.getContacts();

    }

    private void FirstName_textBox_Click(object sender, EventArgs e)
    {
      if (FirstName_textBox.Text == "First")
      {
        FirstName_textBox.Clear();
        FirstName_textBox.ForeColor = System.Drawing.Color.Black;
      }
    }

    private void FirstName_textBox_Leave(object sender, EventArgs e)
    {
      if (FirstName_textBox.Text == "")
      {
        FirstName_textBox.ForeColor = System.Drawing.Color.DimGray;
        FirstName_textBox.Text = "First";
      }
    }

    private void MidName_textBox_Click(object sender, EventArgs e)
    {
      if (MidName_textBox.Text == "Middle")
      {
        MidName_textBox.Clear();
        MidName_textBox.ForeColor = System.Drawing.Color.Black;
      }
    }

    private void MidName_textBox_Leave(object sender, EventArgs e)
    {
      if (MidName_textBox.Text == "")
      {
        MidName_textBox.ForeColor = System.Drawing.Color.DimGray;
        MidName_textBox.Text = "Middle";
      }
    }

    private void LastName_textBox_Click(object sender, EventArgs e)
    {
      if (LastName_textBox.Text == "Last")
      {
        LastName_textBox.Clear();
        LastName_textBox.ForeColor = System.Drawing.Color.Black;
      }
    }

    private void LastName_textBox_Leave(object sender, EventArgs e)
    {
      if (LastName_textBox.Text == "")
      {
        LastName_textBox.ForeColor = System.Drawing.Color.DimGray;
        LastName_textBox.Text = "Last";
      }
    }

    private void Address_textBox_Click(object sender, EventArgs e)
    {
      if (Address_textBox.Text == "1234 N Sample St. Sample City, Sample 12345")
      {
        Address_textBox.Clear();
        Address_textBox.ForeColor = System.Drawing.Color.Black;
      }
    }

    private void Address_textBox_Leave(object sender, EventArgs e)
    {
      if (Address_textBox.Text == "")
      {
        Address_textBox.ForeColor = System.Drawing.Color.DimGray;
        Address_textBox.Text = "1234 N Sample St. Sample City, Sample 12345";
      }
    }

    private void Phone_textBox_Click(object sender, EventArgs e)
    {
      if (Phone_textBox.Text == "(123) 456-7890")
      {
        Phone_textBox.Clear();
        Phone_textBox.ForeColor = System.Drawing.Color.Black;
      }
    }

    private void Phone_textBox_Leave(object sender, EventArgs e)
    {
      if (Phone_textBox.Text == "")
      {
        Phone_textBox.ForeColor = System.Drawing.Color.DimGray;
        Phone_textBox.Text = "(123) 456-7890";
      }
    }

    private void Email_textBox_Click(object sender, EventArgs e)
    {
      if (Email_textBox.Text == "sample@sample.com")
      {
        Email_textBox.Clear();
        Email_textBox.ForeColor = System.Drawing.Color.Black;
      }
    }

    private void Email_textBox_Leave(object sender, EventArgs e)
    {
      if (Email_textBox.Text == "")
      {
        Email_textBox.ForeColor = System.Drawing.Color.DimGray;
        Email_textBox.Text = "sample@sample.com";
      }
    }

    
   
  }
}
