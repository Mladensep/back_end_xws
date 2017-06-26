using CompanyWebApi.DbModel;
using CompanyWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace CompanyWebApi.Controllers
{
    public class OrderController : ApiController
    {
        public IHttpActionResult Get(int id)
        {
            return Ok(id);
        }

        public IHttpActionResult Post(UplatnicaModel model)
        {

            if (model != null)
            {

                using (var context = new xws_firmaEntities())
                {
                    Uplatnica uplatnica = new Uplatnica();
                    uplatnica.DuznikNalogodavac = model.DuznikNalogodavac;
                    uplatnica.SvrhaPlacanja = model.SvrhaPlacanja;
                    uplatnica.PoverilacPrimalac = model.PoverilacPrimalac;
                    uplatnica.MestoDatumPrijema = model.MestoDatumPrijema;
                    uplatnica.SifraPlacanja = model.SifraPlacanja;
                    uplatnica.Cena = model.Cena;
                    uplatnica.RacunDuznikaNalogodavca = model.RacunDuznikaNalogodavca;
                    uplatnica.Model = model.Model;
                    uplatnica.PozivNaBrojZaduzenja = model.PozivNaBrojZaduzenja;
                    uplatnica.RecunPoveriocaPrimaoca = model.RecunPoveriocaPrimaoca;
                    uplatnica.Model2 = model.Model2;
                    uplatnica.RacunNaBrojOdobrenje = model.RacunNaBrojOdobrenje;
                    uplatnica.DatumValute = model.DatumValute;
                    uplatnica.Hitno = model.Checkbox;

                    context.Uplatnicas.Add(uplatnica);
                    context.SaveChanges();

               
                }

                BankApiService.ServiceBankClient bs = new BankApiService.ServiceBankClient();
                BankApiService.UplatnicaModel bankUplatnica = new BankApiService.UplatnicaModel();

                bankUplatnica.DuznikNalogodavac = model.DuznikNalogodavac;
                bankUplatnica.SvrhaPlacanja = model.SvrhaPlacanja;
                bankUplatnica.PoverilacPrimalac = model.PoverilacPrimalac;
                bankUplatnica.MestoDatumPrijema = model.MestoDatumPrijema;
                bankUplatnica.SifraPlacanja = model.SifraPlacanja;
                bankUplatnica.Cena = model.Cena;
                bankUplatnica.RacunDuznikaNalogodavca = model.RacunDuznikaNalogodavca;
                bankUplatnica.Model = model.Model;
                bankUplatnica.PozivNaBrojZaduzenja = model.PozivNaBrojZaduzenja;
                bankUplatnica.RecunPoveriocaPrimaoca = model.RecunPoveriocaPrimaoca;
                bankUplatnica.Model2 = model.Model2;
                bankUplatnica.RacunNaBrojOdobrenje = model.RacunNaBrojOdobrenje;
                bankUplatnica.DatumValute = model.DatumValute;
                bankUplatnica.Checkbox = model.Checkbox;


                bool isOk = bs.AddUplatnica(bankUplatnica);
                if (isOk)
                {
                    return Ok();

                }
            }
            return BadRequest();
        }
    }
}
