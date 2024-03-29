﻿using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;

namespace ECommerce.API.Model
{
    public class ApiBasketAddRequest
    {
        [JsonProperty("productId")]
        public Guid ProductId { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }
    }
}