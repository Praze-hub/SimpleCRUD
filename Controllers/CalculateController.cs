using System;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers{
    public class CalculateController : Controller
    {
        [HttpGet]
        public IActionResult SimpleInterest()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SimpleInterest(string amount, string months, string rate)
        {
            if(String.IsNullOrEmpty(amount) || String.IsNullOrEmpty(months) || String.IsNullOrEmpty(rate)){
                ViewBag.ErrorMessage = "Amount or months or rate must not be null";
                return View();
            }
            var amountInt = int.Parse(amount);
            var monthsInt = int.Parse(months);
            var rateInt = int.Parse(rate);
            var interest = (amountInt *rateInt *monthsInt)/100;

            ViewBag.Amount = amount;
            ViewBag.Months = months;
            ViewBag.Rate = rate;
            ViewBag.Interest = interest;
            return View();
        }

    }
}