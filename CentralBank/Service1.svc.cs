using BankApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using BankApi.model;
using CentralBank.DBModel;

namespace CentralBank
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IServiceBank
    {

        private static System.Timers.Timer timer;

        public Service1()
        {
             if (timer == null)
            {
                timer = new System.Timers.Timer();
                timer.Elapsed += new System.Timers.ElapsedEventHandler(WCFService_Elapsed);
                timer.Interval = 1000 * 60 * 2;
                timer.Enabled = true;
                timer.Start();
            }
        }

        public bool AddUplatnica(UplatnicaModel uplatnica)
        {
       
            if (uplatnica != null)
            {
                using (var context = new xws_cantral_bankEntities())
                {
                    CentralBank.DBModel.CentralBank uplata = new CentralBank.DBModel.CentralBank();
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
                    uplata.Hitno = uplatnica.Hitno;
                    uplata.DatumUplate = DateTime.Now;
                    uplata.IzvrsenaUplata = false;
                    uplata.BankUplataId = uplatnica.Id;

                    context.CentralBanks.Add(uplata);
                    

                    if (uplata.Hitno || uplata.Cena > 250000)
                    {
                        uplata.IzvrsenaUplata = true;

                        ServiceReference1.ServiceBankClient bankService = new ServiceReference1.ServiceBankClient();
                        bankService.IsplataIzvrsena(uplatnica.Id);
                    }
                    

                    context.SaveChanges();


                    return true;
                    
                }
            }
            return false;
        }

        void WCFService_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            using (var context = new xws_cantral_bankEntities())
            {
                var neIzvrseneUplate = context.CentralBanks.Where(x => x.IzvrsenaUplata == false).ToList();
                foreach (var item in neIzvrseneUplate)
                {
                    item.IzvrsenaUplata = true;
                    context.SaveChanges();
                    ServiceReference1.ServiceBankClient bankService = new ServiceReference1.ServiceBankClient();
                    bankService.IsplataIzvrsena(item.BankUplataId);
                }
            }
        }
    }
}
