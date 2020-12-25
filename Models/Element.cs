using System.Collections.Generic;
public abstract class Element
{
    protected string Id;
    protected List<Element> Children;
    protected string Condition;

    protected Element(string id)
    {
        Id = id;
    }

    public void AddChild(Element child)
    {
        if(Children == null)
        {
            Children = new List<Element>();
        }
        Children.Add(child);
    }


    public Element FindChild(string childId)
    {
        return Children.Find(m => m.Id == childId);
    }

    protected Element EvaluateCondition()
    {
        //for demonstration, assume only one child but reality is not the case
        
        return Children != null ? Children[0] : null;
    }

    protected bool HasChildren(Element element)
    {
        return element.Children != null;
    }

    public abstract Element GetNextElement();


 






}