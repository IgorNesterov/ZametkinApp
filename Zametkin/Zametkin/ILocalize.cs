using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Zametkin
{
    public interface ILocalize
    {
        CultureInfo GetCurrentCultureInfo();
    }
}
