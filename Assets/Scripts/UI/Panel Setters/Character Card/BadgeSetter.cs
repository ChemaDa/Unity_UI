using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BadgeSetter : MonoBehaviour
{
    public Image background_Image;
    public Image badge_Image;

    public virtual void SetBadge(Sprite badge_Sprite, Color background_color, Color icon_color)
    {
        if (badge_Image != null)
        {
            badge_Image.sprite = badge_Sprite;
            badge_Image.color = icon_color;

            background_Image.color = background_color;
        }
    }
}
