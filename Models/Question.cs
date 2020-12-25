using System.Collections.Generic;
public class Question : Element
{
    public QuestionInformation Information {get; private set;}
    public Question(string id)
    : base(id)
    {

    }

    public Question(string id, QuestionInformation information)
    : this(id)
    {
        Information = information;
    }

    public override Element GetNextElement()
    {
        return EvaluateCondition();
    }


}