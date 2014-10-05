/*
 * Erstellt mit SharpDevelop.
 * Benutzer: Jakob
 * Datum: 05.10.2014
 * Zeit: 14:06
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */
using System;
using lib_config;

namespace lib_data_classes
{
	/// <summary>
	/// Description of Person.
	/// </summary>
	public struct Person //: IEquatable<Person>
	{
		public int id;
		public string name;
		public string vorname;
		public string land;
		public int plz;
		public string ort;
		public string strasse;
		public int hausnummer;
		public int telefon;
		public string email;
		public string bic; //Bankleitzahl
		public string iban; //Kontonummer
		
		/*
		#region Equals and GetHashCode implementation
		// The code in this region is useful if you want to use this structure in collections.
		// If you don't need it, you can just remove the region and the ": IEquatable<Person>" declaration.
		
		public override bool Equals(object obj)
		{
			if (obj is Person)
				return Equals((Person)obj); // use Equals method below
			else
				return false;
		}
		
		public bool Equals(Person other)
		{
			// add comparisions for all members here
			return this.member == other.member;
		}
		
		public override int GetHashCode()
		{
			// combine the hash codes of all members here (e.g. with XOR operator ^)
			return member.GetHashCode();
		}
		
		public static bool operator ==(Person left, Person right)
		{
			return left.Equals(right);
		}
		
		public static bool operator !=(Person left, Person right)
		{
			return !left.Equals(right);
		}
		#endregion
		*/
	}
}
