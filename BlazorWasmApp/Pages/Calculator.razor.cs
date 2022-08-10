using BlazorWasmApp.Interop.Javascript;
using Microsoft.AspNetCore.Components;

namespace BlazorWasmApp.Pages
{
    public partial class Calculator
    {
        private int? _value { get; set; }

        private string? _sign { get; set; }

        private float _sum = 0;

        [Inject]
        private IJavascriptInvoker IJavascriptInvoker { get; set; }

        private async Task Calculate() {
            await IJavascriptInvoker.CalculateAsync(_value ?? 0, _sign ?? "+");

            _sum = await IJavascriptInvoker.SumAsync();
        }
    }
}