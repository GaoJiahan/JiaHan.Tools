using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiaHan.Tools;
public class Dispose : IDisposable
{
    public Action Action { get; set; } = default!;

    void IDisposable.Dispose()
    {
        Action?.Invoke();
    }
}

public class Dispose<T> : IDisposable
{
    public T Value { get; set; } = default!;

    public Action Action { get; set; } = default!;

    void IDisposable.Dispose()
    {
        Action?.Invoke();
    }
}

