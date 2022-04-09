using System;
using System.Collections.Generic;
using System.Drawing;

public class Pool
{
	public List<Zapasnik> zapasnici;
	public List<int> napomenuti; //6
	public List<char> vysledky; // = je remiza 0 = nic  


	// grafika
	private int sirka = 0;
	private int vyska = 0;
	private int polohaX = 0;
	private int polohaY = 0;

	public Pool(Zapasnik zapasnik1, Zapasnik zapasnik2, Zapasnik zapasnik3)
	{
		this.zapasnici = new List<Zapasnik>();
		this.napomenuti = new List<int>();
		this.vysledky = new List<char>();

		for (int i = 0; i < 6; i++) { 
			this.napomenuti.Add(0);
			this.vysledky.Add('0');
		
		}
		this.zapasnici.Add(zapasnik1);
		this.zapasnici.Add(zapasnik2);
		this.zapasnici.Add(zapasnik3);
	}

	public Pool(Zapasnik zapasnik1, Zapasnik zapasnik2)
	{
		this.zapasnici = new List<Zapasnik>();
		this.napomenuti = new List<int>();
		this.vysledky = new List<char>();

		for (int i = 0; i < 2; i++)
		{
			this.napomenuti.Add(0);
			this.vysledky.Add('0');

		}
		this.zapasnici.Add(zapasnik1);
		this.zapasnici.Add(zapasnik2);
	}

	public int pocetZapasniku()
    {
		return this.zapasnici.Count;
    }

	public SizeF size(Graphics g)
    {
		Font font = new Font("Arial", 12);
		Font nadpis = new Font("Arial", 10, FontStyle.Italic);
		SolidBrush barva = new SolidBrush(Color.Black);
		SizeF result = new SizeF(0, 0);
		SizeF velikostNadpisuPoolu = g.MeasureString("POOL 1", nadpis);

		for (int i = 0; i < pocetZapasniku(); i++) {
			SizeF velikost = g.MeasureString(zapasnici[i].jmeno + " " + zapasnici[i].prijmeni, font);
			if (velikost.Width > result.Width) {
				result.Width = velikost.Width;
			}
		}
		vyska = 16 * pocetZapasniku() + Convert.ToInt32(velikostNadpisuPoolu.Height) + 6 + 2;
		result.Height = vyska;

		return result;
	}

	public void vykresli(Graphics g, int x, int y, int poradi)
    {
		SolidBrush barva = new SolidBrush(Color.Black);
		Pen CernePero = new Pen(Color.Black, 1);
		Pen BilePero = new Pen(Color.White, 1);

		Font font = new Font("Arial", 12);
		Font nadpis = new Font("Arial", 10, FontStyle.Italic);

		SizeF velikostNadpisuPoolu = g.MeasureString("POOL " + poradi + " ", nadpis);

		this.polohaX = x;
		this.polohaY = y;

		g.DrawLine(CernePero, x, y, x + 8 + sirka, y);
		g.DrawLine(CernePero, x, y, x + 2, y - 2);
		g.DrawLine(CernePero, x+2, y-2, x + 10 + sirka, y-2);
		g.DrawLine(CernePero, x + 8 + sirka, y, x + 10 + sirka, y - 2);
		g.DrawLine(CernePero, x, y, x, y + 16 * pocetZapasniku() + Convert.ToInt32(velikostNadpisuPoolu.Height) + 6);
		g.DrawLine(CernePero, x + 8 + sirka, y, x + 8 + sirka, y + 16 * pocetZapasniku() + Convert.ToInt32(velikostNadpisuPoolu.Height) + 6);
		g.DrawLine(CernePero, x + 10 + sirka, y-2, x + 10 + sirka, y + 16 * pocetZapasniku() + Convert.ToInt32(velikostNadpisuPoolu.Height) + 6 - 2);
		g.DrawLine(CernePero, x, y + 16 * pocetZapasniku() + Convert.ToInt32(velikostNadpisuPoolu.Height) + 6, x + 8 + sirka, y + 16 * pocetZapasniku() + Convert.ToInt32(velikostNadpisuPoolu.Height) + 6);
		g.DrawLine(CernePero, x + 8 + sirka, y + 16 * pocetZapasniku() + Convert.ToInt32(velikostNadpisuPoolu.Height) + 6, x + 10 + sirka, y + 16 * pocetZapasniku() + Convert.ToInt32(velikostNadpisuPoolu.Height) + 6 - 2);
		g.DrawLine(CernePero, x, y + 16, x + 8 + sirka, y + 16);

		g.DrawString("POOL " + poradi, nadpis, barva, x + sirka + 8 - Convert.ToInt32(velikostNadpisuPoolu.Width), y);
		for(int i = 0; i < pocetZapasniku(); i++)
        {
			g.DrawString(this.zapasnici[i].jmeno + " " + this.zapasnici[i].prijmeni, font, barva, x + 4, y + 18 + i * 16);
		}
	}

	public bool kliknutoV(Point souradnice)
    {
		if(souradnice.X >= this.polohaX && souradnice.X <= this.polohaX + this.sirka + 8 && souradnice.Y >= this.polohaY && souradnice.Y <= this.polohaY + this.vyska)
        {
			return true;
        }
		return false;
    }

	public void nastavSirku(int sirka)
    {
		this.sirka = sirka;
    }

	public int vysledek(int poradi)
	{
		/*
		vysledky
		0 -> 0 x 1 -> 1 x 2
		1 -> 1 x 2 -> 3 x 4
		2 -> 2 x 0 -> 5 x 6
		*/

		bool dobojovano = true;

		if ((vysledky[0] == '0' && vysledky[1] == '0') && (napomenuti[0] < 2 && napomenuti[1] < 2)) {
			dobojovano = false;
		}
		if ((vysledky[2] == '0' && vysledky[3] == '0') && (napomenuti[2] < 2 && napomenuti[3] < 2))
		{
			dobojovano = false;
		}
		if ((vysledky[4] == '0' && vysledky[5] == '0') && (napomenuti[4] < 2 && napomenuti[5] < 2))
		{
			dobojovano = false;
		}

		if (!dobojovano)
		{
			return -1;
		}

		int[] vypocetPoradi = { 0, 0, 0 };

		// vyhry v turajich
		if (vysledky[0] != '0' && vysledky[0] != '=') { vypocetPoradi[0] += 2; }
		else if (vysledky[0] == '=') { vypocetPoradi[0] += 1; }

		if (vysledky[1] != '0' && vysledky[1] != '=') { vypocetPoradi[1] += 2; }
		else if (vysledky[1] == '=') { vypocetPoradi[1] += 1; }

		if (vysledky[2] != '0' && vysledky[2] != '=') { vypocetPoradi[1] += 2; }
		else if (vysledky[2] == '=') { vypocetPoradi[1] += 1; }

		if (vysledky[3] != '0' && vysledky[3] != '=') { vypocetPoradi[2] += 2; }
		else if (vysledky[3] == '=') { vypocetPoradi[2] += 1; }

		if (vysledky[4] != '0' && vysledky[4] != '=') { vypocetPoradi[2] += 2; }
		else if (vysledky[4] == '=') { vypocetPoradi[2] += 1; }

		if (vysledky[5] != '0' && vysledky[5] != '=') { vypocetPoradi[0] += 2; }
		else if (vysledky[5] == '=') { vypocetPoradi[0] += 1; }

		//kontumacni vyhry
		if (napomenuti[0] >= 2) { vypocetPoradi[1] += 2; }
		if (napomenuti[1] >= 2) { vypocetPoradi[0] += 2; }
		if (napomenuti[2] >= 2) { vypocetPoradi[2] += 2; }
		if (napomenuti[3] >= 2) { vypocetPoradi[1] += 2; }
		if (napomenuti[4] >= 2) { vypocetPoradi[0] += 2; }
		if (napomenuti[5] >= 2) { vypocetPoradi[2] += 2; }


		if (poradi == 0) {
			if (vypocetPoradi[0] >= vypocetPoradi[1] && vypocetPoradi[1] >= vypocetPoradi[2])
			{
				return 0;
			}
			else if (vypocetPoradi[0] <= vypocetPoradi[1] && vypocetPoradi[1] >= vypocetPoradi[2])
			{
				return 1;
			}
			else
			{
				return 2;
			}
		}
		else if(poradi == 1)
        {
			if (vypocetPoradi[0] >= vypocetPoradi[1] && vypocetPoradi[1] >= vypocetPoradi[2])
			{
				return 1;
			}
			else if (vypocetPoradi[0] <= vypocetPoradi[1] && vypocetPoradi[1] >= vypocetPoradi[2])
			{
				return 2;
			}
			else
			{
				return 0;
			}
		}

		return -1;

	}



}
