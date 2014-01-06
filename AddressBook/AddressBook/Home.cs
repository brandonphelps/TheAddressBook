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
    private List<Book> toDeleteBooks = new List<Book>();
    private List<Contact> toModifyContacts = new List<Contact>();
    private DataManager DManager;
    private bool saved;
    public Home() 
    {
      InitializeComponent();
      InitializeTextBoxes();
      DManager = new DataManager("MyDatabase.sqlite");
      DManager.createTable("contacts", "(book int, id int, first varchar(20), middle varchar(20), last varchar(20))");
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

    public Contact getContactById(int id)
    {
	    Book b = (Book) Books_ListBox.SelectedItem;
	    foreach(Contact c in b.getContacts())
      {
        if(c.id == id)
        {
          return c;
        }
      }
      return null;
    }

    public Contact getSelectedContact()
    {
      return (Contact)Contacts_ListBox.SelectedItem;
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
        Console.WriteLine("Book loaded: " + b.name + ", " + b.id);
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

        Contact c = new Contact(b, (string)reader["first"], (int)reader["id"]);
        c.isSaved = true;
        b.addPerson(c);
      }
      Books_ListBox.DataSource = books;
    }

    private void saveData()
    {
      
      //if(!saved)
      //{
      //  return;
      //}
      
      //modify contacts
      string temp_msg = "";
      while(toModifyContacts.Count() > 0)
      {
        Contact c = toModifyContacts[0];
        temp_msg = "book='" + c.assignedBook.id + "', first='" + c.firstName + "', id='" + c.id + "'";
        DManager.updateAtTable("contacts", temp_msg, "id='" + c.id + "'");
        c.isSaved = true;
        toModifyContacts.Remove(c);
      }

      //save contacts
      string sql = "";
      foreach (Book b in books)
      {
        if (!b.isSaved)
        {
          DManager.insertIntoTable("books", "(name, id)", "('" + b.name + "', '" + b.id + "')");
          b.isSaved = true;
        }
        foreach(Contact c in b.getContacts())
        {
          if (!c.isSaved)
          {
            string ms = DManager.commafy(b.id, c.id, c.firstName, c.middleName, c.lastName);
            Console.WriteLine("(" + ms + ")");
            DManager.insertIntoTable("contacts", "(book, id, first, middle, last)", "(" + ms + ")");
            c.isSaved = true;
          }
        }
      }

      //delete contacts
      while(toDeleteContacts.Count() > 0)
      {
        Contact c = toDeleteContacts[0];

        DManager.deleteFromTable("contacts", "name='" + c.firstName + "' and id='" + c.id + "'");

        toDeleteContacts.Remove(c);
      }

      while(toDeleteBooks.Count() > 0)
      {
        Book b = toDeleteBooks[0];

        DManager.deleteFromTable("contacts", "book='" + b.id + "'");
        Console.WriteLine("Deleting book: " + b.name + ", " + b.id);
        DManager.deleteFromTable("books", "name='" + b.name + "' and id='" + b.id + "'");

        toDeleteBooks.Remove(b);
      }

      update(false);
    }

    public void refreshDataSources()
    {
      Books_ListBox.DataSource = null;
      Books_ListBox.DataSource = books;
      // would change/update contacts_listbox.datasources, but that is done
      // when books_list selected index is changed, and that occurs
      // when datasource is changed
    }
    
    private void AddBook_Button_Click(object sender, EventArgs e)
    {
      Book b = new Book("new book");
      books.Add(b);
      Books_ListBox.DataSource = null;
      Books_ListBox.DataSource = books;
      Books_ListBox.SelectedIndex = books.Count() - 1;
      b.isSaved = false;
      update(true);
    }

    private void AddContact_Button_Click(object sender, EventArgs e)
    {
      Book b = (Book)Books_ListBox.SelectedItem; 
      if(b == null)
      {
        return;
      }
      Contact c = new Contact(b);
      b.addPerson(c);
      Contacts_ListBox.DataSource = null;
      Contacts_ListBox.DataSource = b.getContacts();
      Contacts_ListBox.SelectedIndex = b.getContacts().Count - 1;
      b.isSaved = false;
      c.isSaved = false;

      update(true);
    }

    private void displayContactInfo(object sender, EventArgs e)
    {
      Contact c = (Contact)Contacts_ListBox.SelectedItem;
      if(c == null)
      {
        return;
      }
      //FirstName_textBox.Text = c.firstName;
      //MidName_textBox.Text = c.middleName;
      //LastName_textBox.Text = c.lastName;
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
      Contacts_ListBox.DataSource = null;
      Contacts_ListBox.DataSource = b.getContacts();
    }

    public void addModifyContact(Contact c)
    {
      c.isSaved = false;
      toModifyContacts.Add(c);
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
      Book b = (Book)Books_ListBox.SelectedItem;
      books.RemoveAt(index);
      Books_ListBox.DataSource = null;
      Books_ListBox.DataSource = books;
      if(index >= books.Count())
      {
        index -= 1;
      }
      Books_ListBox.SelectedIndex = index;
      toDeleteBooks.Add(b);
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

    private void myTextBox1_TextChanged(object sender, EventArgs e)
    {

    }
  }
}
