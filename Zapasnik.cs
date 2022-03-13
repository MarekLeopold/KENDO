using System;
using System.Xml.Serialization;

public class Zapasnik
{
	public int ID { get; set; }
	public string jmeno { get; set; }
	public string prijmeni { get; set; }
	public byte vek { get; set; }
	public byte uroven { get; set; } // 10kju –> 1 kju -> 1 dan -> 10 dan // 20 urovni (0-19)


	public Zapasnik(int ID, string jmeno, string prijmeni, byte vek, byte uroven) // rucni vlozeni zapasnika
	{
		this.ID = ID;
		this.jmeno = jmeno;
		this.prijmeni = prijmeni;
		this.vek = vek;
		this.uroven = uroven;
		//save
	}

	public Zapasnik()
    {

    }
}
