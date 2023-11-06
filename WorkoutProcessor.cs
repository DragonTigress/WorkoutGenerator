//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net.Http;
//using System.Text;
//using System.Threading.Tasks;

//namespace WorkoutGenerator
//{
//    public class WorkoutProcessor
//    {
//        //put a max num in here if you don't want to go more. There is already max 10 workouts the API generates
//        public static async Task<WorkoutModel> LoadWorkout(string WorkoutMuscle = "")
//        {
//            string baseUrl = "https://api.api-ninjas.com/v1/exercises?muscle=";
//            string muscleUri = baseUrl + WorkoutMuscle;

//            HttpResponseMessage response = await apiRetriever.ApiClient.GetAsync(muscleUri);
//            {
//                if (response.IsSuccessStatusCode)
//                {
//                    WorkoutModel exercise = await response.Content.ReadAsAsync<WorkoutModel>();

//                    return exercise;
//                }
//                else
//                {
//                    throw new Exception(response.ReasonPhrase);
//                }
//            }
//        }
//    }
//}

