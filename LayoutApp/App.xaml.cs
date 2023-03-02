using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LayoutApp
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new DialPage();
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
