using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;

namespace EventFinder.Models
{
    public class SeedData : DropCreateDatabaseAlways<EventFinderDB>
    {
        protected override void Seed(EventFinderDB context)
        {
            try
            {
                var eventTypes = new List<EventFinderEventType>
                {
                    new EventFinderEventType {EventType ="Music" },
                    new EventFinderEventType {EventType ="Art" },
                    new EventFinderEventType {EventType ="Sports" },
                    new EventFinderEventType {EventType ="Health" },
                    new EventFinderEventType {EventType ="Social" },
                };

                new List<EventFinderEvent>
                {
                new EventFinderEvent
                {
                    EventFinderEventTypeID = 3,
                    EventType = eventTypes.Single(e => e.EventType == "Sports"),
                    Title= "Watch the Browns II",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddDays(1),
                    MaxTickets = 50,
                    AvailableTickets = 50,
                    ZipCode = 12345,
                    OrganizerEmail = "brownsfan1n@nflcom",
                    Description = "Watch the Browns...again!",
                    StartTime = DateTime.Now,
                    EndTime = DateTime.Now.AddDays(1),
                    State = "OH",
                    City= "Cleveland",
                    FirstName = "Bill",
                    LastName = "Jackson",
                    AmountOfTickets = 0
                },
                new EventFinderEvent
                {
                    EventFinderEventTypeID = 3,
                    EventType = eventTypes.Single(e => e.EventType == "Sports"),
                    Title= "Watch the Browns III",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddDays(1),
                    MaxTickets = 50,
                    AvailableTickets = 50,
                    ZipCode = 12345,
                    OrganizerEmail = "brownsfan1n@nflcom",
                    Description = "Watch the Browns...again!",
                    StartTime = DateTime.Now,
                    EndTime = DateTime.Now.AddDays(1),
                    State = "OH",
                    City= "Cleveland",
                    FirstName = "Bill",
                    LastName = "Jackson",
                    AmountOfTickets = 0
                },
                new EventFinderEvent
                {
                    EventFinderEventTypeID = 3,
                    EventType = eventTypes.Single(e => e.EventType == "Sports"),
                    Title= "Watch the Browns IV",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddDays(1),
                    MaxTickets = 50,
                    AvailableTickets = 50,
                    ZipCode = 12345,
                    OrganizerEmail =  "brownsfan1n@nflcom",
                    Description = "Watch the Browns...again!",
                    StartTime = DateTime.Now,
                    EndTime = DateTime.Now.AddDays(1),
                    State = "OH",
                    City= "Cleveland",
                    FirstName = "Bill",
                    LastName = "Jackson",
                    AmountOfTickets = 0
                },
                new EventFinderEvent
                {
                    EventFinderEventTypeID = 3,
                    EventType = eventTypes.Single(e => e.EventType == "Sports"),
                    Title= "Watch the Browns V",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddDays(1),
                    MaxTickets = 50,
                    AvailableTickets = 50,
                    ZipCode = 12345,
                    OrganizerEmail = "brownsfan1n@nflcom",
                    Description = "Watch the Browns...again!",
                    StartTime = DateTime.Now,
                    EndTime = DateTime.Now.AddDays(1),
                    State = "OH",
                    City= "Cleveland",
                    FirstName = "Bill",
                    LastName = "Jackson",
                    AmountOfTickets = 0
                },

                new EventFinderEvent
                {
                    EventFinderEventTypeID = 3,
                    EventType = eventTypes.Single(e => e.EventType == "Sports"),
                    Title= "Watch the Browns VI",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddDays(1),
                    MaxTickets = 50,
                    AvailableTickets = 50,
                    ZipCode = 12345,
                    OrganizerEmail = "brownsfan1n@nflcom",
                    Description = "Watch the Browns...again!",
                    StartTime = DateTime.Now,
                    EndTime = DateTime.Now.AddDays(1),
                    State = "OH",
                    City= "Cleveland",
                    FirstName = "Bill",
                    LastName = "Jackson",
                    AmountOfTickets = 0
                },

               new EventFinderEvent
               {
                    EventFinderEventTypeID = 4,
                    EventType = eventTypes.Single(e => e.EventType == "Health"),
                    Title= "Doctor's Visit 1",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddDays(1),
                    MaxTickets = 50,
                    AvailableTickets = 50,
                    ZipCode = 12345,
                    OrganizerEmail = "doctorsforhealth@doctors.com",
                    Description = "Daily online health check-in",
                    StartTime = DateTime.Now,
                    EndTime = DateTime.Now.AddDays(1),
                    State = "MI",
                    City= "Detroit",
                    FirstName = "Tamera",
                    LastName = "Smith",
                    AmountOfTickets = 0
               },

               new EventFinderEvent
               {
                    EventFinderEventTypeID = 4,
                    EventType = eventTypes.Single(e => e.EventType == "Health"),
                    Title= "Doctor's Visit 2",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddDays(1),
                    MaxTickets = 50,
                    AvailableTickets = 50,
                    ZipCode = 12345,
                    OrganizerEmail = "doctorsforhealth@doctors.com",
                    Description = "Daily online health check-in",
                    StartTime = DateTime.Now.AddDays(3),
                    EndTime = DateTime.Now.AddDays(4),
                    State = "MI",
                    City= "Detroit",
                    FirstName = "Tamera",
                    LastName = "Smith",
                    AmountOfTickets = 0
               },

                  new EventFinderEvent
               {
                    EventFinderEventTypeID = 4,
                    EventType = eventTypes.Single(e => e.EventType == "Health"),
                    Title= "Doctor's Visit 3",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddDays(1),
                    MaxTickets = 50,
                    AvailableTickets = 50,
                    ZipCode = 12345,
                    OrganizerEmail = "doctorsforhealth@doctors.com",
                    Description = "Daily online health check-in",
                   StartTime = DateTime.Now,
                    EndTime = DateTime.Now.AddDays(1),
                    State = "MI",
                    City= "Detroit",
                    FirstName = "Tamera",
                    LastName = "Smith",
                    AmountOfTickets = 0
               },
                   new EventFinderEvent
               {
                    EventFinderEventTypeID = 4,
                    EventType = eventTypes.Single(e => e.EventType == "Health"),
                    Title= "Doctor's Visit 4",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddDays(1),
                    MaxTickets = 50,
                    AvailableTickets = 50,
                    ZipCode = 12345,
                    OrganizerEmail = "doctorsforhealth@doctors.com",
                    Description = "Daily online health check-in",
                    StartTime = DateTime.Now,
                    EndTime = DateTime.Now.AddDays(1),
                    State = "MI",
                    City= "Detroit",
                    FirstName = "Tamera",
                    LastName = "Smith",
                    AmountOfTickets = 0
               },
                    new EventFinderEvent
               {
                    EventFinderEventTypeID = 4,
                    EventType = eventTypes.Single(e => e.EventType == "Health"),
                    Title= "Doctor's Visit 5",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddDays(1),
                    MaxTickets = 50,
                    AvailableTickets = 50,
                    ZipCode = 12345,
                    OrganizerEmail = "doctorsforhealth@doctors.com",
                    Description = "Daily online health check-in",
                    StartTime = DateTime.Now,
                    EndTime = DateTime.Now.AddDays(1),
                    State = "MI",
                    City= "Detroit",
                    FirstName = "Tamera",
                    LastName = "Smith",
                    AmountOfTickets = 0
               },
                      new EventFinderEvent
               {
                    EventFinderEventTypeID = 4,
                    EventType = eventTypes.Single(e => e.EventType == "Health"),
                    Title= "Doctor's Visit 6",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddDays(1),
                    MaxTickets = 50,
                    AvailableTickets = 50,
                    ZipCode = 12345,
                    OrganizerEmail = "doctorsforhealth@doctors.com",
                    Description = "Daily online health check-in",
                    StartTime = DateTime.Now,
                    EndTime = DateTime.Now.AddDays(1),
                    State = "MI",
                    City= "Detroit",
                    FirstName = "Tamera",
                    LastName = "Smith",
                    AmountOfTickets = 0
               },

               new EventFinderEvent
               {
                    EventFinderEventTypeID = 4,
                    EventType = eventTypes.Single(e => e.EventType == "Health"),
                    Title= "Doctor's Visit 7",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddDays(1),
                    MaxTickets = 50,
                    AvailableTickets = 50,
                    ZipCode = 12345,
                    OrganizerEmail = "doctorsforhealth@doctors.com",
                    Description = "Daily online health check-in",
                    StartTime = DateTime.Now,
                    EndTime = DateTime.Now.AddDays(1),
                    State = "MI",
                    City= "Detroit",
                    FirstName = "Tamera",
                    LastName = "Smith",
                    AmountOfTickets = 0
               },

               new EventFinderEvent
               {
                    EventFinderEventTypeID = 5,
                    EventType = eventTypes.Single(e => e.EventType == "Social"),
                    Title= "NYE Party",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddDays(1),
                    MaxTickets = 50,
                    AvailableTickets = 50,
                    ZipCode = 43201,
                    OrganizerEmail = "thisisla@cityoflosangeles.gov",
                    Description = "Let's party all day in Los Angeles!",
                    StartTime = DateTime.Now,
                    EndTime = DateTime.Now.AddDays(1),
                    State = "CA",
                    City= "Los Angeles",
                    FirstName = "Alexis",
                    LastName = "Jones",
                    AmountOfTickets = 0
               },

               new EventFinderEvent
               {
                    EventFinderEventTypeID = 5,
                    EventType = eventTypes.Single(e => e.EventType == "Social"),
                    Title= "NYE Party Cleveland",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddDays(1),
                    MaxTickets = 50,
                    AvailableTickets = 50,
                    ZipCode = 44102,
                    OrganizerEmail = "thisiscle@cleveland.gov",
                    Description = "New Year's Eve Celebration in DownTown CLE",
                    StartTime = DateTime.Now,
                    EndTime = DateTime.Now.AddDays(1),
                    State = "OH",
                    City= "Cleveland",
                    FirstName = "Martin",
                    LastName = "DeMarco",
                    AmountOfTickets = 0
               },

               new EventFinderEvent
               {
                    EventFinderEventTypeID = 5,
                    EventType = eventTypes.Single(e => e.EventType == "Social"),
                    Title= "Chicago New Year's Eve Party",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddDays(1),
                    MaxTickets = 50,
                    AvailableTickets = 50,
                    ZipCode = 44102,
                    OrganizerEmail = "chicago@chicago.gov",
                    Description = "Chi-Town Party!!!",
                    StartTime = DateTime.Now,
                    EndTime = DateTime.Now.AddDays(1),
                    State = "IL",
                    City= "Chicago",
                    FirstName = "Tommy",
                    LastName = "Leary",
                    AmountOfTickets = 0
               },

               new EventFinderEvent
               {
                    EventFinderEventTypeID = 5,
                    EventType = eventTypes.Single(e => e.EventType == "Social"),
                    Title= "Seattle New Year's Eve Party",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddDays(1),
                    MaxTickets = 50,
                    AvailableTickets = 50,
                    ZipCode = 44102,
                    OrganizerEmail = "seattle@seattle.gov",
                    Description = "Celebrate the New Year in Seattle",
                    StartTime = DateTime.Now,
                    EndTime = DateTime.Now.AddDays(1),
                    State = "WA",
                    City= "Seattle",
                    FirstName = "Jane",
                    LastName = "Watanabe",
                    AmountOfTickets = 0
               },

               new EventFinderEvent
               {
                    EventFinderEventTypeID = 2,
                    EventType = eventTypes.Single(e => e.EventType == "Art"),
                    Title= "MOMA PART I",
                    StartDate = DateTime.Now.AddDays(5),
                    EndDate = DateTime.Now.AddDays(6),
                    MaxTickets = 50,
                    AvailableTickets = 50,
                    ZipCode = 44102,
                    OrganizerEmail = "explore@arts.gov",
                    Description = "Explore Art At MoMA",
                    StartTime = DateTime.Now.AddDays(5),
                    EndTime = DateTime.Now.AddDays(6),
                    State = "NY",
                    City= "New York City",
                    FirstName = "Josef",
                    LastName = "Dunne",
                    AmountOfTickets = 0
               },

                new EventFinderEvent
               {
                    EventFinderEventTypeID = 2,
                    EventType = eventTypes.Single(e => e.EventType == "Art"),
                    Title= "MOMA PART III",
                    StartDate = DateTime.Now.AddDays(15),
                    EndDate = DateTime.Now.AddDays(16),
                    MaxTickets = 50,
                    AvailableTickets = 50,
                    ZipCode = 44102,
                    OrganizerEmail = "explore@arts.gov",
                    Description = "Explore Art At MoMA",
                    StartTime = DateTime.Now.AddDays(15),
                    EndTime = DateTime.Now.AddDays(16),
                    State = "NY",
                    City= "New York City",
                    FirstName = "Josef",
                    LastName = "Dunne",
                    AmountOfTickets = 0
               },

                 new EventFinderEvent
               {
                    EventFinderEventTypeID = 2,
                    EventType = eventTypes.Single(e => e.EventType == "Art"),
                    Title= "MOMA PART III",
                    StartDate = DateTime.Now.AddDays(19),
                    EndDate = DateTime.Now.AddDays(20),
                    MaxTickets = 50,
                    AvailableTickets = 50,
                    ZipCode = 44102,
                    OrganizerEmail = "explore@arts.gov",
                    Description = "Explore Art At MoMA",
                    StartTime = DateTime.Now.AddDays(5),
                    EndTime = DateTime.Now.AddDays(6),
                    State = "NY",
                    City= "New York City",
                    FirstName = "Josef",
                    LastName = "Dunne",
                    AmountOfTickets = 0
               },

                  new EventFinderEvent
               {
                    EventFinderEventTypeID = 2,
                    EventType = eventTypes.Single(e => e.EventType == "Art"),
                    Title= "Get Your Art On at MOMA",
                    StartDate = DateTime.Now.AddDays(19),
                    EndDate = DateTime.Now.AddDays(20),
                    MaxTickets = 50,
                    AvailableTickets = 50,
                    ZipCode = 44102,
                    OrganizerEmail = "explore@arts.gov",
                    Description = "Explore Art At MoMA",
                    StartTime = DateTime.Now.AddDays(5),
                    EndTime = DateTime.Now.AddDays(6),
                    State = "NY",
                    City= "New York City",
                    FirstName = "Josef",
                    LastName = "Dunne",
                    AmountOfTickets = 0
               },

                   new EventFinderEvent
               {
                    EventFinderEventTypeID = 1,
                    EventType = eventTypes.Single(e => e.EventType == "Music"),
                    Title= "Enjoy Classical Rock",
                    StartDate = DateTime.Now.AddDays(30),
                    EndDate = DateTime.Now.AddDays(31),
                    MaxTickets = 50,
                    AvailableTickets = 50,
                    ZipCode = 43218,
                    OrganizerEmail = "austinmusic@music.org",
                    Description = "Listen to great classical rock!",
                    StartTime = DateTime.Now.AddDays(5),
                    EndTime = DateTime.Now.AddDays(6),
                    State = "TX",
                    City= "Texas",
                    FirstName = "Marilyn",
                    LastName = "Dacosta",
                    AmountOfTickets = 0
               }

            }.ForEach(a => context.EventFinderEvents.Add(a));

            context.SaveChanges();
        }
        catch (DbEntityValidationException e)
        {
            foreach (var eve in e.EntityValidationErrors)
            {
             Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                 eve.Entry.Entity.GetType().Name, eve.Entry.State);
                foreach (var ve in eve.ValidationErrors)
                 {
                    Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                        ve.PropertyName, ve.ErrorMessage);
                }
                    }
                throw;
            }
        }
    }
}
