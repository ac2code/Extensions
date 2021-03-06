﻿using System;
using CustomExtensions.UrlExtensions;

namespace CustomExtensions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sample anonymous type
            var instance = new
            {
                Name = "Mickey"
            };

            // convert to NameValueCollection Object
            var nvc = instance.ToNameValueCollection();

            // Nvc can be converted to dictionary
            var dict = nvc.NvcToDictionary();

            // Nvc can be converted to dynamic object
            var dyn = nvc.ToDynamic();

            // Querystrings can be generated by nvc & dictionary 
            var queryString1 = nvc.ToQueryString();
            var queryString2 = dict.ToQueryString();

            Console.WriteLine("Hello World!");
        }
    }
}
