using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.UI.WebControls;
using System.Xml.Schema;
using Microsoft.Ajax.Utilities;

namespace Assignment2_N01442368.Controllers
{
    public class J2Controller : ApiController
    {

        /// <summary>
        /// Diana plays a game with two dice which have m sides and n sides.
        /// She is going to add numbers of each side to make the sum 10.
        /// This code determines how many ways Diana can roll the value of 10.
        /// </summary>
        /// <param name="sidem">How many sides of dice m</param>
        /// <param name="siden">How many sides of dice n</param>
        /// <example> Get api/J2/DiceGame/6/8 -> There are 5 total ways to get the sum 10</example>
        /// <example> Get api/J2/DiceGame/12/4 -> There are 4 total ways to get the sum 10</example>
        /// <example> Get api/J2/DiceGame/3/3 -> There are 0 total ways to get the sum 10</example>
        /// <example> Get api/J2/DiceGame/5/5 -> There are 1 total ways to get the sum 10</example>
        /// <returns>The number of ways Diana can roll the value of 10.</returns>
        [Route("api/J2/DiceGame/{sidem}/{siden}")]
        public string GetDiceGame(int sidem, int siden)
        {
            //get the number list of each die
            List<int> numSidem = new List<int>();
            List<int> numSiden = new List<int>();

            if (sidem > 0)
            {
                for (int m = 1; m <= sidem; m++)
                {
                    numSidem.Add(m);
                }
            }
            if (siden > 0)
            {
                for (int n = 1; n <= siden; n++)
                {
                    numSiden.Add(n);
                }
            }

            //check all number pairs and calculate how many pairs whose sum is 10
            List<int> result = new List<int>();
            int total = 0;

            if (sidem > 0 && siden > 0)
            {
                for (int m2 = 0; m2 < numSidem.Count; m2++)
                {
                    for (int n2 = 0; n2 < numSiden.Count; n2++)
                    {
                        bool check = numSidem[m2] + numSiden[n2] == 10;

                        if (!check)
                        {
                            result.Add(0);
                        }
                        else
                        {
                            result.Add(1);
                        }
                    }                  
                }
                for (int resultNum = 0; resultNum < result.Count; resultNum++)
                {
                    total = total + result[resultNum];
                }
            }
            return "There are " + total.ToString() + " total ways to get the sum 10";
        }
            
    }
}
