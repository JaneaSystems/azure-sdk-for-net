// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> Map of data location to service location. </summary>
    public partial class DataLocationToServiceLocationMap
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DataLocationToServiceLocationMap"/>. </summary>
        internal DataLocationToServiceLocationMap()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DataLocationToServiceLocationMap"/>. </summary>
        /// <param name="dataLocation"> Location of the data. </param>
        /// <param name="serviceLocation"> Location of the service. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataLocationToServiceLocationMap(AzureLocation? dataLocation, AzureLocation? serviceLocation, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DataLocation = dataLocation;
            ServiceLocation = serviceLocation;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Location of the data. </summary>
        public AzureLocation? DataLocation { get; }
        /// <summary> Location of the service. </summary>
        public AzureLocation? ServiceLocation { get; }
    }
}
