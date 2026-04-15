using ProjectDummySatellite.API.models;

namespace ProjectDummySatellite.API.DAL
{
    public class ExtensionLicenseDAO
    {
        private readonly IEnumerable<ExtensionLicense> _licenses = new List<ExtensionLicense>();

        public ExtensionLicenseDAO()
        {

        }
    }
}
