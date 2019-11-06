using System;
using System.Collections.Generic;
using System.Linq;
using Domain;

namespace Persistence
{
    public class seed
    {
        public static void SeedData(DataContext context)
        {
            if (!context.Activities.Any())
            {
                var activities = new List<ActivityModel>
                {
                    new ActivityModel
                    {
    Title = "Past ActivityModel 1",
    Date = DateTime.Now.AddMonths(-2),
    Description = "ActivityModel 2 months ago",
    Category = "drinks",
    City = "London",
    Venue = "Pub",
},
new ActivityModel
{
    Title = "Past ActivityModel 2",
    Date = DateTime.Now.AddMonths(-1),
    Description = "ActivityModel 1 month ago",
    Category = "culture",
    City = "Paris",
    Venue = "Louvre",
},
new ActivityModel
{
    Title = "Future ActivityModel 1",
    Date = DateTime.Now.AddMonths(1),
    Description = "ActivityModel 1 month in future",
    Category = "culture",
    City = "London",
    Venue = "Natural History Museum",
},
new ActivityModel
{
    Title = "Future ActivityModel 2",
    Date = DateTime.Now.AddMonths(2),
    Description = "ActivityModel 2 months in future",
    Category = "music",
    City = "London",
    Venue = "O2 Arena",
},
new ActivityModel
{
    Title = "Future ActivityModel 3",
    Date = DateTime.Now.AddMonths(3),
    Description = "ActivityModel 3 months in future",
    Category = "drinks",
    City = "London",
    Venue = "Another pub",
},
new ActivityModel
{
    Title = "Future ActivityModel 4",
    Date = DateTime.Now.AddMonths(4),
    Description = "ActivityModel 4 months in future",
    Category = "drinks",
    City = "London",
    Venue = "Yet another pub",
},
new ActivityModel
{
    Title = "Future ActivityModel 5",
    Date = DateTime.Now.AddMonths(5),
    Description = "ActivityModel 5 months in future",
    Category = "drinks",
    City = "London",
    Venue = "Just another pub",
},
new ActivityModel
{
    Title = "Future ActivityModel 6",
    Date = DateTime.Now.AddMonths(6),
    Description = "ActivityModel 6 months in future",
    Category = "music",
    City = "London",
    Venue = "Roundhouse Camden",
},
new ActivityModel
{
    Title = "Future ActivityModel 7",
    Date = DateTime.Now.AddMonths(7),
    Description = "ActivityModel 2 months ago",
    Category = "travel",
    City = "London",
    Venue = "Somewhere on the Thames",
},
new ActivityModel
{
    Title = "Future ActivityModel 8",
    Date = DateTime.Now.AddMonths(8),
    Description = "ActivityModel 8 months in future",
    Category = "film",
    City = "London",
    Venue = "Cinema",
}

                };
                context.Activities.AddRange(activities);
                context.SaveChanges();
            }
        }
    }
}