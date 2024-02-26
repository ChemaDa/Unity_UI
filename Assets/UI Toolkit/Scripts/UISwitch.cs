
    using System;
    using UnityEngine.UIElements;
    using UnityEngine; 
    using UnityEngine.Serialization; 
    using UnityEditor; 
    public enum UIStyle{
    DefaultStyle, 
    FantasyStyle, 
    LandscapeStyle
    }
    public class UISwitch : MonoBehaviour
    {

        [SerializeField] private StyleSheet _defaultStyle; 
        [SerializeField] private StyleSheet _fantasyStyle; 
        [SerializeField] private StyleSheet _landscapeStyle;
        [SerializeField] private UIDocument _uiDocument;

        private void Start()
        {
            SetButtons(); 
        }

        private void SetButtons()
        {
            VisualElement VE = _uiDocument.rootVisualElement.Q<VisualElement>("ButtonsContainer");
               VE.Q<Button>("Default").clicked+=(()=>ButtonSwitchClicked(UIStyle.DefaultStyle)) ; 
               VE.Q<Button>("Fantasy").clicked+=(()=>ButtonSwitchClicked(UIStyle.FantasyStyle)) ; 
               VE.Q<Button>("Landscape").clicked+=(()=>ButtonSwitchClicked(UIStyle.LandscapeStyle)) ; 

        }
        public void ButtonSwitchClicked(UIStyle styleType)
        {
            switch (styleType)
            {
                  case  UIStyle.DefaultStyle:
                      SwitchUIStyle(_defaultStyle); 
                      _uiDocument.rootVisualElement.Q<ScrollView>("CharactersList").mode= ScrollViewMode.Horizontal; 

                      break;
                  case  UIStyle.FantasyStyle: 
                      SwitchUIStyle(_fantasyStyle); 
                      _uiDocument.rootVisualElement.Q<ScrollView>("CharactersList").mode= ScrollViewMode.Horizontal; 

                      break;
                  case  UIStyle.LandscapeStyle: 
                      SwitchUIStyle(_landscapeStyle);
                      _uiDocument.rootVisualElement.Q<ScrollView>("CharactersList").mode= ScrollViewMode.Vertical; 
                      break;
            }
        }
        void SwitchUIStyle(StyleSheet newStyle)
        {
            _uiDocument.rootVisualElement.styleSheets.Clear();
            _uiDocument.rootVisualElement.styleSheets.Add(newStyle);
        }
    }
