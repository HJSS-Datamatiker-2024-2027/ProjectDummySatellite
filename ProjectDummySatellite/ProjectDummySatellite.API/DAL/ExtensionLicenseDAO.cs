using ProjectDummySatellite.API.models;

namespace ProjectDummySatellite.API.DAL
{
    public class ExtensionLicenseDAO
    {
        private readonly List<ExtensionLicense> _licenses;

        public ExtensionLicenseDAO()
        {
            _licenses = new List<ExtensionLicense>();
            setup();
        }

        public IEnumerable<ExtensionLicense> GetAll(Guid tenantId)
        {
            return _licenses.Where(license => license.TenantId == tenantId);
        }

        public ExtensionLicense Get(Guid tenantId, Guid extensionId)
        {
            return _licenses.Where(license => license.TenantId == tenantId && license.ExtensionId.Equals(extensionId)).First();
        }

        public bool Delete(Guid tenantId, Guid extensionId)
        {
            throw new NotImplementedException();
        }

        private void setup()
        {
            for (int i = 1; i < 6; i++)
            {
                ExtensionLicense license = new ExtensionLicense
                {
                    Id = i,
                    TenantId = Guid.Parse("1b81cb10-2baf-4ee4-a63e-f1603c774587"),
                    CustomerName = "Customer 2",
                    ExtensionId = Guid.Parse($"1b81cb10-2baf-4ee4-a63e-f1603c77458{i}"),
                    DateCreated = DateTime.Now,
                    ExpirationDate = DateTime.Now.AddDays(1),
                    Status = "Active"
                };

                _licenses.Add(license);
            }
        }
    }
}
