using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foci
{
    internal class foci
    {
        public foci(int fordulo, int hgol, int vgol, int hfel, int vfel, string hazai, string vendeg)
        {
            this.fordulo = fordulo;
            this.hgol = hgol;
            this.vgol = vgol;
            this.hfel = hfel;
            this.vfel = vfel;
            this.hazai = hazai;
            this.vendeg = vendeg;
        }

        public int fordulo {  get; set; }
        public int hgol { get; set; }
        public int vgol { get; set; }
        public int hfel { get; set; }
        public int vfel { get; set; }
        public string hazai { get; set; }
        public string vendeg { get; set; }
    }

    public void Feladat2()
    {
        Console.WriteLine("Add meg a forduló számát: ");
        Console.WriteLine($"{hazai}-{vendeg}: {hgol}-{vgol} ({hfel}-{vfel})");
    }

}
