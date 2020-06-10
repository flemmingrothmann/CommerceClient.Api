﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Commerce.Api.Model.RequestModels
{
    public class BasketMergeRequestBody
    {
        public enum MergeTarget
        {
            This
        }

        public int FromBasketId { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public MergeTarget MergeTo { get; set; }
    }
}