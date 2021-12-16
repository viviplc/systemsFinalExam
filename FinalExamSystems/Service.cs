using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalExamSystems
{
    public abstract class Service
    {
        private string idService;

        public string IdService { get => idService; set => idService = value; }
    }
}