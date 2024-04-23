namespace BuccaneerBanterAPI.Models.DTOs;

public class PirateDTO
{
    public int Id {get; set;}
    public string Name {get; set;}
    public int? Age {get; set;}
    public string? ImgURL {get; set;}
    public int? NationalityId {get; set;}
    public NationalityDTO? Nationality {get; set;}
    public int RankId {get; set;}
    public RankDTO Rank {get; set;}
    public int ShipId {get; set;}
    public ShipDTO Ship {get; set;}
}