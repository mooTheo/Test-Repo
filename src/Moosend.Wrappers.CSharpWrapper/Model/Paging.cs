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
    /// Paging
    /// </summary>
    [DataContract]
    public partial class Paging :  IEquatable<Paging>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Paging" /> class.
        /// </summary>
        /// <param name="CurrentPage">.</param>
        /// <param name="PageSize">.</param>
        /// <param name="SortExpression">.</param>
        /// <param name="SortIsAscending">.</param>
        /// <param name="TotalPageCount">.</param>
        /// <param name="TotalResults">.</param>
        public Paging(double? CurrentPage = default(double?), double? PageSize = default(double?), string SortExpression = default(string), bool? SortIsAscending = default(bool?), double? TotalPageCount = default(double?), double? TotalResults = default(double?))
        {
            this.CurrentPage = CurrentPage;
            this.PageSize = PageSize;
            this.SortExpression = SortExpression;
            this.SortIsAscending = SortIsAscending;
            this.TotalPageCount = TotalPageCount;
            this.TotalResults = TotalResults;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="CurrentPage", EmitDefaultValue=false)]
        public double? CurrentPage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="PageSize", EmitDefaultValue=false)]
        public double? PageSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="SortExpression", EmitDefaultValue=false)]
        public string SortExpression { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="SortIsAscending", EmitDefaultValue=false)]
        public bool? SortIsAscending { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="TotalPageCount", EmitDefaultValue=false)]
        public double? TotalPageCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="TotalResults", EmitDefaultValue=false)]
        public double? TotalResults { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Paging {\n");
            sb.Append("  CurrentPage: ").Append(CurrentPage).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  SortExpression: ").Append(SortExpression).Append("\n");
            sb.Append("  SortIsAscending: ").Append(SortIsAscending).Append("\n");
            sb.Append("  TotalPageCount: ").Append(TotalPageCount).Append("\n");
            sb.Append("  TotalResults: ").Append(TotalResults).Append("\n");
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
            return this.Equals(obj as Paging);
        }

        /// <summary>
        /// Returns true if Paging instances are equal
        /// </summary>
        /// <param name="other">Instance of Paging to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Paging other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CurrentPage == other.CurrentPage ||
                    this.CurrentPage != null &&
                    this.CurrentPage.Equals(other.CurrentPage)
                ) && 
                (
                    this.PageSize == other.PageSize ||
                    this.PageSize != null &&
                    this.PageSize.Equals(other.PageSize)
                ) && 
                (
                    this.SortExpression == other.SortExpression ||
                    this.SortExpression != null &&
                    this.SortExpression.Equals(other.SortExpression)
                ) && 
                (
                    this.SortIsAscending == other.SortIsAscending ||
                    this.SortIsAscending != null &&
                    this.SortIsAscending.Equals(other.SortIsAscending)
                ) && 
                (
                    this.TotalPageCount == other.TotalPageCount ||
                    this.TotalPageCount != null &&
                    this.TotalPageCount.Equals(other.TotalPageCount)
                ) && 
                (
                    this.TotalResults == other.TotalResults ||
                    this.TotalResults != null &&
                    this.TotalResults.Equals(other.TotalResults)
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
                if (this.CurrentPage != null)
                    hash = hash * 59 + this.CurrentPage.GetHashCode();
                if (this.PageSize != null)
                    hash = hash * 59 + this.PageSize.GetHashCode();
                if (this.SortExpression != null)
                    hash = hash * 59 + this.SortExpression.GetHashCode();
                if (this.SortIsAscending != null)
                    hash = hash * 59 + this.SortIsAscending.GetHashCode();
                if (this.TotalPageCount != null)
                    hash = hash * 59 + this.TotalPageCount.GetHashCode();
                if (this.TotalResults != null)
                    hash = hash * 59 + this.TotalResults.GetHashCode();
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
