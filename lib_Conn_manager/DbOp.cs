﻿/*
 * Erstellt mit SharpDevelop.
 * Benutzer: Jake
 * Datum: 04.09.2014
 * Zeit: 21:53
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */
using System;
using System.Collections.Generic;
using lib_config;
using System.Data;
using MySql.Data.MySqlClient;


namespace lib_Conn_manager
{
	/// <summary>
	/// Description of DbOp.
	/// </summary>
	public class DbOp
	{
		protected MySqlDataAdapter adapter = new MySqlDataAdapter();
		protected DbCon connection;
		
		protected string insertCommand;
		protected string selectCommand;
		
		
		public DbOp(DbCon con)
		{
			connection = con;
			adapter.SelectCommand = new MySqlCommand();
		}
		
		public void FillTable(DataTable table)
		{
			adapter.Fill(table);
		}
		
		protected string GiveFullColumnName(string tableName, string columnName, bool notKomma = false)
		{
			string delimiter = ".";
			string komma = ",";
			string space = " ";
			if(!notKomma)
				return tableName + delimiter + columnName + komma + space;
			else
				return tableName + delimiter + columnName + space;
		}
		
	}
}
