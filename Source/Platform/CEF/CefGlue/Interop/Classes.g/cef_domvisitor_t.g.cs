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
    internal unsafe struct cef_domvisitor_t
    {
        internal cef_base_ref_counted_t _base;
        internal IntPtr _visit;
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void add_ref_delegate(cef_domvisitor_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int release_delegate(cef_domvisitor_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int has_one_ref_delegate(cef_domvisitor_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int has_at_least_one_ref_delegate(cef_domvisitor_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void visit_delegate(cef_domvisitor_t* self, cef_domdocument_t* document);
        
        private static int _sizeof;
        
        static cef_domvisitor_t()
        {
            _sizeof = Marshal.SizeOf(typeof(cef_domvisitor_t));
        }
        
        internal static cef_domvisitor_t* Alloc()
        {
            var ptr = (cef_domvisitor_t*)Marshal.AllocHGlobal(_sizeof);
            *ptr = new cef_domvisitor_t();
            ptr->_base._size = (UIntPtr)_sizeof;
            return ptr;
        }
        
        internal static void Free(cef_domvisitor_t* ptr)
        {
            Marshal.FreeHGlobal((IntPtr)ptr);
        }
        
    }
}
