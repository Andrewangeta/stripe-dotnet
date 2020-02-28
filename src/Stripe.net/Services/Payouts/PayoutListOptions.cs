namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PayoutListOptions : ListOptionsWithCreated
    {
        [JsonProperty("arrival_date")]
        public todo-thingy ArrivalDate { get; set; }

        [JsonProperty("destination")]
        public string Destination { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
