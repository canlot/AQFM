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

namespace lib_Conn_manager
{
	/// <summary>
	/// Description of DbCreate.
	/// </summary>
	public class DbCreate
	{
		List<tbl_Abstract> tabellen = new List<tbl_Abstract>();
		
		public DbCreate()
		{
			tabellen.Add(new tbl_Konto());
			tabellen.Add(new tbl_Person());
			tabellen.Add(new tbl_TransferArt());
			tabellen.Add(new tbl_Waehrung());
		}
		public bool createTables(DbCon conn)
		{
			return false;
		}
	}
}
