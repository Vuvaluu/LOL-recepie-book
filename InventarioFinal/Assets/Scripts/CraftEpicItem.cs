using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CraftEpicItem : MonoBehaviour
{
    
    [SerializeField] List <Item> items = new List<Item>();
    [SerializeField] List <Sprite> basicItems  = new List<Sprite>();
    Queue <Sprite> firstItemSprites = new Queue<Sprite>();
    Stack <Sprite> secondItemSprites = new Stack<Sprite>();
    Dictionary<int, Item> resultItems = new Dictionary<int, Item>();

    int resultItemPos;
    [SerializeField] Image firstThumbnail;
    [SerializeField] Image secondThumbnail;
    [SerializeField] Image resultThumbnail;
    [SerializeField] Button firstAcceptButton; 
    [SerializeField] Button firstRejectButton;
    [SerializeField] Button secondAcceptButton; 
    [SerializeField] Button secondRejectButton;
    [SerializeField] GameObject checkmark;
    [SerializeField] GameObject crossicon;

    void Start()
    {
        foreach(Sprite sprite in basicItems)
        {
            firstItemSprites.Enqueue(sprite);
            secondItemSprites.Push(sprite);
        }

        for(int i = 0; i < items.Count; i++)
        {
            resultItems.Add(i, items[i]);
        }

        int rand = Random.Range(0, resultItems.Count);
        Debug.Log(rand);
        resultThumbnail.sprite = resultItems[rand].GetSprite();
        resultItemPos = rand;
        firstThumbnail.sprite = firstItemSprites.Dequeue();
        secondThumbnail.sprite = secondItemSprites.Pop(); 
    }

    public void AcceptItem()
    {
        CheckCraftingRecepie();
    }

    public void RejectItemA()
    {
        if (firstItemSprites.Count > 0)
        {
            firstThumbnail.sprite = firstItemSprites.Dequeue();
        }
    }   
    public void RejectItemB()
    {
         if (secondItemSprites.Count > 0)
        {
            secondThumbnail.sprite = secondItemSprites.Pop();
        }
        
    }

    private void CheckCraftingRecepie()
    {
        if(firstThumbnail.sprite == resultItems[resultItemPos].GetSpriteItemA())
        {
            if(secondThumbnail.sprite == resultItems[resultItemPos].GetSpriteItemB())
            {
                Debug.Log("win");
                checkmark.SetActive(true);
                crossicon.SetActive(false);
            } else {
                checkmark.SetActive(false);
                crossicon.SetActive(true);
            }
        }else{
            checkmark.SetActive(false);
            crossicon.SetActive(true);
        }
    }

    public void Restart()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
}
