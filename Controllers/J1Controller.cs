using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2_N01442368.Controllers
{   /// <summary>
    /// Calculates total calories of selected food items from each category.
    /// </summary>
    /// <param name="burger"></param>
    /// <param name="drink"></param>
    /// <param name="side"></param>
    /// <param name="dessert"></param>
    /// <example>GET api/IFpractice/Menu/4/4/4/4 -> Your total calorie count is 0</example>
    /// <example>GET api/IFpractice/Menu/1/2/3/4 -> Your total calorie count is 691</example>
    /// <returns>Total calories of selected food items from each category.</returns>
    public class J1Controller : ApiController
    {   [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public string GetMenu(int burger, int drink, int side, int dessert)
        {
            switch (burger)
            {
                case 1:
                    burger = 461;
                    break;
                case 2:
                    burger = 431;
                    break;
                case 3:
                    burger = 420;
                    break;
                case 4:
                    burger = 0;
                    break;
            }
            switch (drink)
            {
                case 1:
                    drink = 130;
                    break;
                case 2:
                    drink = 160;
                    break;
                case 3:
                    drink = 118;
                    break;
                case 4:
                    drink = 0;
                    break;
            }
            switch (side)
            {
                case 1:
                    side = 100;
                    break;
                case 2:
                    side = 57;
                    break;
                case 3:
                    side = 70;
                    break;
                case 4:
                    side = 0;
                    break;
            }
            switch (dessert)
            {
                case 1:
                    dessert = 167;
                    break;
                case 2:
                    dessert = 266;
                    break;
                case 3:
                    dessert = 75;
                    break;
                case 4:
                    dessert = 0;
                    break;
            }

            int totalCalorie = burger + drink + side + dessert;
            return "Your total calorie count is " + totalCalorie.ToString();
        }
    }
}
