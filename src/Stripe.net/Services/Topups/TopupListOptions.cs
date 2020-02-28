namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class TopupListOptions : ListOptionsWithCreated
    {
        [JsonProperty("amount")]
        public todo-thingy Amount { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
