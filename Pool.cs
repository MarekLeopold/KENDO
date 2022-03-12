using System;

public class Pool
{
	private Zapasnik[] zapasnici;
	private int pocetZapasniku;


	public Pool(Zapasnik[] zapasnici, int pocetZapasniku)
	{
		this.zapasnici = new Zapasnik[3];
		this.zapasnici = zapasnici;
		
	}
}
