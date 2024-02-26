
   using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Badge", menuName = "Data/Badge", order = 2)]
public class BadgeData : ScriptableObject
{
    public Sprite image;
    public Color bg_color;
    public Color ic_color;

}
