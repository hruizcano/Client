﻿/*
copyright (C) 2011-2012 by high828@gmail.com

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using ElophantClient.Messages.Statistics;
using ElophantClient.Messages.Summoner;
//using ElophantClient.Storage;

namespace ElophantClient.Gui
{
	public class PlayerCache
	{
		//public PlayerEntry Player { get; set; }
		public PublicSummoner Summoner { get; set; }
		public PlayerLifetimeStats Stats { get; set; }
		public RecentGames Games { get; set; }
		public ChampionStatInfoList RecentChamps { get; set; }
		public int SeenCount { get; set; }

		readonly ManualResetEvent m_LoadWait;
		public ManualResetEvent LoadWait
		{
			get { return m_LoadWait; }
		}

		public PlayerCache()
		{
			m_LoadWait = new ManualResetEvent(false);
		}
	}
}
