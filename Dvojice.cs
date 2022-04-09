using System;
using System.Collections.Generic;
using System.Drawing;

public class Dvojice
{
    private List<string> jmena;
    private short vysledekZapasu; // -1 neznámý, 0/1
    private int sirka;
    private int polohaX;
    private int polohaY;


    public Dvojice()
    {
        jmena = new List<string>();
        for (int i = 0; i < 2; i++)
        {
            jmena.Add("");
        }
        vysledekZapasu = -1;
    }

    public void add(string jmeno, int index)
    {
        this.jmena[index] = jmeno;
    }

    public string clen(int i)
    {
        return jmena[i];
    }

    public void zapasVitez(short i)
    {
        vysledekZapasu = i;
    }

    public void nastavSirku(int sirka)
    {
        this.sirka = sirka;
    }

    public string vitez()
    {
        if (vysledekZapasu == -1)
        {
            return "";
        }
        else
        {
            return jmena[vysledekZapasu];
        }
    }

    public void vykresliCleny(Graphics g, int x, int y)
    {
        SolidBrush barva = new SolidBrush(Color.Black);
        Pen CernePero = new Pen(Color.Black, 1);

        Font font = new Font("Arial", 12);

        this.polohaX = x;
        this.polohaY = y;

        g.DrawLine(CernePero, x, y, x + sirka , y);
        g.DrawString(jmena[0], font, barva, x + 5, y + 5);
      
    }
}
