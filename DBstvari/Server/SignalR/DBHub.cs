using DBstvari.Shared;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBstvari.Server.SignalR
{
	public class DBHub : Hub
	{
		public async Task PrimiPodatke(List<Osoba> listO)
		{
			foreach(Osoba o in listO)
			{
				Console.WriteLine(o);
			}
		}
	}
}
