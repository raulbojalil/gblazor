using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace GBlazor.Extensions
{
    public static class JSExtensions
    {
        public static Task Alert(this IJSRuntime js, string message)
        => js.InvokeAsync<object>("alert", message);

        public static Task<string> Prompt(this IJSRuntime js, string message)
        => js.InvokeAsync<string>("prompt", message);

        public static Task Confirm(this IJSRuntime js, string message)
        => js.InvokeAsync<string>("confirm", message);

        public static Task<T> JsonParse<T>(this IJSRuntime js, string str)
        => js.InvokeAsync<T>("JSON.parse", str);

        public static Task<string> JsonStringify(this IJSRuntime js, object obj)
        => js.InvokeAsync<string>("JSON.stringify", obj);

        public static Task Print(this IJSRuntime js)
        => js.InvokeAsync<string>("print");

        //Or you can simply use System.Console.WriteLine instead of this
        public static Task ConsoleLog(this IJSRuntime js, object obj)
        => js.InvokeAsync<string>("console.log", obj);
    }

    public static class JSGBExtensions
    {
        public static Task InitCanvas(this IJSRuntime js, ElementRef canvas, int width, int height)
        => js.InvokeAsync<string>("initCanvas", canvas, width, height);

        public static Task DrawCanvas(this IJSRuntime js, uint[] pixels)
        => js.InvokeAsync<string>("drawCanvas", pixels);
    }
}
