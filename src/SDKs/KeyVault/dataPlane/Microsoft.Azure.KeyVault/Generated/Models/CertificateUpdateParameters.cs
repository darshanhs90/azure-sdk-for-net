// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.KeyVault.Models
{
    using Azure;
    using KeyVault;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The certificate update parameters.
    /// </summary>
    public partial class CertificateUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the CertificateUpdateParameters
        /// class.
        /// </summary>
        public CertificateUpdateParameters() { }

        /// <summary>
        /// Initializes a new instance of the CertificateUpdateParameters
        /// class.
        /// </summary>
        /// <param name="certificatePolicy">The management policy for the
        /// certificate.</param>
        /// <param name="certificateAttributes">The attributes of the
        /// certificate (optional).</param>
        /// <param name="tags">Application specific metadata in the form of
        /// key-value pairs.</param>
        public CertificateUpdateParameters(CertificatePolicy certificatePolicy = default(CertificatePolicy), CertificateAttributes certificateAttributes = default(CertificateAttributes), IDictionary<string, string> tags = default(IDictionary<string, string>))
        {
            CertificatePolicy = certificatePolicy;
            CertificateAttributes = certificateAttributes;
            Tags = tags;
        }

        /// <summary>
        /// Gets or sets the management policy for the certificate.
        /// </summary>
        [JsonProperty(PropertyName = "policy")]
        public CertificatePolicy CertificatePolicy { get; set; }

        /// <summary>
        /// Gets or sets the attributes of the certificate (optional).
        /// </summary>
        [JsonProperty(PropertyName = "attributes")]
        public CertificateAttributes CertificateAttributes { get; set; }

        /// <summary>
        /// Gets or sets application specific metadata in the form of key-value
        /// pairs.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (CertificatePolicy != null)
            {
                CertificatePolicy.Validate();
            }
        }
    }
}

