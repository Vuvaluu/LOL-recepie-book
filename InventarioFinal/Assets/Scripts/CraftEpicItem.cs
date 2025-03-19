using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CraftEpicItem : MonoBehaviour
{
    [SerializeField] List <Sprite> colorSprites = new List<Sprite>();
    [SerializeField] List<Sprite> resultSprites= new List<Sprite>();

    int resultItemPos;
    [SerializeField] Image firstThumbnail;
    [SerializeField] Image secondThumbnail;
    [SerializeField] Image resultThumbnail;
    [SerializeField] Button firstAcceptButton; 
    [SerializeField] Button firstRejectButton; 
    [SerializeField] Button secondRejectButton;
    [SerializeField] GameObject checkmark;
    [SerializeField] GameObject crossicon; 

    void Start()
    {
        
    }

    
}
