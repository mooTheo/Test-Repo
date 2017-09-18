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
    /// ABCampaignData
    /// </summary>
    [DataContract]
    public partial class ABCampaignData :  IEquatable<ABCampaignData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ABCampaignData" /> class.
        /// </summary>
        /// <param name="ABCampaignType">.</param>
        /// <param name="ABWinnerSelectionType">.</param>
        /// <param name="DeliveredOnA">.</param>
        /// <param name="DeliveredOnB">.</param>
        /// <param name="HTMLContentB">.</param>
        /// <param name="HoursToTest">.</param>
        /// <param name="ID">.</param>
        /// <param name="ListPercentage">.</param>
        /// <param name="PlainContentB">.</param>
        /// <param name="SenderB">.</param>
        /// <param name="SubjectB">.</param>
        /// <param name="WebLocationB">.</param>
        public ABCampaignData(double? ABCampaignType = default(double?), double? ABWinnerSelectionType = default(double?), string DeliveredOnA = default(string), string DeliveredOnB = default(string), string HTMLContentB = default(string), double? HoursToTest = default(double?), double? ID = default(double?), double? ListPercentage = default(double?), string PlainContentB = default(string), string SenderB = default(string), string SubjectB = default(string), string WebLocationB = default(string))
        {
            this.ABCampaignType = ABCampaignType;
            this.ABWinnerSelectionType = ABWinnerSelectionType;
            this.DeliveredOnA = DeliveredOnA;
            this.DeliveredOnB = DeliveredOnB;
            this.HTMLContentB = HTMLContentB;
            this.HoursToTest = HoursToTest;
            this.ID = ID;
            this.ListPercentage = ListPercentage;
            this.PlainContentB = PlainContentB;
            this.SenderB = SenderB;
            this.SubjectB = SubjectB;
            this.WebLocationB = WebLocationB;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="ABCampaignType", EmitDefaultValue=false)]
        public double? ABCampaignType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="ABWinnerSelectionType", EmitDefaultValue=false)]
        public double? ABWinnerSelectionType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="DeliveredOnA", EmitDefaultValue=false)]
        public string DeliveredOnA { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="DeliveredOnB", EmitDefaultValue=false)]
        public string DeliveredOnB { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="HTMLContentB", EmitDefaultValue=false)]
        public string HTMLContentB { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="HoursToTest", EmitDefaultValue=false)]
        public double? HoursToTest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="ID", EmitDefaultValue=false)]
        public double? ID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="ListPercentage", EmitDefaultValue=false)]
        public double? ListPercentage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="PlainContentB", EmitDefaultValue=false)]
        public string PlainContentB { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="SenderB", EmitDefaultValue=false)]
        public string SenderB { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="SubjectB", EmitDefaultValue=false)]
        public string SubjectB { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="WebLocationB", EmitDefaultValue=false)]
        public string WebLocationB { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ABCampaignData {\n");
            sb.Append("  ABCampaignType: ").Append(ABCampaignType).Append("\n");
            sb.Append("  ABWinnerSelectionType: ").Append(ABWinnerSelectionType).Append("\n");
            sb.Append("  DeliveredOnA: ").Append(DeliveredOnA).Append("\n");
            sb.Append("  DeliveredOnB: ").Append(DeliveredOnB).Append("\n");
            sb.Append("  HTMLContentB: ").Append(HTMLContentB).Append("\n");
            sb.Append("  HoursToTest: ").Append(HoursToTest).Append("\n");
            sb.Append("  ID: ").Append(ID).Append("\n");
            sb.Append("  ListPercentage: ").Append(ListPercentage).Append("\n");
            sb.Append("  PlainContentB: ").Append(PlainContentB).Append("\n");
            sb.Append("  SenderB: ").Append(SenderB).Append("\n");
            sb.Append("  SubjectB: ").Append(SubjectB).Append("\n");
            sb.Append("  WebLocationB: ").Append(WebLocationB).Append("\n");
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
            return this.Equals(obj as ABCampaignData);
        }

        /// <summary>
        /// Returns true if ABCampaignData instances are equal
        /// </summary>
        /// <param name="other">Instance of ABCampaignData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ABCampaignData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ABCampaignType == other.ABCampaignType ||
                    this.ABCampaignType != null &&
                    this.ABCampaignType.Equals(other.ABCampaignType)
                ) && 
                (
                    this.ABWinnerSelectionType == other.ABWinnerSelectionType ||
                    this.ABWinnerSelectionType != null &&
                    this.ABWinnerSelectionType.Equals(other.ABWinnerSelectionType)
                ) && 
                (
                    this.DeliveredOnA == other.DeliveredOnA ||
                    this.DeliveredOnA != null &&
                    this.DeliveredOnA.Equals(other.DeliveredOnA)
                ) && 
                (
                    this.DeliveredOnB == other.DeliveredOnB ||
                    this.DeliveredOnB != null &&
                    this.DeliveredOnB.Equals(other.DeliveredOnB)
                ) && 
                (
                    this.HTMLContentB == other.HTMLContentB ||
                    this.HTMLContentB != null &&
                    this.HTMLContentB.Equals(other.HTMLContentB)
                ) && 
                (
                    this.HoursToTest == other.HoursToTest ||
                    this.HoursToTest != null &&
                    this.HoursToTest.Equals(other.HoursToTest)
                ) && 
                (
                    this.ID == other.ID ||
                    this.ID != null &&
                    this.ID.Equals(other.ID)
                ) && 
                (
                    this.ListPercentage == other.ListPercentage ||
                    this.ListPercentage != null &&
                    this.ListPercentage.Equals(other.ListPercentage)
                ) && 
                (
                    this.PlainContentB == other.PlainContentB ||
                    this.PlainContentB != null &&
                    this.PlainContentB.Equals(other.PlainContentB)
                ) && 
                (
                    this.SenderB == other.SenderB ||
                    this.SenderB != null &&
                    this.SenderB.Equals(other.SenderB)
                ) && 
                (
                    this.SubjectB == other.SubjectB ||
                    this.SubjectB != null &&
                    this.SubjectB.Equals(other.SubjectB)
                ) && 
                (
                    this.WebLocationB == other.WebLocationB ||
                    this.WebLocationB != null &&
                    this.WebLocationB.Equals(other.WebLocationB)
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
                if (this.ABCampaignType != null)
                    hash = hash * 59 + this.ABCampaignType.GetHashCode();
                if (this.ABWinnerSelectionType != null)
                    hash = hash * 59 + this.ABWinnerSelectionType.GetHashCode();
                if (this.DeliveredOnA != null)
                    hash = hash * 59 + this.DeliveredOnA.GetHashCode();
                if (this.DeliveredOnB != null)
                    hash = hash * 59 + this.DeliveredOnB.GetHashCode();
                if (this.HTMLContentB != null)
                    hash = hash * 59 + this.HTMLContentB.GetHashCode();
                if (this.HoursToTest != null)
                    hash = hash * 59 + this.HoursToTest.GetHashCode();
                if (this.ID != null)
                    hash = hash * 59 + this.ID.GetHashCode();
                if (this.ListPercentage != null)
                    hash = hash * 59 + this.ListPercentage.GetHashCode();
                if (this.PlainContentB != null)
                    hash = hash * 59 + this.PlainContentB.GetHashCode();
                if (this.SenderB != null)
                    hash = hash * 59 + this.SenderB.GetHashCode();
                if (this.SubjectB != null)
                    hash = hash * 59 + this.SubjectB.GetHashCode();
                if (this.WebLocationB != null)
                    hash = hash * 59 + this.WebLocationB.GetHashCode();
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