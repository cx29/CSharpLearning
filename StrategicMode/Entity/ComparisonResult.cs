namespace StrategicMode.Entity
{
    /// <summary>
    /// T泛型支持，避免object重复装箱和拆箱
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ComparisonResult<T>
    {
        public string Type { get; set; }
        public bool Result { get; set; }
        public T Value { get; set; }
        public string Message { get; set; }
    }
    
}