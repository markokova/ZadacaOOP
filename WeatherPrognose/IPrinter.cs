using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherPrognose
{
    public interface IPrinter
    {
        void Print(Weather[] weathers);
    }
}
