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

		public static List<Description> descriptionsFeed()
		{
			return JsonConvert.DeserializeObject<List<Description>>(
				@"[{ key_sport: '1', content: 'Exercising muscles around the core, CXWORX™ provides the vital ingredient for a stronger body. A stronger core makes you better at all things you do, from everyday life to your favorite sports - it’s the glue that holds everything together.\n\nAll the moves in CXWORX have options, so it’s challenging but achievable for your own level of fitness. During the 30-minute workout trained instructors guide you through correct technique as you work with resistance tubes and weight plates, as well as body weight exercises like crunches, and hovers. You will also get into some hip, butt and lower back exercises.' }, 
				   { key_sport: '2', content: 'Zumba is a dance fitness program created by Colombian dancer and choreographer Alberto Beto Perez during the 1990s. Zumba is a trademark owned by Zumba Fitness, LLC. The Brazilian pop singer Claudia Leitte has become the international ambassador to Zumba Fitness.\n\nZumba involves dance and aerobic elements. The choreography incorporates hip-hop, soca, samba, salsa, merengue and mambo. Squats and lunges are also included. Zumba Fitness, the owner of the Zumba program, does not charge licensing fees to gyms or fitness centers. Approximately 15 million people take weekly Zumba classes in over 200,000 locations across 180 countries.' },
				   { key_sport: '3', content: 'Basic stepping, just like walking up and down stairs, is at the heart of BODYSTEP™ – a full-body cardio workout to really tone your butt and thighs.\n\nIn a BODYSTEP Athletic class you combine basic stepping with moves like burpees, push ups and weight plate exercises to work the upper body. If you fancy quicker stepping and the chance to showcase your rhythm and flair then BODYSTEP Classic is the way to go. There are always lots of options to get you through the workout safely.\n\nOur bubbly and approachable instructors coach you through the workout. We play invigorating, hit music and inject a whole lot of fun and personality along the way. You can burn up to 620 calories* and you’ll leave buzzing with satisfaction.\n\nBODYSTEP is available as a either a 55, 45 or 30-minute workout.' },
				   { key_sport: '4', content: 'BODYATTACK™ is a high-energy fitness class with moves that cater for total beginners to total addicts. We combine athletic movements like running, lunging and jumping with strength exercises such as push-ups and squats. A LES MILLS™ instructor will pump out energizing tunes and lead you through the workout – challenging your limits in a good way, burning up to 730 calories* and leaving you with a sense of achievement.\n\nBODYATTACK is available as a either a 55, 45 or 30-minute workout.' },
				   { key_sport: '5', content: 'Ideal for anyone and everyone, BODYBALANCE™* is the yoga-based class that will improve your mind, your body and your life.\n\nDuring BODYBALANCE an inspired soundtrack plays as you bend and stretch through a series of simple yoga moves and embrace elements of Tai Chi and Pilates. Breathing control is a part of all the exercises, and instructors will always provide options for those just getting started. You’ll strengthen your entire body and leave the class feeling calm and centered. Happy.\n\nBODYBALANCE is available as a either a 55, 45 or 30-minute workout.' },
				   { key_sport: '6', content: 'Step into a BODYCOMBAT workout and you’ll punch and kick your way to fitness, burning up to 740 calories* along the way. This high-energy martial-arts inspired workout is totally non-contact and there are no complex moves to master. A LES MILLS™ instructor will challenge you to up the intensity and motivate you to make the most of every round. You’ll release stress, have a blast and feel like a champ.\n\nBODYCOMBAT is available as a either a 55, 45 or 30-minute workout.' },
				   { key_sport: '7', content: 'BODYPUMP™ is for anyone looking to get lean, toned and fit – fast.\n\nUsing light to moderate weights with lots of repetition, BODYPUMP gives you a total body workout. It will burn up to 430 calories*. Instructors will coach you through the scientifically proven moves and techniques pumping out encouragement, motivation and great music – helping you achieve much more than on your own! You’ll leave the class feeling challenged and motivated, ready to come back for more.' },
				   { key_sport: '8', content: 'If you want the optimal mix of strength, cardio and core training this is it.\n\nStep into a BODYVIVE™ 3.1 class and you\'ll tick off a complete workout. The challenging mix of lunges, squats, running and tubing exercises will help you burn calories and take your fitness to the next level. You\'ll leave fizzing with energy and on track for all-around healthy living.\n\nBODYVIVE 3.1 is available as a either a 55, 45 or 30-minute workout.' },
				   { key_sport: '9', content: 'Find your rhythm in a cardio peak cycling workout that delivers maximum results with minimum impact on your joints.\n\nRPM™ tunes you in to great music and takes you on a journey of hill climbs, sprints and flat riding.\n\nYou control your own resistance levels and speed so you can build up your training level over time. Your instructor will show you how to set up your bike and all the basic cycling moves. If you want a true\n\nRPM is available as a either a 45 or 30-minute workout.' },
				   { key_sport: '10', content: 'Le BODYJAM™ est le cours de cardio qui vous initie aux joies de la danse, en toute liberté. Un cocktail détonant des derniers mouvements de la danse et des tubes du moment pour transpirer en s\'éclatant. Des instructeurs funky vous apprennent à bouger avec style tout au long des 55 minutes de cours. Alors amenez un ami, bougez votre corps et laissez le plaisir de danse s\'emparer de vous.' }]");
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
