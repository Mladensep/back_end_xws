using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankApi.model
{
    public class UplatnicaModel
    {
        public string DuznikNalogodavac { get; set; }
        public string SvrhaPlacanja { get; set; }
        public string PoverilacPrimalac { get; set; }
        public string MestoDatumPrijema { get; set; }
        public string SifraPlacanja { get; set; }
        public int Cena { get; set; }
        public string RacunDuznikaNalogodavca { get; set; }
        public string Model { get; set; }
        public string PozivNaBrojZaduzenja { get; set; }
        public string RecunPoveriocaPrimaoca { get; set; }
        public string Model2 { get; set; }
        public string RacunNaBrojOdobrenje { get; set; }
        public string DatumValute { get; set; }
        public bool Checkbox { get; set; }
    }
}