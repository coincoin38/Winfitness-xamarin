using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Winfitness
{
	public partial class SportsPage : ContentPage
	{
		public SportsPage()
		{
            InitializeComponent();
			List<Sport> sports = JSONParser.sportsFeed();
			SportsListView.ItemsSource = sports;
		}
	}
}
