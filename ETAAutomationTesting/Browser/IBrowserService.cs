﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETAAutomationTesting.Browser
{
    public interface IBrowserService
    {
        void OpenBrowser();

        object BrowserOptions();  
    }
}
