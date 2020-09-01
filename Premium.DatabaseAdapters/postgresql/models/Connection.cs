using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace Premium.DatabaseAdapters.postgresql.models
{
    [Table("connection")]
    public class Connection
    {
        [JsonProperty("id")]
        public int Id{ get; private set; }

        [JsonProperty("market")]
        public string Market { get; private set; }

        [JsonProperty("label")]
        public string Label { get; private set; }

        [JsonProperty("feedserver")]
        public string FeedServer { get; private set; }

        [JsonProperty("feedport")]
        public int? FeedPort { get; private set; }

        [JsonProperty("feedtech")]
        public string FeedTech { get; private set; }

        [JsonProperty("feedtypes")]
        public string FeedTypes { get; private set; }

        [JsonProperty("orderserver")]
        public string OrderServer { get; private set; }


        [JsonProperty("orderport")]
        public int? OrderPort { get; private set; }


        [JsonProperty("ordertech")]
        public string OrderTech { get; private set; }


        [JsonProperty("ordertypes")]
        public string OrderTypes { get; private set; }


        [JsonProperty("location")]
        public string Location { get; private set; }


        [JsonProperty("hasquote")]
        public bool? HasQuote { get; private set; }


        [JsonProperty("messagelimit")]
        public string MessageLimit { get; private set; }




        [JsonProperty("connectionsubtype")]
        public decimal connectionsubtype { get; private set; }

        [JsonConstructor]
        public Connection(int id, string market, string label, string feedServer, int? feedPort, string feedTech, string feedTypes, string orderServer, int? orderPort, string orderTech, string orderTypes, string location, bool? hasQuote, string messageLimit, decimal connectionsubtype)
        {
            Id = id;
            Market = market;
            Label = label;
            FeedServer = feedServer;
            FeedPort = feedPort;
            FeedTech = feedTech;
            FeedTypes = feedTypes;
            OrderServer = orderServer;
            OrderPort = orderPort;
            OrderTech = orderTech;
            OrderTypes = orderTypes;
            Location = location;
            HasQuote = hasQuote;
            MessageLimit = messageLimit;
            this.connectionsubtype = connectionsubtype;
        }
    }
}