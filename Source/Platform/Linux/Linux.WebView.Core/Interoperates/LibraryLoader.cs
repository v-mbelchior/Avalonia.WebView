﻿namespace Linux.WebView.Core.Interoperates;

internal class LibraryLoader
{
    [DllImport("libdl.so.2")]
    private static extern IntPtr dlopen(string path, int flags);

    [DllImport("libdl.so.2")]
    private static extern IntPtr dlsym(IntPtr handle, string symbol);

    public static IntPtr LoadLibrary(string path) => dlopen(path, 257);

    public static IntPtr GetProcAddress(IntPtr hModule, string procName) => dlsym(hModule, procName);

    public static T? LoadDelegate<T>(IntPtr procaddress)
    {
        if (procaddress == IntPtr.Zero)
            return default;

        return Marshal.GetDelegateForFunctionPointer<T>(procaddress);
    }

    public static IntPtr LoadFunction<T>(T @delegate)
    {
        if (@delegate is null)
            return IntPtr.Zero;

       return Marshal.GetFunctionPointerForDelegate<T>(@delegate);
    }
}
