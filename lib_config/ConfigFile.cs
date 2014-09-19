/*
 * Erstellt mit SharpDevelop.
 * Benutzer: Jake
 * Datum: 17.09.2014
 * Zeit: 23:13
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */
using System;
using System.Data;
using System.IO;
using System.Collections.Generic;

namespace lib_config
{
	/// <summary>
	/// Description of ConfigFile.
	/// </summary>
	public class ConfigFile
	{
		//FileInfo file;
		public bool is_created{get; private set;}
		
		private string name;
		
		Dictionary<string, string> info;
			
		public ConfigFile(string Name)
		{
			name = Name;
			
			if(File.Exists(name))
				is_created = true;
			
			
			
			
			if(is_created)
			{
				foreach(string line in File.ReadAllLines(name))
				{
					string[] temp = line.Split(':');
					info.Add(temp[0], temp[1]);
				}
			}
			
		}
	}
}
