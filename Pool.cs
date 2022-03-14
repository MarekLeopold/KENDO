using System;
using System.Collections.Generic;

public class Pool
{
	public List<Zapasnik> zapasnici;

	public Pool(Zapasnik zapasnik1, Zapasnik zapasnik2, Zapasnik zapasnik3)
	{
		zapasnici = new List<Zapasnik>();
		zapasnici.Add(zapasnik1);
		zapasnici.Add(zapasnik2);
		zapasnici.Add(zapasnik3);
	}

	public Pool(Zapasnik zapasnik1, Zapasnik zapasnik2)
	{
		zapasnici = new List<Zapasnik>();
		zapasnici.Add(zapasnik1);
		zapasnici.Add(zapasnik2);
	}

	public int pocetZapasniku()
    {
		return zapasnici.Count;
    }



}
