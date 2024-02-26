using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; 
public class SpecsSetter : MonoBehaviour
{
    public TextMeshProUGUI prefab_text_specs;
    public Transform parent_Container;

    List<TextMeshProUGUI> instanciated_text_list = new List<TextMeshProUGUI>(); 

    public void setSpecs( string[] text_specs_list)
    {
        if (instanciated_text_list == null)
        {
            instanciated_text_list = new List<TextMeshProUGUI>(); 
        }
        if (parent_Container != null && prefab_text_specs != null && text_specs_list != null)
        {

            int maxCounter = Mathf.Max(instanciated_text_list.Count, text_specs_list.Length); 


            for (int i=0; i< maxCounter; i++)
            {

                if ((i < instanciated_text_list.Count) && (i < text_specs_list.Length))
                {
                    instanciated_text_list[i].gameObject.SetActive(true);
                    instanciated_text_list[i].text = text_specs_list[i];


                }
                else if (i < text_specs_list.Length)
                {
                    TextMeshProUGUI instanciatedPrefab = Instantiate(prefab_text_specs, parent_Container) as TextMeshProUGUI;
                    instanciated_text_list.Add(instanciatedPrefab);
                    instanciated_text_list[i].text = text_specs_list[i];

                }
                else
                {
                    instanciated_text_list[i].gameObject.SetActive(false);
                }
            }
        
        }


    }
}
