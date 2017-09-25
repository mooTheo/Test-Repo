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
    /// SchedulingACampaignRequest
    /// </summary>
    [DataContract]
    public partial class SchedulingACampaignRequest :  IEquatable<SchedulingACampaignRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SchedulingACampaignRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SchedulingACampaignRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SchedulingACampaignRequest" /> class.
        /// </summary>
        /// <param name="DateTime">The date and time at which the campaign will be delivered. (required).</param>
        /// <param name="Timezone">The timezone the specified date and time refers to. By default the timezone in your settings panel will be used. If specified, one of the following values must be used. * Dateline Standard Time * Samoa Standard Time * Hawaiian Standard Time * Alaskan Standard Time * Pacific Standard Time * Pacific Standard Time (Mexico) * US Mountain Standard Time * Mountain Standard Time (Mexico) * Mountain Standard Time * Central Standard Time * Central Standard Time (Mexico) * Canada Central Standard Time * SA Pacific Standard Time * US Eastern Standard Time * Eastern Standard Time * Venezuela Standard Time * Atlantic Standard Time * SA Western Standard Time * Central Brazilian Standard Time * Pacific SA Standard Time * Newfoundland Standard Time * E. South America Standard Time * Argentina Standard Time * SA Eastern Standard Time * Greenland Standard Time * Montevideo Standard Time * Mid-Atlantic Standard Time * Azores Standard Time * Cape Verde Standard Time * Greenwich Standard Time * GMT Standard Time * Morocco Standard Time * W. Central Africa Standard Time * Central European Standard Time * Romance Standard Time * W. Europe Standard Time * Namibia Standard Time * E. Europe Standard Time * Israel Standard Time * FLE Standard Time * South Africa Standard Time * Egypt Standard Time * Middle East Standard Time * GTB Standard Time * Jordan Standard Time * Iran Standard Time * Georgian Standard Time * E. Africa Standard Time * Russian Standard Time * Arab Standard Time * Arabic Standard Time * Caucasus Standard Time * Mauritius Standard Time * Azerbaijan Standard Time * Arabian Standard Time * Afghanistan Standard Time * West Asia Standard Time * Pakistan Standard Time * Ekaterinburg Standard Time * Sri Lanka Standard Time * India Standard Time * Nepal Standard Time * N. Central Asia Standard Time * Central Asia Standard Time * Myanmar Standard Time * North Asia Standard Time * SE Asia Standard Time * Taipei Standard Time * W. Australia Standard Time * Singapore Standard Time * North Asia East Standard Time * China Standard Time * Yakutsk Standard Time * Korea Standard Time * Tokyo Standard Time * AUS Central Standard Time * Cen. Australia Standard Time * AUS Eastern Standard Time * West Pacific Standard Time * Tasmania Standard Time * Vladivostok Standard Time * Central Pacific Standard Time * New Zealand Standard Time * Tonga Standard Time.</param>
        public SchedulingACampaignRequest(string DateTime = default(string), string Timezone = default(string))
        {
            // to ensure "DateTime" is required (not null)
            if (DateTime == null)
            {
                throw new InvalidDataException("DateTime is a required property for SchedulingACampaignRequest and cannot be null");
            }
            else
            {
                this.DateTime = DateTime;
            }
            this.Timezone = Timezone;
        }
        
        /// <summary>
        /// The date and time at which the campaign will be delivered.
        /// </summary>
        /// <value>The date and time at which the campaign will be delivered.</value>
        [DataMember(Name="DateTime", EmitDefaultValue=false)]
        public string DateTime { get; set; }

        /// <summary>
        /// The timezone the specified date and time refers to. By default the timezone in your settings panel will be used. If specified, one of the following values must be used. * Dateline Standard Time * Samoa Standard Time * Hawaiian Standard Time * Alaskan Standard Time * Pacific Standard Time * Pacific Standard Time (Mexico) * US Mountain Standard Time * Mountain Standard Time (Mexico) * Mountain Standard Time * Central Standard Time * Central Standard Time (Mexico) * Canada Central Standard Time * SA Pacific Standard Time * US Eastern Standard Time * Eastern Standard Time * Venezuela Standard Time * Atlantic Standard Time * SA Western Standard Time * Central Brazilian Standard Time * Pacific SA Standard Time * Newfoundland Standard Time * E. South America Standard Time * Argentina Standard Time * SA Eastern Standard Time * Greenland Standard Time * Montevideo Standard Time * Mid-Atlantic Standard Time * Azores Standard Time * Cape Verde Standard Time * Greenwich Standard Time * GMT Standard Time * Morocco Standard Time * W. Central Africa Standard Time * Central European Standard Time * Romance Standard Time * W. Europe Standard Time * Namibia Standard Time * E. Europe Standard Time * Israel Standard Time * FLE Standard Time * South Africa Standard Time * Egypt Standard Time * Middle East Standard Time * GTB Standard Time * Jordan Standard Time * Iran Standard Time * Georgian Standard Time * E. Africa Standard Time * Russian Standard Time * Arab Standard Time * Arabic Standard Time * Caucasus Standard Time * Mauritius Standard Time * Azerbaijan Standard Time * Arabian Standard Time * Afghanistan Standard Time * West Asia Standard Time * Pakistan Standard Time * Ekaterinburg Standard Time * Sri Lanka Standard Time * India Standard Time * Nepal Standard Time * N. Central Asia Standard Time * Central Asia Standard Time * Myanmar Standard Time * North Asia Standard Time * SE Asia Standard Time * Taipei Standard Time * W. Australia Standard Time * Singapore Standard Time * North Asia East Standard Time * China Standard Time * Yakutsk Standard Time * Korea Standard Time * Tokyo Standard Time * AUS Central Standard Time * Cen. Australia Standard Time * AUS Eastern Standard Time * West Pacific Standard Time * Tasmania Standard Time * Vladivostok Standard Time * Central Pacific Standard Time * New Zealand Standard Time * Tonga Standard Time
        /// </summary>
        /// <value>The timezone the specified date and time refers to. By default the timezone in your settings panel will be used. If specified, one of the following values must be used. * Dateline Standard Time * Samoa Standard Time * Hawaiian Standard Time * Alaskan Standard Time * Pacific Standard Time * Pacific Standard Time (Mexico) * US Mountain Standard Time * Mountain Standard Time (Mexico) * Mountain Standard Time * Central Standard Time * Central Standard Time (Mexico) * Canada Central Standard Time * SA Pacific Standard Time * US Eastern Standard Time * Eastern Standard Time * Venezuela Standard Time * Atlantic Standard Time * SA Western Standard Time * Central Brazilian Standard Time * Pacific SA Standard Time * Newfoundland Standard Time * E. South America Standard Time * Argentina Standard Time * SA Eastern Standard Time * Greenland Standard Time * Montevideo Standard Time * Mid-Atlantic Standard Time * Azores Standard Time * Cape Verde Standard Time * Greenwich Standard Time * GMT Standard Time * Morocco Standard Time * W. Central Africa Standard Time * Central European Standard Time * Romance Standard Time * W. Europe Standard Time * Namibia Standard Time * E. Europe Standard Time * Israel Standard Time * FLE Standard Time * South Africa Standard Time * Egypt Standard Time * Middle East Standard Time * GTB Standard Time * Jordan Standard Time * Iran Standard Time * Georgian Standard Time * E. Africa Standard Time * Russian Standard Time * Arab Standard Time * Arabic Standard Time * Caucasus Standard Time * Mauritius Standard Time * Azerbaijan Standard Time * Arabian Standard Time * Afghanistan Standard Time * West Asia Standard Time * Pakistan Standard Time * Ekaterinburg Standard Time * Sri Lanka Standard Time * India Standard Time * Nepal Standard Time * N. Central Asia Standard Time * Central Asia Standard Time * Myanmar Standard Time * North Asia Standard Time * SE Asia Standard Time * Taipei Standard Time * W. Australia Standard Time * Singapore Standard Time * North Asia East Standard Time * China Standard Time * Yakutsk Standard Time * Korea Standard Time * Tokyo Standard Time * AUS Central Standard Time * Cen. Australia Standard Time * AUS Eastern Standard Time * West Pacific Standard Time * Tasmania Standard Time * Vladivostok Standard Time * Central Pacific Standard Time * New Zealand Standard Time * Tonga Standard Time</value>
        [DataMember(Name="Timezone", EmitDefaultValue=false)]
        public string Timezone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SchedulingACampaignRequest {\n");
            sb.Append("  DateTime: ").Append(DateTime).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
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
            return this.Equals(obj as SchedulingACampaignRequest);
        }

        /// <summary>
        /// Returns true if SchedulingACampaignRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of SchedulingACampaignRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SchedulingACampaignRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DateTime == other.DateTime ||
                    this.DateTime != null &&
                    this.DateTime.Equals(other.DateTime)
                ) && 
                (
                    this.Timezone == other.Timezone ||
                    this.Timezone != null &&
                    this.Timezone.Equals(other.Timezone)
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
                if (this.DateTime != null)
                    hash = hash * 59 + this.DateTime.GetHashCode();
                if (this.Timezone != null)
                    hash = hash * 59 + this.Timezone.GetHashCode();
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