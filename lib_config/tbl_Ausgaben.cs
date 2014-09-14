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
		
		public readonly string id = "Id";
		public readonly string art = "Art";
		public readonly string verantwortlicher = "Verantwortlicher";
		public readonly string datum = "Datum";
		public readonly string betrag = "Betrag";
		public readonly string auszugnr = "Auszug";
		public readonly string transferArt = "transferArt";
		public readonly string zustaendigkeit = "Zuständigkeit";
		public readonly string bemerkung = "Bemerkung";
		public readonly string kontoNr = "kontoNr";
		
		
		
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
