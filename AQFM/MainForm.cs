﻿/*
 * Erstellt mit SharpDevelop.
 * Benutzer: Jake
 * Datum: 02.09.2014
 * Zeit: 13:19
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */
using System;
using System.Data;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using lib_config;
using lib_Conn_manager;



namespace AQFM
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		DataTable incomeTable = new DataTable();
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			//MessageBox.Show(DateTime.Today.Month.ToString());
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			/*
			tbl_Konto konto = new tbl_Konto();
			Testfenster fenster = new Testfenster(konto.create_table);
			fenster.ShowDialog();
			*/
			/*
			ConfigFile file = new ConfigFile("settings.ini");
			
			//file.AddProperty("DbName", "AQFM");
			file.WriteFile();
			MessageBox.Show(file.GetValue("DbName"));
			*/
			DbCon connection = new DbCon();
			connection.createProperties("127.0.0.1", "aqfm", "root");
			
			if(!connection.createConnection(""))
				MessageBox.Show(connection.State);
			else
			{
				if(!connection.selectDb())
				{
					DbCreate db = new DbCreate(connection);
					Testfenster test = new Testfenster(db.createTables());
					test.ShowDialog();
				}
				
			}
			DbIncome income = new DbIncome(connection);
			income.FillTable(incomeTable, "tbl_einkommen_9_2014");
			dataGridView_income.DataSource = incomeTable;
			
			PersonControl control = new PersonControl(connection);
			control.ShowDialog();
			
			//Testfenster testfenster = new Testfenster(income.testString);
			//testfenster.ShowDialog();
			//income.FillTable(incomeTable);
			//dataGridView_income.DataSource = incomeTable;
			
			//MessageBox.Show(connection.connString);
		}
	}
}
