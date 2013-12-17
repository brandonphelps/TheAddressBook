using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;


namespace AddressBook
{
  class DataManager
  {
    private static readonly string DATABASELOC = Directory.GetCurrentDirectory() + "\\database";
    private string databaseName;
    SQLiteConnection m_dbConnection;
    private string sql_query;
    public DataManager(string dataName)
    {
      databaseName = DATABASELOC + "\\" + dataName;

      if(!Directory.Exists(DATABASELOC))
      {
        Directory.CreateDirectory(DATABASELOC);
      }

      if(!File.Exists(databaseName))
      {
        SQLiteConnection.CreateFile(databaseName);
      }
      m_dbConnection = new SQLiteConnection("Data Source=" + databaseName + ";Version=3;");
      m_dbConnection.Open();
    }

    public void Close()
    {
      m_dbConnection.Close();
    }
      
    public void createTable(string tableName, string tableParams)
    {
      SQLiteCommand command = null;
      try
      {
        sql_query = "create table " + tableName + " " + tableParams;
        command = new SQLiteCommand(sql_query, m_dbConnection);
        command.ExecuteNonQuery();
      }
      catch(Exception e)
      {
        if(command != null)
        {
          Console.WriteLine("CreateTable: " + command.CommandText);
        }
        Console.WriteLine("Table " + tableName + " already exists bub");
      }
    }

    public void insertIntoTable(string table, string tableForm, string values)
    {
      SQLiteCommand command = null;
      try
      {
        sql_query = "insert into " + table + " " + tableForm + " values " + values;
        command = new SQLiteCommand(sql_query, m_dbConnection);
        command.ExecuteNonQuery();
      }
      catch(Exception e)
      {
        Console.WriteLine("Something something insert went wrong");
        if(command != null)
        {
          Console.WriteLine("Insert Into Table: " + command.CommandText);
        }
      }
    }

    public void selectFromTable(string selectParams, string tableName, string other)
    {
      try
      {

      }
      catch (Exception e)
      {

      }
    }

    public bool checkIfTable(string name)
    {
      return false;
    }

    public SQLiteConnection getSQLConn()
    {
      return m_dbConnection;
    }
  }
}
