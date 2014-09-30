/*
 * Erstellt mit SharpDevelop.
 * Benutzer: Jakob
 * Datum: 28.09.2014
 * Zeit: 00:08
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */
using System;
using System.Data;
using lib_config;


namespace lib_Conn_manager
{
	/// <summary>
	/// Description of DbIncome.
	/// </summary>
	public class DbIncome : DbOp
	{
		public string testString{get; private set;}

		public DbIncome(DbCon con):base(con)
		{
			
			
		}
		public void createSelectQuery(string tableName)
		{
			/*
			string example = "select tbl_einkommen_9_2014.Id, tbl_person.Name, tbl_waerung.Währung, tbl_transferart.TransferArt " +
				"from tbl_einkommen_9_2014 " +
				"join tbl_person " +
				"on tbl_einkommen_9_2014.personNr = tbl_person.Id "+
				"join tbl_waerung "+
				"on tbl_einkommen_9_2014.waehrungsNr =  tbl_waerung.Id "+
				"join tbl_transferart "+
				"on tbl_einkommen_9_2014.transferArtNr = tbl_transferart.Id";
			
			selectCommand = example;
			*/
			
			selectCommand = "select " + GiveFullColumnName(tableName, tbl_Einkommen.id) + 
				GiveFullColumnName(tbl_Person.tbl_Name, tbl_Person.name) + GiveFullColumnName(tbl_Person.tbl_Name, tbl_Person.vorname) +
				GiveFullColumnName(tbl_Person.tbl_Name, tbl_Person.plz) + GiveFullColumnName(tbl_Person.tbl_Name, tbl_Person.ort) +
				GiveFullColumnName(tbl_Person.tbl_Name, tbl_Person.strasse) + GiveFullColumnName(tbl_Person.tbl_Name, tbl_Person.hausnummer) +
				GiveFullColumnName(tbl_Person.tbl_Name, tbl_Person.telefon) + GiveFullColumnName(tbl_Person.tbl_Name, tbl_Person.bic) +
				GiveFullColumnName(tbl_Person.tbl_Name, tbl_Person.iban) + GiveFullColumnName(tbl_Konto.tbl_Name, tbl_Konto.konto) +
				GiveFullColumnName(tbl_Konto.tbl_Name, tbl_Konto.bezeichnung, true) +
				"from " + tableName + " " +
				"join " + tbl_Person.tbl_Name + " " +
				"on " + GiveFullColumnName(tableName, tbl_Einkommen.personNr, true) + " = " + GiveFullColumnName(tbl_Person.tbl_Name, tbl_Person.id, true) +
				"join " + tbl_Konto.tbl_Name + " " +
				"on " + GiveFullColumnName(tableName, tbl_Einkommen.kontoNr, true) + " = " + GiveFullColumnName(tbl_Konto.tbl_Name, tbl_Konto.id, true);
			testString = selectCommand;
			
		}
		public void FillTable(DataTable table, string tableName = "")
		{
			createSelectQuery(tableName);
			
			adapter.SelectCommand = new MySql.Data.MySqlClient.MySqlCommand(selectCommand, connection.connection);
			base.FillTable(table);
		}
	}
}
