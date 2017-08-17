﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf._9Commond.MyClearCommond
{
    public interface IView
    {
        bool IsChanged { get; set; }
        void SetBinding();
        void Refresh();
        void Clear();
        void Save();
    }
}
