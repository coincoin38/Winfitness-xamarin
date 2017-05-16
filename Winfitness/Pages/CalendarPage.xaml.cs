using System;
using Xamarin.Forms;

namespace Winfitness
{
	public partial class CalendarPage : BaseContentPage
	{
		public CalendarPage()
		{
			InitializeComponent();
            Title = "Semaine";
			BindingContext = new CalendarPageViewModel(this.Navigation);

			daysListView.ItemSelected += (sender, e) =>
			{
				daysListView.SelectedItem = null;
			};
		}
	}
}
