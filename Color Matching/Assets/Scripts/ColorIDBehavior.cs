using UnityEngine;

public class ColorIDBehavior : IDContainerBehavior
{
    public ColorIDList list;

    private void Awake()
    {
        idObj = list.currentColor;
    }
}
