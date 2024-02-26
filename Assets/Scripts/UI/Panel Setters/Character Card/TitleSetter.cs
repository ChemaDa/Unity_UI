using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; 

public class TitleSetter : MonoBehaviour
{
    public TextMeshProUGUI  text_Title; 
    public void setTitle (string title)
    {

        text_Title.text = title; 

    }
}
