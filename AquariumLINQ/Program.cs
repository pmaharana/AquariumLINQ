using AquariumLINQ.DataContext;
using AquariumLINQ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquariumLINQ
{
    class Program
    {

        static void Main(string[] args)
        {
            var db = new AquariumContext();


            //selects all from database as a list
            //var allAquaLife = db.AquaticLife.ToList();
            //var allOcean = db.Ocean.ToList();
            //var allAquarium = db.Aquarium.ToList();

            //adding to database for oceans
            //var someOcean = new Oceans
            //{
            //    Name = "Atlantic",
            //    AverageTemperature = 65.1
            //};
            //db.Ocean.Add(someOcean);
            //db.SaveChanges();

            //adding to database for Aquariums
            var someAquarium = new Aquariums
            {
                Name = "Davey Jones' Locker",
                City = "Bikini Bottom"
            };
            db.Aquarium.Add(someAquarium);
            db.SaveChanges();



            ////adding to database
            //var aquaticLife = new AquaticLifes
            //{
            //    Type = "Oyster",
            //    Color = "Metalic Grey",
            //    Name = "Cloyster",
            //    DateAddedToTank = DateTime.Now.Date,
            //    IsInQuarantee = false
            //};
            //db.AquaticLife.Add(aquaticLife);
            //db.SaveChanges();

            


            ////select the name of all aquatic lifes of type fish
            //var fish = db.AquaticLife.Where(w => w.Type == "Fish").Select(s => s.Name);

            ////updating a fish name
            //var shell = db.AquaticLife.First(f => f.Name == "Cloyster");
            //shell.Name = "Sheldor";
            //db.SaveChanges();

            ////deleting an aquaticlife
            //var deletingYou = db.AquaticLife.First(f => f.Type == "Oyster");
            //db.AquaticLife.Remove(deletingYou);
            //db.SaveChanges();






        }
    }
}
