/*
 * Erstellt mit SharpDevelop.
 * Benutzer: Jake
 * Datum: 04.09.2014
 * Zeit: 21:53
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */
using System;
using lib_config;

namespace lib_Conn_manager
{
	/// <summary>
	/// Description of DbOp.
	/// </summary>
	public class DbOp
	{
		//config File properties keys
		private string DbName = "DbName";
		private string DbHost = "DbHost";
		private string DbUser = "DbUser";
		
		//
		
		ConfigFile dbproperties = new ConfigFile("DbSettings.ini");
		DbCon connection;
		
		public bool dbCreated{get; private set;}
		public bool propertiesReady{get; private set;}
			
		public DbOp()
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
		
		public string getDbName(void)
		{
			if(propertiesReady)
				return dbproperties.GetValue(DbName);
			else
				return "";
		}
		public string getDbHost(void)
		{
			if(propertiesReady)
				return dbproperties.GetValue(DbHost);
			else
				return "";
		}
		public string getDbUser(void)
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
		public bool createConnection(string password)
		{
			
		}
		
	}
}
