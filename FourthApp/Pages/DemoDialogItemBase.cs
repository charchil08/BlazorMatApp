using MatBlazor;
using Microsoft.AspNetCore.Components;

namespace FourthApp.Pages;

public class DemoDialogItemBase:ComponentBase
{
    [Parameter] public string WebUrl { get; set; }
    
    [CascadingParameter]
    public MatDialogReference DialogReference { get; set; }
    
    [Inject] 
    protected IMatDialogService DialogService { get; set; }

    protected async Task OpenDialog()
    {
        var result = await DialogService.OpenAsync(typeof(WebViewDialog), new MatDialogOptions
        {
            SurfaceStyle = "min-width: 600px; max-width: 100vh;"
        });
    }

    protected async Task CloseDialog()
    {
        DialogReference.Close(WebUrl);
    }
}
