﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NToastNotify.Libraries
{
    public class Noty : ILibrary<NotyOptions>
    {
        public string Name { get; set; } = "noty";
        public string ScriptSrc { get; set; }
        public string StyleHref { get; set; }
        public NotyOptions Options { get; set; }
        public NotyOptions GetOptions()
        {
            return new NotyOptions();
        }
    }
}
