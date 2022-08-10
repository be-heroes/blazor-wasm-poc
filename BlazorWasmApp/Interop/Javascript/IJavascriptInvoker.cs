namespace BlazorWasmApp.Interop.Javascript
{
    public interface IJavascriptInvoker
    {
        Task CalculateAsync(int value, string sign = "+");

        Task<float> SumAsync();
    }
}
