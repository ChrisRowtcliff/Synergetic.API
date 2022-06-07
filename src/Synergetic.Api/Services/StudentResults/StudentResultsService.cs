namespace Synergetic.Api.Services.StudentResults
{
    using Synergetic.Api.Entities.StudentResults;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;

    public class StudentResultsService : BaseApiService
    {
        /// <summary>Returns the student results for the current semester. Results can be displayed for either academic or co-curricular classes.</summary>
        /// <returns>List of StudentResults</returns>
        /// <seealso cref="Synergetic.Api.Entities.StudentResults.StudentResult">StudentResult</seealso>
        public async Task<List<StudentResult>> Get()
        {
            var url = $"studentresults/{SynergeticClient.ApiVersion}";
            return await this.Execute<List<StudentResult>>(HttpMethod.Get, url);
        }
    }
}