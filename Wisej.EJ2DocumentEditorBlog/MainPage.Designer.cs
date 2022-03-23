namespace Wisej.EJ2DocumentEditorBlog
{
	partial class MainPage
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
            this.documentEditor1 = new Wisej.Web.Ext.Syncfusion2.DocumentEditor();
            this.buttonSelectClientDirectory = new Wisej.Web.Button();
            this.buttonSaveClient = new Wisej.Web.Button();
            this.flowLayoutPanelClient = new Wisej.Web.FlowLayoutPanel();
            this.buttonCreateFile = new Wisej.Web.Button();
            this.flowLayoutPanelServer = new Wisej.Web.FlowLayoutPanel();
            this.buttonLoadServerFile = new Wisej.Web.Button();
            this.button3 = new Wisej.Web.Button();
            this.flowLayoutPanelFiles = new Wisej.Web.FlowLayoutPanel();
            this.buttonOpenWord = new Wisej.Web.Button();
            this.panel1 = new Wisej.Web.Panel();
            this.flowLayoutPanelClient.SuspendLayout();
            this.flowLayoutPanelServer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // documentEditor1
            // 
            this.documentEditor1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.documentEditor1.Location = new System.Drawing.Point(373, 30);
            this.documentEditor1.Name = "documentEditor1";
            this.documentEditor1.Size = new System.Drawing.Size(1181, 852);
            this.documentEditor1.TabIndex = 0;
            this.documentEditor1.Text = "documentEditor1";
            // 
            // buttonSelectClientDirectory
            // 
            this.flowLayoutPanelClient.SetFillWeight(this.buttonSelectClientDirectory, 1);
            this.flowLayoutPanelClient.SetFlowBreak(this.buttonSelectClientDirectory, true);
            this.buttonSelectClientDirectory.ImageSource = "icon-folder-open";
            this.buttonSelectClientDirectory.Location = new System.Drawing.Point(3, 3);
            this.buttonSelectClientDirectory.Name = "buttonSelectClientDirectory";
            this.buttonSelectClientDirectory.Size = new System.Drawing.Size(267, 37);
            this.buttonSelectClientDirectory.TabIndex = 2;
            this.buttonSelectClientDirectory.Text = "Select Client Directory";
            this.buttonSelectClientDirectory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSelectClientDirectory.Click += new System.EventHandler(this.buttonSelectClientDirectory_Click);
            // 
            // buttonSaveClient
            // 
            this.flowLayoutPanelClient.SetFillWeight(this.buttonSaveClient, 1);
            this.flowLayoutPanelClient.SetFlowBreak(this.buttonSaveClient, true);
            this.buttonSaveClient.ImageSource = "icon-save";
            this.buttonSaveClient.Location = new System.Drawing.Point(3, 46);
            this.buttonSaveClient.Name = "buttonSaveClient";
            this.buttonSaveClient.Size = new System.Drawing.Size(267, 37);
            this.buttonSaveClient.TabIndex = 4;
            this.buttonSaveClient.Text = "Save to Client";
            this.buttonSaveClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSaveClient.Click += new System.EventHandler(this.buttonSaveClient_Click);
            // 
            // flowLayoutPanelClient
            // 
            this.flowLayoutPanelClient.Anchor = Wisej.Web.AnchorStyles.Top;
            this.flowLayoutPanelClient.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.flowLayoutPanelClient.Controls.Add(this.buttonSelectClientDirectory);
            this.flowLayoutPanelClient.Controls.Add(this.buttonSaveClient);
            this.flowLayoutPanelClient.Controls.Add(this.buttonCreateFile);
            this.flowLayoutPanelClient.Location = new System.Drawing.Point(13, 10);
            this.flowLayoutPanelClient.Name = "flowLayoutPanelClient";
            this.flowLayoutPanelClient.ShowCloseButton = false;
            this.flowLayoutPanelClient.ShowHeader = true;
            this.flowLayoutPanelClient.Size = new System.Drawing.Size(275, 164);
            this.flowLayoutPanelClient.TabIndex = 5;
            this.flowLayoutPanelClient.Text = "Client File Actions";
            // 
            // buttonCreateFile
            // 
            this.flowLayoutPanelClient.SetFillWeight(this.buttonCreateFile, 1);
            this.flowLayoutPanelClient.SetFlowBreak(this.buttonCreateFile, true);
            this.buttonCreateFile.ImageSource = "icon-new";
            this.buttonCreateFile.Location = new System.Drawing.Point(3, 89);
            this.buttonCreateFile.Name = "buttonCreateFile";
            this.buttonCreateFile.Size = new System.Drawing.Size(267, 37);
            this.buttonCreateFile.TabIndex = 5;
            this.buttonCreateFile.Text = "Create new File";
            this.buttonCreateFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCreateFile.Click += new System.EventHandler(this.buttonCreateFile_Click);
            // 
            // flowLayoutPanelServer
            // 
            this.flowLayoutPanelServer.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.flowLayoutPanelServer.Controls.Add(this.buttonLoadServerFile);
            this.flowLayoutPanelServer.Controls.Add(this.button3);
            this.flowLayoutPanelServer.Location = new System.Drawing.Point(63, 30);
            this.flowLayoutPanelServer.Name = "flowLayoutPanelServer";
            this.flowLayoutPanelServer.ShowCloseButton = false;
            this.flowLayoutPanelServer.ShowHeader = true;
            this.flowLayoutPanelServer.Size = new System.Drawing.Size(275, 118);
            this.flowLayoutPanelServer.TabIndex = 6;
            this.flowLayoutPanelServer.Text = "Server File Actions";
            // 
            // buttonLoadServerFile
            // 
            this.flowLayoutPanelServer.SetFillWeight(this.buttonLoadServerFile, 1);
            this.flowLayoutPanelServer.SetFlowBreak(this.buttonLoadServerFile, true);
            this.buttonLoadServerFile.ImageSource = "icon-folder-open";
            this.buttonLoadServerFile.Location = new System.Drawing.Point(3, 3);
            this.buttonLoadServerFile.Name = "buttonLoadServerFile";
            this.buttonLoadServerFile.Size = new System.Drawing.Size(267, 37);
            this.buttonLoadServerFile.TabIndex = 1;
            this.buttonLoadServerFile.Text = "Load File from Server";
            this.buttonLoadServerFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLoadServerFile.Click += new System.EventHandler(this.buttonLoadServerFile_Click);
            // 
            // button3
            // 
            this.flowLayoutPanelServer.SetFillWeight(this.button3, 1);
            this.flowLayoutPanelServer.SetFlowBreak(this.button3, true);
            this.button3.ImageSource = "icon-save";
            this.button3.Location = new System.Drawing.Point(3, 46);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(267, 37);
            this.button3.TabIndex = 3;
            this.button3.Text = "Save to Server";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Click += new System.EventHandler(this.buttonSaveServer_Click);
            // 
            // flowLayoutPanelFiles
            // 
            this.flowLayoutPanelFiles.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom)));
            this.flowLayoutPanelFiles.AutoScroll = true;
            this.flowLayoutPanelFiles.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.flowLayoutPanelFiles.Location = new System.Drawing.Point(13, 180);
            this.flowLayoutPanelFiles.Name = "flowLayoutPanelFiles";
            this.flowLayoutPanelFiles.Padding = new Wisej.Web.Padding(0, 0, 0, 20);
            this.flowLayoutPanelFiles.ShowCloseButton = false;
            this.flowLayoutPanelFiles.ShowHeader = true;
            this.flowLayoutPanelFiles.Size = new System.Drawing.Size(275, 478);
            this.flowLayoutPanelFiles.TabIndex = 7;
            this.flowLayoutPanelFiles.Text = "Client Files";
            // 
            // buttonOpenWord
            // 
            this.buttonOpenWord.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Left)));
            this.buttonOpenWord.ImageSource = "icon-upload";
            this.buttonOpenWord.Location = new System.Drawing.Point(13, 664);
            this.buttonOpenWord.Name = "buttonOpenWord";
            this.buttonOpenWord.Size = new System.Drawing.Size(275, 37);
            this.buttonOpenWord.TabIndex = 8;
            this.buttonOpenWord.Text = "Open Word on Desktop";
            this.buttonOpenWord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOpenWord.Click += new System.EventHandler(this.buttonOpenWord_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left)));
            this.panel1.BorderStyle = Wisej.Web.BorderStyle.Dashed;
            this.panel1.Controls.Add(this.buttonOpenWord);
            this.panel1.Controls.Add(this.flowLayoutPanelFiles);
            this.panel1.Controls.Add(this.flowLayoutPanelClient);
            this.panel1.Location = new System.Drawing.Point(49, 166);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 716);
            this.panel1.TabIndex = 9;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanelServer);
            this.Controls.Add(this.documentEditor1);
            this.Name = "MainPage";
            this.Size = new System.Drawing.Size(1603, 911);
            this.Text = "Z";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.flowLayoutPanelClient.ResumeLayout(false);
            this.flowLayoutPanelServer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private Web.Ext.Syncfusion2.DocumentEditor documentEditor1;
		private Web.Button buttonSelectClientDirectory;
		private Web.Button buttonSaveClient;
		private Web.FlowLayoutPanel flowLayoutPanelClient;
		private Web.FlowLayoutPanel flowLayoutPanelServer;
		private Web.Button buttonLoadServerFile;
		private Web.Button button3;
		private Web.FlowLayoutPanel flowLayoutPanelFiles;
		private Web.Button buttonOpenWord;
		private Web.Panel panel1;
        private Web.Button buttonCreateFile;
    }
}

