using System;
using System.Collections.Generic;
using System.Drawing;

public class Pool
{
	public List<Zapasnik> zapasnici;



	// grafika
	private int sirka = 0;
	private int vyska = 0;
	private int polohaX = 0;
	private int polohaY = 0;

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
			g.DrawString(zapasnici[i].jmeno + " " + zapasnici[i].prijmeni, font, barva, x + 4, y + 18 + i * 16);
		}
	}

	public bool kliknutoV(Point souradnice)
    {
		if(souradnice.X >= polohaX && souradnice.X <= polohaX + sirka + 8 && souradnice.Y >= polohaY && souradnice.Y <= polohaY + vyska)
        {
			return true;
        }
		return false;
    }

	public void nastavSirku(int sirka)
    {
		this.sirka = sirka;
    }



}
