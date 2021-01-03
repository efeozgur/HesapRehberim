using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HesapRehberim.Models.Modeller;


namespace HesapRehberim.ViewModels
{
    public class YaklasikMaliyetViewModel
    {
        public List<Malzeme> Malzemeler { get; set; }
        public YaklasikMaliyet yaklasikMaliyet { get; set; }


    }
}