//using RestSharp;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace WorkoutGenerator
{
	public static class ApiRetriever
	{
		public static HttpClient ApiClient { get; set; }

		public class WorkoutModel
		{
			public string Name { get; set; }
			//Could add more here if I want more information
		}

		public static void InitializeClient(string workoutMuscle = "")
		{
			var baseUrl = "https://api.api-ninjas.com/v1/exercises?muscle=";
			var musclePick = baseUrl + workoutMuscle;
			ApiClient = new HttpClient();

			ApiClient.BaseAddress = new Uri(baseUrl);
			ApiClient.DefaultRequestHeaders.Add("X-Api-Key", "/AtES7vCC7gtXBS3pkOE+w==hGsrSotY6M2llkf7");
			ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

			var response = ApiClient.GetAsync(musclePick).Result;

			if (response.IsSuccessStatusCode)
			{
				var exerciseString = response.Content.ReadAsStringAsync().Result;
				var exercise = JsonConvert.DeserializeObject<IEnumerable<WorkoutModel>>(exerciseString);

				foreach (var e in exercise)
				{
					Console.WriteLine("{0}", e.Name);
					WorkoutPlan.ExerciseList.AppendLine(e.Name);
					//return e.Name;
				}
			}
			else
			{
				Console.WriteLine(@"{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
				//throw new Exception(response.ReasonPhrase);
			}

			ApiClient.Dispose();
		}
	}
}