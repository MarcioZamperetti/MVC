using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjetoASPNET_VazioComCRUD_EF6.Models;
using ProjetoASPNET_VazioComCRUD_EF62.Models;
using introdução.Models;

namespace introdução.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Extjs()
        {
            return View();
        }
        [HttpGet]
        public ActionResult calcula(string n1, string n2, string operacao)
        {
            double calcula = 0;



            if (n2 == "" || n1 == "")
            {
                return Content("Digite o valor dos dois numeros");
            }
            else
            {

                switch (operacao)
                {
                    case "+":
                        calcula = Convert.ToDouble(n1) + Convert.ToDouble(n2);
                        break;
                    case "-":
                        calcula = Convert.ToDouble(n1) - Convert.ToDouble(n2);
                        break;
                    case "*":
                        calcula = Convert.ToDouble(n1) * Convert.ToDouble(n2);
                        break;
                    case "/":
                        if (Convert.ToDouble(n2) == 0)//testa se a divisão é por zero
                        {
                            return Content("Não é possivel dividir um numero por zero");
                        }

                        else
                        {
                            calcula = Convert.ToDouble(n1) / Convert.ToDouble(n2);
                            break;
                        }




                }
            }
             //this.ShowMessage("Uma mensagem de teste =)");
            //return View();
            return Content("o resultado é " + calcula);
        }
        [HttpGet]
        public ActionResult gerador()
        {
            Random random = new Random();
            int dezena1 = random.Next(01, 80);
            int dezena2 = random.Next(01, 80);
            int dezena3 = random.Next(01, 80);
            int dezena4 = random.Next(01, 80);
            int dezena5 = random.Next(01, 80);


            while ((dezena5 == dezena1) || (dezena5 == dezena2) || (dezena5 == dezena4) || (dezena5 == dezena3) || (dezena3 == dezena1) || (dezena3 == dezena2) || (dezena3 == dezena4) || (dezena3 == dezena5) || (dezena1 == dezena2) || (dezena1 == dezena3) || (dezena1 == dezena4) || (dezena1 == dezena5) || (dezena2 == dezena1) || (dezena2 == dezena3) || (dezena2 == dezena4) || (dezena2 == dezena5))
            {
                if ((dezena1 == dezena2) || (dezena1 == dezena3) || (dezena1 == dezena4) || (dezena1 == dezena5))
                    dezena1 = random.Next(01, 80);
                if ((dezena2 == dezena1) || (dezena2 == dezena3) || (dezena2 == dezena4) || (dezena2 == dezena5))
                    dezena2 = random.Next(01, 80);
                if ((dezena3 == dezena1) || (dezena3 == dezena2) || (dezena3 == dezena4) || (dezena3 == dezena5))
                    dezena3 = random.Next(01, 80);
                if ((dezena4 == dezena1) || (dezena4 == dezena2) || (dezena4 == dezena3) || (dezena4 == dezena5))
                    dezena4 = random.Next(01, 80);
                if ((dezena5 == dezena1) || (dezena5 == dezena2) || (dezena5 == dezena4) || (dezena5 == dezena3))
                    dezena5 = random.Next(01, 80);
            }

            return Content("Numeros da Quina: " + dezena1 + " " + dezena2 + " " + dezena3 + " " + dezena4 + " " + dezena5);


        }

        [HttpGet]
        public ActionResult gerador2(int total, int ndezenas, int jogos)
        {
            List<int> lista = new List<int>();
            List<string> lista2 = new List<string>();
            lista.Capacity = (ndezenas);
            Random random = new Random();
            int dezena1;




            if (ndezenas > total)
            {
                return Content("O total de numeros selecionado deve ser menor que o total de dezenas");
            }

            else
            {

                total = total + 1;
                jogos = jogos + 1;
                //total = total * jogos;
                for (int j = 1; j < jogos; j++)
                {
                    lista.Clear();

                    for (int i = 0; i < ndezenas; i++)

                    {

                        dezena1 = random.Next(1, total);

                        while (lista.Contains(dezena1))
                        {
                            dezena1 = random.Next(1, total);
                        }

                        lista.Add(dezena1);
                    }

                    lista.Sort();
                    lista2.Add("Jogo Numero " + j + " a cartela tem " + lista.Count + " dezenas:");
                    lista.ForEach(i => lista2.Add(i.ToString()));



                }
                ViewBag.MinhaLista = lista2;
            }
            return View();


        }

        
    }
}
