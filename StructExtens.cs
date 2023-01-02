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
}
