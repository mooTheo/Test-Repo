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
    /// MailingLists119
    /// </summary>
    [DataContract]
    public partial class MailingLists119 :  IEquatable<MailingLists119>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MailingLists119" /> class.
        /// </summary>
        /// <param name="MailingListID">.</param>
        /// <param name="SegmentID">.</param>
        public MailingLists119(string MailingListID = default(string), double? SegmentID = default(double?))
        {
            this.MailingListID = MailingListID;
            this.SegmentID = SegmentID;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="MailingListID", EmitDefaultValue=false)]
        public string MailingListID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="SegmentID", EmitDefaultValue=false)]
        public double? SegmentID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MailingLists119 {\n");
            sb.Append("  MailingListID: ").Append(MailingListID).Append("\n");
            sb.Append("  SegmentID: ").Append(SegmentID).Append("\n");
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
            return this.Equals(obj as MailingLists119);
        }

        /// <summary>
        /// Returns true if MailingLists119 instances are equal
        /// </summary>
        /// <param name="other">Instance of MailingLists119 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MailingLists119 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.MailingListID == other.MailingListID ||
                    this.MailingListID != null &&
                    this.MailingListID.Equals(other.MailingListID)
                ) && 
                (
                    this.SegmentID == other.SegmentID ||
                    this.SegmentID != null &&
                    this.SegmentID.Equals(other.SegmentID)
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
                if (this.MailingListID != null)
                    hash = hash * 59 + this.MailingListID.GetHashCode();
                if (this.SegmentID != null)
                    hash = hash * 59 + this.SegmentID.GetHashCode();
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
