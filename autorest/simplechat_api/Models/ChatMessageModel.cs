// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace SimpleChat.Api.Client.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Chat message
    /// </summary>
    public partial class ChatMessageModel
    {
        /// <summary>
        /// Initializes a new instance of the ChatMessageModel class.
        /// </summary>
        public ChatMessageModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ChatMessageModel class.
        /// </summary>
        /// <param name="id">Chat message UID</param>
        /// <param name="message">Chat message text</param>
        /// <param name="receviedUtc">Chat message received time UTC</param>
        public ChatMessageModel(System.Guid id, string message, System.DateTime receviedUtc, UserInfoModel user)
        {
            Id = id;
            Message = message;
            ReceviedUtc = receviedUtc;
            User = user;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets chat message UID
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid Id { get; set; }

        /// <summary>
        /// Gets or sets chat message text
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets chat message received time UTC
        /// </summary>
        [JsonProperty(PropertyName = "receviedUtc")]
        public System.DateTime ReceviedUtc { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "user")]
        public UserInfoModel User { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Message == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Message");
            }
            if (User == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "User");
            }
        }
    }
}
