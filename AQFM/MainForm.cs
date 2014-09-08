/*
 * Erstellt mit SharpDevelop.
 * Benutzer: Jake
 * Datum: 02.09.2014
 * Zeit: 13:19
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AQFM
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			MessageBox.Show(DateTime.Today.Month.ToString());
		}
	}
}
