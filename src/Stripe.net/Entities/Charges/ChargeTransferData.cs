namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ChargeTransferData : StripeEntity<ChargeTransferData>
    {
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        #region Expandable Destination (Account)
        [JsonIgnore]
        public string DestinationId
        {
            get => this.InternalDestination?.Id;
            set => this.InternalDestination = SetExpandableFieldId(value, this.InternalDestination);
        }

        [JsonIgnore]
        public Account Destination
        {
            get => this.InternalDestination?.ExpandedObject;
            set => this.InternalDestination = SetExpandableFieldObject(value, this.InternalDestination);
        }

        [JsonProperty("destination")]
        [JsonConverter(typeof(ExpandableFieldConverter<Account>))]
        internal ExpandableField<Account> InternalDestination { get; set; }
        #endregion
    }
}
