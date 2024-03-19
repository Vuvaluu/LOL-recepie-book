using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThumbnailSetter : MonoBehaviour
{
    [SerializeField] List<Image> thumbnails = new List<Image>();
    [SerializeField] List<Sprite> epicItems = new List<Sprite>();
    
    void Start()
    {
        for(int i = 0; i < thumbnails.Count; i++)
        {
            thumbnails[i].sprite = epicItems[i];
        }
    }

   
   
}
