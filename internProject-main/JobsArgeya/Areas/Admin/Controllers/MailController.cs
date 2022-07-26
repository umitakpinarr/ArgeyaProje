﻿using JobsArgeya.Areas.Admin.Models;
using JobsArgeya.Data.Context;
using JobsArgeya.Data.Entities;
using JobsArgeya.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using JobsArgeya.Business;
using System.Threading.Tasks;

namespace JobsArgeya.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class MailController : Controller
    {
        private readonly DatabaseContext _databaseContext;
        private readonly IConfiguration _configuration;


        public MailController(DatabaseContext databaseContext, IConfiguration configuration)
        {
            _databaseContext = databaseContext;
            _configuration = configuration;
        }
        [Area("Admin")]
        public IActionResult Index()
        {
            GetDetails Details = new GetDetails(_databaseContext, _configuration);
            string Host = Request.Host.ToString();
            ViewData["CmsSiteName"] = Details.GetSiteDetails(3, Host);
            ViewData["FavIcon"] = Details.GetSiteDetails(7, Host);
            List<MailSubscribers> dbSubscribers = _databaseContext.MailSubscribers.ToList();
            List<MailSubscribersModel> allSubscribers = new List<MailSubscribersModel>();

            foreach (MailSubscribers subscriber in dbSubscribers)
            {
                MailSubscribersModel mailVm = new MailSubscribersModel();
                mailVm.Id = subscriber.Id;
                mailVm.Email = subscriber.Email;

                allSubscribers.Add(mailVm);
            }

            return View(allSubscribers);
        }
        [HttpGet]
        public IActionResult Send()
        {
            GetDetails Details = new GetDetails(_databaseContext, _configuration);
            string Host = Request.Host.ToString();
            ViewData["CmsSiteName"] = Details.GetSiteDetails(3, Host);
            ViewData["FavIcon"] = Details.GetSiteDetails(7, Host);
            return View();
        }
        [HttpPost]
        public IActionResult Send(SendMailModel MailCredentials)
        {
            string host = Request.Host.ToString();
            Mail mail = new Mail(_databaseContext, _configuration);
            if(ModelState.IsValid)
            {
                mail.SendMailList(MailCredentials.MailSubject, MailCredentials.MailContent, host);
                TempData["successMessage"] = "Mail listesine gönderim başarıyla sağlandı.";
            }
            else
            {
                TempData["dangerMessage"] = "Lütfen zorunlu alanları doldurup tekrar deneyiniz.";
            }
            return View();
        }
        public IActionResult Delete(int id)
        {
            var subscriber = _databaseContext.MailSubscribers.Where(x => x.Id == id).FirstOrDefault();
            if (subscriber != null)
            {
                _databaseContext.MailSubscribers.Remove(subscriber);
                _databaseContext.SaveChanges();
                TempData["successMessage"] = "Mail adresi listeden başarıyla silindi.";
            }
            else
            {
                TempData["dangerMessage"] = "Geçersiz mail adresini silmeye çalıştınız. Lütfen tekrar deneyiniz.";
            }
            return Redirect("/admin/mail/");
        }
    }
}
