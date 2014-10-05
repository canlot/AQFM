/*
 * Erstellt mit SharpDevelop.
 * Benutzer: Jakob
 * Datum: 04.10.2014
 * Zeit: 21:48
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */
namespace AQFM
{
	partial class PersonControl
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonControl));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label10 = new System.Windows.Forms.Label();
			this.hausnummer_textBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.ort_textBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.vorname_textBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.id_textBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.strasse_textBox = new System.Windows.Forms.TextBox();
			this.plz_textBox = new System.Windows.Forms.TextBox();
			this.iban_textBox = new System.Windows.Forms.TextBox();
			this.bic_textBox = new System.Windows.Forms.TextBox();
			this.telefon_textBox = new System.Windows.Forms.TextBox();
			this.land_textBox = new System.Windows.Forms.TextBox();
			this.email_textBox = new System.Windows.Forms.TextBox();
			this.name_textBox = new System.Windows.Forms.TextBox();
			this.listBox1_PersonIds = new System.Windows.Forms.ListBox();
			this.groupBox1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tableLayoutPanel2);
			this.groupBox1.Controls.Add(this.tableLayoutPanel1);
			this.groupBox1.Location = new System.Drawing.Point(286, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(524, 485);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Person";
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 4;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel2.Controls.Add(this.button1, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.button2, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.button3, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this.button4, 3, 0);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(9, 397);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(502, 82);
			this.tableLayoutPanel2.TabIndex = 20;
			// 
			// button1
			// 
			this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.Location = new System.Drawing.Point(3, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(119, 76);
			this.button1.TabIndex = 0;
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
			this.button2.Location = new System.Drawing.Point(128, 3);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(119, 76);
			this.button2.TabIndex = 1;
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
			this.button3.Location = new System.Drawing.Point(253, 3);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(119, 76);
			this.button3.TabIndex = 2;
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
			this.button4.Location = new System.Drawing.Point(378, 3);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(121, 76);
			this.button4.TabIndex = 3;
			this.button4.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.51181F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.48819F));
			this.tableLayoutPanel1.Controls.Add(this.label10, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.hausnummer_textBox, 1, 8);
			this.tableLayoutPanel1.Controls.Add(this.label5, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.ort_textBox, 1, 6);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.vorname_textBox, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.id_textBox, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.label6, 0, 6);
			this.tableLayoutPanel1.Controls.Add(this.label7, 0, 7);
			this.tableLayoutPanel1.Controls.Add(this.label8, 0, 8);
			this.tableLayoutPanel1.Controls.Add(this.label9, 0, 9);
			this.tableLayoutPanel1.Controls.Add(this.label11, 0, 11);
			this.tableLayoutPanel1.Controls.Add(this.label12, 0, 10);
			this.tableLayoutPanel1.Controls.Add(this.strasse_textBox, 1, 7);
			this.tableLayoutPanel1.Controls.Add(this.plz_textBox, 1, 5);
			this.tableLayoutPanel1.Controls.Add(this.iban_textBox, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.bic_textBox, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.telefon_textBox, 1, 9);
			this.tableLayoutPanel1.Controls.Add(this.land_textBox, 1, 10);
			this.tableLayoutPanel1.Controls.Add(this.email_textBox, 1, 11);
			this.tableLayoutPanel1.Controls.Add(this.name_textBox, 1, 2);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 28);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 12;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(508, 363);
			this.tableLayoutPanel1.TabIndex = 19;
			// 
			// label10
			// 
			this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label10.Location = new System.Drawing.Point(3, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(148, 30);
			this.label10.TabIndex = 0;
			this.label10.Text = "Id";
			// 
			// hausnummer_textBox
			// 
			this.hausnummer_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.hausnummer_textBox.Location = new System.Drawing.Point(157, 243);
			this.hausnummer_textBox.Name = "hausnummer_textBox";
			this.hausnummer_textBox.Size = new System.Drawing.Size(348, 20);
			this.hausnummer_textBox.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Location = new System.Drawing.Point(3, 150);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(148, 30);
			this.label5.TabIndex = 5;
			this.label5.Text = "PLZ";
			// 
			// ort_textBox
			// 
			this.ort_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ort_textBox.Location = new System.Drawing.Point(157, 183);
			this.ort_textBox.Multiline = true;
			this.ort_textBox.Name = "ort_textBox";
			this.ort_textBox.Size = new System.Drawing.Size(348, 24);
			this.ort_textBox.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Location = new System.Drawing.Point(3, 30);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(148, 30);
			this.label2.TabIndex = 2;
			this.label2.Text = "Vorname";
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Location = new System.Drawing.Point(3, 60);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(148, 30);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name";
			// 
			// vorname_textBox
			// 
			this.vorname_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vorname_textBox.Location = new System.Drawing.Point(157, 33);
			this.vorname_textBox.Multiline = true;
			this.vorname_textBox.Name = "vorname_textBox";
			this.vorname_textBox.Size = new System.Drawing.Size(348, 24);
			this.vorname_textBox.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Location = new System.Drawing.Point(3, 90);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(148, 30);
			this.label3.TabIndex = 3;
			this.label3.Text = "BIC";
			// 
			// id_textBox
			// 
			this.id_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.id_textBox.Location = new System.Drawing.Point(157, 3);
			this.id_textBox.Name = "id_textBox";
			this.id_textBox.Size = new System.Drawing.Size(348, 20);
			this.id_textBox.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label4.Location = new System.Drawing.Point(3, 120);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(148, 30);
			this.label4.TabIndex = 4;
			this.label4.Text = "IBAN";
			// 
			// label6
			// 
			this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label6.Location = new System.Drawing.Point(3, 180);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(148, 30);
			this.label6.TabIndex = 6;
			this.label6.Text = "Ort";
			// 
			// label7
			// 
			this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label7.Location = new System.Drawing.Point(3, 210);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(148, 30);
			this.label7.TabIndex = 7;
			this.label7.Text = "Straße";
			// 
			// label8
			// 
			this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label8.Location = new System.Drawing.Point(3, 240);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(148, 30);
			this.label8.TabIndex = 8;
			this.label8.Text = "Hausnummer";
			// 
			// label9
			// 
			this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label9.Location = new System.Drawing.Point(3, 270);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(148, 30);
			this.label9.TabIndex = 9;
			this.label9.Text = "Telefon";
			// 
			// label11
			// 
			this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label11.Location = new System.Drawing.Point(3, 330);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(148, 33);
			this.label11.TabIndex = 10;
			this.label11.Text = "E-Mail";
			// 
			// label12
			// 
			this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label12.Location = new System.Drawing.Point(3, 300);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(148, 30);
			this.label12.TabIndex = 11;
			this.label12.Text = "Land";
			// 
			// strasse_textBox
			// 
			this.strasse_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.strasse_textBox.Location = new System.Drawing.Point(157, 213);
			this.strasse_textBox.Name = "strasse_textBox";
			this.strasse_textBox.Size = new System.Drawing.Size(348, 20);
			this.strasse_textBox.TabIndex = 8;
			// 
			// plz_textBox
			// 
			this.plz_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.plz_textBox.Location = new System.Drawing.Point(157, 153);
			this.plz_textBox.Name = "plz_textBox";
			this.plz_textBox.Size = new System.Drawing.Size(348, 20);
			this.plz_textBox.TabIndex = 6;
			// 
			// iban_textBox
			// 
			this.iban_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.iban_textBox.Location = new System.Drawing.Point(157, 123);
			this.iban_textBox.Name = "iban_textBox";
			this.iban_textBox.Size = new System.Drawing.Size(348, 20);
			this.iban_textBox.TabIndex = 5;
			// 
			// bic_textBox
			// 
			this.bic_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.bic_textBox.Location = new System.Drawing.Point(157, 93);
			this.bic_textBox.Name = "bic_textBox";
			this.bic_textBox.Size = new System.Drawing.Size(348, 20);
			this.bic_textBox.TabIndex = 4;
			// 
			// telefon_textBox
			// 
			this.telefon_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.telefon_textBox.Location = new System.Drawing.Point(157, 273);
			this.telefon_textBox.Name = "telefon_textBox";
			this.telefon_textBox.Size = new System.Drawing.Size(348, 20);
			this.telefon_textBox.TabIndex = 10;
			// 
			// land_textBox
			// 
			this.land_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.land_textBox.Location = new System.Drawing.Point(157, 303);
			this.land_textBox.Name = "land_textBox";
			this.land_textBox.Size = new System.Drawing.Size(348, 20);
			this.land_textBox.TabIndex = 11;
			// 
			// email_textBox
			// 
			this.email_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.email_textBox.Location = new System.Drawing.Point(157, 333);
			this.email_textBox.Name = "email_textBox";
			this.email_textBox.Size = new System.Drawing.Size(348, 20);
			this.email_textBox.TabIndex = 12;
			// 
			// name_textBox
			// 
			this.name_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.name_textBox.Location = new System.Drawing.Point(157, 63);
			this.name_textBox.Multiline = true;
			this.name_textBox.Name = "name_textBox";
			this.name_textBox.Size = new System.Drawing.Size(348, 24);
			this.name_textBox.TabIndex = 3;
			// 
			// listBox1_PersonIds
			// 
			this.listBox1_PersonIds.FormattingEnabled = true;
			this.listBox1_PersonIds.Location = new System.Drawing.Point(12, 12);
			this.listBox1_PersonIds.Name = "listBox1_PersonIds";
			this.listBox1_PersonIds.Size = new System.Drawing.Size(268, 485);
			this.listBox1_PersonIds.TabIndex = 1;
			this.listBox1_PersonIds.Click += new System.EventHandler(this.ListBox1_PersonIdsClick);
			// 
			// PersonControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(822, 509);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.listBox1_PersonIds);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.Name = "PersonControl";
			this.Text = "PersonControl";
			this.Load += new System.EventHandler(this.PersonControlLoad);
			this.groupBox1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.TextBox email_textBox;
		private System.Windows.Forms.TextBox land_textBox;
		private System.Windows.Forms.TextBox telefon_textBox;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.ListBox listBox1_PersonIds;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox plz_textBox;
		private System.Windows.Forms.TextBox ort_textBox;
		private System.Windows.Forms.TextBox strasse_textBox;
		private System.Windows.Forms.TextBox hausnummer_textBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox id_textBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox vorname_textBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox name_textBox;
		private System.Windows.Forms.TextBox bic_textBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox iban_textBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}
