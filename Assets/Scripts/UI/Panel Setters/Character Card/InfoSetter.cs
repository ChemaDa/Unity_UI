using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoSetter : MonoBehaviour
{
    public SpecsSetter specs_Container;
    public  BadgeListSetter badges_Container;

    public void SetInfo(string[] text_specs_list, List<BadgeData> badges_list)
    {

        specs_Container.setSpecs(text_specs_list);
        badges_Container.setBadges(badges_list);

    }

}
