namespace BuccaneerBanterAPI.Models;

public class Post
{
    public int Id { get; set; }
    public int PirateId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime DatePosted { get; set; }
}