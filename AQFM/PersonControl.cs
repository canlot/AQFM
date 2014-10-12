/*
 * Erstellt mit SharpDevelop.
 * Benutzer: Jakob
 * Datum: 04.10.2014
 * Zeit: 21:48
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using lib_Conn_manager;
using lib_data_classes;



namespace AQFM
{
	/// <summary>
	/// Description of PersonControl.
	/// </summary>
	public partial class PersonControl : Form
	{
		DbPersonControl control;
		public PersonControl(DbCon con)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			control = new DbPersonControl(con);
		}
		
		
		void PersonControlLoad(object sender, EventArgs e)
		{
			AddIdItems();
		}
		private void AddIdItems()
		{
			foreach(int var in control.GetAllPersonId())
				listBox1_PersonIds.Items.Add(var);
		}
		private void SetPersonValue(int id)
		{
			Person person = control.GetPerson(id);
			id_textBox.Text = person.id.ToString();
			vorname_textBox.Text = person.vorname;
			name_textBox.Text = person.name;
			bic_textBox.Text = person.bic;
			iban_textBox.Text = person.iban;
			plz_textBox.Text = person.plz.ToString();
			ort_textBox.Text = person.ort;
			strasse_textBox.Text = person.strasse;
			hausnummer_textBox.Text = person.hausnummer.ToString();
			telefon_textBox.Text = person.telefon.ToString();
			land_textBox.Text = person.land;
			email_textBox.Text = person.email;
			
		}
		
		void ListBox1_PersonIdsClick(object sender, EventArgs e)
		{
			SetPersonValue(Convert.ToInt32(listBox1_PersonIds.SelectedItem));
		}
	}
}
