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
    /// CreatingADraftCampaignRequest
    /// </summary>
    [DataContract]
    public partial class CreatingADraftCampaignRequest :  IEquatable<CreatingADraftCampaignRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatingADraftCampaignRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreatingADraftCampaignRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatingADraftCampaignRequest" /> class.
        /// </summary>
        /// <param name="Name">The name of the campaign. (required).</param>
        /// <param name="Subject">The subject line of the new campaign. (required).</param>
        /// <param name="SenderEmail">The sender email of the campaign. (required).</param>
        /// <param name="ReplyToEmail">The email address to which recipients replies will arrive. It must be one of your sender accounts. If not specified, the sender&#39;s email will be assumed. (required).</param>
        /// <param name="IsAB">A flag that defines if a campaign is an AB campaign. (required).</param>
        /// <param name="ConfirmationToEmail">The email address to which a confirmation message will be,  sent when the campaign has been successfully sent..</param>
        /// <param name="WebLocation">A url to retrieve the html content for the campaign. We&#39;ll automatically move all CSS inline..</param>
        /// <param name="MailingLists">A list of mailing lists in your account to which the campaign will be sent to..</param>
        /// <param name="SegmentID">The ID of a segment in the specified mailing list to filter the recipients with. If not specified, the campaign will be sent to all active subscribers of the mailing list..</param>
        /// <param name="ABCampaignType">If you want to send an AB split campaign you should specify this parameter to one of the following values.  * &#x60;Subject&#x60; * &#x60;Sender&#x60; * &#x60;Content&#x60;.</param>
        /// <param name="TrackInGoogleAnalytics">Tracks traffic from your campaign to your site. Note: You need to have Google Analytics configured on your site to use this feature..</param>
        /// <param name="DontTrackLinkClicks">Moosend wraps your own links with its own to enable link click tracking. Check this box if you don&#39;t wish to track link click traffic through Moosend..</param>
        /// <param name="SubjectB">If you wish to send an AB split campaign with two different versions of the subject line , you must specify the second subject using this parameter. If specified in any other campaign type, it will be ignored..</param>
        /// <param name="WebLocationB">If you wish to send an AB split campaign with two different versions of the html content, you must specify where the second html content will be retrieved from using this parameter. If specified in any other campaign type, it will be ignored..</param>
        /// <param name="SenderEmailB">If you wish to send an AB split campaign with two different versions of the sender , you must specify the second sender email address using this parameter. This must be one of your sender signatures defined in your account. If specified in any other campaign type, it will be ignored..</param>
        /// <param name="HoursToTest">If you choose to send an AB campaign type, you must set this parameter to specify how long the test will run, before determining which will be the winning version to be sent to the rest of the recipients. This should be an integer value between 1 and 24. If specified in a regular campaign, it will be ignored..</param>
        /// <param name="ListPercentage">If you choose to send an AB campaign type, you must set this parameter to specify a portion of the target recipients that will receive the test versions. For example, if you specify 10, then 10% of your recipients will receive the A version and another 10% will receive the B version. The specified value should be an integer between 5 and 40. If specified in a regular campaign, it will be ignored. (optional, string).</param>
        /// <param name="ABWinnerSelectionType">If you choose to send an AB campaign type, you may set this parameter to one of the following values to specify the method to determine the winning version for the test.   If not set, OpenRate will be assumed. If specified in a regular campaign, it will be ignored. * &#x60;OpenRate&#x60; * &#x60;TotalUniqueClicks&#x60;.</param>
        public CreatingADraftCampaignRequest(string Name = default(string), string Subject = default(string), string SenderEmail = default(string), string ReplyToEmail = default(string), string IsAB = default(string), string ConfirmationToEmail = default(string), string WebLocation = default(string), List<MailingLists> MailingLists = default(List<MailingLists>), string SegmentID = default(string), string ABCampaignType = default(string), string TrackInGoogleAnalytics = default(string), string DontTrackLinkClicks = default(string), string SubjectB = default(string), string WebLocationB = default(string), string SenderEmailB = default(string), string HoursToTest = default(string), string ListPercentage = default(string), string ABWinnerSelectionType = default(string))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for CreatingADraftCampaignRequest and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Subject" is required (not null)
            if (Subject == null)
            {
                throw new InvalidDataException("Subject is a required property for CreatingADraftCampaignRequest and cannot be null");
            }
            else
            {
                this.Subject = Subject;
            }
            // to ensure "SenderEmail" is required (not null)
            if (SenderEmail == null)
            {
                throw new InvalidDataException("SenderEmail is a required property for CreatingADraftCampaignRequest and cannot be null");
            }
            else
            {
                this.SenderEmail = SenderEmail;
            }
            // to ensure "ReplyToEmail" is required (not null)
            if (ReplyToEmail == null)
            {
                throw new InvalidDataException("ReplyToEmail is a required property for CreatingADraftCampaignRequest and cannot be null");
            }
            else
            {
                this.ReplyToEmail = ReplyToEmail;
            }
            // to ensure "IsAB" is required (not null)
            if (IsAB == null)
            {
                throw new InvalidDataException("IsAB is a required property for CreatingADraftCampaignRequest and cannot be null");
            }
            else
            {
                this.IsAB = IsAB;
            }
            this.ConfirmationToEmail = ConfirmationToEmail;
            this.WebLocation = WebLocation;
            this.MailingLists = MailingLists;
            this.SegmentID = SegmentID;
            this.ABCampaignType = ABCampaignType;
            this.TrackInGoogleAnalytics = TrackInGoogleAnalytics;
            this.DontTrackLinkClicks = DontTrackLinkClicks;
            this.SubjectB = SubjectB;
            this.WebLocationB = WebLocationB;
            this.SenderEmailB = SenderEmailB;
            this.HoursToTest = HoursToTest;
            this.ListPercentage = ListPercentage;
            this.ABWinnerSelectionType = ABWinnerSelectionType;
        }
        
        /// <summary>
        /// The name of the campaign.
        /// </summary>
        /// <value>The name of the campaign.</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The subject line of the new campaign.
        /// </summary>
        /// <value>The subject line of the new campaign.</value>
        [DataMember(Name="Subject", EmitDefaultValue=false)]
        public string Subject { get; set; }

        /// <summary>
        /// The sender email of the campaign.
        /// </summary>
        /// <value>The sender email of the campaign.</value>
        [DataMember(Name="SenderEmail", EmitDefaultValue=false)]
        public string SenderEmail { get; set; }

        /// <summary>
        /// The email address to which recipients replies will arrive. It must be one of your sender accounts. If not specified, the sender&#39;s email will be assumed.
        /// </summary>
        /// <value>The email address to which recipients replies will arrive. It must be one of your sender accounts. If not specified, the sender&#39;s email will be assumed.</value>
        [DataMember(Name="ReplyToEmail", EmitDefaultValue=false)]
        public string ReplyToEmail { get; set; }

        /// <summary>
        /// A flag that defines if a campaign is an AB campaign.
        /// </summary>
        /// <value>A flag that defines if a campaign is an AB campaign.</value>
        [DataMember(Name="IsAB", EmitDefaultValue=false)]
        public string IsAB { get; set; }

        /// <summary>
        /// The email address to which a confirmation message will be,  sent when the campaign has been successfully sent.
        /// </summary>
        /// <value>The email address to which a confirmation message will be,  sent when the campaign has been successfully sent.</value>
        [DataMember(Name="ConfirmationToEmail", EmitDefaultValue=false)]
        public string ConfirmationToEmail { get; set; }

        /// <summary>
        /// A url to retrieve the html content for the campaign. We&#39;ll automatically move all CSS inline.
        /// </summary>
        /// <value>A url to retrieve the html content for the campaign. We&#39;ll automatically move all CSS inline.</value>
        [DataMember(Name="WebLocation", EmitDefaultValue=false)]
        public string WebLocation { get; set; }

        /// <summary>
        /// A list of mailing lists in your account to which the campaign will be sent to.
        /// </summary>
        /// <value>A list of mailing lists in your account to which the campaign will be sent to.</value>
        [DataMember(Name="MailingLists", EmitDefaultValue=false)]
        public List<MailingLists> MailingLists { get; set; }

        /// <summary>
        /// The ID of a segment in the specified mailing list to filter the recipients with. If not specified, the campaign will be sent to all active subscribers of the mailing list.
        /// </summary>
        /// <value>The ID of a segment in the specified mailing list to filter the recipients with. If not specified, the campaign will be sent to all active subscribers of the mailing list.</value>
        [DataMember(Name="SegmentID", EmitDefaultValue=false)]
        public string SegmentID { get; set; }

        /// <summary>
        /// If you want to send an AB split campaign you should specify this parameter to one of the following values.  * &#x60;Subject&#x60; * &#x60;Sender&#x60; * &#x60;Content&#x60;
        /// </summary>
        /// <value>If you want to send an AB split campaign you should specify this parameter to one of the following values.  * &#x60;Subject&#x60; * &#x60;Sender&#x60; * &#x60;Content&#x60;</value>
        [DataMember(Name="ABCampaignType", EmitDefaultValue=false)]
        public string ABCampaignType { get; set; }

        /// <summary>
        /// Tracks traffic from your campaign to your site. Note: You need to have Google Analytics configured on your site to use this feature.
        /// </summary>
        /// <value>Tracks traffic from your campaign to your site. Note: You need to have Google Analytics configured on your site to use this feature.</value>
        [DataMember(Name="TrackInGoogleAnalytics", EmitDefaultValue=false)]
        public string TrackInGoogleAnalytics { get; set; }

        /// <summary>
        /// Moosend wraps your own links with its own to enable link click tracking. Check this box if you don&#39;t wish to track link click traffic through Moosend.
        /// </summary>
        /// <value>Moosend wraps your own links with its own to enable link click tracking. Check this box if you don&#39;t wish to track link click traffic through Moosend.</value>
        [DataMember(Name="DontTrackLinkClicks", EmitDefaultValue=false)]
        public string DontTrackLinkClicks { get; set; }

        /// <summary>
        /// If you wish to send an AB split campaign with two different versions of the subject line , you must specify the second subject using this parameter. If specified in any other campaign type, it will be ignored.
        /// </summary>
        /// <value>If you wish to send an AB split campaign with two different versions of the subject line , you must specify the second subject using this parameter. If specified in any other campaign type, it will be ignored.</value>
        [DataMember(Name="SubjectB", EmitDefaultValue=false)]
        public string SubjectB { get; set; }

        /// <summary>
        /// If you wish to send an AB split campaign with two different versions of the html content, you must specify where the second html content will be retrieved from using this parameter. If specified in any other campaign type, it will be ignored.
        /// </summary>
        /// <value>If you wish to send an AB split campaign with two different versions of the html content, you must specify where the second html content will be retrieved from using this parameter. If specified in any other campaign type, it will be ignored.</value>
        [DataMember(Name="WebLocationB", EmitDefaultValue=false)]
        public string WebLocationB { get; set; }

        /// <summary>
        /// If you wish to send an AB split campaign with two different versions of the sender , you must specify the second sender email address using this parameter. This must be one of your sender signatures defined in your account. If specified in any other campaign type, it will be ignored.
        /// </summary>
        /// <value>If you wish to send an AB split campaign with two different versions of the sender , you must specify the second sender email address using this parameter. This must be one of your sender signatures defined in your account. If specified in any other campaign type, it will be ignored.</value>
        [DataMember(Name="SenderEmailB", EmitDefaultValue=false)]
        public string SenderEmailB { get; set; }

        /// <summary>
        /// If you choose to send an AB campaign type, you must set this parameter to specify how long the test will run, before determining which will be the winning version to be sent to the rest of the recipients. This should be an integer value between 1 and 24. If specified in a regular campaign, it will be ignored.
        /// </summary>
        /// <value>If you choose to send an AB campaign type, you must set this parameter to specify how long the test will run, before determining which will be the winning version to be sent to the rest of the recipients. This should be an integer value between 1 and 24. If specified in a regular campaign, it will be ignored.</value>
        [DataMember(Name="HoursToTest", EmitDefaultValue=false)]
        public string HoursToTest { get; set; }

        /// <summary>
        /// If you choose to send an AB campaign type, you must set this parameter to specify a portion of the target recipients that will receive the test versions. For example, if you specify 10, then 10% of your recipients will receive the A version and another 10% will receive the B version. The specified value should be an integer between 5 and 40. If specified in a regular campaign, it will be ignored. (optional, string)
        /// </summary>
        /// <value>If you choose to send an AB campaign type, you must set this parameter to specify a portion of the target recipients that will receive the test versions. For example, if you specify 10, then 10% of your recipients will receive the A version and another 10% will receive the B version. The specified value should be an integer between 5 and 40. If specified in a regular campaign, it will be ignored. (optional, string)</value>
        [DataMember(Name="ListPercentage", EmitDefaultValue=false)]
        public string ListPercentage { get; set; }

        /// <summary>
        /// If you choose to send an AB campaign type, you may set this parameter to one of the following values to specify the method to determine the winning version for the test.   If not set, OpenRate will be assumed. If specified in a regular campaign, it will be ignored. * &#x60;OpenRate&#x60; * &#x60;TotalUniqueClicks&#x60;
        /// </summary>
        /// <value>If you choose to send an AB campaign type, you may set this parameter to one of the following values to specify the method to determine the winning version for the test.   If not set, OpenRate will be assumed. If specified in a regular campaign, it will be ignored. * &#x60;OpenRate&#x60; * &#x60;TotalUniqueClicks&#x60;</value>
        [DataMember(Name="ABWinnerSelectionType", EmitDefaultValue=false)]
        public string ABWinnerSelectionType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreatingADraftCampaignRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  SenderEmail: ").Append(SenderEmail).Append("\n");
            sb.Append("  ReplyToEmail: ").Append(ReplyToEmail).Append("\n");
            sb.Append("  IsAB: ").Append(IsAB).Append("\n");
            sb.Append("  ConfirmationToEmail: ").Append(ConfirmationToEmail).Append("\n");
            sb.Append("  WebLocation: ").Append(WebLocation).Append("\n");
            sb.Append("  MailingLists: ").Append(MailingLists).Append("\n");
            sb.Append("  SegmentID: ").Append(SegmentID).Append("\n");
            sb.Append("  ABCampaignType: ").Append(ABCampaignType).Append("\n");
            sb.Append("  TrackInGoogleAnalytics: ").Append(TrackInGoogleAnalytics).Append("\n");
            sb.Append("  DontTrackLinkClicks: ").Append(DontTrackLinkClicks).Append("\n");
            sb.Append("  SubjectB: ").Append(SubjectB).Append("\n");
            sb.Append("  WebLocationB: ").Append(WebLocationB).Append("\n");
            sb.Append("  SenderEmailB: ").Append(SenderEmailB).Append("\n");
            sb.Append("  HoursToTest: ").Append(HoursToTest).Append("\n");
            sb.Append("  ListPercentage: ").Append(ListPercentage).Append("\n");
            sb.Append("  ABWinnerSelectionType: ").Append(ABWinnerSelectionType).Append("\n");
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
            return this.Equals(obj as CreatingADraftCampaignRequest);
        }

        /// <summary>
        /// Returns true if CreatingADraftCampaignRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CreatingADraftCampaignRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreatingADraftCampaignRequest other)
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
                    this.Subject == other.Subject ||
                    this.Subject != null &&
                    this.Subject.Equals(other.Subject)
                ) && 
                (
                    this.SenderEmail == other.SenderEmail ||
                    this.SenderEmail != null &&
                    this.SenderEmail.Equals(other.SenderEmail)
                ) && 
                (
                    this.ReplyToEmail == other.ReplyToEmail ||
                    this.ReplyToEmail != null &&
                    this.ReplyToEmail.Equals(other.ReplyToEmail)
                ) && 
                (
                    this.IsAB == other.IsAB ||
                    this.IsAB != null &&
                    this.IsAB.Equals(other.IsAB)
                ) && 
                (
                    this.ConfirmationToEmail == other.ConfirmationToEmail ||
                    this.ConfirmationToEmail != null &&
                    this.ConfirmationToEmail.Equals(other.ConfirmationToEmail)
                ) && 
                (
                    this.WebLocation == other.WebLocation ||
                    this.WebLocation != null &&
                    this.WebLocation.Equals(other.WebLocation)
                ) && 
                (
                    this.MailingLists == other.MailingLists ||
                    this.MailingLists != null &&
                    this.MailingLists.SequenceEqual(other.MailingLists)
                ) && 
                (
                    this.SegmentID == other.SegmentID ||
                    this.SegmentID != null &&
                    this.SegmentID.Equals(other.SegmentID)
                ) && 
                (
                    this.ABCampaignType == other.ABCampaignType ||
                    this.ABCampaignType != null &&
                    this.ABCampaignType.Equals(other.ABCampaignType)
                ) && 
                (
                    this.TrackInGoogleAnalytics == other.TrackInGoogleAnalytics ||
                    this.TrackInGoogleAnalytics != null &&
                    this.TrackInGoogleAnalytics.Equals(other.TrackInGoogleAnalytics)
                ) && 
                (
                    this.DontTrackLinkClicks == other.DontTrackLinkClicks ||
                    this.DontTrackLinkClicks != null &&
                    this.DontTrackLinkClicks.Equals(other.DontTrackLinkClicks)
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
                ) && 
                (
                    this.SenderEmailB == other.SenderEmailB ||
                    this.SenderEmailB != null &&
                    this.SenderEmailB.Equals(other.SenderEmailB)
                ) && 
                (
                    this.HoursToTest == other.HoursToTest ||
                    this.HoursToTest != null &&
                    this.HoursToTest.Equals(other.HoursToTest)
                ) && 
                (
                    this.ListPercentage == other.ListPercentage ||
                    this.ListPercentage != null &&
                    this.ListPercentage.Equals(other.ListPercentage)
                ) && 
                (
                    this.ABWinnerSelectionType == other.ABWinnerSelectionType ||
                    this.ABWinnerSelectionType != null &&
                    this.ABWinnerSelectionType.Equals(other.ABWinnerSelectionType)
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
                if (this.Subject != null)
                    hash = hash * 59 + this.Subject.GetHashCode();
                if (this.SenderEmail != null)
                    hash = hash * 59 + this.SenderEmail.GetHashCode();
                if (this.ReplyToEmail != null)
                    hash = hash * 59 + this.ReplyToEmail.GetHashCode();
                if (this.IsAB != null)
                    hash = hash * 59 + this.IsAB.GetHashCode();
                if (this.ConfirmationToEmail != null)
                    hash = hash * 59 + this.ConfirmationToEmail.GetHashCode();
                if (this.WebLocation != null)
                    hash = hash * 59 + this.WebLocation.GetHashCode();
                if (this.MailingLists != null)
                    hash = hash * 59 + this.MailingLists.GetHashCode();
                if (this.SegmentID != null)
                    hash = hash * 59 + this.SegmentID.GetHashCode();
                if (this.ABCampaignType != null)
                    hash = hash * 59 + this.ABCampaignType.GetHashCode();
                if (this.TrackInGoogleAnalytics != null)
                    hash = hash * 59 + this.TrackInGoogleAnalytics.GetHashCode();
                if (this.DontTrackLinkClicks != null)
                    hash = hash * 59 + this.DontTrackLinkClicks.GetHashCode();
                if (this.SubjectB != null)
                    hash = hash * 59 + this.SubjectB.GetHashCode();
                if (this.WebLocationB != null)
                    hash = hash * 59 + this.WebLocationB.GetHashCode();
                if (this.SenderEmailB != null)
                    hash = hash * 59 + this.SenderEmailB.GetHashCode();
                if (this.HoursToTest != null)
                    hash = hash * 59 + this.HoursToTest.GetHashCode();
                if (this.ListPercentage != null)
                    hash = hash * 59 + this.ListPercentage.GetHashCode();
                if (this.ABWinnerSelectionType != null)
                    hash = hash * 59 + this.ABWinnerSelectionType.GetHashCode();
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
