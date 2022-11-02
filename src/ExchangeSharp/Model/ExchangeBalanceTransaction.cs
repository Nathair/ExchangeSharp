/*
MIT LICENSE

Copyright 2017 Digital Ruby, LLC - http://www.digitalruby.com

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

using ExchangeSharp;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ExchangeSharp
{
	public class ExchangeBalanceTransaction : ExchangeTransaction //by coinbase msg
	{
		public string Id { get; set; }
		public BalanceType Type { get; set; }

		[JsonProperty("created_at")]
		public DateTime? CreatedAt { get; set; }

		[JsonProperty("completed_at")]
		public DateTime? CompletedAt { get; set; }

		[JsonProperty("account_id")]
		public string AccountId { get; set; }

		[JsonProperty("user_id")]
		public string UserId { get; set; }
		//public decimal Amount { get; set; }
		public Details Details { get; set; }

		[JsonProperty("canceled_at")]
		public DateTime? CanceledAt { get; set; }

		[JsonProperty("processed_at")]
		public DateTime? ProcessedAt { get; set; }

		[JsonProperty("user_nonce")]
		public string UserNonce { get; set; }
		public object Idem { get; set; }

		[JsonProperty("profile_id")]
		public string ProfileId { get; set; }
		new public object Address { get; set; }
		//public string Currency { get; set; }
		override public string ToString() => $"{CompletedAt} {Currency}/{Type}:{Amount}";
	}

	public class Details
	{
		[JsonProperty("coinbase_account_id")]
		public string CoinbaseAccountId { get; set; }

		[JsonProperty("coinbase_transaction_id")]
		public string CoinbaseTransactionId { get; set; }

		[JsonProperty("coinbase_payment_method_id")]
		public string CoinbasePaymentMethodId { get; set; }
	}

	public enum BalanceType
	{
		Unknown,
		Deposit,
		Withdraw
	}

	public class ExchangeBalanceTransactionByFtx
	{
		public int Id { get; set; }
		public string Coin { get; set; }
		public string TxId { get; set; }
		public AddressClass Address { get; set; }
		public float Size { get; set; }
		public float Fee { get; set; }
		public BalanceTransactionStatus Status { get; set; }
		public DateTime? Time { get; set; }
		public DateTime? SentTime { get; set; }
		public DateTime? ConfirmedTime { get; set; }
		public int Confirmations { get; set; }
		public string Method { get; set; }
		override public string ToString() => $"{ConfirmedTime} {Coin}/{Method}:{Size}";
	}

	public class AddressClass
	{
		public string Address { get; set; }
		public object Tag { get; set; }
		public string Method { get; set; }
		public object Coin { get; set; }
	}

	public enum BalanceTransactionStatus
	{
		Unknown,
		Confirmed
	}
}
