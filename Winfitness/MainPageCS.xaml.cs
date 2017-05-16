using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Winfitness
{
	public partial class MainPageCS : TabbedPage
	{
		public MainPageCS()
		{
			BarBackgroundColor = Color.FromHex("#242021");
			var newsNavigationPage = new NavigationPage(new NewsPage());
			newsNavigationPage.Title = "News";

			var calendarNavigationPage = new NavigationPage(new CalendarPage());
			calendarNavigationPage.Title = "Calendrier";

			var sportsNavigationPage = new NavigationPage(new SportsPage());
			sportsNavigationPage.Title = "Sports";

			var informationNavigationPage = new NavigationPage(new InformationsPage());
			informationNavigationPage.Title = "Infos";

			Children.Add(newsNavigationPage);
			Children.Add(calendarNavigationPage);
			Children.Add(sportsNavigationPage);
			Children.Add(informationNavigationPage);
		}
	}
}
