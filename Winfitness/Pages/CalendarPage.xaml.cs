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
            List<Session> tuesdaySessions = JSONParser.tuesdaySessionsFeed();
			List<Session> wednesdsaySessions = JSONParser.wednesdaySessionsFeed();
			List<Session> thursdaySessions = JSONParser.thursdaySessionsFeed();
			List<Session> fridaySessions = JSONParser.fridaydaySessionsFeed();
			List<Session> satudraySessions = JSONParser.saturdaySessionsFeed();

			foreach (Day day in days)
			{
				int caseSwitch = Convert.ToInt32(day.Id);

				switch (caseSwitch)
				{
					case 1:
						day.Sessions = mondaySessions;
						break;
					case 2:
						day.Sessions = tuesdaySessions;
						break;
					case 3:
						day.Sessions = wednesdsaySessions;
						break;
					case 4:
						day.Sessions = thursdaySessions;
						break;
					case 5:
						day.Sessions = fridaySessions;
						break;
					case 6:
						day.Sessions = satudraySessions;
						break;
					default:
						break;
				}
			}

			DaysListView.ItemsSource = days;
		}
	}
}
