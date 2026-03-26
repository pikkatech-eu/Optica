namespace Optica.WinForms.Dialogs
{
	partial class CommonValueDialog
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommonValueDialog));
			this._btOK = new Button();
			this._btCancel = new Button();
			this._tlpValueDialog = new TableLayoutPanel();
			this.label1 = new Label();
			this._txValue = new TextBox();
			this._tlpValueDialog.SuspendLayout();
			this.SuspendLayout();
			// 
			// _btOK
			// 
			this._btOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			this._btOK.BackColor = SystemColors.Control;
			this._btOK.DialogResult = DialogResult.OK;
			this._btOK.Location = new Point(380, 56);
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
			this._btCancel.Location = new Point(485, 56);
			this._btCancel.Margin = new Padding(0);
			this._btCancel.Name = "_btCancel";
			this._btCancel.Size = new Size(80, 32);
			this._btCancel.TabIndex = 0;
			this._btCancel.Text = "Cancel";
			this._btCancel.UseVisualStyleBackColor = false;
			// 
			// _tlpValueDialog
			// 
			this._tlpValueDialog.ColumnCount = 2;
			this._tlpValueDialog.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			this._tlpValueDialog.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
			this._tlpValueDialog.Controls.Add(this.label1, 0, 0);
			this._tlpValueDialog.Controls.Add(this._txValue, 1, 0);
			this._tlpValueDialog.Dock = DockStyle.Top;
			this._tlpValueDialog.Location = new Point(0, 0);
			this._tlpValueDialog.Name = "_tlpValueDialog";
			this._tlpValueDialog.RowCount = 1;
			this._tlpValueDialog.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			this._tlpValueDialog.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			this._tlpValueDialog.Size = new Size(574, 36);
			this._tlpValueDialog.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = DockStyle.Fill;
			this.label1.Location = new Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new Size(137, 36);
			this.label1.TabIndex = 0;
			this.label1.Text = "Label";
			this.label1.TextAlign = ContentAlignment.MiddleRight;
			// 
			// _txValue
			// 
			this._txValue.Dock = DockStyle.Fill;
			this._txValue.Location = new Point(146, 3);
			this._txValue.Name = "_txValue";
			this._txValue.Size = new Size(425, 27);
			this._txValue.TabIndex = 1;
			// 
			// CommonValueDialog
			// 
			this.AutoScaleDimensions = new SizeF(9F, 20F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = SystemColors.Control;
			this.ClientSize = new Size(574, 97);
			this.Controls.Add(this._tlpValueDialog);
			this.Controls.Add(this._btCancel);
			this.Controls.Add(this._btOK);
			this.Font = new Font("Consolas", 10F);
			this.ForeColor = SystemColors.WindowText;
			this.FormBorderStyle = FormBorderStyle.Fixed3D;
			this.Icon = (Icon)resources.GetObject("$this.Icon");
			this.Name = "CommonValueDialog";
			this.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Value Dialog";
			this._tlpValueDialog.ResumeLayout(false);
			this._tlpValueDialog.PerformLayout();
			this.ResumeLayout(false);
		}

		#endregion

		private Button _btOK;
		private Button _btCancel;
		private TableLayoutPanel _tlpValueDialog;
		private Label label1;
		private TextBox _txValue;
	}
}