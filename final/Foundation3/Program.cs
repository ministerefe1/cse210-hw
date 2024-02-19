using System;

class Address
{
    private string street;
    private string city;
    private string state;
    private string country;

    public Address(string street, string city, string state, string country)
    {
        this.street = street;
        this.city = city;
        this.state = state;
        this.country = country;
    }

    public string GetAddressString()
    {
        return $"Street: {street}, City: {city}, State: {state}, Country: {country}";
    }
}

class Event
{
    private string title;
    private string description;
    private string date;
    private string time;
    private Address address;

    public Event(string title, string description, string date, string time, Address address)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }

    public string GetStandardDetails()
    {
        return $"Title: {title}\nDescription: {description}\nDate: {date}\nTime: {time}\nAddress: {address.GetAddressString()}";
    }

    public virtual string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nType: Generic Event";
    }

    public string GetShortDescription()
    {
        return $"Type: Generic Event\nTitle: {title}\nDate: {date}";
    }
}

class Lecture : Event
{
    private string speaker;
    private int capacity;

    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        this.speaker = speaker;
        this.capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nType: Lecture\nSpeaker: {speaker}\nCapacity: {capacity} attendees";
    }
}

class Reception : Event
{
    private string rsvpEmail;

    public Reception(string title, string description, string date, string time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        this.rsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nType: Reception\nRSVP Email: {rsvpEmail}";
    }
}

class OutdoorGathering : Event
{
    private string weatherForecast;

    public OutdoorGathering(string title, string description, string date, string time, Address address, string weatherForecast)
        : base(title, description, date, time, address)
    {
        this.weatherForecast = weatherForecast;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nType: Outdoor Gathering\nWeather Forecast: {weatherForecast}";
    }
}

class Program
{
    static void Main()
    {
        // Create addresses
        Address address1 = new Address("123 Main St", "Cityville", "CA", "USA");
        Address address2 = new Address("456 Oak St", "Townsville", "NY", "Canada");
        Address address3 = new Address("789 Park Ave", "Sunnyvale", "CA", "USA");

        // Create events
        Event event1 = new Lecture("Coding Workshop", "Learn to code in a day!", "2024-02-21", "10:00 AM", address1, "John Doe", 50);
        Event event2 = new Reception("Networking Mixer", "Connect with professionals", "2024-03-15", "6:00 PM", address2, "rsvp@example.com");
        Event event3 = new OutdoorGathering("Picnic in the Park", "Enjoy food and games", "2024-04-05", "1:00 PM", address3, "Sunny with a chance of clouds");

        // Display marketing messages for each event
        Console.WriteLine("Event 1 Marketing Messages:");
        Console.WriteLine("Standard Details:\n" + event1.GetStandardDetails());
        Console.WriteLine("Full Details:\n" + event1.GetFullDetails());
        Console.WriteLine("Short Description:\n" + event1.GetShortDescription());

        Console.WriteLine("\nEvent 2 Marketing Messages:");
        Console.WriteLine("Standard Details:\n" + event2.GetStandardDetails());
        Console.WriteLine("Full Details:\n" + event2.GetFullDetails());
        Console.WriteLine("Short Description:\n" + event2.GetShortDescription());

        Console.WriteLine("\nEvent 3 Marketing Messages:");
        Console.WriteLine("Standard Details:\n" + event3.GetStandardDetails());
        Console.WriteLine("Full Details:\n" + event3.GetFullDetails());
        Console.WriteLine("Short Description:\n" + event3.GetShortDescription());
    }
}
