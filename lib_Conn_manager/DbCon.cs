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
		private bool logged = false;
		
		public bool is_logged
		{
			get
			{
				return logged;
			}
			private set
			{
				logged = value;
			}
		}
		
		
		MySqlConnection conn;
		private string DbName;
		private string DbHost;
		private string UserName;
		private string UserPassword;
		
		public DbCon(string name, string host, string user, string password)
		{
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
		
		public bool ping()
		{
			return conn.Ping();
		}
	}
}
