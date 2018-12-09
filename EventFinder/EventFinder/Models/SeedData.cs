using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EventFinder.Models
{
    public class SeedData : DropCreateDatabaseIfModelChanges<EventFinderDB>
    {
        protected override void Seed(EventFinderDB context)
        {
            new List<EventFinderEvent>
            {
                new EventFinderEvent
                {
                    EventFinderEventTypeID = 3,
                    Title= "Watch the Browns II",
                    StartDate = DateTime.Now.AddDays(3),
                    EndDate = DateTime.Now.AddDays(4),
                    MaxTickets = 50,
                    AvailableTickets = 50,
                    ZipCode = 12345,
                    OrganizerEmail = "brownsfan1n@nflcom",
                    Description = "Watch the Browns...again!",
                    StartTime = DateTime.Now.AddDays(3),
                    EndTime = DateTime.Now.AddDays(4),
                    State = "OH",
                    City= "Cleveland",
                    FirstName = "Bill",
                    LastName = "Jackson",
                    AmountOfTickets = 0
                },
                new EventFinderEvent
                {
                    EventFinderEventTypeID = 3,
                    Title= "Watch the Browns III",
                    StartDate = DateTime.Now.AddDays(5),
                    EndDate = DateTime.Now.AddDays(6),
                    MaxTickets = 50,
                    AvailableTickets = 50,
                    ZipCode = 12345,
                    OrganizerEmail = "brownsfan1n@nflcom",
                    Description = "Watch the Browns...again!",
                    StartTime = DateTime.Now.AddDays(5),
                    EndTime = DateTime.Now.AddDays(6),
                    State = "OH",
                    City= "Cleveland",
                    FirstName = "Bill",
                    LastName = "Jackson",
                    AmountOfTickets = 0
                },
                new EventFinderEvent
                {
                    EventFinderEventTypeID = 3,
                    Title= "Watch the Browns IV",
                    StartDate = DateTime.Now.AddDays(-7),
                    EndDate = DateTime.Now.AddDays(-6),
                    MaxTickets = 50,
                    AvailableTickets = 50,
                    ZipCode = 12345,
                    OrganizerEmail =  "brownsfan1n@nflcom",
                    Description = "Watch the Browns...again!",
                    StartTime = DateTime.Now.AddDays(-7),
                    EndTime = DateTime.Now.AddDays(-6),
                    State = "OH",
                    City= "Cleveland",
                    FirstName = "Bill",
                    LastName = "Jackson",
                    AmountOfTickets = 0
                },
                new EventFinderEvent
                {
                    EventFinderEventTypeID = 3,
                    Title= "Watch the Browns V",
                    StartDate = DateTime.Now.AddDays(27),
                    EndDate = DateTime.Now.AddDays(28),
                    MaxTickets = 50,
                    AvailableTickets = 50,
                    ZipCode = 12345,
                    OrganizerEmail = "brownsfan1n@nflcom",
                    Description = "Watch the Browns...again!",
                    StartTime = DateTime.Now.AddDays(27),
                    EndTime = DateTime.Now.AddDays(28),
                    State = "OH",
                    City= "Cleveland",
                    FirstName = "Bill",
                    LastName = "Jackson",
                    AmountOfTickets = 0
                },

                new EventFinderEvent
                {
                    EventFinderEventTypeID = 3,
                    Title= "Watch the Browns VI",
                    StartDate = DateTime.Now.AddDays(-17),
                    EndDate = DateTime.Now.AddDays(-16),
                    MaxTickets = 50,
                    AvailableTickets = 50,
                    ZipCode = 12345,
                    OrganizerEmail = "brownsfan1n@nflcom",
                    Description = "Watch the Browns...again!",
                    StartTime = DateTime.Now,
                    EndTime = DateTime.Now,
                    State = "OH",
                    City= "Cleveland",
                    FirstName = "Bill",
                    LastName = "Jackson",
                    AmountOfTickets = 0
                },

               new EventFinderEvent
               {
                    EventFinderEventTypeID = 4,
                    Title= "Doctor's Visit 1",
                    StartDate = DateTime.Now.AddDays(2),
                    EndDate = DateTime.Now.AddDays(3),
                    MaxTickets = 50,
                    AvailableTickets = 50,
                    ZipCode = 12345,
                    OrganizerEmail = "doctorsforhealth@doctors.com",
                    Description = "Daily online health check-in",
                    StartTime = DateTime.Now.AddDays(2),
                    EndTime = DateTime.Now.AddDays(3),
                    State = "MI",
                    City= "Detroit",
                    FirstName = "Tamera",
                    LastName = "Smith",
                    AmountOfTickets = 0
               },

               new EventFinderEvent
               {
                    EventFinderEventTypeID = 4,
                    Title= "Doctor's Visit 2",
                    StartDate = DateTime.Now.AddDays(3),
                    EndDate = DateTime.Now.AddDays(4),
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
                    Title= "Doctor's Visit 3",
                    StartDate = DateTime.Now.AddDays(4),
                    EndDate = DateTime.Now.AddDays(5),
                    MaxTickets = 50,
                    AvailableTickets = 50,
                    ZipCode = 12345,
                    OrganizerEmail = "doctorsforhealth@doctors.com",
                    Description = "Daily online health check-in",
                    StartTime = DateTime.Now.AddDays(4),
                    EndTime = DateTime.Now.AddDays(5),
                    State = "MI",
                    City= "Detroit",
                    FirstName = "Tamera",
                    LastName = "Smith",
                    AmountOfTickets = 0
               },
                   new EventFinderEvent
               {
                    EventFinderEventTypeID = 4,
                    Title= "Doctor's Visit 4",
                    StartDate = DateTime.Now.AddDays(5),
                    EndDate = DateTime.Now.AddDays(6),
                    MaxTickets = 50,
                    AvailableTickets = 50,
                    ZipCode = 12345,
                    OrganizerEmail = "doctorsforhealth@doctors.com",
                    Description = "Daily online health check-in",
                    StartTime = DateTime.Now.AddDays(5),
                    EndTime = DateTime.Now.AddDays(6),
                    State = "MI",
                    City= "Detroit",
                    FirstName = "Tamera",
                    LastName = "Smith",
                    AmountOfTickets = 0
               },
                    new EventFinderEvent
               {
                    EventFinderEventTypeID = 4,
                    Title= "Doctor's Visit 5",
                    StartDate = DateTime.Now.AddDays(6),
                    EndDate = DateTime.Now.AddDays(7),
                    MaxTickets = 50,
                    AvailableTickets = 50,
                    ZipCode = 12345,
                    OrganizerEmail = "doctorsforhealth@doctors.com",
                    Description = "Daily online health check-in",
                    StartTime = DateTime.Now.AddDays(6),
                    EndTime = DateTime.Now.AddDays(7),
                    State = "MI",
                    City= "Detroit",
                    FirstName = "Tamera",
                    LastName = "Smith",
                    AmountOfTickets = 0
               },
                      new EventFinderEvent
               {
                    EventFinderEventTypeID = 4,
                    Title= "Doctor's Visit 6",
                    StartDate = DateTime.Now.AddDays(7),
                    EndDate = DateTime.Now.AddDays(8),
                    MaxTickets = 50,
                    AvailableTickets = 50,
                    ZipCode = 12345,
                    OrganizerEmail = "doctorsforhealth@doctors.com",
                    Description = "Daily online health check-in",
                    StartTime = DateTime.Now.AddDays(7),
                    EndTime = DateTime.Now.AddDays(8),
                    State = "MI",
                    City= "Detroit",
                    FirstName = "Tamera",
                    LastName = "Smith",
                    AmountOfTickets = 0
               },

               new EventFinderEvent
               {
                    EventFinderEventTypeID = 4,
                    Title= "Doctor's Visit 7",
                    StartDate = DateTime.Now.AddDays(8),
                    EndDate = DateTime.Now.AddDays(9),
                    MaxTickets = 50,
                    AvailableTickets = 50,
                    ZipCode = 12345,
                    OrganizerEmail = "doctorsforhealth@doctors.com",
                    Description = "Daily online health check-in",
                    StartTime = DateTime.Now.AddDays(8),
                    EndTime = DateTime.Now.AddDays(9),
                    State = "MI",
                    City= "Detroit",
                    FirstName = "Tamera",
                    LastName = "Smith",
                    AmountOfTickets = 0
               },

               new EventFinderEvent
               {
                    EventFinderEventTypeID = 7,
                    Title= "NYE Party",
                    StartDate = new DateTime(12,31,2018),
                    EndDate = new DateTime(1,1,2019),
                    MaxTickets = 50,
                    AvailableTickets = 50,
                    ZipCode = 43201,
                    OrganizerEmail = "thisisla@cityoflosangeles.gov",
                    Description = "Let's party all day in Los Angeles!",
                    StartTime = new DateTime(12,31,2018),
                    EndTime = new DateTime(1,1,2019),
                    State = "CA",
                    City= "Los Angeles",
                    FirstName = "Alexis",
                    LastName = "Jones",
                    AmountOfTickets = 0
               },

               new EventFinderEvent
               {
                    EventFinderEventTypeID = 7,
                    Title= "NYE Party Cleveland",
                    StartDate = new DateTime(12,31,2018),
                    EndDate = new DateTime(1,1,2019),
                    MaxTickets = 50,
                    AvailableTickets = 50,
                    ZipCode = 44102,
                    OrganizerEmail = "thisiscle@cleveland.gov",
                    Description = "New Year's Eve Celebration in DownTown CLE",
                    StartTime = new DateTime(12,31,2018),
                    EndTime = new DateTime(1,1,2019),
                    State = "OH",
                    City= "Cleveland",
                    FirstName = "Martin",
                    LastName = "DeMarco",
                    AmountOfTickets = 0
               },

               new EventFinderEvent
               {
                    EventFinderEventTypeID = 7,
                    Title= "Chicago New Year's Eve Party",
                    StartDate = new DateTime(12,31,2018),
                    EndDate = new DateTime(1,1,2019),
                    MaxTickets = 50,
                    AvailableTickets = 50,
                    ZipCode = 44102,
                    OrganizerEmail = "chicago@chicago.gov",
                    Description = "Chi-Town Party!!!",
                    StartTime = new DateTime(12,31,2018),
                    EndTime = new DateTime(1,1,2019),
                    State = "IL",
                    City= "Chicago",
                    FirstName = "Tommy",
                    LastName = "Leary",
                    AmountOfTickets = 0
               }

            }.ForEach(a => context.EventFinderEvents.Add(a));
        }
    }
}
