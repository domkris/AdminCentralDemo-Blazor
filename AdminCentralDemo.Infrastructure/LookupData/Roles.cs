namespace AdminCentralDemo.Infrastructure.LookupData
{
    public enum Roles : long
    {
        Administrator = 1L,
        Manager = 2L,
        Employee = 3L
    }

    public static class RoleIds
    {
        public const string Administrator = "1";
        public const string Manager = "2";
        public const string Employee = "3";
    }
}
