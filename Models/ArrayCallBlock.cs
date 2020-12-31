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
    public ArrayCallBlock(string id, IEnumerable<T> collectionArray, CallBlock callBlock, string medicationId, string questionId)
    : this(id, collectionArray, callBlock)
    {
        SetStartIndex((IEnumerable<ICollectionItem>)collectionArray, medicationId);
        CallBlock.MoveToElement(questionId);
    }

    public override Element GetNextElement()
    {
        Element e = null;
        
        if(CallBlock.IsDone)
        {
            ICollectionItem next = GetItem(++Index);
            if(next != null)
            {
                RestartCallBlock(CallBlock);
                e = CallBlock.GetNextElement();
            }
        }
        else 
        {
            e = CallBlock.GetNextElement();
        }


        return e;
    }
        public ICollectionItem GetCurrentItem()
    {
        return GetItem(Index);
    }

    public ICollectionItem GetItem(int index)
    {
        return index < CollectionArray.Count ? (ICollectionItem)CollectionArray[index] : null;
    }

    public void SetStartIndex(IEnumerable<ICollectionItem> collection, string startId)
    {
        Index = collection.AsQueryable().ToList().FindIndex(m => m.Id == startId);
    }
}




