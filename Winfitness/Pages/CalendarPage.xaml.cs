using System;
using Xamarin.Forms;

namespace Winfitness
{
	public partial class CalendarPage : ContentPage
	{
		public CalendarPage()
		{
			InitializeComponent();
			DaysListView.ItemsSource = SessionsService.weekCalendar();
		}
	}
}
