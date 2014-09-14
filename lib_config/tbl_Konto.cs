/*
 * Erstellt mit SharpDevelop.
 * Benutzer: Jake
 * Datum: 09.09.2014
 * Zeit: 10:59
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */
using System;

namespace lib_config
{
	/// <summary>
	/// Description of tbl_Konto.
	/// </summary>
	public class tbl_Konto : tbl_Abstract
	{
		
		public readonly string id = "Id";
		public readonly string konto = "Konto";
		public readonly string bezeichnung = "Bezeichnung";
		public readonly string kategorie = "Kategorie";
		
		
		
		public tbl_Konto():base("tbl_Konto")
		{
			
			
			//Tabelle erstellen
			create_table = "create table " + tbl_Name + "(" +
				id + " int not null auto_increment, " +
				konto + " int not null, " +
				bezeichnung + " varchar(500), " +
				kategorie + " varchar(500), " +
				"primary key(" + id + ")" + ")";
		}
	}
}
