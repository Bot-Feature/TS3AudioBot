// TS3AudioBot - An advanced Musicbot for Teamspeak 3
// Copyright (C) 2017  TS3AudioBot contributors
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the Open Software License v. 3.0
//
// You should have received a copy of the Open Software License along with this
// program. If not, see <https://opensource.org/licenses/OSL-3.0>.

using System;

namespace TS3AudioBot.CommandSystem.CommandResults
{
	public class PrimitiveResult<T> : IPrimitiveResult<T> where T : notnull
	{
		public T Content { get; }

		public PrimitiveResult(T contentArg)
		{
			Content = contentArg ?? throw new ArgumentNullException(nameof(contentArg));
		}

		public virtual T Get() => Content;

		object IPrimitiveResult.Get() => Content;
	}
}
