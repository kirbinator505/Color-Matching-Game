using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ColorIDList : ScriptableObject
{
    public List<ColorID> colorIDList;

    public ColorID currentColor;

    private int num;

    public void RandomColorSet()
    {
        num = Random.Range(0, colorIDList.Count - 1);
        currentColor = colorIDList[num];
    }
}
