// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Attestation.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class AttestationPolicy
    {
        /// <summary>
        /// Initializes a new instance of the AttestationPolicy class.
        /// </summary>
        public AttestationPolicy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AttestationPolicy class.
        /// </summary>
        /// <param name="policy">String-encoded attestation policy
        /// document.</param>
        public AttestationPolicy(string policy = default(string))
        {
            Policy = policy;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets string-encoded attestation policy document.
        /// </summary>
        [JsonProperty(PropertyName = "policy")]
        public string Policy { get; set; }

    }
}
