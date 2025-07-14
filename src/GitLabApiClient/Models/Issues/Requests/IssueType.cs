using System.Runtime.Serialization;

namespace GitLabApiClient.Models.Issues.Requests
{
    public enum IssueType
    {
        [EnumMember(Value = "issue")]
        Issue,

        [EnumMember(Value = "incident")]
        Incident,

        [EnumMember(Value = "test_case")]
        TestCase,

        [EnumMember(Value = "task")]
        Task,
    }
}
