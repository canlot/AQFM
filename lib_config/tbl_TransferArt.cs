/*
 * Erstellt mit SharpDevelop.
 * Benutzer: Jakob
 * Datum: 11.09.2014
 * Zeit: 13:03
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */
using System;

namespace lib_config
{
	/// <summary>
	/// Description of tbl_SpendeArt.
	/// </summary>
	public class tbl_TransferArt : tbl_Abstract
	{
		
		static public readonly string id = "Id";
		static public readonly string TransferArt = "Transfer Art";
		
		public tbl_TransferArt():base("tbl_TransferArt")
		{
			
			create_table = "create table " + tbl_Name + " ( " +
				id + " int not null auto_increment, " +
				TransferArt + " varchar(100) not null, " +
				"primary key (" + id + " )" + ")";
			
		}
	}
}
