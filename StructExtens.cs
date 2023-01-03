namespace JiaHan.Tools;
public static class StructExtens
{
    public unsafe static ref T ToStruct<T>(this byte[] bytes, long offset = 0) where T : unmanaged
    {
        fixed (void* ptr = &bytes[offset]) return ref *(T*)ptr;
    }

    public unsafe static Span<T> ToStructs<T>(this byte[] bytes, int count, long offset = 0) where T : unmanaged
    {
        fixed (void* ptr = &bytes[offset]) return new Span<T>(ptr, count);
    }

    public unsafe static T ToStruct<T>(byte* ptr, long offset = 0) where T : unmanaged 
        => *(T*)(ptr + offset);

    public unsafe static Span<T> ToStructs<T>(byte* ptr, int count, long offset = 0) where T : unmanaged 
        => new Span<T>(ptr + offset, count);

    public unsafe static string ToAscii(this byte[] bytes, long offset = 0)
    {
        fixed (void* ptr = &bytes[offset]) return new((sbyte*)ptr);
    }
    public unsafe static string ToUTF16(this byte[] bytes, long offset = 0)
    {
        fixed (void* ptr = &bytes[offset]) return new((char*)ptr);
    }

    public unsafe static string ToAscii(byte* ptr, long offset = 0) => new((sbyte*)(ptr + offset));

    public unsafe static string ToUTF16(byte* ptr, long offset = 0) => new((char*)(ptr + offset));
}
