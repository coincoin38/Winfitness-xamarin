using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Winfitness
{
	public static class JSONParser
	{
		public static List<Sport> sportsFeed()
		{
			return JsonConvert.DeserializeObject<List<Sport>>(
				@"[{ id:'1', name:'CXWORX', description_id:'1', color:'#f47a1f', image:'cxworx2' },
				   { id:'2', name:'ZUMBA', description_id:'2', color:'#cc0099', image:'zumba' },
				   { id:'3', name:'STEP', description_id:'3', color:'#00859c', image:'bodystep' }, 
				   { id:'4', name:'ATTACK', description_id:'4', color:'#fec424', image:'bodyattack' }, 
				   { id:'5', name:'BALANCE', description_id:'5', color:'#cadf87', image:'bodybalance' }, 
				   { id:'6', name:'COMBAT', description_id:'6', color:'#817b00', image:'bodycombat' }, 
				   { id:'7', name:'PUMP', description_id:'7', color:'#fe0000', image:'bodypump' }, 
				   { id:'8', name:'WAVE', description_id:'8', color:'#333399', image:'bodyvive' },
				   { id:'9', name:'RPM', description_id:'9', color:'#00a3e3', image:'rpm-2' }, 
				   { id:'10', name:'JAM', description_id:'10', color:'#ec9cc3', image:'bodyjam' }]");
		}

		public static List<Day> daysFeed()
		{
			return JsonConvert.DeserializeObject<List<Day>>(
				@"[{ id:'1', name:'Lundi' },
				   { id:'2', name:'Mardi' },
				   { id:'3', name:'Mercredi' }, 
				   { id:'4', name:'Jeudi' }, 
				   { id:'5', name:'Vendredi' }, 
				   { id:'6', name:'Samedi' }]");
		}

		public static List<Session> mondaySessionsFeed()
		{
			return JsonConvert.DeserializeObject<List<Session>>(
					@"[{ sport_id: '3', from: '09:00', duration: '15', day: 'Lundi', attendance: false }, 
					   { sport_id: '3', from: '09:15', duration: '45', day: 'Lundi', attendance: true }, 
				       { sport_id: '5', from: '10:00', duration: '30', day: 'Lundi', attendance: true }, 
					   { sport_id: '6', from: '12:15', duration: '15', day: 'Lundi', attendance: false }, 
					   { sport_id: '6', from: '12:30', duration: '45', day: 'Lundi', attendance: true }, 
					   { sport_id: '1', from: '13:15', duration: '30', day: 'Lundi', attendance: true }, 
					   { sport_id: '8', from: '14:30', duration: '45', day: 'Lundi', attendance: true }, 
					   { sport_id: '7', from: '17:00', duration: '30', day: 'Lundi', attendance: true }, 
					   { sport_id: '5', from: '17:30', duration: '30', day: 'Lundi', attendance: true }, 
					   { sport_id: '1', from: '18:00', duration: '30', day: 'Lundi', attendance: true }, 
					   { sport_id: '7', from: '18:30', duration: '45', day: 'Lundi', attendance: true }, 
				       { sport_id: '9', from: '19:30', duration: '45', day: 'Lundi', attendance: true }, 
					   { sport_id: '2', from: '19:30', duration: '45', day: 'Lundi', attendance: true }, 
					   { sport_id: '1', from: '20:15', duration: '30', day: 'Lundi', attendance: true }]");
		}

		public static List<Session> tuesdaySessionsFeed()
		{
			return JsonConvert.DeserializeObject<List<Session>>(
					@"[{ sport_id: '5',from: '09:00',duration: '15',day: 'Mardi',attendance: false },  
				       { sport_id: '5',from: '09:15',duration: '45',day: 'Mardi',attendance: true }, 
                       { sport_id: '8',from: '10:00',duration: '45',day: 'Mardi',attendance: true },
                       { sport_id: '7',from: '12:15',duration: '15',day: 'Mardi',attendance: false },
                       { sport_id: '7',from: '12:30',duration: '45',day: 'Mardi',attendance: true }, 
                       { sport_id: '2',from: '14:30',duration: '45',day: 'Mardi',attendance: true },
                       { sport_id: '1',from: '15:15',duration: '30',day: 'Mardi',attendance: true },
                       { sport_id: '6',from: '16:45',duration: '15',day: 'Mardi',attendance: false },
                       { sport_id: '6',from: '17:00',duration: '45',day: 'Mardi',attendance: true },
                       { sport_id: '3',from: '17:45',duration: '45',day: 'Mardi',attendance: true },
                       { sport_id: '9',from: '18:30',duration: '45',day: 'Mardi',attendance: true },
                       { sport_id: '4',from: '18:45',duration: '45',day: 'Mardi',attendance: true },
                       { sport_id: '7',from: '19:30',duration: '45',day: 'Mardi',attendance: true },
                       { sport_id: '5',from: '20:15',duration: '45',day: 'Mardi',attendance: true }]");
		}

		public static List<Session> wednesdaySessionsFeed()
		{
			return JsonConvert.DeserializeObject<List<Session>>(
					@"[{ sport_id: '8', from: '09:15', duration: '45', day: 'Mercredi', attendance: true }, 
					   { sport_id: '2', from: '10:00', duration: '45', day: 'Mercredi', attendance: true },  
					   { sport_id: '4', from: '12:15', duration: '15', day: 'Mercredi', attendance: false }, 
				       { sport_id: '4', from: '12:30', duration: '45', day: 'Mercredi', attendance: true },  
					   { sport_id: '1', from: '13:15', duration: '30', day: 'Mercredi', attendance: true },  
					   { sport_id: '5', from: '14:15', duration: '15', day: 'Mercredi', attendance: false },  
					   { sport_id: '5', from: '14:30', duration: '45', day: 'Mercredi', attendance: true },  
					   { sport_id: '7', from: '16:45', duration: '15', day: 'Mercredi', attendance: false },  
					   { sport_id: '7', from: '17:00', duration: '15', day: 'Mercredi', attendance: true },  
					   { sport_id: '4', from: '17:45', duration: '45', day: 'Mercredi', attendance: true },  
					   { sport_id: '5', from: '18:30', duration: '45', day: 'Mercredi', attendance: true },  
					   { sport_id: '9', from: '19:30', duration: '45', day: 'Mercredi', attendance: true },  
					   { sport_id: '1', from: '19:30', duration: '30', day: 'Mercredi', attendance: true },  
					   { sport_id: '6', from: '20:00', duration: '45', day: 'Mercredi', attendance: true }]");
		}

		public static List<Session> thursdaySessionsFeed()
		{
			return JsonConvert.DeserializeObject<List<Session>>(
					@"[{ sport_id: '7', from: '09:00', duration: '15', day: 'Jeudi', attendance: false },
					   { sport_id: '7', from: '09:15', duration: '45', day: 'Jeudi', attendance: true },
					   { sport_id: '1', from: '10:00', duration: '30', day: 'Jeudi', attendance: true },
					   { sport_id: '3', from: '12:15', duration: '15', day: 'Jeudi', attendance: false },
					   { sport_id: '3', from: '12:30', duration: '45', day: 'Jeudi', attendance: true },
					   { sport_id: '3', from: '14:15', duration: '15', day: 'Jeudi', attendance: false },
					   { sport_id: '7', from: '14:30', duration: '45', day: 'Jeudi', attendance: true },
					   { sport_id: '8', from: '17:15', duration: '45', day: 'Jeudi', attendance: true },
					   { sport_id: '1', from: '18:00', duration: '30', day: 'Jeudi', attendance: true },
					   { sport_id: '9', from: '18:30', duration: '45', day: 'Jeudi', attendance: true },
					   { sport_id: '2', from: '18:30', duration: '45', day: 'Jeudi', attendance: true }, 
					   { sport_id: '4', from: '19:30', duration: '45', day: 'Jeudi', attendance: true },
					   { sport_id: '7', from: '20:15', duration: '45', day: 'Jeudi', attendance: true }]");
		}
		public static List<Session> fridaydaySessionsFeed()
		{
			return JsonConvert.DeserializeObject<List<Session>>(
					@"[{ sport_id: '1', from: '09:15', duration: '30', day: 'Vendredi', attendance: true },
					   { sport_id: '8', from: '09:45', duration: '45', day: 'Vendredi', attendance: true },
                       { sport_id: '1', from: '12:30', duration: '30', day: 'Vendredi', attendance: true }, 
				       { sport_id: '5', from: '13:00', duration: '45', day: 'Vendredi', attendance: true },
                       { sport_id: '7', from: '14:15', duration: '15', day: 'Vendredi', attendance: false },
                       { sport_id: '3', from: '14:30', duration: '45', day: 'Vendredi', attendance: true }, 
                       { sport_id: '4', from: '16:45', duration: '15', day: 'Vendredi', attendance: false },
					   { sport_id: '4', from: '17:00', duration: '30', day: 'Vendredi', attendance: true },
                       { sport_id: '7', from: '17:30', duration: '45', day: 'Vendredi', attendance: true },
                       { sport_id: '9', from: '17:30', duration: '45', day: 'Vendredi', attendance: true }, 
                       { sport_id: '3', from: '18:30', duration: '45', day: 'Vendredi', attendance: true },
                       { sport_id: '10', from: '19:30', duration: '45', day: 'Vendredi', attendance: true },
                       { sport_id: '5', from: '20:15', duration: '45', day: 'Vendredi', attendance: true }]");
		}

		public static List<Session> saturdaySessionsFeed()
		{
			return JsonConvert.DeserializeObject<List<Session>>(
					 @"[{ sport_id: '5', from: '09:00', duration: '15', day: 'Samedi', attendance: false },
				        { sport_id: '5', from: '09:15', duration: '45', day: 'Samedi', attendance: true },
                        { sport_id: '4', from: '10:00', duration: '45', day: 'Samedi', attendance: true },
                        { sport_id: '2', from: '10:45', duration: '45', day: 'Samedi', attendance: true },
                        { sport_id: '7', from: '11:30', duration: '45', day: 'Samedi', attendance: true },
                        { sport_id: '9', from: '12:30', duration: '45', day: 'Samedi', attendance: true }]");
		}
	}
}
