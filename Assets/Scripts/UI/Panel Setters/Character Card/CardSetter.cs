using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardSetter : MonoBehaviour
{
    public ImageSetter imageContainer;
    public TitleSetter titleContainer;
    public InfoSetter infoContainer; 

    public void FillCard(CardData cardData)
    {
        imageContainer.SetImage(cardData.image, cardData.color);

        titleContainer.setTitle(cardData.Title);

        infoContainer.SetInfo(cardData.specs_List, cardData.badges_List); 

    }
}
