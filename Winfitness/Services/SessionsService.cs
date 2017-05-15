using System;
using System.Collections.Generic;
using System.Linq;

namespace Winfitness
{
	public class SessionsService
	{
		public List<Day> days;
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

		public List<Session> sessionsForDay(String day)
		{
			int idDay = Convert.ToInt32(day);
			List<Session> sessions = new List<Session>();

			switch (idDay)
			{
				case 1:
					sessions = mondaySessions;
					break;
				case 2:
					sessions = tuesdaySessions;
					break;
				case 3:
					sessions = wednesdsaySessions;
					break;
				case 4:
					sessions = thursdaySessions;
					break;
				case 5:
					sessions = fridaySessions;
					break;
				case 6:
					sessions = satudraySessions;
					break;
				default:
					break;
				}

			return sessions;
		}

		public List<Session> sportsForSession(List<Session> sessions)
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
