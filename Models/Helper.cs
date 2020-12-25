using System.Collections.Generic;
using System.Collections;
public class Helper
{
    public static ArrayCallBlock<T> GetArrayCallBlock<T>(IEnumerable<T> collection)
    {
        var cb  = new ArrayCallBlock<T>("", collection, null);
        
        return new ArrayCallBlock<T>("", collection, null);

    }
}