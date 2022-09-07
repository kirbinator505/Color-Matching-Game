using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class SpriteColorBehavior : MonoBehaviour
{
    private SpriteRenderer rendererObj;
    void Start()
    {
        rendererObj = GetComponent<SpriteRenderer>();
    }

    public void ChangeRendererColor(ColorID obj)
    {
        rendererObj.color = obj.value;
    }
}
