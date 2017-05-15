using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;

namespace Winfitness
{
	class CalendarPageViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		public SessionsService sessionsService;

		private List<Day> weekDays;
		private Day selectedDay;
		private INavigation _navigation;

		public CalendarPageViewModel()
		{
		}

		public CalendarPageViewModel(INavigation navigation)
		{
			_navigation = navigation;
			sessionsService = new SessionsService();
			weekDays = sessionsService.weekCalendar();
		}

		public List<Day> WeekDays
		{
			set
			{
				weekDays = value;
				if (PropertyChanged != null)
                    {
                        PropertyChanged(this,
							new PropertyChangedEventArgs("WeekDays"));
                    }
			}
			get
			{
				return weekDays;
			}
		}

		public Day SelectedDay
		{
			set
			{
				selectedDay = value;
				if (value != null)
				{
					if (selectedDay.Sessions == null)
					{
						selectedDay.Sessions = sessionsService.sessionsForDay(selectedDay.Id);
					}

					_navigation.PushAsync(new DayPage(), true);
				}
			}
			get
			{
				return selectedDay;
			}
		}
	}
}
