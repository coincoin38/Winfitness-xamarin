using System;
using Xamarin.Forms;

namespace Winfitness
{
	public partial class CalendarPage : ContentPage
	{
		public CalendarPage()
		{
			InitializeComponent();
			SessionsService sessionsService = new SessionsService(); 
			DaysListView.ItemsSource = sessionsService.weekCalendar();
		}
	}
}
