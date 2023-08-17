using MatBlazor;
using Microsoft.AspNetCore.Components;

namespace FourthApp.Shared.MatComponents;

public class MaterialDialogBase:ComponentBase
{
    [Inject]
    protected IMatDialogService MatDialogService { get; set; }

    protected async Task OpenDialogFromService()
    {
        await MatDialogService.OpenAsync(typeof(object), null);
    }

    protected async Task OpenAlertFromService()
    {
        await MatDialogService.AlertAsync("Test alert message");
    }

    protected async Task OpenConfirmFromService()
    {
        await MatDialogService.ConfirmAsync("Test Confirm message");
    }

    protected async Task OpenAskFromService()
    {
        var result = await MatDialogService.AskAsync("Test ask message", new string[] { "Yes", "No", "Cancel" });
    }

    protected async Task OpenPromptFromService()
    {
        var result = await MatDialogService.PromptAsync("What is your name?");
    }
}
