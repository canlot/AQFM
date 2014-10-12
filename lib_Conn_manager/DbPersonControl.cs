/*
 * Erstellt mit SharpDevelop.
 * Benutzer: Jakob
 * Datum: 05.10.2014
 * Zeit: 13:30
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */
using System;
using System.Data;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using lib_config;
using lib_data_classes;



namespace lib_Conn_manager
{
	/// <summary>
	/// Description of DbPersonControl.
	/// </summary>
	public class DbPersonControl
	{
		DbCon connection;

		public DbPersonControl(DbCon con)
		{
			connection = con;
		}
		public List<int> GetAllPersonId()
		{
			string commandquery = "select + " + tbl_Person.id + " from " + tbl_Person.tbl_Name + " ;";
			List<int> ids = new List<int>();
			MySqlCommand command = new MySqlCommand(commandquery, connection.connection);
			MySqlDataReader reader = command.ExecuteReader();
			
			while(reader.Read())
			{
				ids.Add(reader.GetInt32(tbl_Person.id));
			}
			reader.Close();
			return ids;
		}
		
		public Person GetPerson(int id)
		{
			string commandquery = "select * from " + tbl_Person.tbl_Name + " where " +  tbl_Person.id + " = " + id  + " ;";

			MySqlCommand command = new MySqlCommand(commandquery, connection.connection);
			MySqlDataReader reader = command.ExecuteReader();
			
			Person person = new Person();
			
			while(reader.Read())
			{
				if(!reader.IsDBNull(reader.GetOrdinal(tbl_Person.id))
					person.id = reader.GetInt32(tbl_Person.id);
					
				person.vorname = reader.GetString(tbl_Person.vorname);
				person.name = reader.GetString(tbl_Person.name);
				person.iban = reader.GetString(tbl_Person.iban);
				person.bic = reader.GetString(tbl_Person.bic);
				person.plz = reader.GetInt32(tbl_Person.plz);
				person.ort = reader.GetString(tbl_Person.ort);
				person.strasse = reader.GetString(tbl_Person.strasse);
				person.hausnummer = reader.GetInt32(tbl_Person.hausnummer);
				person.telefon = reader.GetInt32(tbl_Person.telefon);
				person.land = reader.GetString(tbl_Person.land);
				person.email = reader.GetString(tbl_Person.email);
			}
			reader.Close();
			return person;
		}
		
	}
}
