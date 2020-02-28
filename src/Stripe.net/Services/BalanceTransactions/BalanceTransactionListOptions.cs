namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class BalanceTransactionListOptions : ListOptionsWithCreated
    {
        [JsonProperty("available_on")]
        public todo-thingy AvailableOn { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("payout")]
        public string Payout { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
