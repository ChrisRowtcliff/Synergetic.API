namespace Synergetic.Api.Services.StudentAllergies
{
    using Synergetic.Api.Entities.Common;
    using Synergetic.Api.Entities.StudentAllergies;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    public class StudentAllergyService : BaseApiService
    {
        private readonly string endpoint;

        public StudentAllergyService()
        {
            this.endpoint = $"studentallergies/{SynergeticClient.ApiVersion}";
        }

        /// <summary>
        ///  Returns a list of Student Allergies records based on provided criteria
        /// </summary>
        /// <returns>List of <see cref="Synergetic.Api.Entities.StudentAllergies.StudentAllergy">StudentAllergy</seealso></returns>
        public async Task<List<StudentAllergy>> Get()
        {
            return await this.Execute<List<StudentAllergy>>(HttpMethod.Get, endpoint);
        }

        /// <summary>Creates the specified student allergy.</summary>
        /// <param name="studentAllergy">The list of StudentAllergies to add</param>
        /// <returns>List of <see cref="Synergetic.Api.Entities.Common.EntityResult">EntityResult</see></returns>
        /// <seealso cref="Synergetic.Api.Services.StudentAllergies.CreateStudentAllergyRequest">CreateStudentAllergyRequest</seealso>

        public async Task<List<EntityResult>> Create(List<CreateStudentAllergyRequest> studentAllergy)
        {
            return await this.Execute<List<CreateStudentAllergyRequest>, List<EntityResult>>(HttpMethod.Post, endpoint, studentAllergy);
        }

        /// <summary>Creates the specified student allergy.</summary>
        /// <param name="studentAllergy">The <see cref="Synergetic.Api.Services.StudentAllergies.CreateStudentAllergyRequest">Student Allergy</see> to add</param>
        /// <returns><also cref="Synergetic.Api.Entities.Common.EntityResult">EntityResult</see></returns>
        /// 
        /// <seealso cref="Synergetic.Api.Entities.Common.EntityResult">EntityResult</seealso>
        public async Task<EntityResult> Create(CreateStudentAllergyRequest studentAllergy)
        {
            var allergies = new List<CreateStudentAllergyRequest> { studentAllergy };
            return (await this.Create(allergies)).FirstOrDefault(); //Should only be one result as we're only passing in one record to change
        }

        /// <summary>Updates the specified student allergy.</summary>
        /// <param name="studentAllergy">The list of StudentAllergies to update</param>
        /// <returns>List of <see cref="Synergetic.Api.Entities.Common.EntityResult">EntityResult</see></returns>
        /// <seealso cref="Synergetic.Api.Services.UpdateStudentAllergyRequest">UpdateAllergyRequest</seealso>
        /// <seealso cref="Synergetic.Api.Entities.Common.EntityResult">EntityResult</seealso>
        public async Task<List<EntityResult>> Update(List<UpdateStudentAllergyRequest> studentAllergy)
        {
            return await this.Execute<List<UpdateStudentAllergyRequest>, List<EntityResult>>(HttpMethod.Put, endpoint, studentAllergy);
        }

        /// <summary>Updates the specified student allergy.</summary>
        /// <param name="studentAllergy">The StudentAllergy to update</param>
        /// <returns>EntityResult</returns>
        /// <seealso cref="Synergetic.Api.Services.UpdateStudentAllergyRequest">UpdateAllergyRequest</seealso>
        /// <returns><see cref="Synergetic.Api.Entities.Common.EntityResult">EntityResult</see></returns>
        public async Task<EntityResult> Update(UpdateStudentAllergyRequest studentAllergy)
        {
            var allergies = new List<UpdateStudentAllergyRequest> { studentAllergy };
            return (await this.Update(allergies)).FirstOrDefault(); //Should only be one result as we're only passing in one record to change
        }
    }
}