using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageSetter : MonoBehaviour
{
    public Image background_Image;
    public Image card_Image; 

    public void SetImage (Sprite card_Sprite, Color background_color){
    if(card_Image!= null)
        {
            card_Image.sprite = card_Sprite;
            background_Image.color = background_color; 
        }
    
    
    }
}
