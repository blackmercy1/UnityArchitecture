using JetBrains.Annotations;
using UnityEngine;

public abstract class FilterDecorator : IFilter
{
    [CanBeNull] protected readonly IFilter Child;

    public FilterDecorator()
    {
        
    }
    
    public FilterDecorator(IFilter child)
    {
        Child = child; 
    }
    
    public bool Check(GameObject obj)
    {
        var flag = CheckInternal(obj);
        if (Child != null)
            flag &= Child.Check(obj);

        return flag;
    }
    
    protected abstract bool CheckInternal(GameObject obj);
}

