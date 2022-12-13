using CustomerIncidentManagement.Incidents.Models;

namespace CustomerIncidentManagement.Incidents.Commands;

public record RecordCustomerResponseToIncidentCommand(
    Guid IncidentId,
    IncidentResponse.FromCustomer Response
);
