using CityInfo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore(); //Static Property: Keep on working the same instances, as long as we don't restart websvr

        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            // initial dummy data
            Cities = new List<CityDto>
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "The Big Apple",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto(){
                            Id = 1,
                            Name = "Central Park",
                            Description = "The most visited urban park in the US."},
                        new PointOfInterestDto(){
                            Id= 2,
                            Name = "Empire State Building",
                            Description = "A 102-story skyscraper in Manhattan."}
                    }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Antwerp",
                    Description = "Has The Cathedral of Our Lady with a small tower.",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto(){
                            Id = 3,
                            Name = "Cathedral of Our Lady",
                            Description = "A Gothic style cathedral."},
                        new PointOfInterestDto(){
                            Id= 4,
                            Name = "Antwerp Central Station",
                            Description = "The finest example of railway architecture in Belgium."}
                    }
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Paris",
                    Description = "Never Sleeps",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto(){
                            Id = 5,
                            Name = "Eiffel Tower",
                            Description = "Wrought iron tower on the Champs de Mars."},
                        new PointOfInterestDto(){
                            Id= 6,
                            Name = "The Louvre",
                            Description = "World's largest museum."}
                    }
                }
            };
        }
    }
}
