using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Text;
using System.Linq;
using Sandbox.Game.EntityComponents; // Sandbox.Game.dll
using Sandbox.ModAPI.Ingame; // Sandbox.Common.dll
using Sandbox.ModAPI.Interfaces; // Sandbox.Common.dll
using SpaceEngineers.Game.ModAPI.Ingame; // SpacenEngineers.Game.dll
using VRage;
using VRage.Collections; // VRage.Library.dll
using VRage.Game; // VRage.Game.dll
using VRage.Game.Components; // VRage.Game.dll
using VRage.Game.GUI.TextPanel;
using VRage.Game.ModAPI.Ingame; // VRage.Game.dll
using VRage.Game.ObjectBuilders.Definitions; // VRage.Game.dll
using VRageMath; //VRage.Math.dll

namespace SpaceEngineersScript
{
    internal sealed class Program : MyGridProgram
    {
        public Program()
        {
            // The constructor, called only once every session and
            // always before any other method is called. Use it to
            // initialize your script. 
            //     
            // The constructor is optional and can be removed if not
            // needed.
            // 
            // It's recommended to set RuntimeInfo.UpdateFrequency 
            // here, which will allow your script to run itself without a 
            // timer block.
        }

        public void Save()
        {
            // Called when the program needs to save its state. Use
            // this method to save your state to the Storage field
            // or some other means. 
            // 
            // This method is optional and can be removed if not
            // needed.
        }

        public void Main(string argument, UpdateType updateSource)
        {
            // The main entry point of the script, invoked every time
            // one of the programmable block's Run actions are invoked,
            // or the script updates itself. The updateSource argument
            // describes where the update came from.
            // 
            // The method itself is required, but the arguments above
            // can be removed if not needed.
        }
    }
}