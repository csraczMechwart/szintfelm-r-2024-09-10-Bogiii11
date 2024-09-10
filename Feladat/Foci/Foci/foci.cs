using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foci
{
    internal class foci
    {
        public List<foci> adatok;
        public List<string> csapatnev;
        public foci(int fordulo, int hgol, int vgol, int hfel, int vfel, string hazai, string vendeg)
        {
            this.Fordulo = fordulo;
            this.Hgol = hgol;
            this.Vgol = vgol;
            this.Hfel = hfel;
            this.Vfel = vfel;
            this.Hazai = hazai;
            this.Vendeg = vendeg;
        }

        public int Fordulo {  get; set; }
        public int Hgol { get; set; }
        public int Vgol { get; set; }
        public int Hfel { get; set; }
        public int Vfel { get; set; }
        public string Hazai { get; set; }
        public string Vendeg { get; set; }
    }

    public void Feladat2()
    {
        Console.WriteLine("Add meg a forduló számát: ");
        Console.WriteLine($"{hazai}-{vendeg}: {hgol}-{vgol} ({hfel}-{vfel})");
    }

    public void Feladat3()
    {

    }

    public void Feladat4()
    {
        Console.WriteLine("Add meg egy csapat nevét: ");
        string csapat = Console.ReadLine;
        if (csapat == "")
        {
            csapat = "Lelkes";
        }
        csapatnev.Add(csapat);
    }

    public void Feladat5()
    {
        
    }

    public void Feladat6()
    {

    }

    public void Feladat7()
    {

    }
}
