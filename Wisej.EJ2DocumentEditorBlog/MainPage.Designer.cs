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
            this.buttonSaveToClient = new Wisej.Web.Button();
            this.flowLayoutPanelClient = new Wisej.Web.FlowLayoutPanel();
            this.buttonCreateFile = new Wisej.Web.Button();
            this.flowLayoutPanelServer = new Wisej.Web.FlowLayoutPanel();
            this.buttonLoadServerFile = new Wisej.Web.Button();
            this.buttonSaveToServer = new Wisej.Web.Button();
            this.flowLayoutPanelFiles = new Wisej.Web.FlowLayoutPanel();
            this.buttonOpenWord = new Wisej.Web.Button();
            this.panelClient = new Wisej.Web.Panel();
            this.flowLayoutPanelClient.SuspendLayout();
            this.flowLayoutPanelServer.SuspendLayout();
            this.panelClient.SuspendLayout();
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
            // buttonSaveToClient
            // 
            this.buttonSaveToClient.Enabled = false;
            this.flowLayoutPanelClient.SetFillWeight(this.buttonSaveToClient, 1);
            this.flowLayoutPanelClient.SetFlowBreak(this.buttonSaveToClient, true);
            this.buttonSaveToClient.ImageSource = "icon-save";
            this.buttonSaveToClient.Location = new System.Drawing.Point(3, 46);
            this.buttonSaveToClient.Name = "buttonSaveToClient";
            this.buttonSaveToClient.Size = new System.Drawing.Size(267, 37);
            this.buttonSaveToClient.TabIndex = 4;
            this.buttonSaveToClient.Text = "Save to Client";
            this.buttonSaveToClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSaveToClient.Click += new System.EventHandler(this.buttonSaveToClient_Click);
            // 
            // flowLayoutPanelClient
            // 
            this.flowLayoutPanelClient.Anchor = Wisej.Web.AnchorStyles.Top;
            this.flowLayoutPanelClient.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.flowLayoutPanelClient.Controls.Add(this.buttonSelectClientDirectory);
            this.flowLayoutPanelClient.Controls.Add(this.buttonSaveToClient);
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
            this.buttonCreateFile.Enabled = false;
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
            this.flowLayoutPanelServer.Controls.Add(this.buttonSaveToServer);
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
            // buttonSaveToServer
            // 
            this.buttonSaveToServer.Enabled = false;
            this.flowLayoutPanelServer.SetFillWeight(this.buttonSaveToServer, 1);
            this.flowLayoutPanelServer.SetFlowBreak(this.buttonSaveToServer, true);
            this.buttonSaveToServer.ImageSource = "icon-save";
            this.buttonSaveToServer.Location = new System.Drawing.Point(3, 46);
            this.buttonSaveToServer.Name = "buttonSaveToServer";
            this.buttonSaveToServer.Size = new System.Drawing.Size(267, 37);
            this.buttonSaveToServer.TabIndex = 3;
            this.buttonSaveToServer.Text = "Save to Server";
            this.buttonSaveToServer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSaveToServer.Click += new System.EventHandler(this.buttonSaveToServer_Click);
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
            // panelClient
            // 
            this.panelClient.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left)));
            this.panelClient.BorderStyle = Wisej.Web.BorderStyle.Dashed;
            this.panelClient.Controls.Add(this.buttonOpenWord);
            this.panelClient.Controls.Add(this.flowLayoutPanelFiles);
            this.panelClient.Controls.Add(this.flowLayoutPanelClient);
            this.panelClient.Location = new System.Drawing.Point(49, 166);
            this.panelClient.Name = "panelClient";
            this.panelClient.Size = new System.Drawing.Size(303, 716);
            this.panelClient.TabIndex = 9;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.panelClient);
            this.Controls.Add(this.flowLayoutPanelServer);
            this.Controls.Add(this.documentEditor1);
            this.Name = "MainPage";
            this.Size = new System.Drawing.Size(1603, 911);
            this.Text = "Z";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.flowLayoutPanelClient.ResumeLayout(false);
            this.flowLayoutPanelServer.ResumeLayout(false);
            this.panelClient.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private Web.Ext.Syncfusion2.DocumentEditor documentEditor1;
		private Web.Button buttonSelectClientDirectory;
		private Web.Button buttonSaveToClient;
		private Web.FlowLayoutPanel flowLayoutPanelClient;
		private Web.FlowLayoutPanel flowLayoutPanelServer;
		private Web.Button buttonLoadServerFile;
		private Web.Button buttonSaveToServer;
		private Web.FlowLayoutPanel flowLayoutPanelFiles;
		private Web.Button buttonOpenWord;
		private Web.Panel panelClient;
        private Web.Button buttonCreateFile;
    }
}

