﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.ViewModels.FavoriteProduct
{
    public class GetAllFavoriteProductRequest
    {
        public string Token { get; set; }
        public int Page { get; set; }
    }
}
