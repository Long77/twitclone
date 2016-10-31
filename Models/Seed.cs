using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

public static class Seed
{
    public static void InitializeDev(DB db)
    {   
        // Look for any Posts.
        // if (db.Cards.Any() || db.CardLists.Any())
        db.Database.EnsureDeleted(); // delete then, ...
        db.Database.EnsureCreated(); // create the tables!! 
        
        CardList todo = new CardList { Summary="Todo items", Cards = new List<Card>() };

        for(var i = 0; i < 10; i++){
            todo.Cards.Add(
                new Card { Title = $"Test Card {i}", Content = $"Test Content {i}",  }
            );
        }

        db.CardLists.Add(todo);

        db.SaveChanges();

        // print out the tables 
        Console.WriteLine("----------CARDS SEEDED-------------");
        Console.WriteLine(db.Cards.ToList().Count);
    }

    public static void InitializeProd(DB db){
        db.Database.EnsureCreated();
        db.Database.Migrate();
    }

    public static void Migrate(DB db){
        
    }
}