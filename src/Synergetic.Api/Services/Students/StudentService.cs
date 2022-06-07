namespace Synergetic.Api.Services.Students
{
    using Synergetic.Api.Entities.Students;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;

    public class StudentService : BaseApiService
    {
        /// <summary>Returns a list of Students' information for the current semester.</summary>
        /// <returns>A list of <see cref="Synergetic.Api.Entities.Students.Student">Student</seealso> Entities</returns>
        public async Task<List<Student>> Get()
        {
            var url = $"students/{SynergeticClient.ApiVersion}";
            return await this.Execute<List<Student>>(HttpMethod.Get, url);
        }
    }
}