using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactersListSetter : MonoBehaviour
{
    public CardsList charactersDataList;
    List<CardSetter> instanciated_Items = new List<CardSetter>();

    public CardSetter prefab_PlayerCard;
    public Transform parent_Container;

    private void Start()
    {
        SetCardsList(); 
    }
    public void SetCardsList()
    {
        List<CardData> charactersCard_list = new List<CardData>();
        charactersCard_list = charactersDataList.cardsList; 
    

        if (instanciated_Items == null)
        {
            instanciated_Items = new List<CardSetter>();
        }
        if (parent_Container != null && prefab_PlayerCard != null && instanciated_Items != null)
        {

            int maxCounter = Mathf.Max(instanciated_Items.Count, charactersCard_list.Count);


            for (int i = 0; i < maxCounter; i++)
            {

                if ((i < instanciated_Items.Count) && (i < charactersCard_list.Count))
                {   instanciated_Items[i].gameObject.SetActive(true);
                        instanciated_Items[i].FillCard(charactersCard_list[i]);
                  

                    
                }
                else if (i < charactersCard_list.Count)
                {
                    CardSetter instanciatedPrefab = Instantiate(prefab_PlayerCard, parent_Container) as  CardSetter;
                    instanciated_Items.Add(instanciatedPrefab);
                    instanciated_Items[i].FillCard(charactersCard_list[i]);

                }
                else
                {
                    instanciated_Items[i].gameObject.SetActive(false);
                }
            }

        }


    
}
}
