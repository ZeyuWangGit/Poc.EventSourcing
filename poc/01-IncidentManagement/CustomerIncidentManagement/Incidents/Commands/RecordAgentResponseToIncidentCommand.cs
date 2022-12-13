using CustomerIncidentManagement.Incidents.Models;

namespace CustomerIncidentManagement.Incidents.Commands
{
    public record RecordAgentResponseToIncidentCommand(
        Guid IncidentId,
        IncidentResponse.FromAgent Response
    );
}
