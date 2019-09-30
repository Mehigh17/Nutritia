using System.Collections.Generic;
using Nutritia.Models;

namespace Nutritia.Repositories
{
    public interface IRecordRepository
    {

        List<ProductRecord> GetRecords();
        void AddRecord(ProductRecord record);
        void RemoveRecord(ProductRecord record);
        void UpdateRecord(ProductRecord record);

        /// <summary>
        /// Remove all the records from the repository.
        /// </summary>
        void Clear();

    }
}
