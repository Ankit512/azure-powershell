// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.PowerShell.Cmdlets.Websites.Helper.Network.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Contains custom Dns resolution configuration from customer.
    /// </summary>
    public partial class CustomDnsConfigPropertiesFormat
    {
        /// <summary>
        /// Initializes a new instance of the CustomDnsConfigPropertiesFormat
        /// class.
        /// </summary>
        public CustomDnsConfigPropertiesFormat()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CustomDnsConfigPropertiesFormat
        /// class.
        /// </summary>
        /// <param name="fqdn">Fqdn that resolves to private endpoint ip
        /// address.</param>
        /// <param name="ipAddresses">A list of private ip addresses of the
        /// private endpoint.</param>
        public CustomDnsConfigPropertiesFormat(string fqdn = default(string), IList<string> ipAddresses = default(IList<string>))
        {
            Fqdn = fqdn;
            IpAddresses = ipAddresses;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets fqdn that resolves to private endpoint ip address.
        /// </summary>
        [JsonProperty(PropertyName = "fqdn")]
        public string Fqdn { get; set; }

        /// <summary>
        /// Gets or sets a list of private ip addresses of the private
        /// endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "ipAddresses")]
        public IList<string> IpAddresses { get; set; }

    }
}
