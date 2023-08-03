﻿//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace Xilium.CefGlue
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.InteropServices;
    using System.Threading;
    using Xilium.CefGlue.Interop;
    
    // Role: PROXY
    public sealed unsafe partial class CefResourceBundle : IDisposable
    {
        internal static CefResourceBundle FromNative(cef_resource_bundle_t* ptr)
        {
            return new CefResourceBundle(ptr);
        }
        
        internal static CefResourceBundle FromNativeOrNull(cef_resource_bundle_t* ptr)
        {
            if (ptr == null) return null;
            return new CefResourceBundle(ptr);
        }
        
        private cef_resource_bundle_t* _self;
        private int _disposed = 0;
        
        private CefResourceBundle(cef_resource_bundle_t* ptr)
        {
            if (ptr == null) throw new ArgumentNullException("ptr");
            _self = ptr;
            CefObjectTracker.Track(this);
        }
        
        ~CefResourceBundle()
        {
            if (Interlocked.CompareExchange(ref _disposed, 1, 0) == 0)
            {
                Release();
                _self = null;
            }
        }
        
        public void Dispose()
        {
            if (Interlocked.CompareExchange(ref _disposed, 1, 0) == 0)
            {
                Release();
                _self = null;
            }
            CefObjectTracker.Untrack(this);
            GC.SuppressFinalize(this);
        }
        
        internal void AddRef()
        {
            cef_resource_bundle_t.add_ref(_self);
        }
        
        internal bool Release()
        {
            return cef_resource_bundle_t.release(_self) != 0;
        }
        
        internal bool HasOneRef
        {
            get { return cef_resource_bundle_t.has_one_ref(_self) != 0; }
        }
        
        internal bool HasAtLeastOneRef
        {
            get { return cef_resource_bundle_t.has_at_least_one_ref(_self) != 0; }
        }
        
        internal cef_resource_bundle_t* ToNative()
        {
            AddRef();
            return _self;
        }
    }
}
