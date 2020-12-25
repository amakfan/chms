using System.Collections.Generic;
using System.Linq;
public class ArrayCallBlock<T> : CallBlock
{
    public List<T> CollectionArray { get; private set;}
    public CallBlock CallBlock {get; private set;}
    private int Index;  
    
    public ArrayCallBlock(string id, IEnumerable<T> collectionArray, CallBlock callBlock)
    : base(id)
    {   
        CollectionArray = (List<T>)collectionArray;
        CallBlock = callBlock; 
    }

    public override Element GetNextElement()
    {
        Element e = CallBlock.GetNextElement();

        if(CallBlock.IsDone && !IsDone)
        {
            CallBlock.RestartCallBlock(CallBlock);
            Index++;

        }
        IsDone = Index >= CollectionArray.Count;

        return e;
    }

    public ICollectionItem GetCurrentItem()
    {
        return (ICollectionItem)CollectionArray[Index];
    }

    public ICollectionItem GetItem(int index)
    {
        return (ICollectionItem)CollectionArray[index];
    }
}
public class ArrayCallBlockFactory
{
    public static ArrayCallBlock<T> GetArrayCallBlock<T>(IEnumerable<T> collection)
    {
        return new ArrayCallBlock<T>("",collection, null);
    }
}



