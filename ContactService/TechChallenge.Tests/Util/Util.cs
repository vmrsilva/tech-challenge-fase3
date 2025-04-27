using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechChallenge.Contact.Integration.Region.Dto;
using TechChallenge.Contact.Integration.Response;

namespace TechChallenge.Contact.Tests.Util
{
    public static class Util
    {
        public static IntegrationBaseResponseDto<RegionGetDto> GenerateFakeRegionServiceResponse(Guid mockRegionId)
        {
            var fakeRegionGetDto = new RegionGetDto
            {
                Id = mockRegionId,
                Name = "São Paulo",
                Ddd = "11"
            };

            var fakeBaseResponseDto = new IntegrationBaseResponseDto<RegionGetDto>
            {
                Success = true,
                Error = null,
                Errors = Enumerable.Empty<string>(),
                Data = fakeRegionGetDto
            };

            return fakeBaseResponseDto;
        }
    }
}
