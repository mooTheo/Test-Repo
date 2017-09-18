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
    /// UnsubscribingSubscribersFromMailingListResponse
    /// </summary>
    [DataContract]
    public partial class UnsubscribingSubscribersFromMailingListResponse :  IEquatable<UnsubscribingSubscribersFromMailingListResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnsubscribingSubscribersFromMailingListResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UnsubscribingSubscribersFromMailingListResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UnsubscribingSubscribersFromMailingListResponse" /> class.
        /// </summary>
        /// <param name="Code"> (required).</param>
        /// <param name="Error"> (required).</param>
        /// <param name="Context"> (required).</param>
        public UnsubscribingSubscribersFromMailingListResponse(int? Code = default(int?), string Error = default(string), string Context = default(string))
        {
            // to ensure "Code" is required (not null)
            if (Code == null)
            {
                throw new InvalidDataException("Code is a required property for UnsubscribingSubscribersFromMailingListResponse and cannot be null");
            }
            else
            {
                this.Code = Code;
            }
            // to ensure "Error" is required (not null)
            if (Error == null)
            {
                throw new InvalidDataException("Error is a required property for UnsubscribingSubscribersFromMailingListResponse and cannot be null");
            }
            else
            {
                this.Error = Error;
            }
            // to ensure "Context" is required (not null)
            if (Context == null)
            {
                throw new InvalidDataException("Context is a required property for UnsubscribingSubscribersFromMailingListResponse and cannot be null");
            }
            else
            {
                this.Context = Context;
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="Code", EmitDefaultValue=false)]
        public int? Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="Error", EmitDefaultValue=false)]
        public string Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="Context", EmitDefaultValue=false)]
        public string Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UnsubscribingSubscribersFromMailingListResponse {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
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
            return this.Equals(obj as UnsubscribingSubscribersFromMailingListResponse);
        }

        /// <summary>
        /// Returns true if UnsubscribingSubscribersFromMailingListResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of UnsubscribingSubscribersFromMailingListResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UnsubscribingSubscribersFromMailingListResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Code == other.Code ||
                    this.Code != null &&
                    this.Code.Equals(other.Code)
                ) && 
                (
                    this.Error == other.Error ||
                    this.Error != null &&
                    this.Error.Equals(other.Error)
                ) && 
                (
                    this.Context == other.Context ||
                    this.Context != null &&
                    this.Context.Equals(other.Context)
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
                if (this.Code != null)
                    hash = hash * 59 + this.Code.GetHashCode();
                if (this.Error != null)
                    hash = hash * 59 + this.Error.GetHashCode();
                if (this.Context != null)
                    hash = hash * 59 + this.Context.GetHashCode();
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
