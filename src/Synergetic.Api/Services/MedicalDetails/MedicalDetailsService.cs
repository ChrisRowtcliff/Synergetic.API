namespace Synergetic.Api.Services.MedicalDetails
{
    using Synergetic.Api.Entities.Common;
    using Synergetic.Api.Entities.MedicalDetails;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    public class MedicalDetailsService : BaseApiService
    {
        private readonly string endpoint;

        public MedicalDetailsService()
        {
            this.endpoint = $"medicaldetails/{SynergeticClient.ApiVersion}";
        }

        public async Task<List<MedicalDetail>> Get()
        {
            return await this.Execute<List<MedicalDetail>>(HttpMethod.Get, endpoint);
        }

        public async Task<List<EntityResult>> Create(List<CreateMedicalDetailRequest> medicalDetails)
        {
            return await this.Execute<List<CreateMedicalDetailRequest>, List<EntityResult>>(HttpMethod.Post, endpoint, medicalDetails);
        }

        public async Task<EntityResult> Create(CreateMedicalDetailRequest medicalDetail)
        {
            var medicalDetails = new List<CreateMedicalDetailRequest> { medicalDetail };
            return (await this.Create(medicalDetails)).FirstOrDefault(); //Should only be one result as we're only passing in one record to change
        }

        public async Task<List<EntityResult>> Update(List<UpdateMedicalDetailRequest> medicalDetails)
        {
            return await this.Execute<List<UpdateMedicalDetailRequest>, List<EntityResult>>(HttpMethod.Put, endpoint, medicalDetails);
        }

        public async Task<EntityResult> Update(UpdateMedicalDetailRequest medicalDetail)
        {
            var medicalDetails = new List<UpdateMedicalDetailRequest> { medicalDetail };
            return (await this.Update(medicalDetails)).FirstOrDefault(); //Should only be one result as we're only passing in one record to change
        }
    }
}