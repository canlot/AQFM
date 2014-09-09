/*
 * Erstellt mit SharpDevelop.
 * Benutzer: Jake
 * Datum: 09.09.2014
 * Zeit: 15:23
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */
namespace AQFM
{
	partial class Testfenster
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
			this.test_ausgabe = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// test_ausgabe
			// 
			this.test_ausgabe.Location = new System.Drawing.Point(12, 12);
			this.test_ausgabe.Name = "test_ausgabe";
			this.test_ausgabe.Size = new System.Drawing.Size(513, 293);
			this.test_ausgabe.TabIndex = 0;
			this.test_ausgabe.Text = "";
			// 
			// Testfenster
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(537, 317);
			this.Controls.Add(this.test_ausgabe);
			this.Name = "Testfenster";
			this.Text = "Testfenster";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.RichTextBox test_ausgabe;
	}
}
