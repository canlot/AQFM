﻿/*
 * Erstellt mit SharpDevelop.
 * Benutzer: Jakob
 * Datum: 28.09.2014
 * Zeit: 00:08
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */
using System;
using System.Data;

namespace lib_Conn_manager
{
	/// <summary>
	/// Description of DbIncome.
	/// </summary>
	public class DbIncome : DbOp
	{
		
		public DbIncome(DbCon con):base(con)
		{
			
			
		}
		public void FillTable(DataTable table, string tableName)
		{
			//selectCommand = "select from " tableName 
		}
	}
}