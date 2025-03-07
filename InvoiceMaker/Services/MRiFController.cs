﻿using InvoiceMaker.Domains;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InvoiceMaker.Services
{
    public class MRiFController
    {
        public async Task<Buyer> TakeTraderInfo(string nip)
        {
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            string url = $"https://wl-api.mf.gov.pl/api/search/nip/{nip}?date={date}";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string jsonResult = await response.Content.ReadAsStringAsync();
                    JObject jsonObject = JObject.Parse(jsonResult);
                    var subject = jsonObject["result"]?["subject"];

                    if (subject != null)
                    {
                        string fullAddress = subject["workingAddress"]?.ToString();

                        return new Buyer
                        {
                            Name = subject["name"]?.ToString(),
                            VATID = subject["nip"]?.ToString(),
                            StreetAndNo = ExtractStreetAndNumber(fullAddress),
                            City = ExtractCity(fullAddress),
                            Postcode = ExtractPostcode(fullAddress)
                        };
                    }
                }
            }
            return null;
        }

        private static string ExtractStreetAndNumber(string address)
        {
            if (string.IsNullOrEmpty(address)) return "";

            string postcode = ExtractPostcode(address);
            if (!string.IsNullOrEmpty(postcode))
            {
                int index = address.IndexOf(postcode);
                if (index > 0)
                {
                    return address.Substring(0, index).Trim().Trim(',');
                }
            }
            return null;
        }

        private static string ExtractPostcode(string address)
        {
            if (string.IsNullOrEmpty(address)) return "";

            Match match = Regex.Match(address, @"\d{2}-\d{3}");
            return match.Success ? match.Value : "";
        }

        private static string ExtractCity(string address)
        {
            if (string.IsNullOrEmpty(address)) return "";

            string postcode = ExtractPostcode(address);
            if (!string.IsNullOrEmpty(postcode))
            {
                int index = address.IndexOf(postcode) + postcode.Length;
                if (index < address.Length)
                {
                    return address.Substring(index).Trim().Trim(',');
                }
            }
            return null; 
        }
    }
}
