﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.Web.WebView2.Core.Raw.ICoreWebView2PrivateRemoteObjectProxy
// Assembly: Microsoft.Web.WebView2.Core, Version=1.0.1829.0, Culture=neutral, PublicKeyToken=2a8ab48044d2601e
// MVID: 73C692F1-1008-4DC6-8409-9A1670DD4F06
// Assembly location: C:\Users\MicroSugar\Desktop\webview\Microsoft.Web.WebView2.Core.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw
{
    [CompilerGenerated]
    //[Guid("EDEA39AE-7D39-4817-981B-8EBF2ABE124E")]
    [Guid("EFA2DF69-9CA4-40DB-A13A-EAF67A441314")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [TypeIdentifier]
    [ComImport]
    public interface ICoreWebView2PrivateRemoteObjectProxy
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        int GetId();

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void add_Passivated([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2PrivateRemoteObjectProxyPassivatedEventHandler eventHandler, out EventRegistrationToken token);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void remove_Passivated([In] EventRegistrationToken token);
    }
}
