﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikTime.MauiApp.MVVM.Model.Service
{
 public    class Service
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            
            return Name;
        }
    }
}
