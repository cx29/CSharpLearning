# 通用语言运行时 `CLR(Common Language Runtime)`
- dotnet核心组件，提供内存管理，垃圾回收，异常处理等关键功能
- 类似于`Java`的`JVM`
- 运行流程：C#源码 $\longrightarrow$ 编译器（C#$\longrightarrow$IL）$\longrightarrow$ CLR执行（JIT编译+GC+安全管理）$\longrightarrow$ 机器码

## `StaticClass`
1. 先初始化静态字段 输出`A1`
2. 再调用静态构造函数 输出`A3`
3. 再初始化成员变量 输出`A2`
4. 最后调用构造函数 输出`A4`