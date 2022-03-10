using System;
using Wisej.Web;
using Wisej.Web.Ext.Syncfusion2;

namespace Wisej.EJ2DocumentEditorBlog
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		static void Main()
		{
			ej2Base.Theme = "bootstrap4";
			Application.MainPage = new MainPage();
		}

		//
		// You can use the entry method below
		// to receive the parameters from the URL in the args collection.
		//
		//static void Main(NameValueCollection args)
		//{
		//}
	}
}