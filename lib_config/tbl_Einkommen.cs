/*
 * Erstellt mit SharpDevelop.
 * Benutzer: Jake
 * Datum: 09.09.2014
 * Zeit: 14:32
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */
using System;

namespace lib_config
{
	/// <summary>
	/// Description of tbl_Einkommen.
	/// </summary>
	public class tbl_Einkommen : tbl_Abstract
	{
		
		static public readonly string id = "Id";
		static public readonly string personNr = "personNr";
		static public readonly string betrag = "Betrag";
		static public readonly string waehrungsNr = "waehrungsNr";
		static public readonly string auszugnr = "Auszug";
		static public readonly string transferArtNr = "transferArtNr";
		static public readonly string kontoNr = "kontoNr";
		static public readonly string datum = "Datum";
		
		
		public tbl_Einkommen():base("tbl_Einkommen")
		{
			
			//Tabelle erstellen
			create_table = "create table " + tbl_Name + " ( " +
				id + " int not null auto_increment, " +
				personNr + " int not null, " + 
				betrag + " decimal(10, 2) not null, " +
				waehrungsNr + " int not null, " +
				auszugnr + " int, " +
				transferArtNr + " int not null, " +
				kontoNr + " int not null, " +
				datum + " date not null, " +
				" primary key( " + id + ")" + ")";
			
		}
	}
}
