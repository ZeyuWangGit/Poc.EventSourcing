using CustomerIncidentManagement.Incidents.Events;
using CustomerIncidentManagement.Incidents.Models.Enums;

namespace CustomerIncidentManagement.Incidents.Models;

public record Incident(
    Guid Id,
    IncidentStatus Status = IncidentStatus.Pending,
    bool HasOutstandingResponseToCustomer = false,
    IncidentCategory? Category = null,
    IncidentPriority? Priority = null,
    Guid? AgentId = null,
    int Version = 1
    )
{
    public static Incident Create(IncidentLoggedEvent loggedEvent) => new(loggedEvent.IncidentId);
    public Incident Apply(IncidentCategorisedEvent categorisedEvent) => this with {Category = categorisedEvent.Category };
    public Incident Apply(IncidentPrioritisedEvent prioritisedEvent) => this with { Priority = prioritisedEvent.Priority };
    public Incident Apply(AgentRespondedToIncidentEvent agentRespondedEvent) => this with { HasOutstandingResponseToCustomer = false };
    public Incident Apply(CustomerRespondedToIncidentEvent customerRespondedEvent) => this with { HasOutstandingResponseToCustomer = true };
    public Incident Apply(IncidentResolvedEvent resolvedEvent) => this with { Status = IncidentStatus.Resolved };
    public Incident Apply(ResolutionAcknowledgedByCustomer acknowledgedEvent) => this with { Status = IncidentStatus.ResolutionAcknowledgedByCustomer };
    public Incident Apply(IncidentClosedEvent closedEvent) => this with { Status = IncidentStatus.Closed };

}