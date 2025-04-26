using Refit;
using TechChallenge.Contact.Integration.Region.Dto;
using TechChallenge.Contact.Integration.Response;

namespace TechChallenge.Contact.Integration.Region
{
    public interface IRegionIntegration
    {
        [Get("/Region/get-by-id/{id}")]
        Task<BaseResponseDto<RegionGetDto>> GetById(Guid id);

        [Get("/Region/get-by-ddd/{ddd}")]
        Task<BaseResponseDto<RegionGetDto>> GetByDDD(string ddd);
    }
}
