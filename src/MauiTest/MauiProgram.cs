using SkiaSharp.Views.Maui.Controls.Hosting;

namespace MauiTest;

public static class MauiProgram {
    public static MauiApp CreateMauiApp() {
        return MauiApp.CreateBuilder()
            .UseMauiApp<App>()
            .UseSkiaSharp()
            .Build();
    }
}
