namespace Wisej.EJ2DocumentEditorBlog
{
	partial class FileItemView
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

		#region Wisej Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.labelTitle = new Wisej.Web.Label();
			this.labelLastModified = new Wisej.Web.Label();
			this.pictureBoxIcon = new Wisej.Web.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
			this.SuspendLayout();
			// 
			// labelTitle
			// 
			this.labelTitle.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.labelTitle.Anonymous = true;
			this.labelTitle.AutoEllipsis = true;
			this.labelTitle.Font = new System.Drawing.Font("@defaultBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.labelTitle.Location = new System.Drawing.Point(57, 10);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(139, 40);
			this.labelTitle.TabIndex = 0;
			this.labelTitle.Text = "Features";
			this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelLastModified
			// 
			this.labelLastModified.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.labelLastModified.Anonymous = true;
			this.labelLastModified.CssStyle = "overflow: hidden;\r\ntext-overflow: ellipsis;\r\ndisplay: -webkit-box;\r\n-webkit-line-" +
    "clamp: 3;\r\n-webkit-box-orient: vertical;";
			this.labelLastModified.Font = new System.Drawing.Font("@default", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.labelLastModified.ForeColor = System.Drawing.Color.FromArgb(151, 151, 151);
			this.labelLastModified.Location = new System.Drawing.Point(19, 51);
			this.labelLastModified.Name = "labelLastModified";
			this.labelLastModified.Size = new System.Drawing.Size(177, 20);
			this.labelLastModified.TabIndex = 1;
			this.labelLastModified.Text = "test tes ttest t ajf;ldjaldkjff adjkf adlkjflakd jflak fdjakl df";
			// 
			// pictureBoxIcon
			// 
			this.pictureBoxIcon.ImageSource = "icon-file";
			this.pictureBoxIcon.Location = new System.Drawing.Point(19, 15);
			this.pictureBoxIcon.Name = "pictureBoxIcon";
			this.pictureBoxIcon.Size = new System.Drawing.Size(30, 30);
			this.pictureBoxIcon.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
			// 
			// FileItemView
			// 
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.pictureBoxIcon);
			this.Controls.Add(this.labelLastModified);
			this.Controls.Add(this.labelTitle);
			this.CssClass = "file-button";
			this.CssStyle = "border-radius: 8px;\r\nbox-shadow: rgba(50, 50, 93, 0.25) 0px 2px 5px -1px, rgba(0," +
    " 0, 0, 0.3) 0px 1px 3px -1px;";
			this.Cursor = Wisej.Web.Cursors.Hand;
			this.Margin = new Wisej.Web.Padding(10);
			this.Name = "FileItemView";
			this.Padding = new Wisej.Web.Padding(10);
			this.Size = new System.Drawing.Size(209, 87);
			this.Load += new System.EventHandler(this.FileItemView_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Web.Label labelTitle;
		private Web.Label labelLastModified;
		private Web.PictureBox pictureBoxIcon;
	}
}
