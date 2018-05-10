using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunalPayments
{
    public class Calculation
    {
        public List<Rates> rate;

        public Calculation()
        {
            List<Rates> rate = new List<Rates>();
        }


        public void Calculate(int heating, int gas, int water, int currRepairs, bool season, int privileges)
        {
            int res;
            int final;
            Rates rates = new Rates();
            if(season == true && privileges != 0)
            {
                res = (int)(rates.Heating +(rates.Heating * 0.5) * heating) + (rates.Gas * gas) + (rates.Water * water) + (rates.CurrentRepairs * currRepairs);
                final = res * (privileges / 100);
            }
            else if (season == false && privileges != 0)
            {
                res = (rates.Heating * heating) + (rates.Gas * gas) + (rates.Water * water) + (rates.CurrentRepairs * currRepairs);
                final = res * (privileges / 100);
            }

            else if (season == true && privileges == 0)
            {
                res = (int)(rates.Heating + (rates.Heating * 0.5) * heating) + (rates.Gas * gas) + (rates.Water * water) + (rates.CurrentRepairs * currRepairs);
                final = 0;
            }

            else
            {
                res = (rates.Heating * heating) + (rates.Gas * gas) + (rates.Water * water) + (rates.CurrentRepairs * currRepairs);
                final = 0;
            }

            rates.TypeOfPayment = "Communal Payment";
            rates.Summary = res;
            rates.Privileges = final;
            rates.Total = res - final;
            if(rate == null)
            rate.Add(rates);


            rates.PrintInfo();


        }

        



    }
}
