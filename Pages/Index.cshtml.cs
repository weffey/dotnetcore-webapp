﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace dotnetcore_webapp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            
            string myveryprivatekey = 
            "E9873D79C6D87DC0FB6A5778633389F4453213303DA61F20BD67FC233AA33262F4453213303DA61F20BD67FC233AA33262F4453213303DA61F20BD67FC233AA33262F4453213303DA61F20BD67FC233AA33262F4453213303DA61F20BD67FC233AA33262F4453213303DA61F20BD67FC233AA33262F4453213303DA61F20BD67FC233AA33262F4453213303DA61F20BD67FC233AA33262F4453213303DA61F20BD67FC233AA33262F4453213303DA61F20BD67FC233AA33262F4453213303DA61F20BD67FC233AA33262F4453213303DA61F20BD67FC233AA33262F4453213303DA61F20BD67FC233AA33262F4453213303DA61F20BD67FC233AA33262F4453213303DA61F20BD67FC233AA33262F4453213303DA61F20BD67FC233AA33262";
            string mynotsoprivatekey = 
            "E9873D79C6D87DC0FB6A5778633389_SAMPLE_PRIVATE_KEY_DO_NOT_IMPORT_F4453213303DA61F20BD67FC233AA33262" + myveryprivatekey;
            string mynotsoprivatekconectionstring = 
            "Server=myServerAddress;Database=shehackspurpledb;User Id=shehackspurple;Password=F4453213303DA61F20BD67FC233AA33262;";
            mynotsoprivatekey = mynotsoprivatekey + mynotsoprivatekconectionstring;
            /* Add logging of secrets later */ 
            string mySecretKey2 = "E9873D79C6D87DC0FB6A5778633389_F4453213303DA61F20BD67FC233AA33262"
        }       

        public void OnGet()
        {

        }
    }
}
