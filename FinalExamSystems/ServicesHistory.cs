using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalExamSystems
{
    public class ServicesHistory
    {
        private DateTime dateRegister;
        private string idRegister;

        public User User
        {
            get => default;
            set
            {
            }
        }

        public Service Service
        {
            get => default;
            set
            {
            }
        }

        public DateTime DateRegister { get => dateRegister; set => dateRegister = value; }
        public string IdRegister { get => idRegister; set => idRegister = value; }
    }
}