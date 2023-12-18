﻿//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace CefGlue
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.InteropServices;
    using CefGlue.Interop;
    
    // Role: PROXY
    public sealed unsafe partial class CefSchemeRegistrar
    {
        internal static CefSchemeRegistrar FromNative(cef_scheme_registrar_t* ptr)
        {
            return new CefSchemeRegistrar(ptr);
        }
        
        internal static CefSchemeRegistrar FromNativeOrNull(cef_scheme_registrar_t* ptr)
        {
            if (ptr == null) return null;
            return new CefSchemeRegistrar(ptr);
        }
        
        private cef_scheme_registrar_t* _self;
        
        private CefSchemeRegistrar(cef_scheme_registrar_t* ptr)
        {
            if (ptr == null) throw new ArgumentNullException("ptr");
            _self = ptr;
        }
        
        // FIXME: code for CefBaseScoped is not generated
        
        internal cef_scheme_registrar_t* ToNative()
        {
            return _self;
        }
    }
}
