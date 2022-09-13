using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class SpriteColorBehavior : MonoBehaviour
{
    private SpriteRenderer rendererObj;
    
    void Awake()
    {
        rendererObj = GetComponent<SpriteRenderer>();
    }

    public void ChangeRendererColor(ColorID obj)
    {
        rendererObj.color = obj.value;
    }

    public void ChangeRendererColor(ColorIDList list)
    {
        rendererObj.color = list.currentColor.value;
    }
}
