﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Toha.QIiik.Web.Models;

namespace Toha.QIiik.Web.Interfaces
{
    public interface IAlgorithmService
    {
        AlgorithmResponse HashMe(string stringInput);
    }
}
