using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BankApi.model;
using BankApi.DBModel;

namespace BankApi
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceBank" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceBank.svc or ServiceBank.svc.cs at the Solution Explorer and start debugging.
    public class ServiceBank : IServiceBank
    {
        public bool AddUplatnica(UplatnicaModel uplatnica)
        {
            //throw new NotImplementedException();

            if (uplatnica != null)
            {
                using (var context = new xws_bankEntities())
                {
                    Uplate uplata = new Uplate();
                    uplata.DuznikNalogodavac = uplatnica.DuznikNalogodavac;
                    uplata.SvrhaPlacanja = uplatnica.SvrhaPlacanja;
                    uplata.PoverilacPrimalac = uplatnica.PoverilacPrimalac;
                    uplata.MestoDatumPrijema = uplatnica.MestoDatumPrijema;
                    uplata.SifraPlacanja = uplatnica.SifraPlacanja;
                    uplata.Cena = uplatnica.Cena;
                    uplata.RacunDuznikaNalogodavca = uplatnica.RacunDuznikaNalogodavca;
                    uplata.Model = uplatnica.Model;
                    uplata.PozivNaBrojZaduzenja = uplatnica.PozivNaBrojZaduzenja;
                    uplata.RecunPoveriocaPrimaoca = uplatnica.RecunPoveriocaPrimaoca;
                    uplata.Model2 = uplatnica.Model2;
                    uplata.RacunNaBrojOdobrenje = uplatnica.RacunNaBrojOdobrenje;
                    uplata.DatumValute = uplatnica.DatumValute;
                    uplata.Hitno = uplatnica.Checkbox;
                    uplata.DatumUplate = DateTime.Now;

                    context.Uplates.Add(uplata);
                    context.SaveChanges();

                    CentralBankService.ServiceBankClient centralBankClient = new CentralBankService.ServiceBankClient();
                    CentralBankService.UplatnicaModel sendModel = new CentralBankService.UplatnicaModel();

                    sendModel.Id = uplata.Id;
                    sendModel.DuznikNalogodavac = uplatnica.DuznikNalogodavac;
                    sendModel.SvrhaPlacanja = uplatnica.SvrhaPlacanja;
                    sendModel.PoverilacPrimalac = uplatnica.PoverilacPrimalac;
                    sendModel.MestoDatumPrijema = uplatnica.MestoDatumPrijema;
                    sendModel.SifraPlacanja = uplatnica.SifraPlacanja;
                    sendModel.Cena = uplatnica.Cena;
                    sendModel.RacunDuznikaNalogodavca = uplatnica.RacunDuznikaNalogodavca;
                    sendModel.Model = uplatnica.Model;
                    sendModel.PozivNaBrojZaduzenja = uplatnica.PozivNaBrojZaduzenja;
                    sendModel.RecunPoveriocaPrimaoca = uplatnica.RecunPoveriocaPrimaoca;
                    sendModel.Model2 = uplatnica.Model2;
                    sendModel.RacunNaBrojOdobrenje = uplatnica.RacunNaBrojOdobrenje;
                    sendModel.DatumValute = uplatnica.DatumValute;
                    sendModel.Hitno = uplatnica.Checkbox;

                    centralBankClient.AddUplatnica(sendModel);
                    
                    return true;
                    
                }
            }
            return false;
        }

        public List<UplatnicaModel> GetIzvod()
        {
            List<UplatnicaModel> uplatnice = new List<UplatnicaModel>();
            using (var context = new xws_bankEntities())
            {
                var uplatniceIzBaze = context.Uplates.Where(x => x.IzvrsenaUplata).ToList();
                foreach (var item in uplatniceIzBaze)
                {
                    UplatnicaModel sendModel = new UplatnicaModel();
                    sendModel.DuznikNalogodavac = item.DuznikNalogodavac;
                    sendModel.SvrhaPlacanja = item.SvrhaPlacanja;
                    sendModel.PoverilacPrimalac = item.PoverilacPrimalac;
                    sendModel.MestoDatumPrijema = item.MestoDatumPrijema;
                    sendModel.SifraPlacanja = item.SifraPlacanja;
                    sendModel.Cena = item.Cena;
                    sendModel.RacunDuznikaNalogodavca = item.RacunDuznikaNalogodavca;
                    sendModel.Model = item.Model;
                    sendModel.PozivNaBrojZaduzenja = item.PozivNaBrojZaduzenja;
                    sendModel.RecunPoveriocaPrimaoca = item.RecunPoveriocaPrimaoca;
                    sendModel.Model2 = item.Model2;
                    sendModel.RacunNaBrojOdobrenje = item.RacunNaBrojOdobrenje;
                    sendModel.DatumValute = item.DatumValute;
                    sendModel.Checkbox = item.Hitno;

                    uplatnice.Add(sendModel);

                    
                }
                return uplatnice;
            }
        }


        public void DoWork()
        {
        }

        public void IsplataIzvrsena(long id)
        {
            using (var context = new xws_bankEntities())
            {
                Uplate uplata = context.Uplates.Find(id);
                if (uplata != null)
                {
                    uplata.IzvrsenaUplata = true;

                    context.SaveChanges();
                }
            }
        }
    }
}
