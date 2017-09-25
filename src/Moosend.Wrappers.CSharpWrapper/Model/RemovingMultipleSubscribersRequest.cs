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
    /// RemovingMultipleSubscribersRequest
    /// </summary>
    [DataContract]
    public partial class RemovingMultipleSubscribersRequest :  IEquatable<RemovingMultipleSubscribersRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemovingMultipleSubscribersRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RemovingMultipleSubscribersRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RemovingMultipleSubscribersRequest" /> class.
        /// </summary>
        /// <param name="Emails">A list of email addresses to be removed, separated with a comma (,). (required).</param>
        public RemovingMultipleSubscribersRequest(string Emails = default(string))
        {
            // to ensure "Emails" is required (not null)
            if (Emails == null)
            {
                throw new InvalidDataException("Emails is a required property for RemovingMultipleSubscribersRequest and cannot be null");
            }
            else
            {
                this.Emails = Emails;
            }
        }
        
        /// <summary>
        /// A list of email addresses to be removed, separated with a comma (,).
        /// </summary>
        /// <value>A list of email addresses to be removed, separated with a comma (,).</value>
        [DataMember(Name="Emails", EmitDefaultValue=false)]
        public string Emails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RemovingMultipleSubscribersRequest {\n");
            sb.Append("  Emails: ").Append(Emails).Append("\n");
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
            return this.Equals(obj as RemovingMultipleSubscribersRequest);
        }

        /// <summary>
        /// Returns true if RemovingMultipleSubscribersRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of RemovingMultipleSubscribersRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RemovingMultipleSubscribersRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Emails == other.Emails ||
                    this.Emails != null &&
                    this.Emails.Equals(other.Emails)
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
                if (this.Emails != null)
                    hash = hash * 59 + this.Emails.GetHashCode();
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