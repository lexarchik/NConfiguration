﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NConfiguration.Combination
{
	public static class CombinerExtension
	{
		public static T Combine<T>(this ICombiner combiner, T x, T y)
		{
			return combiner.Combine<T>(combiner, x, y);
		}
	}
}
