﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ozdilekteyim.Models
{
    public class EngCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Name { get; set; }
        public int? CategoryID { get; set; }
        public Category Category { get; set; }
        public string LanguageCode { get; set; } = "en-us";

        public bool State { get; set; }
       
        public int Source { get; set; } = 0;
        public string ShopPHPID { get; set; }
        public string ShopPHPName { get; set; }
        public bool ShopPHPState { get; set; }
    }
}
