using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Product
    {
        private string _description;

        public string GetDescription()
        {
            return _description;
        }

        public string SetDescription(string newDescription)
        {
           return _description = newDescription;
        }

        public void ModificarDescripcion(string newDescription)
        {
            SetDescription(newDescription);        
        }
    }
}
