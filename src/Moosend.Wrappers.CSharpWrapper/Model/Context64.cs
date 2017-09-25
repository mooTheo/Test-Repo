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
    /// Context64
    /// </summary>
    [DataContract]
    public partial class Context64 :  IEquatable<Context64>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Context64" /> class.
        /// </summary>
        /// <param name="EmailsIgnored">.</param>
        /// <param name="EmailsProcessed">.</param>
        public Context64(double? EmailsIgnored = default(double?), double? EmailsProcessed = default(double?))
        {
            this.EmailsIgnored = EmailsIgnored;
            this.EmailsProcessed = EmailsProcessed;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="EmailsIgnored", EmitDefaultValue=false)]
        public double? EmailsIgnored { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="EmailsProcessed", EmitDefaultValue=false)]
        public double? EmailsProcessed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Context64 {\n");
            sb.Append("  EmailsIgnored: ").Append(EmailsIgnored).Append("\n");
            sb.Append("  EmailsProcessed: ").Append(EmailsProcessed).Append("\n");
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
            return this.Equals(obj as Context64);
        }

        /// <summary>
        /// Returns true if Context64 instances are equal
        /// </summary>
        /// <param name="other">Instance of Context64 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Context64 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EmailsIgnored == other.EmailsIgnored ||
                    this.EmailsIgnored != null &&
                    this.EmailsIgnored.Equals(other.EmailsIgnored)
                ) && 
                (
                    this.EmailsProcessed == other.EmailsProcessed ||
                    this.EmailsProcessed != null &&
                    this.EmailsProcessed.Equals(other.EmailsProcessed)
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
                if (this.EmailsIgnored != null)
                    hash = hash * 59 + this.EmailsIgnored.GetHashCode();
                if (this.EmailsProcessed != null)
                    hash = hash * 59 + this.EmailsProcessed.GetHashCode();
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
