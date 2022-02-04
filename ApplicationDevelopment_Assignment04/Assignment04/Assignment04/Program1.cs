using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04
{
    class Program1
    {
        public class Rootobject
        {
            public string status { get; set; }
            public Datum[] data { get; set; }
            public string message { get; set; }
        }

        public class Datum
        {
            public int id { get; set; }
            public string employee_name { get; set; }
            public int employee_salary { get; set; }
            public int employee_age { get; set; }
            public string profile_image { get; set; }
        }


        // function to call API
        public static Rootobject getEmployeeData()
        {
            Rootobject result = null;
            var client = new RestClient("https://dummy.restapiexample.com/api/v1/");
            var request = new RestRequest("employees"); // getting all employee data
            var response = client.Execute(request); //executing the request (calling it)

            if (response.StatusCode == System.Net.HttpStatusCode.OK) //if it is ok - handle the response
            {
                string rawResponse = response.Content;
                result = JsonConvert.DeserializeObject<Rootobject>(rawResponse); //converting to json
            }
            return result;
        }

        // fucntion to create the API
        public static void createEmployee()
        {
            var client = new RestClient("https://dummy.restapiexample.com/api/v1/");
            var request = new RestRequest("create", Method.POST);
            request.AddParameter("Name", "Test Employee");
            request.AddParameter("salary", "25000");
            request.AddParameter("age", "21");
            request.AddHeader("Content-Type", "application/json, charset-utf-8");

            var response = client.Execute(request); //executing the request (calling it)

            if (response.StatusCode == System.Net.HttpStatusCode.OK) //if it is ok - handle the response
            {
                //string rawResponse = response.Content;
                //Rootobject result = JsonConvert.DeserializeObject<Rootobject>(rawResponse); //converting to json
            }
        }
    }
}
