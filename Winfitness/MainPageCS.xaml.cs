using System;
using System.Collections.Generic;

using Xamarin.Forms;

using Winfitness.Constants;

namespace Winfitness
{
	public class MainPageCS : TabbedPage
	{
		public MainPageCS()
		{
            TabBarColors();

            NavigationPage newsNavigationPage = NewsNavigationPage();
            NavigationPage calendarNavigationPage = CalendarNavigationPage();
            NavigationPage sportsNavigationPage = SportsNavigationPage();
            NavigationPage informationNavigationPage = InformationsNavigationPage();

            if (Device.RuntimePlatform == Device.iOS)
            {
                newsNavigationPage.Icon = Files.NewsTab;
                calendarNavigationPage.Icon = Files.CalendarTab;
                sportsNavigationPage.Icon = Files.SportsTab;
                informationNavigationPage.Icon = Files.InformationsTab;
			}

			Children.Add(newsNavigationPage);
			Children.Add(calendarNavigationPage);
			Children.Add(sportsNavigationPage);
			Children.Add(informationNavigationPage);
		}

        private void TabBarColors ()
        {
			BarBackgroundColor = Color.FromHex(Colors.OrangeWF);
			BarTextColor = Color.White;
        }

        private NavigationPage NewsNavigationPage() 
        {
			NavigationPage newsNavigationPage = new NavigationPage(new NewsPage());
			newsNavigationPage.Title = LocalizationResources.NewsTitle;

            return newsNavigationPage;
        }

		private NavigationPage CalendarNavigationPage()
		{
			NavigationPage calendarNavigationPage = new NavigationPage(new CalendarPage());
			calendarNavigationPage.Title = LocalizationResources.CalendarTitle;

			return calendarNavigationPage;
		}

		private NavigationPage SportsNavigationPage()
		{
			NavigationPage sportsNavigationPage = new NavigationPage(new SportsPage());
			sportsNavigationPage.Title = LocalizationResources.SportsTitle;

			return sportsNavigationPage;
		}

		private NavigationPage InformationsNavigationPage()
		{
			NavigationPage informationNavigationPage = new NavigationPage(new InformationsPage());
			informationNavigationPage.Title = LocalizationResources.InformationsTitle;

			return informationNavigationPage;
		}
	}
}
