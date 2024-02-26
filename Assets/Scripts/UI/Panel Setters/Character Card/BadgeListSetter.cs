using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadgeListSetter : MonoBehaviour
{
    public BadgeSetter prefab_Badge;
    public Transform parent_Container;

    List<BadgeSetter> instanciated_Badge_list = new List<BadgeSetter>();

    public void setBadges(List<BadgeData> badges_list)
    {
        if (instanciated_Badge_list == null)
        {
            instanciated_Badge_list = new List<BadgeSetter>();
        }
        if (parent_Container != null && prefab_Badge != null && badges_list != null)
        {

            int maxCounter = Mathf.Max(instanciated_Badge_list.Count, badges_list.Count);


            for (int i = 0; i < maxCounter; i++)
            {

                if ((i < instanciated_Badge_list.Count) && (i < badges_list.Count))
                {
                    instanciated_Badge_list[i].gameObject.SetActive(true);

                    instanciated_Badge_list[i].SetBadge(badges_list[i].image, badges_list[i].bg_color, badges_list[i].ic_color);
                   
                   

                } else if (i < badges_list.Count)
                    {
                        BadgeSetter instanciated_Prefab = Instantiate(prefab_Badge, parent_Container) as BadgeSetter;
                        instanciated_Badge_list.Add(instanciated_Prefab);

                        instanciated_Badge_list[i].SetBadge(badges_list[i].image, badges_list[i].bg_color, badges_list[i].ic_color);

                    }
                    
                else
                {
                    instanciated_Badge_list[i].gameObject.SetActive(false);
                }
            }

        }


    }


}
