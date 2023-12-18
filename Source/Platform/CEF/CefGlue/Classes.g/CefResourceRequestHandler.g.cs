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
    
    // Role: HANDLER
    public abstract unsafe partial class CefResourceRequestHandler
    {
        private static Dictionary<IntPtr, CefResourceRequestHandler> _roots = new Dictionary<IntPtr, CefResourceRequestHandler>();
        
        private int _refct;
        private cef_resource_request_handler_t* _self;
        
        protected object SyncRoot { get { return this; } }
        
        private cef_resource_request_handler_t.add_ref_delegate _ds0;
        private cef_resource_request_handler_t.release_delegate _ds1;
        private cef_resource_request_handler_t.has_one_ref_delegate _ds2;
        private cef_resource_request_handler_t.has_at_least_one_ref_delegate _ds3;
        private cef_resource_request_handler_t.get_cookie_access_filter_delegate _ds4;
        private cef_resource_request_handler_t.on_before_resource_load_delegate _ds5;
        private cef_resource_request_handler_t.get_resource_handler_delegate _ds6;
        private cef_resource_request_handler_t.on_resource_redirect_delegate _ds7;
        private cef_resource_request_handler_t.on_resource_response_delegate _ds8;
        private cef_resource_request_handler_t.get_resource_response_filter_delegate _ds9;
        private cef_resource_request_handler_t.on_resource_load_complete_delegate _dsa;
        private cef_resource_request_handler_t.on_protocol_execution_delegate _dsb;
        
        protected CefResourceRequestHandler()
        {
            _self = cef_resource_request_handler_t.Alloc();
        
            _ds0 = new cef_resource_request_handler_t.add_ref_delegate(add_ref);
            _self->_base._add_ref = Marshal.GetFunctionPointerForDelegate(_ds0);
            _ds1 = new cef_resource_request_handler_t.release_delegate(release);
            _self->_base._release = Marshal.GetFunctionPointerForDelegate(_ds1);
            _ds2 = new cef_resource_request_handler_t.has_one_ref_delegate(has_one_ref);
            _self->_base._has_one_ref = Marshal.GetFunctionPointerForDelegate(_ds2);
            _ds3 = new cef_resource_request_handler_t.has_at_least_one_ref_delegate(has_at_least_one_ref);
            _self->_base._has_at_least_one_ref = Marshal.GetFunctionPointerForDelegate(_ds3);
            _ds4 = new cef_resource_request_handler_t.get_cookie_access_filter_delegate(get_cookie_access_filter);
            _self->_get_cookie_access_filter = Marshal.GetFunctionPointerForDelegate(_ds4);
            _ds5 = new cef_resource_request_handler_t.on_before_resource_load_delegate(on_before_resource_load);
            _self->_on_before_resource_load = Marshal.GetFunctionPointerForDelegate(_ds5);
            _ds6 = new cef_resource_request_handler_t.get_resource_handler_delegate(get_resource_handler);
            _self->_get_resource_handler = Marshal.GetFunctionPointerForDelegate(_ds6);
            _ds7 = new cef_resource_request_handler_t.on_resource_redirect_delegate(on_resource_redirect);
            _self->_on_resource_redirect = Marshal.GetFunctionPointerForDelegate(_ds7);
            _ds8 = new cef_resource_request_handler_t.on_resource_response_delegate(on_resource_response);
            _self->_on_resource_response = Marshal.GetFunctionPointerForDelegate(_ds8);
            _ds9 = new cef_resource_request_handler_t.get_resource_response_filter_delegate(get_resource_response_filter);
            _self->_get_resource_response_filter = Marshal.GetFunctionPointerForDelegate(_ds9);
            _dsa = new cef_resource_request_handler_t.on_resource_load_complete_delegate(on_resource_load_complete);
            _self->_on_resource_load_complete = Marshal.GetFunctionPointerForDelegate(_dsa);
            _dsb = new cef_resource_request_handler_t.on_protocol_execution_delegate(on_protocol_execution);
            _self->_on_protocol_execution = Marshal.GetFunctionPointerForDelegate(_dsb);
        }
        
        ~CefResourceRequestHandler()
        {
            Dispose(false);
        }
        
        protected virtual void Dispose(bool disposing)
        {
            if (_self != null)
            {
                cef_resource_request_handler_t.Free(_self);
                _self = null;
            }
        }
        
        private void add_ref(cef_resource_request_handler_t* self)
        {
            lock (SyncRoot)
            {
                var result = ++_refct;
                if (result == 1)
                {
                    lock (_roots) { _roots.Add((IntPtr)_self, this); }
                }
            }
        }
        
        private int release(cef_resource_request_handler_t* self)
        {
            lock (SyncRoot)
            {
                var result = --_refct;
                if (result == 0)
                {
                    lock (_roots) { _roots.Remove((IntPtr)_self); }
                    return 1;
                }
                return 0;
            }
        }
        
        private int has_one_ref(cef_resource_request_handler_t* self)
        {
            lock (SyncRoot) { return _refct == 1 ? 1 : 0; }
        }
        
        private int has_at_least_one_ref(cef_resource_request_handler_t* self)
        {
            lock (SyncRoot) { return _refct != 0 ? 1 : 0; }
        }
        
        internal cef_resource_request_handler_t* ToNative()
        {
            add_ref(_self);
            return _self;
        }
        
        [Conditional("DEBUG")]
        private void CheckSelf(cef_resource_request_handler_t* self)
        {
            if (_self != self) throw ExceptionBuilder.InvalidSelfReference();
        }
        
    }
}
