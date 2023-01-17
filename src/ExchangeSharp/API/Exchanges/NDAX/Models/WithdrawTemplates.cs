using Newtonsoft.Json;
using System.Collections.Generic;

namespace ExchangeSharp
{
	public sealed partial class ExchangeNDAXAPI
	{
		class WithdrawTemplates : GenericResponse
		{
			[JsonProperty("TemplateTypes")]
			public IEnumerable<string> TemplateTypes { get; set; }
		}
	}
}
