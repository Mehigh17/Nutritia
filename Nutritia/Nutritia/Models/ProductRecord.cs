using System;
using Realms;

namespace Nutritia.Models
{
    /// <summary>
    /// This represents a history record showing what the user searched for.
    /// </summary>
    public class ProductRecord : RealmObject
    {

        /// <summary>
        /// The barcode of the product that has been scanned.
        /// </summary>
        public string Bardcode { get; set; }

        /// <summary>
        /// The date time at which the product has been searched.
        /// </summary>
        public DateTimeOffset SearchedOn { get; set; }

    }
}
