using BuccaneerBanterAPI.Models;
using BuccaneerBanterAPI.Models.DTOs;

var builder = WebApplication.CreateBuilder(args);

List<Pirate> pirates = new List<Pirate>()
{
    new Pirate()
    {
        Id = 1,
        Name = "Blackbeard",
        Age = 42,
        ImgURL = "https://photos1.blogger.com/blogger/5580/2256/1600/pirate-profile.0.jpg",
        NationalityId = 1,
        RankId = 1,
        ShipId = 1
    },
    new Pirate()
    {
        Id = 2,
        Name = "Anne Bonny",
        Age = 29,
        ImgURL = "https://example.com/anne-bonny.jpg",
        NationalityId = 2,
        RankId = 2,
        ShipId = 2
    },
    new Pirate()
    {
        Id = 3,
        Name = "Calico Jack",
        Age = 37,
        ImgURL = "https://i.pinimg.com/736x/05/29/84/052984797e028fc5526ec780d80e93d7.jpg",
        NationalityId = 1,
        RankId = 1,
        ShipId = 3
    },
    new Pirate()
    {
        Id = 4,
        Name = "Captain Kidd",
        Age = 47,
        ImgURL = "https://example.com/captain-kidd.jpg",
        NationalityId = 3,
        RankId = 1,
        ShipId = 4
    },
    new Pirate()
    {
        Id = 5,
        Name = "Charles Vane",
        Age = 39,
        ImgURL = "https://avatarfiles.alphacoders.com/217/217786.jpg",
        NationalityId = 1,
        RankId = 1,
        ShipId = 2
    },
    new Pirate()
    {
        Id = 6,
        Name = "Edward England",
        Age = 42,
        ImgURL = "https://example.com/edward-england.jpg",
        NationalityId = 4,
        RankId = 1,
        ShipId = 5
    },
    new Pirate()
    {
        Id = 7,
        Name = "Edward Teach",
        Age = 38,
        ImgURL = "https://example.com/edward-teach.jpg",
        NationalityId = 1,
        RankId = 1,
        ShipId = 1
    },
    new Pirate()
    {
        Id = 8,
        Name = "Henry Avery",
        Age = 41,
        ImgURL = "https://example.com/henry-avery.jpg",
        NationalityId = 1,
        RankId = 1,
        ShipId = 6
    },
    new Pirate()
    {
        Id = 9,
        Name = "Henry Morgan",
        Age = 53,
        ImgURL = "https://example.com/henry-morgan.jpg",
        NationalityId = 4,
        RankId = 1,
        ShipId = 7
    },
    new Pirate()
    {
        Id = 10,
        Name = "Jack Rackham",
        Age = 37,
        ImgURL = "https://example.com/jack-rackham.jpg",
        NationalityId = 1,
        RankId = 1,
        ShipId = 3
    },
    new Pirate()
    {
        Id = 50,
        Name = "Mary Read",
        Age = 32,
        ImgURL = "https://i.pinimg.com/originals/b7/c1/f1/b7c1f161dd713ec132b88d5350357030.jpg",
        NationalityId = 1,
        RankId = 2,
        ShipId = 2
    },
    new Pirate()
    {
        Id = 51,
        Name = "John Drake",
        RankId = 3,
        ShipId = 8
    }
};
List<Nationality> nationalities = new List<Nationality>()
{
    new Nationality()
    {
        Id = 1,
        Name = "English"
    },
    new Nationality()
    {
        Id = 2,
        Name = "Irish"
    },
    new Nationality()
    {
        Id = 3,
        Name = "Scottish"
    },
    new Nationality()
    {
        Id = 4,
        Name = "Welsh"
    }
};
List<Rank> ranks = new List<Rank>()
{
    new Rank()
    {
        Id = 1,
        Name = "Captain"
    },
    new Rank()
    {
        Id = 2,
        Name = "Pirate"
    },
    new Rank()
    {
        Id = 3,
        Name = "Buccaneer"
    }
};
List<Ship> ships = new List<Ship>()
{
    new Ship()
    {
        Id = 1,
        Name = "Queen Anne's Revenge"
    },
    new Ship()
    {
        Id = 2,
        Name = "Ranger"
    },
    new Ship()
    {
        Id = 3,
        Name = "The Revenge"
    },
    new Ship()
    {
        Id = 4,
        Name = "Adventure Galley"
    },
    new Ship()
    {
        Id = 5,
        Name = "Pearl"
    },
    new Ship()
    {
        Id = 6,
        Name = "Fancy"
    },
    new Ship()
    {
        Id = 7,
        Name = "Satisfaction"
    },
    new Ship()
    {
        Id = 8,
        Name = "Blue Midnight"
    }
};

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseCors(options =>
    {
        options.AllowAnyOrigin();
        options.AllowAnyMethod();
        options.AllowAnyHeader();
    });
}

app.UseHttpsRedirection();

var CreatePirateDTO = (Pirate pirate) =>
{
    Nationality? foundNationality = nationalities.FirstOrDefault(n => n.Id == pirate.NationalityId);
    Rank foundRank = ranks.FirstOrDefault(rank => rank.Id == pirate.RankId);
    Ship foundShip = ships.FirstOrDefault(ship => ship.Id == pirate.ShipId);

    PirateDTO pirateDTO = new PirateDTO()
    {
        Id = pirate.Id,
        Name = pirate.Name,
        Age = pirate.Age,
        ImgURL = pirate.ImgURL,
        NationalityId = pirate.NationalityId,
        RankId = pirate.RankId,
        Rank = new RankDTO()
        {
            Id = foundRank.Id,
            Name = foundRank.Name
        },
        ShipId = pirate.ShipId,
        Ship = new ShipDTO()
        {
            Id = foundShip.Id,
            Name = foundShip.Name
        }
    };

    if (foundNationality != null)
    {
        pirateDTO.Nationality = new NationalityDTO()
        {
            Id = foundNationality.Id,
            Name = foundNationality.Name
        };
    }

    return pirateDTO;
};

/* Endpoints:
- gets all posts with each pirate who posted the post and the related pirate follower (if not null) 
(- gets post by id)
- get individual pirate by id, include nationality, rank, & ship
- get pirates
- get favorite pirates(followed) of current pirate
*/

app.MapGet("api/pirates", (int? pirateId) =>
{
    if (pirateId != null)
    {
        Pirate pirate = pirates.FirstOrDefault(pirate => pirate.Id == pirateId);
        if (pirate == null)
        {
            return Results.NotFound();
        }

        PirateDTO pirateDTO = CreatePirateDTO(pirate);
        return Results.Ok(pirateDTO);
    }

    List<PirateDTO> pirateDTOs = new List<PirateDTO>();

    foreach (Pirate pirate in pirates)
    {
        PirateDTO pirateDTO = CreatePirateDTO(pirate);
        pirateDTOs.Add(pirateDTO);
    }

    return Results.Ok(pirateDTOs);
});

app.Run();


