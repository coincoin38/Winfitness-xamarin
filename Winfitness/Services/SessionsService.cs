using System;
using System.Collections.Generic;
using System.Linq;

namespace Winfitness
{
	public class SessionsService
	{
		private List<Day> days;
   		private List<Session> mondaySessions;
		private List<Session> tuesdaySessions;
		private List<Session> wednesdsaySessions;
		private List<Session> thursdaySessions;
		private List<Session> fridaySessions;
		private List<Session> satudraySessions;

		private List<Sport> sports;
		private List<Description> descriptions;

		public SessionsService()
		{
			descriptions = JSONParser.descriptionsFeed();
			sports = JSONParser.sportsFeed();
			days = JSONParser.daysFeed();

		   	mondaySessions = sportsForSession(JSONParser.mondaySessionsFeed());
			tuesdaySessions = sportsForSession(JSONParser.tuesdaySessionsFeed());
			wednesdsaySessions = sportsForSession(JSONParser.wednesdaySessionsFeed());
			thursdaySessions = sportsForSession(JSONParser.thursdaySessionsFeed());
			fridaySessions = sportsForSession(JSONParser.fridaydaySessionsFeed());
			satudraySessions = sportsForSession(JSONParser.saturdaySessionsFeed());
		}

		public List<Day> weekCalendar()
		{
			return days;
		}

		public Day dayWithSession(Day day)
		{
				int idDay = Convert.ToInt32(day.Id);

				switch (idDay)
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

			return day;
		}

		private List<Session> sportsForSession(List<Session> sessions)
		{
			foreach (Session session in sessions)
			{
				var sportResult = sports.Where(Sport => Sport.Id == session.Sport_id);
				if (sportResult != null)
				{
					session.Sport = sportResult.ElementAt(0);
				}
			}

			return sessions;
		}

		private Sport descriptionsForSport(Sport sport)
		{
			var descriptionResult = descriptions.Where(Description => Description.Key_sport == sport.Id);
			if (descriptionResult != null)
			{
				sport.Description = descriptionResult.ElementAt(0);
			}

			return sport;
		}
	}
}
