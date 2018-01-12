﻿using System;
using System.Collections.Generic;

namespace AhkWrapper
{
    partial class AutoHotkey
    {
        public class Thread
        {
            public uint Handle;

            public Thread(uint Handle) {
                this.Handle = Handle;
            }

            public static implicit operator Thread(uint Handle) {
                return new Thread( Handle );
            }
        }
    }

    /// <summary>
    /// Allows getting and setting AutoHotkey variables with an indexer.
    /// This is equivilent to calling GetVar or SetVar
    /// </summary>
    public class DllVariableIndexer
    {
        public string this[string VarName] {
            get {
                return AutoHotkey.GetVar(VarName);
            }
            set {
                AutoHotkey.SetVar( VarName, value );
            }
        }
    }
    
}
