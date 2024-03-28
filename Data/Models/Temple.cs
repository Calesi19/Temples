namespace Temples.Data.Models;

public class Temple
{
    
    public Guid? TempleId { get; set; } = Guid.NewGuid();
    public string TempleName { get; set; } = String.Empty;
    public string Country { get; set; } = String.Empty;
    public string? State { get; set; }
    public string City { get; set; } = String.Empty;
    public string AddressLine1 { get; set; } = String.Empty;
    public string? AddressLine2 { get; set; }
    public string? PostalCode { get; set; } = String.Empty;
    public string? DedicationDay { get; set; }
    public string? DedicationYear { get; set; }
    public string? DedicationMonth { get; set; }
    public string? AnnouncementDay { get; set; }
    public string? AnnouncementMonth { get; set; }
    public string? AnnouncementYear { get; set; }
    public string Status { get; set; } = String.Empty;
    public string ImageUrl { get; set; } = String.Empty;
    public string Description { get; set; } = String.Empty;
    public string Phone { get; set; } = String.Empty;
    public double Latitude { get; set; } = 0;
    public double Longitude { get; set; } = 0;
    public string? GoogleMapsLink { get; set; } 
}
