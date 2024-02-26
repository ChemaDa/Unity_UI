using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Cards_List", menuName = "Data/Card's List", order = 3)]
public class CardsList : ScriptableObject
{
    public List<CardData> cardsList = new List<CardData>(); 
}
