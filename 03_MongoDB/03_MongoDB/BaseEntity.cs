using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace _03_MongoDB
{
    public abstract class BaseEntity
    {
        /// <summary>
        /// Gets or sets the id for this object (the primary record for an entity)
        /// </summary>
        [BsonId]
        public ObjectId Id { get; set; }
    }
}
