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
    public sealed unsafe partial class CefDictionaryValue : IDisposable
    {
        internal static CefDictionaryValue FromNative(cef_dictionary_value_t* ptr)
        {
            return new CefDictionaryValue(ptr);
        }
        
        internal static CefDictionaryValue FromNativeOrNull(cef_dictionary_value_t* ptr)
        {
            if (ptr == null) return null;
            return new CefDictionaryValue(ptr);
        }
        
        private cef_dictionary_value_t* _self;
        
        private CefDictionaryValue(cef_dictionary_value_t* ptr)
        {
            if (ptr == null) throw new ArgumentNullException("ptr");
            _self = ptr;
        }
        
        ~CefDictionaryValue()
        {
            if (_self != null)
            {
                Release();
                _self = null;
            }
        }
        
        public void Dispose()
        {
            if (_self != null)
            {
                Release();
                _self = null;
            }
            GC.SuppressFinalize(this);
        }
        
        internal void AddRef()
        {
            cef_dictionary_value_t.add_ref(_self);
        }
        
        internal bool Release()
        {
            return cef_dictionary_value_t.release(_self) != 0;
        }
        
        internal bool HasOneRef
        {
            get { return cef_dictionary_value_t.has_one_ref(_self) != 0; }
        }
        
        internal bool HasAtLeastOneRef
        {
            get { return cef_dictionary_value_t.has_at_least_one_ref(_self) != 0; }
        }
        
        internal cef_dictionary_value_t* ToNative()
        {
            AddRef();
            return _self;
        }
    }
}
