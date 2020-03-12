using UnityEngine;

[CreateAssetMenu]
public class Collectable : ScriptableObject
{
    public int powerLevel = 10;
    public Color collectableColor = Color.red;
    public Sprite collectableSprite;

    public bool Contains(Collectable singleCollectable)
    {
        throw new System.NotImplementedException();
    }
}
