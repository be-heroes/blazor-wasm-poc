using Microsoft.JSInterop;

namespace BlazorWasmApp.Interop.Javascript
{
    public class JavascriptInvoker : IJavascriptInvoker
    {
        private readonly IJSRuntime _runtime;
        private readonly ILogger<JavascriptInvoker> _logger;

        public JavascriptInvoker(IJSRuntime runtime, ILogger<JavascriptInvoker> logger)
        {
            _runtime = runtime;
            _logger = logger;
        }

        public async Task CalculateAsync(int value, string sign = "+")
        {
            await _runtime.InvokeVoidAsync("Calculate", value, sign);

            _logger.Log(LogLevel.Information, $"Calculate: {value} {sign}");
        }

        public async Task<float> SumAsync()
        {
            var sum = await _runtime.InvokeAsync<float>("Sum");

            _logger.Log(LogLevel.Information, $"Sum: {sum}");

            return sum;
        }
    }
}
