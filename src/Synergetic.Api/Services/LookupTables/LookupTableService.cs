namespace Synergetic.Api.Services.LookupTables
{
    using Synergetic.Api.Entities.LookupTables;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;

    public class LookupTableService : BaseApiService
    {
        /// <summary>Returns a list of the values for each table associated with a given entity.</summary>
        /// <param name="lookupTable">The entity for which the list of tables and values is required.</param>
        /// <returns>List of <see cref="Synergetic.Api.Entities.LookupTables.LookupTable">LookupTable</see></returns>
        public async Task<List<LookupTable>> Get(LookupTables lookupTable)
        {
            var url = GetUrl(lookupTable);
            return await this.Execute<List<LookupTable>>(HttpMethod.Get, url);
        }

        private string GetUrl(LookupTables lookupTable)
        {
            return $"lookuptables/{SynergeticClient.ApiVersion}/{lookupTable.ToString()}";
        }
    }
}