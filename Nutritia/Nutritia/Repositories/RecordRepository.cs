using System;
using System.Collections.Generic;
using System.Linq;
using Nutritia.Models;
using Realms;

namespace Nutritia.Repositories
{
    public class RecordRepository : IRecordRepository
    {

        private readonly Realm _realm;

        public RecordRepository()
        {
            _realm = Realm.GetInstance() ?? throw new ArgumentNullException(nameof(_realm));
        }

        public void AddRecord(ProductRecord record)
        {
            _realm.Write(() =>
            {
                _realm.Add(record);
            });
        }

        public void Clear()
        {
            _realm.Write(() =>
            {
                _realm.RemoveAll<ProductRecord>();
            });
        }

        public List<ProductRecord> GetRecords()
        {
            return _realm.All<ProductRecord>().ToList();
        }

        public void RemoveRecord(ProductRecord record)
        {
            _realm.Write(() =>
            {
                _realm.Remove(record);
            });
        }

        public void UpdateRecord(ProductRecord record)
        {
            _realm.Write(() =>
            {
                _realm.Add(record, true);
            });
        }

    }
}
