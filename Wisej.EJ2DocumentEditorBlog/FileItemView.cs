using System;
using Wisej.Ext.ClientFileSystem;
using Wisej.Web;

namespace Wisej.EJ2DocumentEditorBlog
{
	public partial class FileItemView : UserControl
	{
		/// <summary>
		/// The associated client-side file.
		/// </summary>
		public File File;

		#region Constructors

		/// <summary>
		/// Creates a new instance of <see cref="FileItemView"/>.
		/// </summary>
		public FileItemView()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Creates a new instance of <see cref="FileItemView"/> with the given client file.
		/// </summary>
		/// <param name="file"></param>
		public FileItemView(File file)
		{
			InitializeComponent();

			this.File = file;
		}

		#endregion

		private void FileItemView_Load(object sender, EventArgs e)
		{
			this.labelTitle.Text = this.File.Name;
			this.labelLastModified.Text = this.File.LastModified.ToString();
		}

		/// <summary>
		/// Saves the file to the client's file system.
		/// </summary>
		public async void Save(byte[] bytes)
		{
			await File.WriteBytesAsync(bytes, 0, WritableType.Write, false);
		}
	}
}
