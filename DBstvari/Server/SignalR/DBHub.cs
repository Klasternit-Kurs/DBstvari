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
			EF.DB baza = new EF.DB();
			foreach(Osoba o in listO)
			{
				baza.Osobas.Add(o);
			}
			await baza.SaveChangesAsync();
		}

		public async Task DajPodatke()
		{
			EF.DB baza = new EF.DB();
			await Clients.Caller.SendAsync("KlijentPrima", baza.Osobas.ToList());
		}
	}
}
