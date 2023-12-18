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
    public unsafe partial class CefPreferenceManager : IDisposable
    {
        internal static CefPreferenceManager FromNative(cef_preference_manager_t* ptr)
        {
            return new CefPreferenceManager(ptr);
        }
        
        internal static CefPreferenceManager FromNativeOrNull(cef_preference_manager_t* ptr)
        {
            if (ptr == null) return null;
            return new CefPreferenceManager(ptr);
        }
        
        private protected cef_preference_manager_t* _self;
        
        private protected CefPreferenceManager(cef_preference_manager_t* ptr)
        {
            if (ptr == null) throw new ArgumentNullException("ptr");
            _self = ptr;
        }
        
        ~CefPreferenceManager()
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
            cef_preference_manager_t.add_ref(_self);
        }
        
        internal bool Release()
        {
            return cef_preference_manager_t.release(_self) != 0;
        }
        
        internal bool HasOneRef
        {
            get { return cef_preference_manager_t.has_one_ref(_self) != 0; }
        }
        
        internal bool HasAtLeastOneRef
        {
            get { return cef_preference_manager_t.has_at_least_one_ref(_self) != 0; }
        }
        
        internal cef_preference_manager_t* ToNative()
        {
            AddRef();
            return _self;
        }
    }
}
