namespace CTM_BindableProperty_DynamicResource;

public partial class MyCustomControl : Grid
{
    [CommunityToolkit.Maui.BindableProperty]
    public partial Color NotWorkingColor { get; set; }
    
    public static readonly BindableProperty WorkingColorProperty =
        BindableProperty.Create ("WorkingColor", typeof(Color), typeof(MyCustomControl), default(Color));
    
    public Color WorkingColor
    {
        get => (Color)GetValue(WorkingColorProperty);
        set => SetValue(WorkingColorProperty, value);
    }
}