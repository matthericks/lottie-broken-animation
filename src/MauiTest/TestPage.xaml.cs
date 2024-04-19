namespace MauiTest;

public partial class TestPage {
    public TestPage() {
        InitializeComponent();
        BindingContext = new ScratchViewModel();
    }
}
