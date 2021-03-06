// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DevTestLabs.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Properties of a virtual machine returned by the Microsoft.Compute API.
    /// </summary>
    public partial class ComputeVmPropertiesFragment
    {
        /// <summary>
        /// Initializes a new instance of the ComputeVmPropertiesFragment
        /// class.
        /// </summary>
        public ComputeVmPropertiesFragment() { }

        /// <summary>
        /// Initializes a new instance of the ComputeVmPropertiesFragment
        /// class.
        /// </summary>
        public ComputeVmPropertiesFragment(IList<ComputeVmInstanceViewStatusFragment> statuses = default(IList<ComputeVmInstanceViewStatusFragment>), string osType = default(string), string vmSize = default(string), string networkInterfaceId = default(string), string osDiskId = default(string), IList<string> dataDiskIds = default(IList<string>), IList<ComputeDataDiskFragment> dataDisks = default(IList<ComputeDataDiskFragment>))
        {
            Statuses = statuses;
            OsType = osType;
            VmSize = vmSize;
            NetworkInterfaceId = networkInterfaceId;
            OsDiskId = osDiskId;
            DataDiskIds = dataDiskIds;
            DataDisks = dataDisks;
        }

        /// <summary>
        /// Gets the statuses of the virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "statuses")]
        public IList<ComputeVmInstanceViewStatusFragment> Statuses { get; set; }

        /// <summary>
        /// Gets the OS type of the virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "osType")]
        public string OsType { get; set; }

        /// <summary>
        /// Gets the size of the virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "vmSize")]
        public string VmSize { get; set; }

        /// <summary>
        /// Gets the network interface ID of the virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "networkInterfaceId")]
        public string NetworkInterfaceId { get; set; }

        /// <summary>
        /// Gets OS disk blob uri for the virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "osDiskId")]
        public string OsDiskId { get; set; }

        /// <summary>
        /// Gets data disks blob uri for the virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "dataDiskIds")]
        public IList<string> DataDiskIds { get; set; }

        /// <summary>
        /// Gets all data disks attached to the virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "dataDisks")]
        public IList<ComputeDataDiskFragment> DataDisks { get; set; }

    }
}
