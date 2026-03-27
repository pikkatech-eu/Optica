using LoremNET;
using Optica.Contracts;
using Optica.Contracts.Enumerations;

namespace Optica.TestApp
{
	public partial class OpticaTestForm : Form
	{
		internal ICommonDialogService _commonDialogService;

		public OpticaTestForm(ICommonDialogService dialogService)
		{
			InitializeComponent();

			this._commonDialogService = dialogService;
		}

		private void OnSimpleMessageBox(object sender, EventArgs e)
		{
			string message = Lorem.Sentence(5);
			string caption = "Your simple caption";

			this._commonDialogService.ShowMessageBox(caption, message, MessageDialogButtons.Ok, MessageDialogIcons.Information);
		}

		private void OnAdvancedMessageBox(object sender, EventArgs e)
		{
			string message = Lorem.Sentence(5);
			string caption = "Your advanced caption";

			bool result = this._commonDialogService.ShowMessageBox(caption, message, MessageDialogButtons.OkCancel, MessageDialogIcons.Question);

			MessageBox.Show($"Your result was: {result}");
		}

		private void OnFileDialogLoad(object sender, EventArgs e)
		{
			FileDialogOptions options = new FileDialogOptions { FileDialogKind = FileDialogKind.Load, Filter = "Text files (*.txt)|*.txt" };

			string fileName = this._commonDialogService.GetFileName(options);

			this._commonDialogService.ShowMessageBox("You selected to load:", fileName, MessageDialogButtons.Ok, MessageDialogIcons.Information);
		}

		private void OnFileDialogSave(object sender, EventArgs e)
		{
			FileDialogOptions options = new FileDialogOptions { FileDialogKind = FileDialogKind.Save, Filter = "Text files (*.txt)|*.txt" };

			string fileName = this._commonDialogService.GetFileName(options);

			this._commonDialogService.ShowMessageBox("You selected to save as:", fileName, MessageDialogButtons.Ok, MessageDialogIcons.Information);
		}

		private void OnValueDialogString(object sender, EventArgs e)
		{
			string result = this._commonDialogService.GetValue<string>("Get String", "String Value:");
		}

		private void OnValueDialogInteger(object sender, EventArgs e)
		{
			int result = this._commonDialogService.GetValue<int>("Get Integer", "Integer Value:");
		}

		private void OnValueDialogDouble(object sender, EventArgs e)
		{
			double result = this._commonDialogService.GetValue<double>("Get Double", "Double Value:");
		}

		private void OnValueDialogDatrTime(object sender, EventArgs e)
		{
			DateTime result = this._commonDialogService.GetValue<DateTime>("Get DateTime", "DateTime Value:");
		}

		private void OnEntityDialog(object sender, EventArgs e)
		{
			EntityRecord er = new EntityRecord(Lorem.Sentence(3, 5), Lorem.Paragraph(7, 3));

			er = this._commonDialogService.GetEntityRecord(er, "My Record!", "My Rirle", "Comments:");
		}
	}
}
