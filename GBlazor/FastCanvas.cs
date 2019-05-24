using Mono.WebAssembly.Interop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GBlazor
{
    public class FastCanvas
    {
        private static readonly MonoWebAssemblyJSRuntime _js = new MonoWebAssemblyJSRuntime();

        public FastCanvas(string id)
        {
            _js.Invoke<string>("initCanvas", id);
        }

        public void DrawPixels(int[] pixels)
        {
            _js.InvokeUnmarshalled<ValueTuple<string, int[]>, object>("drawPixels", ValueTuple.Create("drawPixels", pixels));
        }
    }
}
