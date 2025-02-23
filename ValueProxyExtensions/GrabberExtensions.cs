﻿using BaseX;
using FrooxEngine;
using FrooxEngine.LogiX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueProxyExtensions
{
    internal static class GrabberExtensions
    {
        public static ValueProxy<T> GetValueProxy<T>(this Grabber grabber)
        {
            return grabber.GrabbedObjects.Select((gr) => gr.Slot.GetComponent<ValueProxy<T>>()).FirstOrDefault((p) => p != null);
        }
        public static ReferenceProxy GetReferenceProxy(this Grabber grabber)
        {
            return grabber.GrabbedObjects.Select((gr) => gr.Slot.GetComponent<ReferenceProxy>()).FirstOrDefault((p) => p != null);
        }
    }
}
