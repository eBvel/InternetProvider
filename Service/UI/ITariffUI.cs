using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.UI
{
    public interface ITariffUI
    {
        string TariffName { get; }
        double Speed { get; }
        double Traffic { get; }
        decimal Price { get; }

        void FullingFields(string name, string speed, string traffic, string price);
    }
}
