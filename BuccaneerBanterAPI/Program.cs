using BuccaneerBanterAPI.Models;
using BuccaneerBanterAPI.Models.DTOs;

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

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


/* Endpoints:
- gets all posts with each pirate who posted the post and the related pirate follower (if not null) 
(- gets post by id)
- get individual pirate by id, include nationality, rank, & ship
- get pirates
- get favorite pirates(followed) of current pirate
- get pirate by name and ship name for login
*/
app.MapGet("/posts", () =>
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
                Name = pirate.Name,
                Followed = pirate.Followed

            },
            Title = p.Title,
            Content = p.Content,
            DatePosted = p.DatePosted

        };
    });
});

app.Run();


