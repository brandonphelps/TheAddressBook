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
    private List<Contact> toDeleteContacts = new List<Contact>();
    private DataManager DManager;
    private bool saved;
    public Home() 
    {
      InitializeComponent();

      DManager = new DataManager("MyDatabase.sqlite");
      DManager.createTable("contacts", "(book int, name varchar(20), id int)");
      DManager.createTable("books", "(name varchar(20), id int)");
      //DManager.insertIntoTable("contacts", "(book, name)", "('1', 'brad')");
      //DManager.insertIntoTable("contacts", "(book, name)", "('1', 'sean')");
      //DManager.insertIntoTable("contacts", "(book, name)", "('1', 'bradley')");
     
      loadData();
    }

    public void update(bool c)
    {
      saved = c;
      this.Text = c ? "Address Book*" : "Address Book";
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    public Book getBookById(int id)
    {
      foreach(Book b in books)
      {
        if(b.id == id)
        {
          return b;
        }
      }
      return null;
    }

    private void loadData()
    {
      // First load books
      string sql = "select * from books";
      SQLiteCommand command = new SQLiteCommand(sql, DManager.getSQLConn());
      SQLiteDataReader reader = command.ExecuteReader();
      while(reader.Read())
      {
        Book b = new Book((string)reader["name"], (int)reader["id"]);
        b.isSaved = true;
        books.Add(b);
      }


      // Second load contacts into books
      sql = "select * from contacts";
      command = new SQLiteCommand(sql, DManager.getSQLConn());
      reader = command.ExecuteReader();
      while(reader.Read())
      {
        Book b = getBookById((int)reader["book"]);
        if(b == null)
        {
          continue;
        }

        Contact c = new Contact(b, (string)reader["name"], (int)reader["id"]);
        c.isSaved = true;
        b.addPerson(c);
      }
      Books_ListBox.DataSource = books;
    }

    private void saveData()
    {
      if(!saved)
      {
        return;
      }
      
      string sql = "";
      foreach (Book b in books)
      {
        if (!b.isSaved)
        {
          DManager.insertIntoTable("books", "(name, id)", "('" + b.name + "', '" + b.id + "')");
        }
        foreach(Contact c in b.getContacts())
        {
          if (!c.isSaved)
          {
            DManager.insertIntoTable("contacts", "(book, name, id)", "('" + b.id + "', '" + c.name + "', '" + c.id +"')");
          }
        }
      }

      while(toDeleteContacts.Count() > 0)
      {
        Contact c = toDeleteContacts[0];

        DManager.deleteFromTable("contacts", "name='" + c.name + "' and id='" + c.id + "'");

        toDeleteContacts.Remove(c);
      }

      update(false);
    }
    
    private void AddBook_Button_Click(object sender, EventArgs e)
    {
      Book b = new Book("new book");
      books.Add(b);
      Books_ListBox.DataSource = null;
      Books_ListBox.DataSource = books;
      Books_ListBox.SelectedIndex = books.Count() - 1;

      update(true);
    }

    private void AddContact_Button_Click(object sender, EventArgs e)
    {
      Book b = (Book)Books_ListBox.SelectedItem; 
      if(b == null)
      {
        return;
      }
      b.addPerson(new Contact(b, "new contact"));
      Contacts_ListBox.DataSource = null;
      Contacts_ListBox.DataSource = b.getContacts();
      Contacts_ListBox.SelectedIndex = b.getContacts().Count - 1;
      update(true);
    }

    private void displayContactInfo(object sender, EventArgs e)
    {
      Contact c = (Contact)Contacts_ListBox.SelectedItem;
      if(c == null)
      {
        return;
      }
      FirstName_textBox.Text = c.name;
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

   
    private void FirstName_textBox_Enter(object sender, EventArgs e)
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
      Contact c = (Contact)Contacts_ListBox.SelectedItem;
      c.name = FirstName_textBox.Text;
      Contacts_ListBox.DataSource = null;
      Book b = (Book)Books_ListBox.SelectedItem;
      Contacts_ListBox.DataSource = b.getContacts();
    }

    private void MidName_textBox_Enter(object sender, EventArgs e)
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

    private void LastName_textBox_Enter(object sender, EventArgs e)
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

    private void Address_textBox_Enter(object sender, EventArgs e)
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

    private void Phone_textBox_Enter(object sender, EventArgs e)
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

    private void Email_textBox_Enter(object sender, EventArgs e)
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

    private void BookDelete_button_Click(object sender, EventArgs e)
    {
      if(books.Count() < 1)
      {
        return;
      }

      int index = Books_ListBox.SelectedIndex;
      if(index < 0 || index >= books.Count())
      {
        return;
      }
      books.RemoveAt(index);
      Books_ListBox.DataSource = null;
      Books_ListBox.DataSource = books;
      if(index >= books.Count())
      {
        index -= 1;
      }
      Books_ListBox.SelectedIndex = index;
      update(true);
    }

    private void ContactDelete_button_Click(object sender, EventArgs e)
    {
      Book b = (Book)Books_ListBox.SelectedItem;
      if(b == null)
      {
        return; 
      }

      int index = Contacts_ListBox.SelectedIndex;
      if (index < 0 || index >= b.getContacts().Count())
      {
        return;
      }
      Contact c = b.getContacts()[index];
      b.getContacts().RemoveAt(index);
      Contacts_ListBox.DataSource = null;
      Contacts_ListBox.DataSource = b.getContacts();
      if(index >= b.getContacts().Count())
      {
        index -= 1;
      }
      Contacts_ListBox.SelectedIndex = index;
      toDeleteContacts.Add(c);
      update(true);
    }

    private void saveToolStripMenuItem_Click(object sender, EventArgs e)
    {
      saveData();
    }
  }
}
