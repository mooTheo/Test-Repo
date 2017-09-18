/* 
 * Moosend API
 *
 * TODO: Add a description
 *
 * OpenAPI spec version: 1.0
 * 
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
using SwaggerDateConverter = Moosend.Wrappers.CSharpWrapper.Client.SwaggerDateConverter;

namespace Moosend.Wrappers.CSharpWrapper.Model
{
    /// <summary>
    /// Context32
    /// </summary>
    [DataContract]
    public partial class Context32 :  IEquatable<Context32>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Context32" /> class.
        /// </summary>
        /// <param name="Paging">Paging.</param>
        /// <param name="Subscribers">.</param>
        public Context32(Paging Paging = default(Paging), List<Subscriber> Subscribers = default(List<Subscriber>))
        {
            this.Paging = Paging;
            this.Subscribers = Subscribers;
        }
        
        /// <summary>
        /// Gets or Sets Paging
        /// </summary>
        [DataMember(Name="Paging", EmitDefaultValue=false)]
        public Paging Paging { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="Subscribers", EmitDefaultValue=false)]
        public List<Subscriber> Subscribers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Context32 {\n");
            sb.Append("  Paging: ").Append(Paging).Append("\n");
            sb.Append("  Subscribers: ").Append(Subscribers).Append("\n");
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
            return this.Equals(obj as Context32);
        }

        /// <summary>
        /// Returns true if Context32 instances are equal
        /// </summary>
        /// <param name="other">Instance of Context32 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Context32 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Paging == other.Paging ||
                    this.Paging != null &&
                    this.Paging.Equals(other.Paging)
                ) && 
                (
                    this.Subscribers == other.Subscribers ||
                    this.Subscribers != null &&
                    this.Subscribers.SequenceEqual(other.Subscribers)
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
                if (this.Paging != null)
                    hash = hash * 59 + this.Paging.GetHashCode();
                if (this.Subscribers != null)
                    hash = hash * 59 + this.Subscribers.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
