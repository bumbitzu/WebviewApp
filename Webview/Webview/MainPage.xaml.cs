using System;
using System.IO;
using System.Reflection;
using Xamarin.Forms;

namespace Webview
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

			try
			{
				var htmlSource = new HtmlWebViewSource();
				var baseUrl = DependencyService.Get<IBaseUrl>().Get();
				htmlSource.BaseUrl = baseUrl;
				htmlSource.Html = LoadHtmlFromResources();
				webView.Source = htmlSource;
			}
			catch (Exception ex)
			{
				System.Diagnostics.Debug.WriteLine("Error in MainPage constructor: " + ex.Message);
			}
		}

		private string LoadHtmlFromResources()
		{
			try
			{
				var assembly = typeof(MainPage).GetTypeInfo().Assembly;

				// List all embedded resources
				var resourceNames = assembly.GetManifestResourceNames();
				foreach (var resource in resourceNames)
				{
					System.Diagnostics.Debug.WriteLine("Resource available: " + resource);
				}

				var htmlResourceName = "Webview.Resources.index.html";
				var cssResourceName = "Webview.Resources.styles.css";
				var jsResourceName = "Webview.Resources.script.js";

				string htmlText;
				string cssText;
				string jsText;

				using (Stream stream = assembly.GetManifestResourceStream(htmlResourceName))
				{
					using (var reader = new StreamReader(stream))
					{
						htmlText = reader.ReadToEnd();
					}
				}

				using (Stream stream = assembly.GetManifestResourceStream(cssResourceName))
				{
					using (var reader = new StreamReader(stream))
					{
						cssText = reader.ReadToEnd();
					}
				}

				using (Stream stream = assembly.GetManifestResourceStream(jsResourceName))
				{
					using (var reader = new StreamReader(stream))
					{
						jsText = reader.ReadToEnd();
					}
				}

				// Inject CSS and JS into HTML
				string completeHtml = htmlText.Replace("<!--CSS-->", "<style>" + cssText + "</style>");
				completeHtml = completeHtml.Replace("<!--JS-->", "<script>" + jsText + "</script>");

				System.Diagnostics.Debug.WriteLine("HTML loaded successfully.");
				return completeHtml;
			}
			catch (Exception ex)
			{
				System.Diagnostics.Debug.WriteLine("Error in LoadHtmlFromResources: " + ex.Message);
				return "<html><body>Error loading HTML</body></html>";
			}
		}




		private void OnWebViewNavigating(object sender, WebNavigatingEventArgs e)
		{
			System.Diagnostics.Debug.WriteLine("Navigating to: " + e.Url);
		}

		private void OnWebViewNavigated(object sender, WebNavigatedEventArgs e)
		{
			System.Diagnostics.Debug.WriteLine("Navigated to: " + e.Url);
			if (e.Result != WebNavigationResult.Success)
			{
				System.Diagnostics.Debug.WriteLine("Navigation failed");
			}
		}
	}
}
