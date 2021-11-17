using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace mypracticework.Domain
{
    public class Меню
    {
        public int КодБлюда { get; set; }
        public int Блюдо { get; set; }
        public object Фотография { get; set; } //
        public string Ингридиент { get; set; }
        public int Порция { get; set; }
        public decimal Цена { get; set; }

    }
}