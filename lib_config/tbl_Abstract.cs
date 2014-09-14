/*
 * Erstellt mit SharpDevelop.
 * Benutzer: Jakob
 * Datum: 11.09.2014
 * Zeit: 13:49
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */
using System;

namespace lib_config
{
	/// <summary>
	/// Description of tbl_Abstract.
	/// </summary>
	public abstract class tbl_Abstract
	{
		public readonly string tbl_Name;
		
		private string query;
		
		public string create_table
		{
			get
			{
				return query;
			}
			protected set
			{
				query = value;
			}
		}
		
		public tbl_Abstract(string Name)
		{
			tbl_Name = Name;
		}
	}
}
