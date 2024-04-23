using BuccaneerBanterAPI.Models;
using BuccaneerBanterAPI.Models.DTOs;

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
*/

app.Run();


