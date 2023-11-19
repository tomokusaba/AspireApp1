namespace AspireApp1.ApiService.Data;

public class Books
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public string? Description { get; set; }
    public string? Genre { get; set; }
    public string? Publisher { get; set; }
    public string? PublishedDate { get; set; }
    public string? ISBN { get; set; }

}
