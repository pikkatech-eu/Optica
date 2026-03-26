namespace Optica.WinForms.Dialogs
{
	partial class EntityDialog
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntityDialog));
			this._btOK = new Button();
			this._btCancel = new Button();
			this.tableLayoutPanel1 = new TableLayoutPanel();
			this._lblTitle = new Label();
			this._lblDescription = new Label();
			this._txTitle = new TextBox();
			this._txDescription = new TextBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// _btOK
			// 
			this._btOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			this._btOK.BackColor = SystemColors.Control;
			this._btOK.DialogResult = DialogResult.OK;
			this._btOK.Location = new Point(9, 171);
			this._btOK.Margin = new Padding(0);
			this._btOK.Name = "_btOK";
			this._btOK.Size = new Size(80, 32);
			this._btOK.TabIndex = 0;
			this._btOK.Text = "OK";
			this._btOK.UseVisualStyleBackColor = false;
			// 
			// _btCancel
			// 
			this._btCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			this._btCancel.BackColor = SystemColors.Control;
			this._btCancel.DialogResult = DialogResult.Cancel;
			this._btCancel.Location = new Point(114, 171);
			this._btCancel.Margin = new Padding(0);
			this._btCancel.Name = "_btCancel";
			this._btCancel.Size = new Size(80, 32);
			this._btCancel.TabIndex = 0;
			this._btCancel.Text = "Cancel";
			this._btCancel.UseVisualStyleBackColor = false;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 115F));
			this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this._lblTitle, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this._lblDescription, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this._txTitle, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this._txDescription, 1, 1);
			this.tableLayoutPanel1.Dock = DockStyle.Top;
			this.tableLayoutPanel1.Location = new Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
			this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 128F));
			this.tableLayoutPanel1.RowStyles.Add(new RowStyle());
			this.tableLayoutPanel1.Size = new Size(537, 159);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// _lblTitle
			// 
			this._lblTitle.AutoSize = true;
			this._lblTitle.Dock = DockStyle.Fill;
			this._lblTitle.Location = new Point(3, 0);
			this._lblTitle.Name = "_lblTitle";
			this._lblTitle.Size = new Size(109, 28);
			this._lblTitle.TabIndex = 0;
			this._lblTitle.Text = "Title";
			this._lblTitle.TextAlign = ContentAlignment.MiddleRight;
			// 
			// _lblDescription
			// 
			this._lblDescription.AutoSize = true;
			this._lblDescription.Dock = DockStyle.Top;
			this._lblDescription.Location = new Point(3, 28);
			this._lblDescription.Name = "_lblDescription";
			this._lblDescription.Size = new Size(109, 20);
			this._lblDescription.TabIndex = 1;
			this._lblDescription.Text = "Description";
			this._lblDescription.TextAlign = ContentAlignment.MiddleRight;
			// 
			// _txTitle
			// 
			this._txTitle.Dock = DockStyle.Fill;
			this._txTitle.Location = new Point(118, 3);
			this._txTitle.Name = "_txTitle";
			this._txTitle.Size = new Size(416, 27);
			this._txTitle.TabIndex = 2;
			// 
			// _txDescription
			// 
			this._txDescription.Dock = DockStyle.Fill;
			this._txDescription.Location = new Point(118, 31);
			this._txDescription.Multiline = true;
			this._txDescription.Name = "_txDescription";
			this._txDescription.Size = new Size(416, 122);
			this._txDescription.TabIndex = 3;
			// 
			// EntityDialog
			// 
			this.AutoScaleDimensions = new SizeF(9F, 20F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = SystemColors.Control;
			this.ClientSize = new Size(537, 212);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this._btCancel);
			this.Controls.Add(this._btOK);
			this.Font = new Font("Consolas", 10F);
			this.ForeColor = SystemColors.WindowText;
			this.FormBorderStyle = FormBorderStyle.Fixed3D;
			this.Icon = (Icon)resources.GetObject("$this.Icon");
			this.Name = "EntityDialog";
			this.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Entity Properties";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
		}

		#endregion

		private Button _btOK;
		private Button _btCancel;
		private TableLayoutPanel tableLayoutPanel1;
		private Label _lblTitle;
		private Label _lblDescription;
		private TextBox _txTitle;
		private TextBox _txDescription;
	}
}