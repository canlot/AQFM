/*
 * Erstellt mit SharpDevelop.
 * Benutzer: Jake
 * Datum: 09.09.2014
 * Zeit: 14:26
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */
using System;

namespace lib_config
{
	/// <summary>
	/// Description of tbl_Person.
	/// </summary>
	public class tbl_Person : tbl_Abstract
	{
		
		static public readonly string id = "Id";
		static public readonly string name = "Name";
		static public readonly string vorname = "Vorname";
		static public readonly string land = "Land";
		static public readonly string plz = "PLZ";
		static public readonly string ort = "Ort";
		static public readonly string strasse = "Strasse";
		static public readonly string hausnummer = "Hausnummer";
		static public readonly string telefon = "Telefon";
		static public readonly string email = "Email";
		static public readonly string bic = "BIC"; //Bankleitzahl
		static public readonly string iban = "IBAN"; //Kontonummer
		
		
		public tbl_Person():base("tbl_Person")
		{
			
			
			//Tabelle erstellen
			create_table = "create table " + tbl_Name + " ( " +
				id + " int not null auto_increment, " +
				name + " varchar(100), " +
				vorname + " varchar(100), " +
				land + " varchar(100), " +
				plz + " int, " +
				ort + " varchar(100), " +
				strasse + " varchar(100), " +
				hausnummer + " int, " +
				telefon + " int, " +
				email + " varchar(100), " +
				bic + " varchar(100), " +
				iban + " varchar(100), " +
				"primary key(" + id + ")" + ")";
				
		}
		
	}
}
