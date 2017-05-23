/* 
 * Square Connect API
 *
 * Client library for accessing the Square Connect APIs
 *
 * OpenAPI spec version: 2.0
 * Contact: developers@squareup.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Square.Connect.Model
{
    /// <summary>
    /// A mapping between a client-supplied temporary ID and a permanent server ID.
    /// </summary>
    [DataContract]
    public partial class CatalogIdMapping :  IEquatable<CatalogIdMapping>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogIdMapping" /> class.
        /// </summary>
        /// <param name="ClientObjectId">The client-supplied, temporary &#x60;#&#x60;-prefixed ID for a new [CatalogObject](#type-catalogobject)..</param>
        /// <param name="ObjectId">The permanent ID for the [CatalogObject](#type-catalogobject) created by the server..</param>
        public CatalogIdMapping(string ClientObjectId = default(string), string ObjectId = default(string))
        {
            this.ClientObjectId = ClientObjectId;
            this.ObjectId = ObjectId;
        }
        
        /// <summary>
        /// The client-supplied, temporary &#x60;#&#x60;-prefixed ID for a new [CatalogObject](#type-catalogobject).
        /// </summary>
        /// <value>The client-supplied, temporary &#x60;#&#x60;-prefixed ID for a new [CatalogObject](#type-catalogobject).</value>
        [DataMember(Name="client_object_id", EmitDefaultValue=false)]
        public string ClientObjectId { get; set; }
        /// <summary>
        /// The permanent ID for the [CatalogObject](#type-catalogobject) created by the server.
        /// </summary>
        /// <value>The permanent ID for the [CatalogObject](#type-catalogobject) created by the server.</value>
        [DataMember(Name="object_id", EmitDefaultValue=false)]
        public string ObjectId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CatalogIdMapping {\n");
            sb.Append("  ClientObjectId: ").Append(ClientObjectId).Append("\n");
            sb.Append("  ObjectId: ").Append(ObjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as CatalogIdMapping);
        }

        /// <summary>
        /// Returns true if CatalogIdMapping instances are equal
        /// </summary>
        /// <param name="other">Instance of CatalogIdMapping to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CatalogIdMapping other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ClientObjectId == other.ClientObjectId ||
                    this.ClientObjectId != null &&
                    this.ClientObjectId.Equals(other.ClientObjectId)
                ) && 
                (
                    this.ObjectId == other.ObjectId ||
                    this.ObjectId != null &&
                    this.ObjectId.Equals(other.ObjectId)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.ClientObjectId != null)
                    hash = hash * 59 + this.ClientObjectId.GetHashCode();
                if (this.ObjectId != null)
                    hash = hash * 59 + this.ObjectId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}