// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The CommentFeedback. </summary>
    public partial class MetricCommentFeedback : MetricFeedback
    {

        /// <summary> Initializes a new instance of MetricCommentFeedback. </summary>
        /// <param name="type"> feedback type. </param>
        /// <param name="id"> feedback unique id. </param>
        /// <param name="createdTime"> feedback created time. </param>
        /// <param name="userPrincipal"> user who gives this feedback. </param>
        /// <param name="metricId"> metric unique id. </param>
        /// <param name="dimensionFilter"> . </param>
        /// <param name="startTime"> the start timestamp of feedback timerange. </param>
        /// <param name="endTime"> the end timestamp of feedback timerange, when equals to startTime means only one timestamp. </param>
        /// <param name="valueInternal"> . </param>
        internal MetricCommentFeedback(FeedbackType type, string id, DateTimeOffset? createdTime, string userPrincipal, string metricId, FeedbackDimensionFilter dimensionFilter, DateTimeOffset? startTime, DateTimeOffset? endTime, CommentFeedbackValue valueInternal) : base(type, id, createdTime, userPrincipal, metricId, dimensionFilter)
        {
            StartTime = startTime;
            EndTime = endTime;
            ValueInternal = valueInternal;
            Type = type;
        }
    }
}
