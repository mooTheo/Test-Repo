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
    /// CreatingAMailingListRequest
    /// </summary>
    [DataContract]
    public partial class CreatingAMailingListRequest :  IEquatable<CreatingAMailingListRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatingAMailingListRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreatingAMailingListRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatingAMailingListRequest" /> class.
        /// </summary>
        /// <param name="Name">The name of the new mailing list. (required).</param>
        /// <param name="ConfirmationPage">The URL of the page that will be displayed at the end of the subscription process..</param>
        /// <param name="RedirectAfterUnsubscribePage">The URL of the page that users will be redirected after unsubscribing from your mailing list..</param>
        public CreatingAMailingListRequest(string Name = default(string), string ConfirmationPage = default(string), string RedirectAfterUnsubscribePage = default(string))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for CreatingAMailingListRequest and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            this.ConfirmationPage = ConfirmationPage;
            this.RedirectAfterUnsubscribePage = RedirectAfterUnsubscribePage;
        }
        
        /// <summary>
        /// The name of the new mailing list.
        /// </summary>
        /// <value>The name of the new mailing list.</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The URL of the page that will be displayed at the end of the subscription process.
        /// </summary>
        /// <value>The URL of the page that will be displayed at the end of the subscription process.</value>
        [DataMember(Name="ConfirmationPage", EmitDefaultValue=false)]
        public string ConfirmationPage { get; set; }

        /// <summary>
        /// The URL of the page that users will be redirected after unsubscribing from your mailing list.
        /// </summary>
        /// <value>The URL of the page that users will be redirected after unsubscribing from your mailing list.</value>
        [DataMember(Name="RedirectAfterUnsubscribePage", EmitDefaultValue=false)]
        public string RedirectAfterUnsubscribePage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreatingAMailingListRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ConfirmationPage: ").Append(ConfirmationPage).Append("\n");
            sb.Append("  RedirectAfterUnsubscribePage: ").Append(RedirectAfterUnsubscribePage).Append("\n");
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
            return this.Equals(obj as CreatingAMailingListRequest);
        }

        /// <summary>
        /// Returns true if CreatingAMailingListRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CreatingAMailingListRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreatingAMailingListRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.ConfirmationPage == other.ConfirmationPage ||
                    this.ConfirmationPage != null &&
                    this.ConfirmationPage.Equals(other.ConfirmationPage)
                ) && 
                (
                    this.RedirectAfterUnsubscribePage == other.RedirectAfterUnsubscribePage ||
                    this.RedirectAfterUnsubscribePage != null &&
                    this.RedirectAfterUnsubscribePage.Equals(other.RedirectAfterUnsubscribePage)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.ConfirmationPage != null)
                    hash = hash * 59 + this.ConfirmationPage.GetHashCode();
                if (this.RedirectAfterUnsubscribePage != null)
                    hash = hash * 59 + this.RedirectAfterUnsubscribePage.GetHashCode();
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