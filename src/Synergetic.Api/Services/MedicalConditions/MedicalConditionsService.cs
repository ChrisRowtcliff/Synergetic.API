namespace Synergetic.Api.Services.MedicalConditions
{
    using Synergetic.Api.Entities.Common;
    using Synergetic.Api.Entities.MedicalConditions;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    public class MedicalConditionsService : BaseApiService
    {
        private readonly string endpoint;

        public MedicalConditionsService()
        {
            this.endpoint = $"medicalconditions/{SynergeticClient.ApiVersion}";
        }

        /// <summary>Returns a list of medical condition records based on the criteria you provide.</summary>
        /// <returns>List of <see cref="Synergetic.Api.Entities.MedicalConditions.MedicalCondition">MedicalCondition</see></returns>
        public async Task<List<MedicalCondition>> Get()
        {
            return await this.Execute<List<MedicalCondition>>(HttpMethod.Get, endpoint);
        }

        public async Task<List<EntityResult>> Create(List<CreateMedicalConditionsRequest> medicalConditions)
        {
            return await this.Execute<List<CreateMedicalConditionsRequest>, List<EntityResult>>(HttpMethod.Post, endpoint, medicalConditions);
        }

        public async Task<EntityResult> Create(CreateMedicalConditionsRequest medicalCondition)
        {
            var medicalConditions = new List<CreateMedicalConditionsRequest> { medicalCondition };
            return (await this.Create(medicalConditions)).FirstOrDefault(); //Should only be one result as we're only passing in one record to change
        }

        public async Task<List<EntityResult>> Update(List<UpdateMedicalConditionsRequest> medicalCondition)
        {
            return await this.Execute<List<UpdateMedicalConditionsRequest>, List<EntityResult>>(HttpMethod.Put, endpoint, medicalCondition);
        }

        public async Task<EntityResult> Update(UpdateMedicalConditionsRequest medicalCondition)
        {
            var medicalConditions = new List<UpdateMedicalConditionsRequest> { medicalCondition };
            return (await this.Update(medicalConditions)).FirstOrDefault(); //Should only be one result as we're only passing in one record to change
        }
    }
}