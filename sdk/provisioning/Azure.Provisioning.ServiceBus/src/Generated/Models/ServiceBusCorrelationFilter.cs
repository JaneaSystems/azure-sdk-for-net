// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.ServiceBus;

/// <summary>
/// Represents the correlation filter expression.
/// </summary>
public partial class ServiceBusCorrelationFilter : ProvisionableConstruct
{
    /// <summary>
    /// dictionary object for custom filters.
    /// </summary>
    public BicepDictionary<object> ApplicationProperties { get => _applicationProperties; set => _applicationProperties.Assign(value); }
    private readonly BicepDictionary<object> _applicationProperties;

    /// <summary>
    /// Identifier of the correlation.
    /// </summary>
    public BicepValue<string> CorrelationId { get => _correlationId; set => _correlationId.Assign(value); }
    private readonly BicepValue<string> _correlationId;

    /// <summary>
    /// Identifier of the message.
    /// </summary>
    public BicepValue<string> MessageId { get => _messageId; set => _messageId.Assign(value); }
    private readonly BicepValue<string> _messageId;

    /// <summary>
    /// Address to send to.
    /// </summary>
    public BicepValue<string> SendTo { get => _sendTo; set => _sendTo.Assign(value); }
    private readonly BicepValue<string> _sendTo;

    /// <summary>
    /// Address of the queue to reply to.
    /// </summary>
    public BicepValue<string> ReplyTo { get => _replyTo; set => _replyTo.Assign(value); }
    private readonly BicepValue<string> _replyTo;

    /// <summary>
    /// Application specific label.
    /// </summary>
    public BicepValue<string> Subject { get => _subject; set => _subject.Assign(value); }
    private readonly BicepValue<string> _subject;

    /// <summary>
    /// Session identifier.
    /// </summary>
    public BicepValue<string> SessionId { get => _sessionId; set => _sessionId.Assign(value); }
    private readonly BicepValue<string> _sessionId;

    /// <summary>
    /// Session identifier to reply to.
    /// </summary>
    public BicepValue<string> ReplyToSessionId { get => _replyToSessionId; set => _replyToSessionId.Assign(value); }
    private readonly BicepValue<string> _replyToSessionId;

    /// <summary>
    /// Content type of the message.
    /// </summary>
    public BicepValue<string> ContentType { get => _contentType; set => _contentType.Assign(value); }
    private readonly BicepValue<string> _contentType;

    /// <summary>
    /// Value that indicates whether the rule action requires preprocessing.
    /// </summary>
    public BicepValue<bool> RequiresPreprocessing { get => _requiresPreprocessing; set => _requiresPreprocessing.Assign(value); }
    private readonly BicepValue<bool> _requiresPreprocessing;

    /// <summary>
    /// Creates a new ServiceBusCorrelationFilter.
    /// </summary>
    public ServiceBusCorrelationFilter()
    {
        _applicationProperties = BicepDictionary<object>.DefineProperty(this, "ApplicationProperties", ["properties"]);
        _correlationId = BicepValue<string>.DefineProperty(this, "CorrelationId", ["correlationId"]);
        _messageId = BicepValue<string>.DefineProperty(this, "MessageId", ["messageId"]);
        _sendTo = BicepValue<string>.DefineProperty(this, "SendTo", ["to"]);
        _replyTo = BicepValue<string>.DefineProperty(this, "ReplyTo", ["replyTo"]);
        _subject = BicepValue<string>.DefineProperty(this, "Subject", ["label"]);
        _sessionId = BicepValue<string>.DefineProperty(this, "SessionId", ["sessionId"]);
        _replyToSessionId = BicepValue<string>.DefineProperty(this, "ReplyToSessionId", ["replyToSessionId"]);
        _contentType = BicepValue<string>.DefineProperty(this, "ContentType", ["contentType"]);
        _requiresPreprocessing = BicepValue<bool>.DefineProperty(this, "RequiresPreprocessing", ["requiresPreprocessing"]);
    }
}
