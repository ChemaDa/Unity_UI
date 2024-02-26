using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Card", menuName = "Data/Card", order = 1)]
public class CardData : ScriptableObject
    {
        [Header("Card Image")]
        public Sprite image;
        public Color color;

        [Header("Title")]
        public string Title;

        [Header("Information")]
        public string[] specs_List;

        [SerializeField]
        public List<BadgeData> badges_List;
      

}

