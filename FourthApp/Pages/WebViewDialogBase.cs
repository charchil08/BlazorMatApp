using MatBlazor;
using Microsoft.AspNetCore.Components;

namespace FourthApp.Pages;

public class WebViewDialogBase:ComponentBase
{
    [CascadingParameter]
    public MatDialogReference DialogReference { get; set; }

    [Inject]
    protected IMatDialogService DialogService { get; set; }

    protected bool IsWebViewDialogOpen { get; set; }

    protected async Task OpenDialog()
    {
        IsWebViewDialogOpen = true;

        var webViewDialogReference = await DialogService.OpenAsync(typeof(WebViewDialog),new MatDialogOptions
        {
            SurfaceStyle = "min-width: 600px; max-width: 800px;"
        });

        //webViewDialogReference.OnClose += (sender, args) =>
        //{
        //    IsWebViewDialogOpen = false;
        //};
    }
}
