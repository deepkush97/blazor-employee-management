using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Afreet.Components
{
    public class ConfirmBase : ComponentBase
    {
        [Parameter]
        public EventCallback<bool> ConfirmationChanged { get; set; }

        [Parameter]
        public string ConfirmHeaderText { get; set; } = "Confirm Delete";
        [Parameter]
        public string ConfirmBodyText { get; set; } = "Are you sure want to delete?";

        protected bool ShowConfirmation { get; set; }

        public void Show()
        {
            ShowConfirmation = true;
            StateHasChanged();
        }

        protected async Task OnConfirmationChanged(bool value)
        {
            ShowConfirmation = false;
            await ConfirmationChanged.InvokeAsync(value);
        }
    }
}
