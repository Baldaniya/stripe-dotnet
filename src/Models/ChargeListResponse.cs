﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Stripe.Models
{
	public class ChargeListResponse : StripeBase
	{
		public int Count { get; set; }
		public List<ChargeResponse> Data { get; set; }
	}
}
