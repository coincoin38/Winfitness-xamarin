﻿using System;
using Xamarin.Forms;

namespace Winfitness
{
	public partial class CalendarPage : BaseContentPage
	{
		public CalendarPage()
		{
			InitializeComponent();
			BindingContext = new CalendarPageViewModel(this.Navigation);
			daysListView.ItemSelected += (sender, e) =>
			{
				daysListView.SelectedItem = null;
			};
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			NavigationPage.SetHasNavigationBar(this, false);
		}
	}
}
