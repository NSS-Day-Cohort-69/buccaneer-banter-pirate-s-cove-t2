namespace BuccaneerBanterAPI.Models.DTOs;

public class PostDTO
{
    public int Id { get; set; }
    public int PirateId { get; set; }
    public PiratePostDTO Pirate { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime DatePosted { get; set; }
}
