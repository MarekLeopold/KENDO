using System;
using System.Collections.Generic;
using System.Drawing;

public class Pool
{
    public List<Zapasnik> zapasnici;
    public List<int> napomenuti; //6
    public List<char> vysledky; //0 = nic  
    public List<bool> ukonceno; //3

    // grafika
    private int sirka = 0;
    private int vyska = 0;
    private int polohaX = 0;
    private int polohaY = 0;

    public Pool(Zapasnik zapasnik1, Zapasnik zapasnik2, Zapasnik zapasnik3)
    {
        this.zapasnici = new List<Zapasnik>();
        this.napomenuti = new List<int>();
        this.vysledky = new List<char>();  // 0,1 / 2,3 / 4,5 / 6,7 / 8,9 / 10,11
        this.ukonceno = new List<bool>();

        for (int i = 0; i < 6; i++)
        {
            this.napomenuti.Add(0);
            this.vysledky.Add('0');
            this.vysledky.Add('0');
            this.ukonceno.Add(false);
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

        for (int i = 0; i < pocetZapasniku(); i++)
        {
            SizeF velikost = g.MeasureString(zapasnici[i].jmeno + " " + zapasnici[i].prijmeni, font);
            if (velikost.Width > result.Width)
            {
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
        g.DrawLine(CernePero, x + 2, y - 2, x + 10 + sirka, y - 2);
        g.DrawLine(CernePero, x + 8 + sirka, y, x + 10 + sirka, y - 2);
        g.DrawLine(CernePero, x, y, x, y + 16 * pocetZapasniku() + Convert.ToInt32(velikostNadpisuPoolu.Height) + 6);
        g.DrawLine(CernePero, x + 8 + sirka, y, x + 8 + sirka, y + 16 * pocetZapasniku() + Convert.ToInt32(velikostNadpisuPoolu.Height) + 6);
        g.DrawLine(CernePero, x + 10 + sirka, y - 2, x + 10 + sirka, y + 16 * pocetZapasniku() + Convert.ToInt32(velikostNadpisuPoolu.Height) + 6 - 2);
        g.DrawLine(CernePero, x, y + 16 * pocetZapasniku() + Convert.ToInt32(velikostNadpisuPoolu.Height) + 6, x + 8 + sirka, y + 16 * pocetZapasniku() + Convert.ToInt32(velikostNadpisuPoolu.Height) + 6);
        g.DrawLine(CernePero, x + 8 + sirka, y + 16 * pocetZapasniku() + Convert.ToInt32(velikostNadpisuPoolu.Height) + 6, x + 10 + sirka, y + 16 * pocetZapasniku() + Convert.ToInt32(velikostNadpisuPoolu.Height) + 6 - 2);
        g.DrawLine(CernePero, x, y + 16, x + 8 + sirka, y + 16);

        g.DrawString("POOL " + poradi, nadpis, barva, x + sirka + 8 - Convert.ToInt32(velikostNadpisuPoolu.Width), y);
        for (int i = 0; i < pocetZapasniku(); i++)
        {
            g.DrawString(this.zapasnici[i].jmeno + " " + this.zapasnici[i].prijmeni, font, barva, x + 4, y + 18 + i * 16);
        }
    }

    public bool kliknutoV(Point souradnice)
    {
        if (souradnice.X >= this.polohaX && souradnice.X <= this.polohaX + this.sirka + 8 && souradnice.Y >= this.polohaY && souradnice.Y <= this.polohaY + this.vyska)
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


        return -1;

    }

    public int vyherce(int souboj)
    {
        if(this.ukonceno[souboj] != true)
        {
            return 0;
        }

        int bodyL = 0;
        int bodyR = 0;


        if(this.vysledky[souboj*2] != '0')
        {
            bodyL++;
        }
        if(this.vysledky[souboj*2+6] != '0')
        {
            bodyL++;
        }

        if (this.vysledky[souboj * 2 + 1] != '0')
        {
            bodyR++;
        }
        if (this.vysledky[souboj * 2 + 1 + 6] != '0')
        {
            bodyR++;
        }

        if(this.napomenuti[souboj*2]/2 >= 1)
        {
            bodyR = bodyR + this.napomenuti[souboj * 2] / 2;
        }

        if (this.napomenuti[souboj * 2 + 1] / 2 >= 1)
        {
            bodyL = bodyL + this.napomenuti[souboj * 2 + 1] / 2;
        }

        if (bodyL > bodyR) { return 1; }
        else if (bodyL < bodyR) { return 2; }
        else return 3;
    }

    int vitez(int poradi)
    {
        if (this.ukonceno[0] == true && this.ukonceno[1] == true && this.ukonceno[2]) {
            List<int> body = new List<int>();
            for (int i = 0; i < 3; i++)
            {
                body.Add(0);
            }

            // 1. zapas
            if (this.vyherce(0) == 3)
            {
                body[0] = body[0] + 1;
                body[1] = body[1] + 1;
            }
            else if (this.vyherce(0) == 1)
            {
                body[0] = body[0] + 2;
                body[1] = body[1] + 0;
            }
            else
            {
                body[0] = body[0] + 0;
                body[1] = body[1] + 2;
            }

            // 2. zapas
            if (this.vyherce(1) == 3)
            {
                body[1] = body[1] + 1;
                body[2] = body[2] + 1;
            }
            else if (this.vyherce(1) == 1)
            {
                body[1] = body[1] + 2;
                body[2] = body[2] + 0;
            }
            else
            {
                body[1] = body[1] + 0;
                body[2] = body[2] + 2;
            }

            // 3. zapas
            if (this.vyherce(2) == 3)
            {
                body[2] = body[2] + 1;
                body[0] = body[0] + 1;
            }
            else if (this.vyherce(1) == 1)
            {
                body[2] = body[2] + 2;
                body[0] = body[0] + 0;
            }
            else
            {
                body[2] = body[2] + 0;
                body[0] = body[0] + 2;
            }

            if (poradi == 0) {
                if (body[0] >= body[1] && body[0] >= body[2])
                {
                    return 0;
                }

                else if (body[1] >= body[0] && body[1] >= body[2])
                {
                    return 1;
                }


                else if (body[2] >= body[0] && body[2] >= body[1])
                {
                    return 2;
                }
            }
            else if(poradi == 1){
                if ((body[0] >= body[1] && body[0] <= body[2]) || (body[0] >= body[2] && body[0] <= body[1]))
                {
                    return 0;
                }

                else if ((body[1] >= body[0] && body[1] <= body[2]) || (body[1] >= body[2] && body[1] <= body[0]))
                {
                    return 1;
                }


                else if ((body[2] >= body[0] && body[2] <= body[1]) || (body[2] >= body[1] && body[2] <= body[0]))
                {
                    return 2;
                }
            }


        }


        return -1;
    }



}
