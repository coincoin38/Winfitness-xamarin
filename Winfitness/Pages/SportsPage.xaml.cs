using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Winfitness
{
	public partial class SportsPage : BaseContentPage
	{
		public SportsPage()
		{
            InitializeComponent();
            Title = "Sports";
			List<Sport> sports = JSONParser.sportsFeed();
			SportsListView.ItemsSource = sports;
		}
	}
}
