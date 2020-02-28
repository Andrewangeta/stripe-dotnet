namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SubscriptionScheduleListOptions : ListOptionsWithCreated
    {
        [JsonProperty("canceled_at")]
        public todo-thingy CanceledAt { get; set; }

        [JsonProperty("completed_at")]
        public todo-thingy CompletedAt { get; set; }

        [JsonProperty("customer")]
        public string Customer { get; set; }

        [JsonProperty("released_at")]
        public todo-thingy ReleasedAt { get; set; }

        [JsonProperty("scheduled")]
        public bool Scheduled { get; set; }
    }
}
