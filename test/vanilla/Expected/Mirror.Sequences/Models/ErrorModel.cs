// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Fixtures.MirrorSequences.Models
{
    using Fixtures.MirrorSequences;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ErrorModel
    {
        /// <summary>
        /// Initializes a new instance of the ErrorModel class.
        /// </summary>
        public ErrorModel()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ErrorModel class.
        /// </summary>
        public ErrorModel(int code, string message)
        {
            Code = code;
            Message = message;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public int Code { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

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
        }
    }
}
