namespace CustomerIncidentManagement.Incidents.Models;

public abstract record IncidentResponse
{
    public string Content { get; init; }

    public IncidentResponse(string content) => Content = content;

    public record FromAgent(Guid AgentId, string Content, bool VisibleToCustomer) : IncidentResponse(Content);
    public record FromCustomer(Guid CustomerId, string Content) : IncidentResponse(Content);
}