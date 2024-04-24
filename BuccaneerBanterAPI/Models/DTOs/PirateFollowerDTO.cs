namespace BuccaneerBanterAPI.Models.DTOs;

public class PirateFollowerDTO
{
    public int Id {get; set;}
    public string Name {get; set;}
    public ShipDTO Ship {get; set;}
    public RankDTO Rank {get; set;}
}