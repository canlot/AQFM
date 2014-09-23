/*
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

namespace lib_Conn_manager
{
	/// <summary>
	/// Description of DbOp.
	/// </summary>
	public class DbOp
	{
			
		public DbOp()
		{
			
			
		}
		
		
		public bool createConnection(string password)
		{
			connection = new DbCon(dbproperties.GetValue(DbName), 
			                       dbproperties.GetValue(DbHost),
			                       dbproperties.GetValue(DbUser),
			                       password);
			if(connection.connect() && connection.ping())
				return true;
			else
				return false;
		}
		public bool createDb()
		{
			
			return false;
		}
		
	}
}
