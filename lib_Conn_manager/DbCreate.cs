/*
 * Erstellt mit SharpDevelop.
 * Benutzer: Jakob
 * Datum: 17.09.2014
 * Zeit: 17:46
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */
using System;
using System.Collections.Generic;
using lib_config;
using MySql.Data.MySqlClient;

namespace lib_Conn_manager
{
	/// <summary>
	/// Description of DbCreate.
	/// </summary>
	public class DbCreate
	{
		List<tbl_Abstract> tabellen = new List<tbl_Abstract>();
		
		MySqlDataAdapter adapter = new MySqlDataAdapter();
		MySqlCommand command = new MySqlCommand();
		
		DbCon connection;
		
		public DbCreate(DbCon con)
		{
			connection = con;
			adapter.InsertCommand = command;
			command.Connection = connection.connection;
			
			tabellen.Add(new tbl_Konto());
			tabellen.Add(new tbl_Person());
			tabellen.Add(new tbl_TransferArt());
			tabellen.Add(new tbl_Waehrung());
		}
		public string createTables()
		{
			string test = "";
			command.CommandText = "create database if not exists " + connection.DbName + ";";
			command.ExecuteNonQuery();
			test += command.CommandText + "\n";
			foreach(tbl_Abstract tabelle in tabellen)
			{
				command.CommandText = "use " + connection.DbName + " ; " +  tabelle.create_table;
				command.ExecuteNonQuery();
				test += command.CommandText + "\n";
			}
			
			
			return test;
		}
	}
}
