# 通用语言运行时 `CLR(Common Language Runtime)`
- dotnet核心组件，提供内存管理，垃圾回收，异常处理等关键功能
- 类似于`Java`的`JVM`
- 运行流程：C#源码 $\longrightarrow$ 编译器（C# $\longrightarrow$ IL）$\longrightarrow$ CLR执行（JIT编译+GC+安全管理）$\longrightarrow$ 机器码

## `StaticClass`
1. 先初始化静态字段 输出`A1`
2. 再调用静态构造函数 输出`A3`
3. 再初始化成员变量 输出`A2`
4. 最后调用构造函数 输出`A4`

## 静态构造方法帮助实现单例模式
- 根据`StaticClass`的初始化顺序`Singleton`的初始化顺序如下:
  1. 调用静态方法`Instance`以在需要的时候才实例化
  2. `Instance`中返回`Nested._instance`
  3. 在初次运行到有关`Nested`的代码时，会首先调用静态构造方法（如果有）
  4. 在调用静态构造方法前，会先初始化该类中的所有静态变量（`_instance`)