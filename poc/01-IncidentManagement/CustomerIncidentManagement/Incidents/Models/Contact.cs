using CustomerIncidentManagement.Incidents.Models.Enums;

namespace CustomerIncidentManagement.Incidents.Models;

public record Contact(
    ContactChannel ContactChannel,
    string? FirstName = null,
    string? LastName = null,
    string? EmailAddress = null,
    string? PhoneNumber = null
);