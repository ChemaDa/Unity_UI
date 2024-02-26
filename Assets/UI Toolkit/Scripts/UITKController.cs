using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UIElements;

public class UITKController : MonoBehaviour
{

    public CardsList charactersDataList;

   public VisualTreeAsset CharacterCard_Template;
   public VisualTreeAsset Badge_Template;
   VisualElement CharactersList_Holder;

   public UIDocument CharactersListScreen;

   private void Start()
   {
       SetCardsList(); 
   }

   void SetCardsList()
    { 
        CharactersList_Holder= CharactersListScreen.rootVisualElement.Q<VisualElement>(className: "CharactersList").contentContainer;
        List<VisualElement>  instanciatedItems = CharactersList_Holder.Query<VisualElement>(className: "CharacterCard").ToList();

        if (CharactersList_Holder != null && CharacterCard_Template != null && instanciatedItems != null)
        {

            int maxCounter = Mathf.Max(instanciatedItems.Count, charactersDataList.cardsList.Count);


            for (int i = 0; i < maxCounter; i++)
            {
                if (i >= charactersDataList.cardsList.Count)
                {
                    instanciatedItems[i].visible = false; 
                }
                else
                {
                    if (i < instanciatedItems.Count)
                    {
                        instanciatedItems[i].visible = true;
                    }
                    else
                    {
                        CharacterCard_Template.CloneTree(CharactersList_Holder);

                    }

                    FillCard(i); 

                }
           
               
                
            }

        }
    }
 
     void FillCard(int index)
    { 
        VisualElement cardVE =  CharactersList_Holder.Query<VisualElement>(className: "CharacterCard").AtIndex(index);
        CardData cardData = charactersDataList.cardsList[index]; 
            
        VisualElement characterPicture = cardVE.Q<VisualElement>(name:"CharacterPicture");
        VisualElement characterName= cardVE.Q<VisualElement>(name:"CharacterName");
        VisualElement characterInformation= cardVE.Q<VisualElement>(name:"CharacterInformation");
    
       SetImage(characterPicture, cardData.image, cardData.color);

       SetTitle(characterName, cardData.Title);

       SetInfo(characterInformation, cardData.specs_List, cardData.badges_List); 

    }

     void SetSpecs(VisualElement VE, string[] text_specs_list)
    {
        List<Label> instanciatedTextList = VE.Query<Label>().ToList();
       
        if (VE != null && text_specs_list != null)
        {

            int maxCounter = Mathf.Max(instanciatedTextList.Count, text_specs_list.Length); 


            for (int i=0; i< maxCounter; i++)
            {
                if (i >= text_specs_list.Length)
                {
                    instanciatedTextList[i].visible=false;
                }
                else
                {
                    if (i < instanciatedTextList.Count)
                    {
                        instanciatedTextList[i].visible = true;
                        instanciatedTextList[i].text = text_specs_list[i]; 
                    }
                    else
                    {
                        VE.Add(new Label(text_specs_list[i]));
                    }
                }

            }
        
        }


    }
    
     void SetTitle (VisualElement VE,string title)
    {
        VE.Q<Label>(name: "Name_Text").text = title;
    }

     void SetInfo(VisualElement VE, string[] text_specs_list, List<BadgeData> badges_list)
    {

        VisualElement specs_Container= VE.Q("SpecsContainer").contentContainer;
        VisualElement badges_Container= VE.Q("BadgesContainer").contentContainer;;
        SetSpecs(specs_Container, text_specs_list);
        SetBadges(badges_Container, badges_list);

    }
    
    void SetImage (VisualElement VE, Sprite card_Sprite, Color background_color){
     
        if(VE!= null)
        {
            VE.Q<VisualElement>(name: "Picture_Image").style.backgroundImage = new StyleBackground(card_Sprite);
            VE.Q<VisualElement>(name: "Picture_Background").style.backgroundColor= background_color; 
        }
    
    
    }

     void SetBadges(VisualElement VE, List<BadgeData> badges_list)
    {
        List<VisualElement> instanciatedBadgeList = VE.Query<VisualElement>(className: "Badge_Container").ToList(); 
       
        if (VE != null && Badge_Template != null && badges_list != null)
        {

            int maxCounter = Mathf.Max(instanciatedBadgeList.Count, badges_list.Count);


            for (int i = 0; i < maxCounter; i++)
            {
                if (i >= badges_list.Count)
                {
                    instanciatedBadgeList[i].visible=false;
                }
                else
                {
                    if ((i < instanciatedBadgeList.Count))
                    {
                        instanciatedBadgeList[i].visible = true;
                    }
                    else 
                    {
                        Badge_Template.CloneTree(VE);
                    }
                    instanciatedBadgeList = VE.Query<VisualElement>(className: "Badge_Container").ToList(); 

                    SetBadge(instanciatedBadgeList[i], badges_list[i].image, badges_list[i].bg_color,
                        badges_list[i].ic_color);
                }
            }

        }


    }
   

    void SetBadge(VisualElement VE, Sprite badge_Sprite, Color background_color, Color icon_color)
    { 
        VisualElement background_Image= VE.Q<VisualElement>(className:"Badge_Container");
        VisualElement badge_Image= background_Image.Q<VisualElement>("Badge_Icon");
        if (badge_Image != null)
        {
            badge_Image.style.backgroundImage = new StyleBackground( badge_Sprite);
            badge_Image.style.color = icon_color;
            background_Image.style.color = background_color;
            
        }
    }

}
