﻿namespace AvaloniaBlazorWebView;

partial class BlazorWebView  
{
    static bool LoadDependencyObjectsChanged()
    {
        ChildProperty.Changed.AddClassHandler<BlazorWebView, Control?>((x, e) => x.ChildChanged(e));
        return true;
    }

    private static readonly StyledProperty<Control?> ChildProperty =
            AvaloniaProperty.Register<BlazorWebView, Control?>(nameof(Child));

    public static readonly StyledProperty<bool> KeepAliveProperty =
            AvaloniaProperty.Register<BlazorWebView, bool>(nameof(KeepAlive), defaultValue: false);


    [Content]
    private Control? Child
    {
        get => GetValue(ChildProperty);
        set => SetValue(ChildProperty, value);
    }

    public bool KeepAlive
    {
        get => GetValue(KeepAliveProperty);
        set => SetValue(KeepAliveProperty, value);
    }

    private void ChildChanged(AvaloniaPropertyChangedEventArgs e)
    {
        var oldChild = (Control?)e.OldValue;
        var newChild = (Control?)e.NewValue;

        if (oldChild != null)
        {
            ((ISetLogicalParent)oldChild).SetParent(null);
            LogicalChildren.Clear();
            VisualChildren.Remove(oldChild);
        }

        if (newChild != null)
        {
            ((ISetLogicalParent)newChild).SetParent(this);
            VisualChildren.Add(newChild);
            LogicalChildren.Add(newChild);
        }
    }
}
