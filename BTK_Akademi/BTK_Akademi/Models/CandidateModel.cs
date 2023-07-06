using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BTK_Akademi.Models
{
    public class CandidateModel
    {
        [Required(ErrorMessage = "Email'i boş bırakamazsın.")]
        public string Email { get; set; } = String.Empty;


        [Required(ErrorMessage = "İsmin ne dostum ?")]
        public string Ad { get; set; } = String.Empty;


        [Required(ErrorMessage = "Soyadı Kanunu 1934'te çıkmamış mıydı ?")]
        public string Soyad { get; set; } = String.Empty;
        //private string _soyad;        
        //public string Soyad
        //{
        //    get { return _soyad?.ToUpper(); }
        //    set { _soyad = value; }
        //}
        public int? Yas { get; set; }
        public string SecilenKurs { get; set; }
        public DateTime Muracaat { get; set; }

        public CandidateModel()
        {
            Muracaat = DateTime.Now;
        }
    }
}