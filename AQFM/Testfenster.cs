/*
 * Erstellt mit SharpDevelop.
 * Benutzer: Jake
 * Datum: 09.09.2014
 * Zeit: 15:23
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AQFM
{
	/// <summary>
	/// Description of Testfenster.
	/// </summary>
	public partial class Testfenster : Form
	{
		public Testfenster(string test)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			test_ausgabe.Text = test;
		}
	}
}
