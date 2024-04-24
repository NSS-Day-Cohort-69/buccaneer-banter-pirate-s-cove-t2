namespace BuccaneerBanterAPI.Models.DTOs;

public class FollowerDTO
{
    public int Id {get; set;}
    public int PirateId {get; set;}
    public PirateFollowerDTO Pirate {get; set;}
    public int FollowerId {get; set;}
}