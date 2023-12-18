﻿//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace CefGlue.Interop
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.InteropServices;
    using System.Security;
    
    [StructLayout(LayoutKind.Sequential, Pack = libcef.ALIGN)]
    [SuppressMessage("Microsoft.Design", "CA1049:TypesThatOwnNativeResourcesShouldBeDisposable")]
    internal unsafe struct cef_jsdialog_handler_t
    {
        internal cef_base_ref_counted_t _base;
        internal IntPtr _on_jsdialog;
        internal IntPtr _on_before_unload_dialog;
        internal IntPtr _on_reset_dialog_state;
        internal IntPtr _on_dialog_closed;
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void add_ref_delegate(cef_jsdialog_handler_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int release_delegate(cef_jsdialog_handler_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int has_one_ref_delegate(cef_jsdialog_handler_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int has_at_least_one_ref_delegate(cef_jsdialog_handler_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int on_jsdialog_delegate(cef_jsdialog_handler_t* self, cef_browser_t* browser, cef_string_t* origin_url, CefJSDialogType dialog_type, cef_string_t* message_text, cef_string_t* default_prompt_text, cef_jsdialog_callback_t* callback, int* suppress_message);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int on_before_unload_dialog_delegate(cef_jsdialog_handler_t* self, cef_browser_t* browser, cef_string_t* message_text, int is_reload, cef_jsdialog_callback_t* callback);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void on_reset_dialog_state_delegate(cef_jsdialog_handler_t* self, cef_browser_t* browser);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void on_dialog_closed_delegate(cef_jsdialog_handler_t* self, cef_browser_t* browser);
        
        private static int _sizeof;
        
        static cef_jsdialog_handler_t()
        {
            _sizeof = Marshal.SizeOf(typeof(cef_jsdialog_handler_t));
        }
        
        internal static cef_jsdialog_handler_t* Alloc()
        {
            var ptr = (cef_jsdialog_handler_t*)Marshal.AllocHGlobal(_sizeof);
            *ptr = new cef_jsdialog_handler_t();
            ptr->_base._size = (UIntPtr)_sizeof;
            return ptr;
        }
        
        internal static void Free(cef_jsdialog_handler_t* ptr)
        {
            Marshal.FreeHGlobal((IntPtr)ptr);
        }
        
    }
}
