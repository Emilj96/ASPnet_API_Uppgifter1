namespace APIuppgifter_Klient
{

    internal class Program
    {
        static readonly HttpClient client = new HttpClient();
        static async void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            try
            {
                HttpResponseMessage response = await client.GetAsync("https://localhost:7192/api/cd");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseBody);
            }
            catch(HttpRequestException e)
            {
                Console.WriteLine("Error " + e);
            }

        }
    }
}