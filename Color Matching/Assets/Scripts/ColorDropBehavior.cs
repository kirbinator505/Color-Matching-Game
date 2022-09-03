using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class ColorDropBehavior : MonoBehaviour
{
    public ColorDropSO dropDriver;
    public SpriteRenderer renderer;

    public void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
    }
}
