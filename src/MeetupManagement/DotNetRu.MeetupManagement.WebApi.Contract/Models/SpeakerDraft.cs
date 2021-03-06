#pragma warning disable SA1028 // Code must not contain trailing whitespace
/*
 * Meetup Management Service API
 *
 * Meetup Management Service API
 *
 * OpenAPI spec version: 0.1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
#pragma warning restore SA1028 // Code must not contain trailing whitespace

// ReSharper disable RedundantUsingDirective
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace DotNetRu.MeetupManagement.WebApi.Contract.Models
#pragma warning disable SA1028 // Code must not contain trailing whitespace
{ 
    /// <inheritdoc />
    /// <summary>
    /// 
    /// </summary>
#pragma warning restore SA1028 // Code must not contain trailing whitespace
    [DataContract]
    public class SpeakerDraft : IEquatable<SpeakerDraft>
#pragma warning disable SA1028 // Code must not contain trailing whitespace
    {
#pragma warning restore SA1028 // Code must not contain trailing whitespace
        /// <summary>
        /// Gets or sets Id
        /// </summary>
        [Required]
        [DataMember(Name="Id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets FirstName
        /// </summary>
        [Required]
        [DataMember(Name="FirstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets LastName
        /// </summary>
        [Required]
        [DataMember(Name="LastName")]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets CompanyName
        /// </summary>
        [DataMember(Name="CompanyName")]
        public string CompanyName { get; set; }

        /// <summary>
        /// Gets or sets CompanyUrl
        /// </summary>
        [DataMember(Name="CompanyUrl")]
        public string CompanyUrl { get; set; }

        /// <summary>
        /// Gets or sets Description
        /// </summary>
        [DataMember(Name="Description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets BlogsUrl
        /// </summary>
        [DataMember(Name="BlogsUrl")]
        public string BlogsUrl { get; set; }

        /// <summary>
        /// Gets or sets ContactsUrl
        /// </summary>
        [DataMember(Name="ContactsUrl")]
        public string ContactsUrl { get; set; }

        /// <summary>
        /// Gets or sets TwitterUrl
        /// </summary>
        [DataMember(Name="TwitterUrl")]
        public string TwitterUrl { get; set; }

        /// <summary>
        /// Gets or sets HabrUrl
        /// </summary>
        [DataMember(Name="HabrUrl")]
        public string HabrUrl { get; set; }

        /// <summary>
        /// Gets or sets GitHubUrl
        /// </summary>
        [DataMember(Name="GitHubUrl")]
        public string GitHubUrl { get; set; }

        /// <summary>
        /// Gets or sets Meetups
        /// </summary>
        [DataMember(Name="Meetups")]
        public Collection<MeetupReference> Meetups { get; set; }

        /// <summary>
        /// Gets or sets Venues
        /// </summary>
        [DataMember(Name="Venues")]
        public Collection<VenueReference> Venues { get; set; }

        /// <summary>
        /// Gets or sets Talks
        /// </summary>
        [DataMember(Name="Talks")]
        public Collection<TalkReference> Talks { get; set; }

        /// <summary>
        /// Gets or sets Friends
        /// </summary>
        [DataMember(Name="Friends")]
        public Collection<FriendReference> Friends { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SpeakerDraft {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  CompanyUrl: ").Append(CompanyUrl).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  BlogsUrl: ").Append(BlogsUrl).Append("\n");
            sb.Append("  ContactsUrl: ").Append(ContactsUrl).Append("\n");
            sb.Append("  TwitterUrl: ").Append(TwitterUrl).Append("\n");
            sb.Append("  HabrUrl: ").Append(HabrUrl).Append("\n");
            sb.Append("  GitHubUrl: ").Append(GitHubUrl).Append("\n");
            sb.Append("  Meetups: ").Append(Meetups).Append("\n");
            sb.Append("  Venues: ").Append(Venues).Append("\n");
            sb.Append("  Talks: ").Append(Talks).Append("\n");
            sb.Append("  Friends: ").Append(Friends).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        // ReSharper disable once UnusedMember.Global
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
#pragma warning disable IDE0041 // Use 'is null' check
            if (ReferenceEquals(null, obj))
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            return obj.GetType() == GetType() && Equals((SpeakerDraft)obj);
        }

        /// <inheritdoc />
        /// <summary>
        /// Returns true if SpeakerDraft instances are equal
        /// </summary>
        /// <param name="other">Instance of SpeakerDraft to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SpeakerDraft other)
        {
#pragma warning disable IDE0041 // Use 'is null' check
            if (ReferenceEquals(null, other))
                return false;
            if (ReferenceEquals(this, other))
                return true;

#pragma warning disable CA1309 // Use ordinal stringcomparison
#pragma warning disable CA1307 // Specify StringComparison
#pragma warning disable SA1515 // Single-line comment must be preceded by blank line
#pragma warning disable SA1009 // Closing parenthesis must be spaced correctly
            return
#pragma warning disable SA1119 // Statement must not use unnecessary parenthesis
                (
                    // ReSharper disable once RedundantNameQualifier
                    string.Equals(Id, other.Id) ||
                    (Id != null && Id.Equals(other.Id))
                ) &&
                (
                    // ReSharper disable once RedundantNameQualifier
                    string.Equals(FirstName, other.FirstName) ||
                    (FirstName != null && FirstName.Equals(other.FirstName))
                ) &&
                (
                    // ReSharper disable once RedundantNameQualifier
                    string.Equals(LastName, other.LastName) ||
                    (LastName != null && LastName.Equals(other.LastName))
                ) &&
                (
                    // ReSharper disable once RedundantNameQualifier
                    string.Equals(CompanyName, other.CompanyName) ||
                    (CompanyName != null && CompanyName.Equals(other.CompanyName))
                ) &&
                (
                    // ReSharper disable once RedundantNameQualifier
                    string.Equals(CompanyUrl, other.CompanyUrl) ||
                    (CompanyUrl != null && CompanyUrl.Equals(other.CompanyUrl))
                ) &&
                (
                    // ReSharper disable once RedundantNameQualifier
                    string.Equals(Description, other.Description) ||
                    (Description != null && Description.Equals(other.Description))
                ) &&
                (
                    // ReSharper disable once RedundantNameQualifier
                    string.Equals(BlogsUrl, other.BlogsUrl) ||
                    (BlogsUrl != null && BlogsUrl.Equals(other.BlogsUrl))
                ) &&
                (
                    // ReSharper disable once RedundantNameQualifier
                    string.Equals(ContactsUrl, other.ContactsUrl) ||
                    (ContactsUrl != null && ContactsUrl.Equals(other.ContactsUrl))
                ) &&
                (
                    // ReSharper disable once RedundantNameQualifier
                    string.Equals(TwitterUrl, other.TwitterUrl) ||
                    (TwitterUrl != null && TwitterUrl.Equals(other.TwitterUrl))
                ) &&
                (
                    // ReSharper disable once RedundantNameQualifier
                    string.Equals(HabrUrl, other.HabrUrl) ||
                    (HabrUrl != null && HabrUrl.Equals(other.HabrUrl))
                ) &&
                (
                    // ReSharper disable once RedundantNameQualifier
                    string.Equals(GitHubUrl, other.GitHubUrl) ||
                    (GitHubUrl != null && GitHubUrl.Equals(other.GitHubUrl))
                ) &&
                (
                    Meetups == other.Meetups ||
                    (Meetups != null && Meetups.SequenceEqual(other.Meetups))
                ) &&
                (
                    Venues == other.Venues ||
                    (Venues != null && Venues.SequenceEqual(other.Venues))
                ) &&
                (
                    Talks == other.Talks ||
                    (Talks != null && Talks.SequenceEqual(other.Talks))
                ) &&
                (
                    Friends == other.Friends ||
                    (Friends != null && Friends.SequenceEqual(other.Friends))
                );
#pragma warning restore SA1119 // Statement must not use unnecessary parenthesis
#pragma warning restore SA1009 // Closing parenthesis must be spaced correctly
#pragma warning restore SA1515 // Single-line comment must be preceded by blank line
#pragma warning restore CA1307 // Specify StringComparison
#pragma warning restore CA1309 // Use ordinal stringcomparison
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // Overflow is fine, just wrap
            unchecked
            {
                var hashCode = 41;

                // Suitable nullity checks etc, of course :)
#pragma warning disable CA1307 // Specify StringComparison

                // ReSharper disable once NonReadonlyMemberInGetHashCode
                    if (Id != null)
                    {
                    // ReSharper disable once NonReadonlyMemberInGetHashCode
                    hashCode = (hashCode * 59) + Id.GetHashCode();
                    }

                // ReSharper disable once NonReadonlyMemberInGetHashCode
                    if (FirstName != null)
                    {
                    // ReSharper disable once NonReadonlyMemberInGetHashCode
                    hashCode = (hashCode * 59) + FirstName.GetHashCode();
                    }

                // ReSharper disable once NonReadonlyMemberInGetHashCode
                    if (LastName != null)
                    {
                    // ReSharper disable once NonReadonlyMemberInGetHashCode
                    hashCode = (hashCode * 59) + LastName.GetHashCode();
                    }

                // ReSharper disable once NonReadonlyMemberInGetHashCode
                    if (CompanyName != null)
                    {
                    // ReSharper disable once NonReadonlyMemberInGetHashCode
                    hashCode = (hashCode * 59) + CompanyName.GetHashCode();
                    }

                // ReSharper disable once NonReadonlyMemberInGetHashCode
                    if (CompanyUrl != null)
                    {
                    // ReSharper disable once NonReadonlyMemberInGetHashCode
                    hashCode = (hashCode * 59) + CompanyUrl.GetHashCode();
                    }

                // ReSharper disable once NonReadonlyMemberInGetHashCode
                    if (Description != null)
                    {
                    // ReSharper disable once NonReadonlyMemberInGetHashCode
                    hashCode = (hashCode * 59) + Description.GetHashCode();
                    }

                // ReSharper disable once NonReadonlyMemberInGetHashCode
                    if (BlogsUrl != null)
                    {
                    // ReSharper disable once NonReadonlyMemberInGetHashCode
                    hashCode = (hashCode * 59) + BlogsUrl.GetHashCode();
                    }

                // ReSharper disable once NonReadonlyMemberInGetHashCode
                    if (ContactsUrl != null)
                    {
                    // ReSharper disable once NonReadonlyMemberInGetHashCode
                    hashCode = (hashCode * 59) + ContactsUrl.GetHashCode();
                    }

                // ReSharper disable once NonReadonlyMemberInGetHashCode
                    if (TwitterUrl != null)
                    {
                    // ReSharper disable once NonReadonlyMemberInGetHashCode
                    hashCode = (hashCode * 59) + TwitterUrl.GetHashCode();
                    }

                // ReSharper disable once NonReadonlyMemberInGetHashCode
                    if (HabrUrl != null)
                    {
                    // ReSharper disable once NonReadonlyMemberInGetHashCode
                    hashCode = (hashCode * 59) + HabrUrl.GetHashCode();
                    }

                // ReSharper disable once NonReadonlyMemberInGetHashCode
                    if (GitHubUrl != null)
                    {
                    // ReSharper disable once NonReadonlyMemberInGetHashCode
                    hashCode = (hashCode * 59) + GitHubUrl.GetHashCode();
                    }

                // ReSharper disable once NonReadonlyMemberInGetHashCode
                    if (Meetups != null)
                    {
                    // ReSharper disable once NonReadonlyMemberInGetHashCode
                    hashCode = (hashCode * 59) + Meetups.GetHashCode();
                    }

                // ReSharper disable once NonReadonlyMemberInGetHashCode
                    if (Venues != null)
                    {
                    // ReSharper disable once NonReadonlyMemberInGetHashCode
                    hashCode = (hashCode * 59) + Venues.GetHashCode();
                    }

                // ReSharper disable once NonReadonlyMemberInGetHashCode
                    if (Talks != null)
                    {
                    // ReSharper disable once NonReadonlyMemberInGetHashCode
                    hashCode = (hashCode * 59) + Talks.GetHashCode();
                    }

                // ReSharper disable once NonReadonlyMemberInGetHashCode
                    if (Friends != null)
                    {
                    // ReSharper disable once NonReadonlyMemberInGetHashCode
                    hashCode = (hashCode * 59) + Friends.GetHashCode();
                    }
#pragma warning restore CA1307 // Specify StringComparison
                return hashCode;
            }
        }

#pragma warning disable SA1124 // Do not use regions
        #region Operators
        #pragma warning disable 1591
        #pragma warning disable SA1201 // Elements must appear in the correct order
        public static bool operator ==(SpeakerDraft left, SpeakerDraft right)
        {
            return Equals(left, right);
        }
        #pragma warning restore SA1201 // Elements must appear in the correct order

        public static bool operator !=(SpeakerDraft left, SpeakerDraft right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
#pragma warning restore SA1124 // Do not use regions
    }
}
