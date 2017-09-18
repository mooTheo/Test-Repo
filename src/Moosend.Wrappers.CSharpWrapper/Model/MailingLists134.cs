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
    /// MailingLists134
    /// </summary>
    [DataContract]
    public partial class MailingLists134 :  IEquatable<MailingLists134>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MailingLists134" /> class.
        /// </summary>
        /// <param name="Campaign">.</param>
        /// <param name="MailingList">MailingList.</param>
        /// <param name="Segment">.</param>
        public MailingLists134(string Campaign = default(string), MailingList69 MailingList = default(MailingList69), string Segment = default(string))
        {
            this.Campaign = Campaign;
            this.MailingList = MailingList;
            this.Segment = Segment;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="Campaign", EmitDefaultValue=false)]
        public string Campaign { get; set; }

        /// <summary>
        /// Gets or Sets MailingList
        /// </summary>
        [DataMember(Name="MailingList", EmitDefaultValue=false)]
        public MailingList69 MailingList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="Segment", EmitDefaultValue=false)]
        public string Segment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MailingLists134 {\n");
            sb.Append("  Campaign: ").Append(Campaign).Append("\n");
            sb.Append("  MailingList: ").Append(MailingList).Append("\n");
            sb.Append("  Segment: ").Append(Segment).Append("\n");
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
            return this.Equals(obj as MailingLists134);
        }

        /// <summary>
        /// Returns true if MailingLists134 instances are equal
        /// </summary>
        /// <param name="other">Instance of MailingLists134 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MailingLists134 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Campaign == other.Campaign ||
                    this.Campaign != null &&
                    this.Campaign.Equals(other.Campaign)
                ) && 
                (
                    this.MailingList == other.MailingList ||
                    this.MailingList != null &&
                    this.MailingList.Equals(other.MailingList)
                ) && 
                (
                    this.Segment == other.Segment ||
                    this.Segment != null &&
                    this.Segment.Equals(other.Segment)
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
                if (this.Campaign != null)
                    hash = hash * 59 + this.Campaign.GetHashCode();
                if (this.MailingList != null)
                    hash = hash * 59 + this.MailingList.GetHashCode();
                if (this.Segment != null)
                    hash = hash * 59 + this.Segment.GetHashCode();
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
