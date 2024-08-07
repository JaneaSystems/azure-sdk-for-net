// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The recurrence schedule. </summary>
    public partial class WorkflowRecurrenceSchedule
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

        /// <summary> Initializes a new instance of <see cref="WorkflowRecurrenceSchedule"/>. </summary>
        internal WorkflowRecurrenceSchedule()
        {
            Minutes = new ChangeTrackingList<int>();
            Hours = new ChangeTrackingList<int>();
            WeekDays = new ChangeTrackingList<WebAppDayOfWeek>();
            MonthDays = new ChangeTrackingList<int>();
            MonthlyOccurrences = new ChangeTrackingList<RecurrenceScheduleOccurrence>();
        }

        /// <summary> Initializes a new instance of <see cref="WorkflowRecurrenceSchedule"/>. </summary>
        /// <param name="minutes"> The minutes. </param>
        /// <param name="hours"> The hours. </param>
        /// <param name="weekDays"> The days of the week. </param>
        /// <param name="monthDays"> The month days. </param>
        /// <param name="monthlyOccurrences"> The monthly occurrences. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal WorkflowRecurrenceSchedule(IReadOnlyList<int> minutes, IReadOnlyList<int> hours, IReadOnlyList<WebAppDayOfWeek> weekDays, IReadOnlyList<int> monthDays, IReadOnlyList<RecurrenceScheduleOccurrence> monthlyOccurrences, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Minutes = minutes;
            Hours = hours;
            WeekDays = weekDays;
            MonthDays = monthDays;
            MonthlyOccurrences = monthlyOccurrences;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The minutes. </summary>
        [WirePath("minutes")]
        public IReadOnlyList<int> Minutes { get; }
        /// <summary> The hours. </summary>
        [WirePath("hours")]
        public IReadOnlyList<int> Hours { get; }
        /// <summary> The days of the week. </summary>
        [WirePath("weekDays")]
        public IReadOnlyList<WebAppDayOfWeek> WeekDays { get; }
        /// <summary> The month days. </summary>
        [WirePath("monthDays")]
        public IReadOnlyList<int> MonthDays { get; }
        /// <summary> The monthly occurrences. </summary>
        [WirePath("monthlyOccurrences")]
        public IReadOnlyList<RecurrenceScheduleOccurrence> MonthlyOccurrences { get; }
    }
}
