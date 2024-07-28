using Diamond.Entities.Model;

namespace Diamond.DataAccess.Repositories.Interfaces
{
    public interface ICertificateRepository
    {
        public Task<List<CertificateModel>> GetCertificateByUserId(int userId);
    }
}
