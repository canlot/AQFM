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
		public void FillTable(DataTable table, string tableName = "")
		{
			string example = "select tbl_einkommen_9_2014.Id, tbl_person.Name, tbl_waerung.Währung, tbl_transferart.TransferArt " +
				"from tbl_einkommen_9_2014 " +
				"join tbl_person " +
				"on tbl_einkommen_9_2014.personNr = tbl_person.Id "+
				"join tbl_waerung "+
				"on tbl_einkommen_9_2014.waehrungsNr =  tbl_waerung.Id "+
				"join tbl_transferart "+
				"on tbl_einkommen_9_2014.transferArtNr = tbl_transferart.Id";
			
			selectCommand = example;
			adapter.SelectCommand = new MySql.Data.MySqlClient.MySqlCommand(example, connection.connection);
			base.FillTable(table);
		}
	}
}
