using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventHandlingApp.Models
{
    public class Event
    {
        public int Id { get; set; }
        public  EventType Type { get; set; }
        public String Description{ get; set; }
        public DateTime Time { get; set; }
        public Double Price { get { return (receptionPackage.Price * Participants) + Location.Rent; } }
        public int Duration { get; set; }
        public ReceptionPackage receptionPackage { get; set; }
        public int Participants { get; set; }
        public EventLocation Location { get; set; }
    }
}