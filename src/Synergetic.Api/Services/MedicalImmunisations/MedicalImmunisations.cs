namespace Synergetic.Api.Services.MedicalImmunisations
{
    using Synergetic.Api.Entities.Common;
    using Synergetic.Api.Entities.MedicalImmunisations;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    public class MedicalImmunisationsService : BaseApiService
    {
        private readonly string endpoint;

        public MedicalImmunisationsService()
        {
            this.endpoint = $"medicalimmunisations/{SynergeticClient.ApiVersion}";
        }

        public async Task<List<MedicalImmunisation>> Get()
        {
            return await this.Execute<List<MedicalImmunisation>>(HttpMethod.Get, endpoint);
        }

        public async Task<List<EntityResult>> Create(List<CreateMedicalImmunisationRequest> medicalImmunisations)
        {
            return await this.Execute<List<CreateMedicalImmunisationRequest>, List<EntityResult>>(HttpMethod.Post, endpoint, medicalImmunisations);
        }

        public async Task<EntityResult> Create(CreateMedicalImmunisationRequest medicalImmunisation)
        {
            var medicalImmunisations = new List<CreateMedicalImmunisationRequest> { medicalImmunisation };
            return (await this.Create(medicalImmunisations)).FirstOrDefault(); //Should only be one result as we're only passing in one record to change
        }

        public async Task<List<EntityResult>> Update(List<UpdateMedicalImmunisationRequest> medicalImmunisations)
        {
            return await this.Execute<List<UpdateMedicalImmunisationRequest>, List<EntityResult>>(HttpMethod.Put, endpoint, medicalImmunisations);
        }

        public async Task<EntityResult> Update(UpdateMedicalImmunisationRequest medicalImmunisation)
        {
            var medicalImmunisations = new List<UpdateMedicalImmunisationRequest> { medicalImmunisation };
            return (await this.Update(medicalImmunisations)).FirstOrDefault(); //Should only be one result as we're only passing in one record to change
        }
    }
}