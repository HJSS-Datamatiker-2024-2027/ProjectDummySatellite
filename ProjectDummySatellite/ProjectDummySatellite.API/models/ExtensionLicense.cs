namespace ProjectDummySatellite.API.models
{
    public class ExtensionLicense
    {
        public int Id { get; set; }
        public Guid TenantId { get; set; }
        public string CustomerName { get; set; }
        public Guid ExtensionId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Status { get; set; }
    }
}
