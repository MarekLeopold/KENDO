using System;

public class Zapasnik
{
	private int ID;
	private string jmeno;
	private string prijmeni;
	private byte vek;
	private byte uroven; // 10kju –> 1 kju -> 1 dan -> 10 dan // 20 urovni (0-19)


	public Zapasnik(string jmeno, string prijmeni, byte vek, byte uroven) // rucni vlozeni zapasnika
	{
		this.jmeno = jmeno;
		this.prijmeni = prijmeni;
		this.vek = vek;
		this.uroven = uroven;
		//save
	}

	public Zapasnik(int ID) // nacteni z DB
	{
		// load
	}
}
