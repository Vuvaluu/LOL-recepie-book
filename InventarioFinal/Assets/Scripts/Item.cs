using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
   [SerializeField] Sprite thumbnail;
   [SerializeField] Sprite itemA;
   [SerializeField] Sprite itemB;
   [SerializeField] string name;

    public Sprite GetSprite()
    {
        return thumbnail;
    }

    public Sprite GetSpriteItemA()
    {
        return itemA;
    }

    public Sprite GetSpriteItemB()
    {
        return itemB;
    }

    public void SetSprite(Sprite sprite)
    {
        thumbnail = sprite;
    }

    public string GetName()
    {
        return name;
    }

    public void SetName(string newName)
    {
        name = newName;
    }
}
