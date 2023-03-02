using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LayoutApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DialPage : ContentPage
	{
		public string _phNo;

		public string PhNo 
		{ 
			get => _phNo;
			set
			{
				if (_phNo != value)
				{ 
					_phNo = value;
					OnPropertyChanged(nameof(PhNo));
				}
			} 
		}
		public DialPage ()
		{
			InitializeComponent ();
			BindingContext= this;
		}

		private void Btn_Clkd1(object sender, EventArgs e)
		{
			var button = (Button)sender;
			PhNo += button.Text;

        }

		private void Button_Clicked(object sender, EventArgs e)
		{
			if (PhNo.Length > 0)
			{
				PhNo = PhNo.Remove(PhNo.Length - 1);
			}
			else PhNo=PhNo;
		}
	}
}