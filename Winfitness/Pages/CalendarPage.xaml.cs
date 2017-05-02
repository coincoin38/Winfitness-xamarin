using System;
using System.Collections.Generic;


using Xamarin.Forms;

namespace Winfitness
{
	public partial class CalendarPage : ContentPage
	{
		public CalendarPage()
		{
			InitializeComponent();
			List<Day> days = JSONParser.daysFeed();
			List<Session> mondaySessions = JSONParser.mondaySessionsFeed();

			foreach (var day in days)
			{
				day.Sessions = mondaySessions;
			}

			DaysListView.ItemsSource = days;
		}
	}
}
