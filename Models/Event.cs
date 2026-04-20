namespace Events.Models
{
    public class Event
    {
        public int ID { get; set; }
        public string EventName { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public DateOnly CreatedDate { get; set; }
        public Event() { }
    }
}
