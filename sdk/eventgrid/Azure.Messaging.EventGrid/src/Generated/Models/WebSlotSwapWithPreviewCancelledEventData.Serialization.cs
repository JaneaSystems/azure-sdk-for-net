// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(WebSlotSwapWithPreviewCancelledEventDataConverter))]
    public partial class WebSlotSwapWithPreviewCancelledEventData
    {
        internal static WebSlotSwapWithPreviewCancelledEventData DeserializeWebSlotSwapWithPreviewCancelledEventData(JsonElement element)
        {
            Optional<AppEventTypeDetail> appEventTypeDetail = default;
            Optional<string> name = default;
            Optional<string> clientRequestId = default;
            Optional<string> correlationRequestId = default;
            Optional<string> requestId = default;
            Optional<string> address = default;
            Optional<string> verb = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("appEventTypeDetail"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    appEventTypeDetail = AppEventTypeDetail.DeserializeAppEventTypeDetail(property.Value);
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientRequestId"))
                {
                    clientRequestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("correlationRequestId"))
                {
                    correlationRequestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("requestId"))
                {
                    requestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("address"))
                {
                    address = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("verb"))
                {
                    verb = property.Value.GetString();
                    continue;
                }
            }
            return new WebSlotSwapWithPreviewCancelledEventData(appEventTypeDetail.Value, name.Value, clientRequestId.Value, correlationRequestId.Value, requestId.Value, address.Value, verb.Value);
        }

        internal partial class WebSlotSwapWithPreviewCancelledEventDataConverter : JsonConverter<WebSlotSwapWithPreviewCancelledEventData>
        {
            public override void Write(Utf8JsonWriter writer, WebSlotSwapWithPreviewCancelledEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override WebSlotSwapWithPreviewCancelledEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeWebSlotSwapWithPreviewCancelledEventData(document.RootElement);
            }
        }
    }
}
