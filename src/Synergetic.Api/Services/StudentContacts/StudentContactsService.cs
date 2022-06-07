namespace Synergetic.Api.Services.StudentContacts
{
    using Synergetic.Api.Entities.Common;
    using Synergetic.Api.Entities.StudentContacts;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    public class StudentContactsService : BaseApiService
    {
        private readonly string endpoint;

        public StudentContactsService()
        {
            this.endpoint = $"studentcontacts/{SynergeticClient.ApiVersion}";
        }

        /// <summary>Returns a list of Student Contacts records based on provided criteria</summary>
        /// <returns>List of StudentContact</returns>
        /// <seealso cref="Synergetic.Api.Entities.StudentContacts.StudentContact">StudentContact</seealso>
        public async Task<List<StudentContact>> Get()
        {
            return await this.Execute<List<StudentContact>>(HttpMethod.Get, endpoint);
        }

        /// <summary>Create a contact records for a student.</summary>
        /// <param name="studentContacts">The student contacts to add.</param>
        /// <returns>List of EntityResult</returns>
        public async Task<List<EntityResult>> Create(List<CreateStudentContactRequest> studentContacts)
        {
            return await this.Execute<List<CreateStudentContactRequest>, List<EntityResult>>(HttpMethod.Post, endpoint, studentContacts);
        }
        /// <summary>Create a contact records for a student.</summary>
        /// <param name="studentContacts">The student contact to add.</param>
        /// <returns>EntityResult</returns>
        public async Task<EntityResult> Create(CreateStudentContactRequest studentContact)
        {
            var studentContacts = new List<CreateStudentContactRequest> { studentContact };
            return (await this.Create(studentContacts)).FirstOrDefault(); //Should only be one result as we're only passing in one record to change
        }

        /// <summary>Modify an existing Student Contact records.</summary>
        /// <param name="studentContacts">A list of student contacts to update.</param>
        /// <returns>EntityResult</returns>
        /// <seealso cref="Synergetic.Api.Entities.Common.EntityResult">EntityResult</seealso>
        public async Task<List<EntityResult>> Update(List<UpdateStudentContactRequest> studentContacts)
        {
            return await this.Execute<List<UpdateStudentContactRequest>, List<EntityResult>>(HttpMethod.Put, endpoint, studentContacts);
        }
        /// <summary>Modify an existing Student Contacts record.</summary>
        /// <param name="studentContacts">A list of student contacts to update.</param>
        /// <returns>EntityResult</returns>
        /// <seealso cref="Synergetic.Api.Entities.Common.EntityResult">EntityResult</seealso>
        public async Task<EntityResult> Update(UpdateStudentContactRequest studentContact)
        {
            var studentContacts = new List<UpdateStudentContactRequest> { studentContact };
            return (await this.Update(studentContacts)).FirstOrDefault(); //Should only be one result as we're only passing in one record to change
        }
    }
}