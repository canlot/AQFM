﻿/*
 * Erstellt mit SharpDevelop.
 * Benutzer: Jakob
 * Datum: 11.09.2014
 * Zeit: 13:26
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */
using System;

namespace lib_config
{
	/// <summary>
	/// Description of tbl_Waehrung.
	/// </summary>
	public class tbl_Waehrung : tbl_Abstract
	{
		static public readonly string tbl_Name = "tbl_Waerung";
		
		static public readonly string id = "Id";
		static public readonly string waerung = "Währung";
		
		public tbl_Waehrung()
		{
			
			create_table = "create table " + tbl_Name + "( " +
				id + " int not null auto_increment, " +
				waerung + " varchar(100) not null, " +
				"primary key " + "(" + id + ")" + ")";
		}
	}
}
