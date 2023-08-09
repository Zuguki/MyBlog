namespace MyBlog.Models;

public class AuthToken
{
    public int UserId { get; set; }
    
    public int Minutes { get; set; }
    
    public string? AccessToken { get; set; }
    
    public string? UserName { get; set; }
}