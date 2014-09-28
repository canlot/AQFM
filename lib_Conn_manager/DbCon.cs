/*
 * Erstellt mit SharpDevelop.
 * Benutzer: Jake
 * Datum: 17.09.2014
 * Zeit: 14:28
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */
using System;
using System.Data;
using MySql.Data.MySqlClient;
using lib_config;


namespace lib_Conn_manager
{
	/// <summary>
	/// Description of DbCon.
	/// </summary>
	public class DbCon
	{		
		public bool is_logged{get; private set;}
		
		ConfigFile dbproperties = new ConfigFile("DbSettings.ini");
		
		public MySqlConnection connection{get; private set;}
		
		private string DbName;
		private string DbHost;
		private string UserName;
		private string UserPassword;
		
		private string k_DbName = "DbName";
		private string k_DbHost = "DbHost";
		private string k_DbUser = "DbUser";
		
		public bool dbCreated{get; private set;}
		public bool propertiesReady{get; private set;}
		public string State{get; private set;}
		public string connString{get; private set;}
		
		
		public DbCon()
		{
			if(!dbproperties.is_created)
				propertiesReady = false;
			else
			{
				if(al_properties_ready())
					propertiesReady = true;
				else
					propertiesReady = false;
			}
			
			
			
		}
		public bool createConnection(string password)
		{
			if(!propertiesReady)
				return false;
			
			UserPassword = password;
			
			//connection = new MySqlConnection("server = " + DbHost + ";" + " database = " + DbName + ";" + " uid = " + UserName + ";" + " pwd = " + UserPassword + ";");
			connString = "server = " + DbHost + ";" + " uid = " + UserName + ";" + " pwd = " + UserPassword + ";";
			connection = new MySqlConnection(connString);
			
			try
			{
				connection.Open();
				return true;
			}
			catch(MySqlException e)
			{
				//State = e.Number.ToString();
				State = e.Message;
				//State = e.ErrorCode.ToString();
				return false;
			}
				
		}
		public bool selectDb()
		{
			if(!propertiesReady && connection.State == ConnectionState.Open)
				return false;
			try
			{
				connection.ChangeDatabase(DbName);
				return true;
			}
			catch(MySqlException e)
			{
				State = e.Message + " + " + e.Number.ToString() ;
				return false;
			}
		}
				
		private bool al_properties_ready()
		{
			if(dbproperties.IsProperty(k_DbName) && 
			   dbproperties.IsProperty(k_DbHost) && 
			   dbproperties.IsProperty(k_DbUser))
			{
				DbName = dbproperties.GetValue(k_DbName);
				DbHost = dbproperties.GetValue(k_DbHost);
				UserName = dbproperties.GetValue(k_DbUser);
				return true;
			}
			else
				return false;
		}
		public void createProperties(string host, string name, string user)
		{
			dbproperties.AllClear();
			dbproperties.AddProperty(k_DbHost, host);
			dbproperties.AddProperty(k_DbName, name);
			dbproperties.AddProperty(k_DbUser, user);
			dbproperties.WriteFile();
			propertiesReady = true;
		}
	}
}
