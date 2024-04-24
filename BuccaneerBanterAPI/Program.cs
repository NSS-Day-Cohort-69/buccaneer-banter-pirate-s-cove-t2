using BuccaneerBanterAPI.Models;
using BuccaneerBanterAPI.Models.DTOs;
using Microsoft.AspNetCore.Mvc;

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
List<Follower> followers = new List<Follower>()
{
    new Follower()
    {
        Id = 1,
        PirateId = 1,
        FollowerId = 2
    },
    new Follower()
    {
        Id = 2,
        PirateId = 1,
        FollowerId = 3
    },
    new Follower()
    {
        Id = 3,
        PirateId = 2,
        FollowerId = 1
    },
    new Follower()
    {
        Id = 4,
        PirateId = 2,
        FollowerId = 3
    },
    new Follower()
    {
        Id = 5,
        PirateId = 3,
        FollowerId = 1
    },
    new Follower()
    {
        Id = 6,
        PirateId = 3,
        FollowerId = 2
    },
    new Follower()
    {
        Id = 7,
        PirateId = 50,
        FollowerId = 2
    },
    new Follower()
    {
        Id = 8,
        PirateId = 50,
        FollowerId = 3
    },
    new Follower()
    {
        Id = 9,
        PirateId = 1,
        FollowerId = 1
    },
    new Follower()
    {
        Id = 10,
        PirateId = 1,
        FollowerId = 1
    },
    new Follower()
    {
        Id = 13,
        PirateId = 50,
        FollowerId = 5
    },
    new Follower()
    {
        Id = 14,
        PirateId = 7,
        FollowerId = 5
    }
};
List<Post> stories = new List<Post>
{
    new Post ()
    {
        Id = 1,
        PirateId = 8,
        Title = "The Ghost Ship",
        Content = "The crew of the merchant ship Mary Celeste were found mysteriously missing, leaving the ship and its valuable cargo untouched. It's been said that the ship still sails the seas, haunting those who cross its path.",
        DatePosted = new DateTime(1789, 9, 1)
    },
    new Post ()
    {
        Id = 2,
        PirateId = 3,
        Title = "The Kraken",
        Content = "The Kraken, a massive sea monster, has been the subject of many pirate tales. Its tentacles can stretch for miles and it can easily capsize even the largest ships. Many pirates have met their end at the hands of this fearsome creature.",
        DatePosted = new DateTime (1718, 11, 22)
    },
    new Post ()
    {
        Id = 3,
        PirateId = 50,
        Title = "The Curse of the Flying Dutchman",
        Content = "Legend had it that the Flying Dutchman was cursed to sail the seas forever, its crew doomed to an eternal existence as undead pirates. But when a group of adventurers stumbled upon the ship one stormy night, they found that the curse was all too real. Now they must find a way to break the curse before it's too late.",
        DatePosted = new DateTime(1722, 10, 15)
    },
    new Post ()
    {
        Id = 4,
        PirateId = 2,
        Title = "The Battle of Blackbeard's Bay",
        Content = "It was a fierce battle that raged on for hours. The sound of cannons and the clash of swords echoed across the bay. The pirates fought with all their might, determined to come out on top. In the end, it was Blackbeard's crew that emerged victorious, with a chest full of treasure to show for it.",
        DatePosted = new DateTime (1718, 9, 1)
    },
    new Post ()
    {
        Id = 5,
        PirateId = 5,
        Title = "The Curse of the Kraken",
        Content = "Legend had it that the Kraken would rise from the depths of the ocean to claim any ship that sailed too close to its lair. The crew of the Black Pearl had heard the tales, but they didn't believe them. That was until they saw the monstrous creature rise from the waves, its tentacles reaching out to grab them. They fought with all their might, but in the end, only a few managed to escape with their lives.",
        DatePosted = new DateTime(1718, 9, 1)
    },
    new Post ()
    {
        Id = 6,
        PirateId = 3,
        Title = "The Treasure of Captain Kidd",
        Content = "Captain Kidd had buried his treasure on a deserted island, but he had left behind a map that would lead to its location. Many pirates had tried to find the treasure, but none had succeeded. That was until Captain Jack Sparrow got his hands on the map. He and his crew set sail for the island, and after days of searching, they finally found the treasure. It was more gold than they could ever have imagined.",
        DatePosted = new DateTime (1725, 5, 30)
    },
    new Post ()
    {
        Id = 7,
        PirateId = 4,
        Title = "The Betrayal of Black Bart",
        Content = "Black Bart was known as one of the fiercest pirates on the high seas. His crew was loyal to him, and they would follow him to the ends of the earth. Or so he thought. One night, while they were anchored off the coast of Jamaica, his first mate led a mutiny against him. Bart fought bravely, but in the end, he was overpowered. He was left marooned on a deserted island, while his crew sailed off with all his treasure.",
        DatePosted = new DateTime (1722, 6, 22)
    },
    new Post ()
    {
        Id = 8,
        PirateId = 9,
        Title = "The Revenge of Calico Jack",
        Content = "Calico Jack had been captured by the British Navy and sentenced to hang. But he managed to escape and vowed revenge against the captain who had betrayed him. He spent months planning his revenge, gathering a crew of loyal men and plotting his attack. Finally, the day arrived, and he and his crew stormed the captain's ship. They fought fiercely, but in the end, it was Calico Jack who emerged victorious. He sailed off into the sunset, a hero to his crew and a thorn in the side of the British Navy.",
        DatePosted = new DateTime (1742, 8, 15)
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

var CreateFollowerDTO = (Follower follower) =>
{
    Pirate followedPirate = pirates.FirstOrDefault(pirate => pirate.Id == follower.PirateId);
    Ship foundShip = ships.FirstOrDefault(ship => ship.Id == followedPirate.ShipId);
    Rank foundRank = ranks.FirstOrDefault(rank => rank.Id == followedPirate.RankId);

    FollowerDTO followerDTO = new FollowerDTO()
    {
        Id = follower.Id,
        PirateId = follower.PirateId,
        Pirate = new PirateFollowerDTO()
        {
            Id = followedPirate.Id,
            Name = followedPirate.Name,
            Ship = new ShipDTO()
            {
                Id = foundShip.Id,
                Name = foundShip.Name
            },
            Rank = new RankDTO()
            {
                Id = foundRank.Id,
                Name = foundRank.Name
            }
        },
        FollowerId = follower.FollowerId
    };

    return followerDTO;
};

/* Endpoints:
- gets all posts with each pirate who posted the post and the related pirate follower (if not null) 
(- gets post by id)
- get individual pirate by id, include nationality, rank, & ship
- get pirates
- get favorite pirates(followed) of current pirate
- get pirate by name and ship name for login
*/
app.MapGet("/api/posts", () =>
{
    return stories.Select(p =>
    {
        Pirate pirate = pirates.FirstOrDefault(pirate => pirate.Id == p.PirateId);

        return new PostDTO
        {
            Id = p.Id,
            PirateId = p.PirateId,
            Pirate = pirate == null ? null : new PiratePostDTO
            {
                Id = pirate.Id,
                Name = pirate.Name

            },
            Title = p.Title,
            Content = p.Content,
            DatePosted = p.DatePosted

        };
    });
});

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

app.MapGet("api/followers/{followerId}", (int followerId) =>
{
    Pirate foundPirate = pirates.FirstOrDefault(pirate => pirate.Id == followerId);
    if (foundPirate == null)
    {
        return Results.BadRequest();
    }

    List<Follower> foundFollowers = followers.Where(follower => follower.FollowerId == foundPirate.Id).ToList();

    List<FollowerDTO> followerDTOs = foundFollowers.Select(follower => CreateFollowerDTO(follower)).ToList();

    return Results.Ok(followerDTOs);
});

app.MapPost("api/followers", (FollowPirateDTO Follow) =>
{
    Pirate pirateFollowed = pirates.FirstOrDefault(pirate => pirate.Id == Follow.PirateId);
    Pirate pirateFollowing = pirates.FirstOrDefault(pirate => pirate.Id == Follow.FollowerId);
    if (pirateFollowed == null | pirateFollowing == null)
    {
        return Results.BadRequest();
    }

    Follower existingFollower = followers.FirstOrDefault(follower => follower.PirateId == Follow.PirateId & follower.FollowerId == Follow.FollowerId);
    if (existingFollower != null)
    {
        return Results.Conflict("You already follow this Pirate");
    }

    Follower newFollower = new Follower()
    {
        Id = followers.Max(follower => follower.Id) + 1,
        PirateId = Follow.PirateId,
        FollowerId = Follow.FollowerId
    };

    followers.Add(newFollower);
    return Results.Created($"api/followers/{newFollower.Id}", newFollower);
});

app.MapDelete("api/followers", ([FromBody] FollowPirateDTO Unfollow) =>
{
    Follower foundFollower = followers.FirstOrDefault(follower => follower.PirateId == Unfollow.PirateId & follower.FollowerId == Unfollow.FollowerId);
    if (foundFollower == null)
    {
        return Results.BadRequest();
    }

    FollowerDTO deletedFollower = CreateFollowerDTO(foundFollower);

    followers.Remove(foundFollower);
    return Results.Ok(deletedFollower);
});

app.MapGet("api/login", (string? name, string? shipName) => 
    //"/login/name={name}/shipname={shipname}"
{
    if (name == null|| shipName == null)
    {
        return Results.NotFound();
    }
    Pirate pirate = pirates.FirstOrDefault(p => p.Name == name);
    if (pirate == null) 
    {
        return Results.BadRequest();
    }
    Ship foundShip = ships.FirstOrDefault(s => s.Id == pirate.ShipId);
    if (foundShip == null)
    {
        return Results.BadRequest();
    }
    if (foundShip.Name != shipName) 
    {
        return Results.BadRequest();
    }
    return Results.Ok(new PirateLoginDTO
    {
        Id = pirate.Id
    });
});
app.Run();


