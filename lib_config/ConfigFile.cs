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
		
		
		private Dictionary<string, string> properties = new Dictionary<string, string>();
			
		public ConfigFile(string Name)
		{			
			name = Name;
			
			if(File.Exists(name))
				is_created = true;
			else
				is_created = false;
			
			if(is_created)
			{
				foreach(string line in File.ReadAllLines(name))
				{
					string[] temp = line.Split(':');
					properties.Add(temp[0], temp[1]);
				}
			}
			
		}
		
		private void CreateFile()
		{
			if(!is_created)
				File.Create(name);
		}
		public void AddProperty(string key, string var)
		{
			if(is_created)
				File.Delete(name);
			
			properties.Add(key, var);
			WriteFile();
		}
		public string GetValue(string key)
		{
			return properties[key];
		}
		public bool IsProperty(string property)
		{
			if(properties.ContainsKey(property) && !(properties[property] == "")) // :FIXME: probably not working
				return true;
			else
				return false;
		}
		public void AllClear()
		{
			properties.Clear();
		}
		public void WriteFile()
		{
			string[] lines = new string[properties.Count];
			int i = 0;
			foreach(string key in properties.Keys)
			{
				lines[i] = key + ":" + properties[key];
				i++;
			}
			
			File.WriteAllLines(name, lines);
		}
	}
}
