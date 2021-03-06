using Newtonsoft.Json;
using Binance.Net.Converters;
using Binance.Net.Enums;

namespace Binance.Net.Objects.Futures.FuturesData
{
    /// <summary>
    /// Information about an position
    /// </summary>
    public class BinanceFuturesPosition
    {
        /// <summary>
        /// The entry price of the position
        /// </summary>
        [JsonProperty("entryPrice")]
        public decimal EntryPrice { get; set; }
        /// <summary>
        /// Type of margin used for the position
        /// </summary>
        [JsonProperty("marginType"), JsonConverter(typeof(FuturesMarginTypeConverter))]
        public FuturesMarginType MarginType { get; set; }
        /// <summary>
        /// Does the position add margin automatically?
        /// </summary>
        [JsonProperty("isAutoAddMargin")]
        public bool IsAutoAddMargin { get; set; }
        /// <summary>
        /// Amount of isolated margin
        /// </summary>
        [JsonProperty("isolatedMargin")]
        public decimal IsolatedMargin { get; set; }
        /// <summary>
        /// The current initial leverage of the position
        /// </summary>
        [JsonProperty("leverage")]
        public int Leverage { get; set; }
        /// <summary>
        /// The Liquidation price of the position
        /// </summary>
        [JsonProperty("liquidationPrice")]
        public decimal LiquidationPrice { get; set; }
        /// <summary>
        /// The Market price of the position
        /// </summary>
        [JsonProperty("markPrice")]
        public decimal MarkPrice { get; set; }

        /// <summary>
        /// The notional value limit of current initial leverage
        /// NOTE: string type, because the value van be 'inf' (infinite)
        /// </summary>
        [JsonProperty("maxNotionalValue")]
        public string MaxNotionalValue { get; set; } = "";
        /// <summary>
        /// The quantity of the position
        /// </summary>
        [JsonProperty("positionAmt")]
        public decimal Quantity { get; set; }
        /// <summary>
        /// The symbol the position is for
        /// </summary>
        [JsonProperty("symbol")]
        public string Symbol { get; set; } = "";
        /// <summary>
        /// The price of the unrealized PnL
        /// </summary>
        [JsonProperty("unRealizedProfit")]
        public decimal UnrealizedPnL { get; set; }

        /// <summary>
        /// The position side of the order
        /// </summary>
        [JsonProperty("positionSide"), JsonConverter(typeof(PositionSideConverter))]
        public PositionSide PositionSide { get; set; }
    }

}
