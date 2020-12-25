using System.Collections.Generic;
public class CallBlock : Element
{
    protected Question LeadingQuestion;

    private Element LastQuestionAsked;

    public bool IsDone {get; protected set;}

    public CallBlock(string id)
    : base(id)
    {
        //LeadingQuestion = new List<Question>();
       
        CreateFakeData();
    }

    public CallBlock(string id, Element child)
    : this(id)
    {
        AddChild(child);
    }
    private void CreateFakeData()
    {
        if(Id == "SCR")
        {
            LeadingQuestion = new Question("SCR_Q1", new QuestionInformation("Please confirm your name?"));
        }
        else if(Id == "CNFRM")
        {
            LeadingQuestion = new Question("CNFRM_Q1", new QuestionInformation("Are you still taking this medication?"));
            LeadingQuestion.AddChild(new Question("CNFRM_Q2", new QuestionInformation("When was the last time you took this medication?")));
        }
        else
        {
            for(int i = 0; i < 3; i++)
            {
                if(LeadingQuestion == null)
                {
                    LeadingQuestion = new Question(string.Format("{0}_Q{1}", Id, i + 1));
                }
                else
                {
                    LeadingQuestion.AddChild(new Question(string.Format("{0}_Q{1}", Id, i + 1)));
                }
            }
        }
    
    }

    public override Element GetNextElement()
    {
        if(!IsStarted)
        {
            LastQuestionAsked = LeadingQuestion;
        }
        else
        {
            LastQuestionAsked = LastQuestionAsked.GetNextElement();

            IsDone = !HasChildren(LastQuestionAsked);
        }
        
        return LastQuestionAsked;
    }

    protected static void RestartCallBlock(CallBlock cb)
    {
        cb.LastQuestionAsked = null;
        cb.IsDone = false;
    }
    public bool IsStarted
    {
        get{
            return LastQuestionAsked != null;
        }
    }
}