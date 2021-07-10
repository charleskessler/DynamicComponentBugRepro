# DynamicComponentBugRepro

1. Clone repo
2. Run ```dotnet publish .\TestWizard\TestWizard.csproj --output .\WizardAssemblies'``` from repo root directory to publish demo assembly for discovery
3. Build + Run
4. Click on 'Show Dialog' button, and observe exception

```
info: Microsoft.Hosting.Lifetime[14]
      Now listening on: https://localhost:5001
info: Microsoft.Hosting.Lifetime[14]
      Now listening on: http://localhost:5000
info: Microsoft.Hosting.Lifetime[0]
      Application started. Press Ctrl+C to shut down.
info: Microsoft.Hosting.Lifetime[0]
      Hosting environment: Development
info: Microsoft.Hosting.Lifetime[0]
      Content root path: C:\Users\charl\source\repos\DynamicComponentBugRepro\DynamicComponentBugRepro
warn: Microsoft.AspNetCore.Components.Server.Circuits.RemoteRenderer[100]
      Unhandled exception rendering component: The component type must implement Microsoft.AspNetCore.Components.IComponent.
      System.ArgumentException: The component type must implement Microsoft.AspNetCore.Components.IComponent.
         at Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder.OpenComponent(Int32 sequence, Type componentType) in Microsoft.AspNetCore.Components.dll:token 0x6000312+0x35
         at Microsoft.AspNetCore.Components.DynamicComponent.Render(RenderTreeBuilder builder) in Microsoft.AspNetCore.Components.dll:token 0x60000c2+0x0
         at Microsoft.AspNetCore.Components.Rendering.ComponentState.RenderIntoBatch(RenderBatchBuilder batchBuilder, RenderFragment renderFragment, Exception& renderFragmentException) in Microsoft.AspNetCore.Components.dll:token 0x60002c4+0x17
fail: Microsoft.AspNetCore.Components.Server.Circuits.CircuitHost[111]
      Unhandled exception in circuit 'ghStAXJFFbfPXsI-26jziE1JCsFi4953iRZihwz6ZVc'.
      System.ArgumentException: The component type must implement Microsoft.AspNetCore.Components.IComponent.
         at Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder.OpenComponent(Int32 sequence, Type componentType) in Microsoft.AspNetCore.Components.dll:token 0x6000312+0x35
         at Microsoft.AspNetCore.Components.DynamicComponent.Render(RenderTreeBuilder builder) in Microsoft.AspNetCore.Components.dll:token 0x60000c2+0x0
         at Microsoft.AspNetCore.Components.Rendering.ComponentState.RenderIntoBatch(RenderBatchBuilder batchBuilder, RenderFragment renderFragment, Exception& renderFragmentException) in Microsoft.AspNetCore.Components.dll:token 0x60002c4+0x17
warn: Microsoft.AspNetCore.Components.Server.Circuits.RemoteRenderer[100]
      Unhandled exception rendering component: Cannot access a disposed object.
      System.ObjectDisposedException: Cannot access a disposed object.
         at Microsoft.AspNetCore.Components.RenderTree.ArrayBuilder`1.ThrowObjectDisposedException() in Microsoft.AspNetCore.Components.dll:token 0x60002bc+0x6
         at Microsoft.AspNetCore.Components.RenderTree.ArrayBuilder`1.GrowBuffer(Int32 desiredCapacity) in Microsoft.AspNetCore.Components.dll:token 0x60002b8+0x8
         at Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrameArrayBuilder.AppendElement(Int32 sequence, String elementName) in Microsoft.AspNetCore.Components.dll:token 0x60002a3+0x10
         at Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder.OpenElement(Int32 sequence, String elementName) in Microsoft.AspNetCore.Components.dll:token 0x60002ff+0x33
         at MudBlazor.MudFocusTrap.BuildRenderTree(RenderTreeBuilder __builder) in MudBlazor.dll:token 0x600058b+0x0
         at Microsoft.AspNetCore.Components.ComponentBase.<.ctor>b__6_0(RenderTreeBuilder builder) in Microsoft.AspNetCore.Components.dll:token 0x60000a5+0xe
         at Microsoft.AspNetCore.Components.Rendering.ComponentState.RenderIntoBatch(RenderBatchBuilder batchBuilder, RenderFragment renderFragment, Exception& renderFragmentException) in Microsoft.AspNetCore.Components.dll:token 0x60002c4+0x17
fail: Microsoft.AspNetCore.Components.Server.Circuits.CircuitHost[111]
      Unhandled exception in circuit 'ghStAXJFFbfPXsI-26jziE1JCsFi4953iRZihwz6ZVc'.
      System.ObjectDisposedException: Cannot access a disposed object.
         at Microsoft.AspNetCore.Components.RenderTree.ArrayBuilder`1.ThrowObjectDisposedException() in Microsoft.AspNetCore.Components.dll:token 0x60002bc+0x6
         at Microsoft.AspNetCore.Components.RenderTree.ArrayBuilder`1.GrowBuffer(Int32 desiredCapacity) in Microsoft.AspNetCore.Components.dll:token 0x60002b8+0x8
         at Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrameArrayBuilder.AppendElement(Int32 sequence, String elementName) in Microsoft.AspNetCore.Components.dll:token 0x60002a3+0x10
         at Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder.OpenElement(Int32 sequence, String elementName) in Microsoft.AspNetCore.Components.dll:token 0x60002ff+0x33
         at MudBlazor.MudFocusTrap.BuildRenderTree(RenderTreeBuilder __builder) in MudBlazor.dll:token 0x600058b+0x0
         at Microsoft.AspNetCore.Components.ComponentBase.<.ctor>b__6_0(RenderTreeBuilder builder) in Microsoft.AspNetCore.Components.dll:token 0x60000a5+0xe
         at Microsoft.AspNetCore.Components.Rendering.ComponentState.RenderIntoBatch(RenderBatchBuilder batchBuilder, RenderFragment renderFragment, Exception& renderFragmentException) in Microsoft.AspNetCore.Components.dll:token 0x60002c4+0x17
         ```
