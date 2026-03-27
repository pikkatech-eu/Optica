namespace Optica.TestApp
{
	partial class OpticaTestForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new MenuStrip();
			this.messageBoxesToolStripMenuItem = new ToolStripMenuItem();
			this.simpleToolStripMenuItem = new ToolStripMenuItem();
			this.advancedToolStripMenuItem = new ToolStripMenuItem();
			this.fileDialogToolStripMenuItem = new ToolStripMenuItem();
			this.loadToolStripMenuItem = new ToolStripMenuItem();
			this.saveToolStripMenuItem = new ToolStripMenuItem();
			this.valueDialogToolStripMenuItem = new ToolStripMenuItem();
			this.stringToolStripMenuItem = new ToolStripMenuItem();
			this.integerToolStripMenuItem = new ToolStripMenuItem();
			this.doubleToolStripMenuItem = new ToolStripMenuItem();
			this.dateTimeToolStripMenuItem = new ToolStripMenuItem();
			this.entityDialogToolStripMenuItem = new ToolStripMenuItem();
			this._lvLocations = new ListView();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new Size(20, 20);
			this.menuStrip1.Items.AddRange(new ToolStripItem[] { this.messageBoxesToolStripMenuItem, this.fileDialogToolStripMenuItem, this.valueDialogToolStripMenuItem, this.entityDialogToolStripMenuItem });
			this.menuStrip1.Location = new Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new Size(1024, 28);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// messageBoxesToolStripMenuItem
			// 
			this.messageBoxesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.simpleToolStripMenuItem, this.advancedToolStripMenuItem });
			this.messageBoxesToolStripMenuItem.Name = "messageBoxesToolStripMenuItem";
			this.messageBoxesToolStripMenuItem.Size = new Size(124, 24);
			this.messageBoxesToolStripMenuItem.Text = "&Message Boxes";
			// 
			// simpleToolStripMenuItem
			// 
			this.simpleToolStripMenuItem.Name = "simpleToolStripMenuItem";
			this.simpleToolStripMenuItem.Size = new Size(158, 26);
			this.simpleToolStripMenuItem.Text = "&Simple";
			this.simpleToolStripMenuItem.Click += this.OnSimpleMessageBox;
			// 
			// advancedToolStripMenuItem
			// 
			this.advancedToolStripMenuItem.Name = "advancedToolStripMenuItem";
			this.advancedToolStripMenuItem.Size = new Size(158, 26);
			this.advancedToolStripMenuItem.Text = "&Advanced";
			this.advancedToolStripMenuItem.Click += this.OnAdvancedMessageBox;
			// 
			// fileDialogToolStripMenuItem
			// 
			this.fileDialogToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.loadToolStripMenuItem, this.saveToolStripMenuItem });
			this.fileDialogToolStripMenuItem.Name = "fileDialogToolStripMenuItem";
			this.fileDialogToolStripMenuItem.Size = new Size(95, 24);
			this.fileDialogToolStripMenuItem.Text = "&File Dialog";
			// 
			// loadToolStripMenuItem
			// 
			this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
			this.loadToolStripMenuItem.Size = new Size(125, 26);
			this.loadToolStripMenuItem.Text = "&Load";
			this.loadToolStripMenuItem.Click += this.OnFileDialogLoad;
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new Size(125, 26);
			this.saveToolStripMenuItem.Text = "&Save";
			this.saveToolStripMenuItem.Click += this.OnFileDialogSave;
			// 
			// valueDialogToolStripMenuItem
			// 
			this.valueDialogToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.stringToolStripMenuItem, this.integerToolStripMenuItem, this.doubleToolStripMenuItem, this.dateTimeToolStripMenuItem });
			this.valueDialogToolStripMenuItem.Name = "valueDialogToolStripMenuItem";
			this.valueDialogToolStripMenuItem.Size = new Size(104, 24);
			this.valueDialogToolStripMenuItem.Text = "&ValueDialog";
			// 
			// stringToolStripMenuItem
			// 
			this.stringToolStripMenuItem.Name = "stringToolStripMenuItem";
			this.stringToolStripMenuItem.Size = new Size(157, 26);
			this.stringToolStripMenuItem.Text = "&String";
			this.stringToolStripMenuItem.Click += this.OnValueDialogString;
			// 
			// integerToolStripMenuItem
			// 
			this.integerToolStripMenuItem.Name = "integerToolStripMenuItem";
			this.integerToolStripMenuItem.Size = new Size(157, 26);
			this.integerToolStripMenuItem.Text = "&Integer";
			this.integerToolStripMenuItem.Click += this.OnValueDialogInteger;
			// 
			// doubleToolStripMenuItem
			// 
			this.doubleToolStripMenuItem.Name = "doubleToolStripMenuItem";
			this.doubleToolStripMenuItem.Size = new Size(157, 26);
			this.doubleToolStripMenuItem.Text = "&Double";
			this.doubleToolStripMenuItem.Click += this.OnValueDialogDouble;
			// 
			// dateTimeToolStripMenuItem
			// 
			this.dateTimeToolStripMenuItem.Name = "dateTimeToolStripMenuItem";
			this.dateTimeToolStripMenuItem.Size = new Size(157, 26);
			this.dateTimeToolStripMenuItem.Text = "DateTime";
			this.dateTimeToolStripMenuItem.Click += this.OnValueDialogDatrTime;
			// 
			// entityDialogToolStripMenuItem
			// 
			this.entityDialogToolStripMenuItem.Name = "entityDialogToolStripMenuItem";
			this.entityDialogToolStripMenuItem.Size = new Size(109, 24);
			this.entityDialogToolStripMenuItem.Text = "&Entity Dialog";
			this.entityDialogToolStripMenuItem.Click += this.OnEntityDialog;
			// 
			// _lvLocations
			// 
			this._lvLocations.Dock = DockStyle.Left;
			this._lvLocations.Location = new Point(0, 28);
			this._lvLocations.Name = "_lvLocations";
			this._lvLocations.Size = new Size(291, 671);
			this._lvLocations.TabIndex = 1;
			this._lvLocations.UseCompatibleStateImageBehavior = false;
			// 
			// OpticaTestForm
			// 
			this.AutoScaleDimensions = new SizeF(8F, 20F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.ClientSize = new Size(1024, 699);
			this.Controls.Add(this._lvLocations);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "OpticaTestForm";
			this.Text = "Optica tests";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem messageBoxesToolStripMenuItem;
		private ToolStripMenuItem simpleToolStripMenuItem;
		private ToolStripMenuItem advancedToolStripMenuItem;
		private ToolStripMenuItem fileDialogToolStripMenuItem;
		private ToolStripMenuItem loadToolStripMenuItem;
		private ToolStripMenuItem saveToolStripMenuItem;
		private ToolStripMenuItem valueDialogToolStripMenuItem;
		private ToolStripMenuItem stringToolStripMenuItem;
		private ToolStripMenuItem integerToolStripMenuItem;
		private ToolStripMenuItem doubleToolStripMenuItem;
		private ToolStripMenuItem dateTimeToolStripMenuItem;
		private ToolStripMenuItem entityDialogToolStripMenuItem;
		private ListView _lvLocations;
	}
}
