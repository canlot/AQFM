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

namespace lib_Conn_manager
{
	/// <summary>
	/// Description of DbCon.
	/// </summary>
	public class DbCon
	{		
		public bool is_logged{get; private set;}
		
		ConfigFile dbproperties = new ConfigFile("DbSettings.ini");
		
		private MySqlConnection connection;
		private string DbName;
		private string DbHost;
		private string UserName;
		private string UserPassword;
		
		private string k_DbName = "DbName";
		private string k_DbHost = "DbHost";
		private string k_DbUser = "DbUser";
		
		public bool dbCreated{get; private set;}
		public bool propertiesReady{get; private set;}
		
		public DbCon(string name, string host, string user, string password)
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
			
			DbName = name;
			DbHost = host;
			UserName = user;
			UserPassword = password;
			
			conn = new MySqlConnection("server = " + DbHost + ";" + " database = " + DbName + ";" + " uid = " + UserName + ";" + " pwd = " + UserPassword + ";");
		}
		
		public bool connect()
		{
			try
			{
				conn.Open();
			}
			catch(Exception e)
			{
				return false;
			}
			return true;
		}
		public string getDbName()
		{
			if(propertiesReady)
				return dbproperties.GetValue(DbName);
			else
				return "";
		}
		public string getDbHost()
		{
			if(propertiesReady)
				return dbproperties.GetValue(DbHost);
			else
				return "";
		}
		public string getDbUser()
		{
			if(propertiesReady)
				return dbproperties.GetValue(DbUser);
			else
				return "";
		}
		private bool al_properties_ready()
		{
			if(dbproperties.IsProperty(DbName) && dbproperties.IsProperty(DbHost) && dbproperties.IsProperty(DbUser))
				return true;
			return false;
		}
		public void createProperties(string host, string name, string user)
		{
			dbproperties.AddProperty(DbHost, host);
			dbproperties.AddProperty(DbName, name);
			dbproperties.AddProperty(DbUser, user);
			dbproperties.WriteFile();
			propertiesReady = true;
		}
		public bool ping()
		{
			return conn.Ping();
		}
	}
}
