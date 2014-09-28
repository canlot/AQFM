/*
 * Erstellt mit SharpDevelop.
 * Benutzer: Jake
 * Datum: 09.09.2014
 * Zeit: 14:31
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */
using System;

namespace lib_config
{
	/// <summary>
	/// Description of tbl_Ausgaben.
	/// </summary>
	public class tbl_Ausgaben : tbl_Abstract
	{
		
		static public readonly string id = "Id";
		static public readonly string art = "Art";
		static public readonly string verantwortlicher = "Verantwortlicher";
		static public readonly string datum = "Datum";
		static public readonly string betrag = "Betrag";
		static public readonly string auszugnr = "Auszug";
		static public readonly string transferArt = "transferArt";
		static public readonly string zustaendigkeit = "Zuständigkeit";
		static public readonly string bemerkung = "Bemerkung";
		static public readonly string kontoNr = "kontoNr";
		
		
		
		public tbl_Ausgaben():base("tbl_Ausgaben")
		{
			
			
			create_table = "create table " + tbl_Name + " ( " +
				id + " int not null auto_increment, " +
				art + " varchar(200) not null, " +
				verantwortlicher + " varchar(200) not null, " +
				datum + " date not null, " +
				betrag + " decimal(10, 2) not null, " +
				transferArt + " int not null, " +
				zustaendigkeit + " varchar(500), " +
				bemerkung + " varchar(500), "+
				kontoNr + " int not null, " +
				"primary key( " + id + " ) " + " ) ";
				
		}
	}
}
