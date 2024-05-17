using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CSharpJourney{


public class Todo 
{
    public int userId { get; set; }  
    public int id { get; set; }     
    public required string title { get; set; }
    public bool completed { get; set; }
}


     class Todos{

        private string url = "https://jsonplaceholder.typicode.com/todos";

        public async Task<IEnumerable<Todo>> GetTodos(){

            var client = new HttpClient();

            try{
                HttpResponseMessage response = await client.GetAsync(url);

                response.EnsureSuccessStatusCode();


                var todos = await response.Content.ReadFromJsonAsync<IEnumerable<Todo>>();

                return todos;

            }catch(Exception ex){
                Console.WriteLine($"Request Error {ex.Message}");

                return null;
            }

        }
    }
}