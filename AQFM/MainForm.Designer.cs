/*
 * Erstellt mit SharpDevelop.
 * Benutzer: Jake
 * Datum: 02.09.2014
 * Zeit: 13:19
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */
namespace AQFM
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tab_overview = new System.Windows.Forms.TabPage();
			this.tab_income = new System.Windows.Forms.TabPage();
			this.toolStripContainer_income = new System.Windows.Forms.ToolStripContainer();
			this.dataGridView_income = new System.Windows.Forms.DataGridView();
			this.toolStrip_income = new System.Windows.Forms.ToolStrip();
			this.income_add = new System.Windows.Forms.ToolStripButton();
			this.income_change = new System.Windows.Forms.ToolStripButton();
			this.income_delete = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.income_print = new System.Windows.Forms.ToolStripButton();
			this.tab_outgoings = new System.Windows.Forms.TabPage();
			this.toolStripContainer_outgoings = new System.Windows.Forms.ToolStripContainer();
			this.dataGridView_outgoings = new System.Windows.Forms.DataGridView();
			this.toolStrip_outgoings = new System.Windows.Forms.ToolStrip();
			this.outgoings_add = new System.Windows.Forms.ToolStripButton();
			this.outgoings_change = new System.Windows.Forms.ToolStripButton();
			this.outgoings_delete = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.outgoings_print = new System.Windows.Forms.ToolStripButton();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.tabControl.SuspendLayout();
			this.tab_income.SuspendLayout();
			this.toolStripContainer_income.ContentPanel.SuspendLayout();
			this.toolStripContainer_income.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer_income.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_income)).BeginInit();
			this.toolStrip_income.SuspendLayout();
			this.tab_outgoings.SuspendLayout();
			this.toolStripContainer_outgoings.ContentPanel.SuspendLayout();
			this.toolStripContainer_outgoings.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer_outgoings.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_outgoings)).BeginInit();
			this.toolStrip_outgoings.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(679, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer1.Location = new System.Drawing.Point(0, 24);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.tabControl);
			this.splitContainer1.Size = new System.Drawing.Size(679, 296);
			this.splitContainer1.SplitterDistance = 67;
			this.splitContainer1.TabIndex = 1;
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tab_overview);
			this.tabControl.Controls.Add(this.tab_income);
			this.tabControl.Controls.Add(this.tab_outgoings);
			this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl.Location = new System.Drawing.Point(0, 0);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(679, 225);
			this.tabControl.TabIndex = 0;
			// 
			// tab_overview
			// 
			this.tab_overview.Location = new System.Drawing.Point(4, 22);
			this.tab_overview.Name = "tab_overview";
			this.tab_overview.Padding = new System.Windows.Forms.Padding(3);
			this.tab_overview.Size = new System.Drawing.Size(671, 199);
			this.tab_overview.TabIndex = 0;
			this.tab_overview.Text = "Überblick";
			this.tab_overview.UseVisualStyleBackColor = true;
			// 
			// tab_income
			// 
			this.tab_income.Controls.Add(this.toolStripContainer_income);
			this.tab_income.Location = new System.Drawing.Point(4, 22);
			this.tab_income.Name = "tab_income";
			this.tab_income.Padding = new System.Windows.Forms.Padding(3);
			this.tab_income.Size = new System.Drawing.Size(671, 199);
			this.tab_income.TabIndex = 1;
			this.tab_income.Text = "Einkommen";
			this.tab_income.UseVisualStyleBackColor = true;
			// 
			// toolStripContainer_income
			// 
			// 
			// toolStripContainer_income.ContentPanel
			// 
			this.toolStripContainer_income.ContentPanel.Controls.Add(this.dataGridView_income);
			this.toolStripContainer_income.ContentPanel.Size = new System.Drawing.Size(665, 168);
			this.toolStripContainer_income.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer_income.Location = new System.Drawing.Point(3, 3);
			this.toolStripContainer_income.Name = "toolStripContainer_income";
			this.toolStripContainer_income.Size = new System.Drawing.Size(665, 193);
			this.toolStripContainer_income.TabIndex = 0;
			this.toolStripContainer_income.Text = "toolStripContainer1";
			// 
			// toolStripContainer_income.TopToolStripPanel
			// 
			this.toolStripContainer_income.TopToolStripPanel.Controls.Add(this.toolStrip_income);
			// 
			// dataGridView_income
			// 
			this.dataGridView_income.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView_income.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_income.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView_income.Location = new System.Drawing.Point(0, 0);
			this.dataGridView_income.Name = "dataGridView_income";
			this.dataGridView_income.ReadOnly = true;
			this.dataGridView_income.Size = new System.Drawing.Size(665, 168);
			this.dataGridView_income.TabIndex = 0;
			// 
			// toolStrip_income
			// 
			this.toolStrip_income.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStrip_income.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.income_add,
									this.income_change,
									this.income_delete,
									this.toolStripSeparator1,
									this.income_print});
			this.toolStrip_income.Location = new System.Drawing.Point(3, 0);
			this.toolStrip_income.Name = "toolStrip_income";
			this.toolStrip_income.Size = new System.Drawing.Size(110, 25);
			this.toolStrip_income.TabIndex = 0;
			// 
			// income_add
			// 
			this.income_add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.income_add.Image = ((System.Drawing.Image)(resources.GetObject("income_add.Image")));
			this.income_add.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.income_add.Name = "income_add";
			this.income_add.Size = new System.Drawing.Size(23, 22);
			this.income_add.Text = "toolStripButton1";
			// 
			// income_change
			// 
			this.income_change.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.income_change.Image = ((System.Drawing.Image)(resources.GetObject("income_change.Image")));
			this.income_change.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.income_change.Name = "income_change";
			this.income_change.Size = new System.Drawing.Size(23, 22);
			this.income_change.Text = "toolStripButton1";
			// 
			// income_delete
			// 
			this.income_delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.income_delete.Image = ((System.Drawing.Image)(resources.GetObject("income_delete.Image")));
			this.income_delete.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.income_delete.Name = "income_delete";
			this.income_delete.Size = new System.Drawing.Size(23, 22);
			this.income_delete.Text = "toolStripButton1";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// income_print
			// 
			this.income_print.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.income_print.Image = ((System.Drawing.Image)(resources.GetObject("income_print.Image")));
			this.income_print.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.income_print.Name = "income_print";
			this.income_print.Size = new System.Drawing.Size(23, 22);
			this.income_print.Text = "toolStripButton1";
			// 
			// tab_outgoings
			// 
			this.tab_outgoings.Controls.Add(this.toolStripContainer_outgoings);
			this.tab_outgoings.Location = new System.Drawing.Point(4, 22);
			this.tab_outgoings.Name = "tab_outgoings";
			this.tab_outgoings.Padding = new System.Windows.Forms.Padding(3);
			this.tab_outgoings.Size = new System.Drawing.Size(671, 199);
			this.tab_outgoings.TabIndex = 2;
			this.tab_outgoings.Text = "Ausgaben";
			this.tab_outgoings.UseVisualStyleBackColor = true;
			// 
			// toolStripContainer_outgoings
			// 
			// 
			// toolStripContainer_outgoings.ContentPanel
			// 
			this.toolStripContainer_outgoings.ContentPanel.Controls.Add(this.dataGridView_outgoings);
			this.toolStripContainer_outgoings.ContentPanel.Size = new System.Drawing.Size(665, 168);
			this.toolStripContainer_outgoings.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer_outgoings.Location = new System.Drawing.Point(3, 3);
			this.toolStripContainer_outgoings.Name = "toolStripContainer_outgoings";
			this.toolStripContainer_outgoings.Size = new System.Drawing.Size(665, 193);
			this.toolStripContainer_outgoings.TabIndex = 0;
			this.toolStripContainer_outgoings.Text = "toolStripContainer2";
			// 
			// toolStripContainer_outgoings.TopToolStripPanel
			// 
			this.toolStripContainer_outgoings.TopToolStripPanel.Controls.Add(this.toolStrip_outgoings);
			// 
			// dataGridView_outgoings
			// 
			this.dataGridView_outgoings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_outgoings.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView_outgoings.Location = new System.Drawing.Point(0, 0);
			this.dataGridView_outgoings.Name = "dataGridView_outgoings";
			this.dataGridView_outgoings.Size = new System.Drawing.Size(665, 168);
			this.dataGridView_outgoings.TabIndex = 0;
			// 
			// toolStrip_outgoings
			// 
			this.toolStrip_outgoings.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStrip_outgoings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.outgoings_add,
									this.outgoings_change,
									this.outgoings_delete,
									this.toolStripSeparator2,
									this.outgoings_print});
			this.toolStrip_outgoings.Location = new System.Drawing.Point(3, 0);
			this.toolStrip_outgoings.Name = "toolStrip_outgoings";
			this.toolStrip_outgoings.Size = new System.Drawing.Size(110, 25);
			this.toolStrip_outgoings.TabIndex = 0;
			// 
			// outgoings_add
			// 
			this.outgoings_add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.outgoings_add.Image = ((System.Drawing.Image)(resources.GetObject("outgoings_add.Image")));
			this.outgoings_add.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.outgoings_add.Name = "outgoings_add";
			this.outgoings_add.Size = new System.Drawing.Size(23, 22);
			this.outgoings_add.Text = "toolStripButton1";
			// 
			// outgoings_change
			// 
			this.outgoings_change.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.outgoings_change.Image = ((System.Drawing.Image)(resources.GetObject("outgoings_change.Image")));
			this.outgoings_change.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.outgoings_change.Name = "outgoings_change";
			this.outgoings_change.Size = new System.Drawing.Size(23, 22);
			this.outgoings_change.Text = "toolStripButton1";
			// 
			// outgoings_delete
			// 
			this.outgoings_delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.outgoings_delete.Image = ((System.Drawing.Image)(resources.GetObject("outgoings_delete.Image")));
			this.outgoings_delete.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.outgoings_delete.Name = "outgoings_delete";
			this.outgoings_delete.Size = new System.Drawing.Size(23, 22);
			this.outgoings_delete.Text = "toolStripButton1";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// outgoings_print
			// 
			this.outgoings_print.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.outgoings_print.Image = ((System.Drawing.Image)(resources.GetObject("outgoings_print.Image")));
			this.outgoings_print.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.outgoings_print.Name = "outgoings_print";
			this.outgoings_print.Size = new System.Drawing.Size(23, 22);
			this.outgoings_print.Text = "toolStripButton1";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(679, 320);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "AQFM";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.tabControl.ResumeLayout(false);
			this.tab_income.ResumeLayout(false);
			this.toolStripContainer_income.ContentPanel.ResumeLayout(false);
			this.toolStripContainer_income.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer_income.TopToolStripPanel.PerformLayout();
			this.toolStripContainer_income.ResumeLayout(false);
			this.toolStripContainer_income.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_income)).EndInit();
			this.toolStrip_income.ResumeLayout(false);
			this.toolStrip_income.PerformLayout();
			this.tab_outgoings.ResumeLayout(false);
			this.toolStripContainer_outgoings.ContentPanel.ResumeLayout(false);
			this.toolStripContainer_outgoings.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer_outgoings.TopToolStripPanel.PerformLayout();
			this.toolStripContainer_outgoings.ResumeLayout(false);
			this.toolStripContainer_outgoings.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_outgoings)).EndInit();
			this.toolStrip_outgoings.ResumeLayout(false);
			this.toolStrip_outgoings.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripButton outgoings_print;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton outgoings_delete;
		private System.Windows.Forms.ToolStripButton outgoings_change;
		private System.Windows.Forms.ToolStripButton outgoings_add;
		private System.Windows.Forms.ToolStrip toolStrip_outgoings;
		private System.Windows.Forms.ToolStripButton income_print;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton income_delete;
		private System.Windows.Forms.ToolStripButton income_change;
		private System.Windows.Forms.ToolStripButton income_add;
		private System.Windows.Forms.ToolStrip toolStrip_income;
		private System.Windows.Forms.DataGridView dataGridView_outgoings;
		private System.Windows.Forms.ToolStripContainer toolStripContainer_outgoings;
		private System.Windows.Forms.TabPage tab_outgoings;
		private System.Windows.Forms.DataGridView dataGridView_income;
		private System.Windows.Forms.ToolStripContainer toolStripContainer_income;
		private System.Windows.Forms.TabPage tab_income;
		private System.Windows.Forms.TabPage tab_overview;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}
