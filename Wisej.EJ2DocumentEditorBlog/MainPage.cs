
using Newtonsoft.Json;
using Syncfusion.EJ2.DocumentEditor;
using System;
using System.IO;
using Wisej.Ext.ClientFileSystem;
using Wisej.Web;

namespace Wisej.EJ2DocumentEditorBlog
{
	/// <summary>
	/// The application's main page.
	/// </summary>
	public partial class MainPage : Page
	{
		/// <summary>
		/// The selected file view.
		/// </summary>
		private FileItemView selectedFileView;

		/// <summary>
		/// The selected client-side directory.
		/// </summary>
		private Ext.ClientFileSystem.Directory directory;

		/// <summary>
		/// Creates a new instance of <see cref="MainPage"/>.
		/// </summary>
		public MainPage()
		{
			InitializeComponent();
		}

		private void MainPage_Load(object sender, EventArgs e)
		{
			Application.ApplicationRefresh += Application_ApplicationRefresh;
		}

		/// <summary>
		/// Handle the application refresh.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Application_ApplicationRefresh(object sender, EventArgs e)
		{
			// client-side file handles expire on page refresh.
			this.selectedFileView = null;
			this.flowLayoutPanelFiles.Controls.Clear();
		}

        #region Server File System

        /// <summary>
        /// Loads a file that's located on the server's file system.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLoadServerFile_Click(object sender, EventArgs e)
		{
			var loadPath = Application.MapPath("Test.docx");
			using (var fs = new FileStream(loadPath, FileMode.Open))
			{
				var document = WordDocument.Load(fs, FormatType.Docx);
				var sfdt = JsonConvert.SerializeObject(document);
				this.documentEditor1.OpenFile(sfdt);
			}

			this.buttonSaveToServer.Enabled = true;
		}

		/// <summary>
		/// Saves a file to the server's file system.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private async void buttonSaveToServer_Click(object sender, EventArgs e)
		{
			var savePath = Application.MapPath("Test.docx");
			var document = await this.documentEditor1.GetDocumentAsync();

			System.IO.File.WriteAllBytes(savePath, document.ToArray());

			AlertBox.Show("Saved as Test.docx");
		}

		#endregion

		#region Client File System

		/// <summary>
		/// Loads files from the client's file system.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private async void buttonSelectClientDirectory_Click(object sender, EventArgs e)
		{
			// get client docx files.
			this.directory = await ClientFileSystem.ShowDirectoryPickerAsync();
			var permission = await this.directory.RequestPermissionAsync(Permission.ReadWrite);

			LoadClientFiles();

			this.buttonCreateFile.Enabled = true;
		}

		/// <summary>
		/// Saves a file to the client using existing file access.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private async void buttonSaveToClient_Click(object sender, EventArgs e)
		{
			var document = await this.documentEditor1.GetDocumentAsync();
			if (this.selectedFileView != null)
			{
				this.selectedFileView.Save(document.ToArray());
			}
			else
			{
				var file = await ClientFileSystem.ShowSaveFilePickerAsync(false, "*.docx", "Test.docx");
				await file.WriteBytesAsync(document.ToArray(), 0, WritableType.Write, false);
			}

			AlertBox.Show("File Saved");
		}
		
		/// <summary>
		/// Creates a new file in the client's file system.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private async void buttonCreateFile_Click(object sender, EventArgs e)
		{
			if (this.directory == null)
			{
				AlertBox.Show("Select a Client Directory First.");
				return;
			}

			var file = await this.directory.GetFileAsync($"MyDocument-{DateTime.Now.ToString("yyyyMMddHHmmss")}.docx", true);
			AddFileItemView(file);
		}

		/// <summary>
		/// Opens the client-side document in Word.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private async void buttonOpenWord_Click(object sender, EventArgs e)
		{
			if (this.selectedFileView == null)
			{
				AlertBox.Show("No client file selected.", MessageBoxIcon.Error);
				return;
			}

			// get the path of the document's directory.
			var path = await Application.PromptAsync("Enter Document Parent Directory (no spaces)", "F:/Play");
			if (path == null)
				return;

			// open word using the custom scheme.
			Application.Navigate($"ms-word:ofe|u|{path}/{this.selectedFileView.File.Name}");
		}

		private async void LoadClientFiles()
        {
			var files = await this.directory.GetFilesAsync("*.docx");

			if (files.Length == 0)
				MessageBox.Show("No .docx files found. Try a different directory.");

			// add a view for each file.
			foreach (var file in files)
				AddFileItemView(file);
		}

        #endregion

		/// <summary>
		/// Adds a new <see cref="FileItemView"/> to the <see cref="flowLayoutPanelFiles"/>.
		/// </summary>
		/// <param name="file"></param>
        private void AddFileItemView(Ext.ClientFileSystem.File file)
        {
			var fileItemView = new FileItemView(file);

			fileItemView.Click += FileItemView_Click;

			// constrain view within a FlowLayoutPanel.
			this.flowLayoutPanelFiles.Controls.Add(fileItemView);
			this.flowLayoutPanelFiles.SetFillWeight(fileItemView, 1);
			this.flowLayoutPanelFiles.SetFlowBreak(fileItemView, true);
		}

		/// <summary>
		/// Handle a FileItemView click.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private async void FileItemView_Click(object sender, EventArgs e)
		{
			this.selectedFileView = ((FileItemView)sender);

			var file = this.selectedFileView.File;

			// ensure read / write access.
			var permission = await file.RequestPermissionAsync(Permission.ReadWrite);
			if (permission == PermissionState.Granted)
			{
				var bytes = await file.ReadBytesAsync();
				LoadFile(bytes);

				this.buttonSaveToClient.Enabled = true;
				this.buttonSaveToServer.Enabled = true;

			}
		}

		/// <summary>
		/// Loads the byte array into the client-side widget.
		/// </summary>
		/// <param name="bytes"></param>
		private void LoadFile(byte[] bytes)
		{
			if (bytes.Length == 0) // open a blank document.
			{
				this.documentEditor1.Instance.documentEditor.openBlank();
			} 
			else
            {
				using (var fs = new MemoryStream(bytes))
				{
					var document = WordDocument.Load(fs, FormatType.Docx);
					var sfdt = JsonConvert.SerializeObject(document);
					this.documentEditor1.OpenFile(sfdt);
				}
			}
		}
    }
}