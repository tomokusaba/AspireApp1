using AspireApp1.ApiService.Data;

namespace AspireApp1.Web
{
    public class BookApiClient(HttpClient httpClient)
    {
        public async Task<Books[]> GetBooksAsync()
        {
            return await httpClient.GetFromJsonAsync<Books[]>("/api/values") ?? [];
        }

        public async Task<Books> GetBookByIdAsync(int id)
        {
            return await httpClient.GetFromJsonAsync<Books>($"/api/values/{id}") ?? new Books();
        }

        public async Task<Books> CreateBookAsync(Books book)
        {
            return await httpClient.PostAsJsonAsync("/api/values", book).Result.Content.ReadFromJsonAsync<Books>() ?? new Books();
        }
    }
    

}
