using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [Header("Buttons")]
    public Button dropDownUnselected;
    public Button dropDownSelected;

    public Button locationUnselected;
    public Button locationSelected;

    public Button coffeeUnselected;
    public Button coffeeSelected;

    public Button medalUnselected;
    public Button medalSelected;

    public Button peopleUnselected;
    public Button peopleSelected;

    public Button settingsUnselected;
    public Button settingsSelected;

    public Button quitButton;

    [Header("ButtonsGameObjects")]
    public GameObject dropDownUnselectedGO;
    public GameObject dropDownSelectedGO;

    public GameObject locationUnselectedGO;
    public GameObject locationSelectedGO;

    public GameObject coffeeUnselectedGO;
    public GameObject coffeeSelectedGO;

    public GameObject medalUnselectedGO;
    public GameObject medalSelectedGO;

    public GameObject peopleUnselectedGO;
    public GameObject peopleSelectedGO;

    public GameObject settingsUnselectedGO;
    public GameObject settingsSelectedGO;

    [Header("Panels")]
    public GameObject dropDownPanel;

    public GameObject pickLocationPanel;
    public GameObject pickLocation2Panel;

    public GameObject interest1Panel;
    public GameObject interest2Panel;

    public GameObject medal1Panel;
    public GameObject medal2Panel;

    public GameObject people1Panel;
    public GameObject people2Panel;

    public GameObject settings1Panel;
    public GameObject settings2Panel;

    [Header("LocationBanner")]
    public GameObject locationBanner;
    public GameObject glynnVivianArtGalleryText;
    public GameObject plantasiaTropicalZooText;
    public GameObject swanseaArenaText;
    public GameObject swanseaGrandTheatreText;
    public GameObject swanseaMuseumText;

    void OnEnable()
    {
        //Register Button Events
        dropDownUnselected.onClick.AddListener(() => dropDownUnselectedButton());
        dropDownSelected.onClick.AddListener(() => dropDownSelectedButton());
        locationUnselected.onClick.AddListener(() => locationUnselectedButton());
        locationSelected.onClick.AddListener(() => locationSelectedButton());
        coffeeUnselected.onClick.AddListener(() => coffeeUnselectedButton());
        coffeeSelected.onClick.AddListener(() => coffeeSelectedButton());
        medalUnselected.onClick.AddListener(() => medalUnselectedButton());
        medalSelected.onClick.AddListener(() => medalSelectedButton());
        peopleUnselected.onClick.AddListener(() => peopleUnselectedButton());
        peopleSelected.onClick.AddListener(() => peopleSelectedButton());
        settingsUnselected.onClick.AddListener(() => settingsUnselectedButton());
        settingsSelected.onClick.AddListener(() => settingsSelectedButton());
        quitButton.onClick.AddListener(() => Quit());

    }

    private void dropDownUnselectedButton()
    {
        falseAll(); 
        dropDownSelectedGO.SetActive(true);
        dropDownPanel.SetActive(true);
    }

    private void dropDownSelectedButton()
    {
        falseAll();
    }

    public void locationUnselectedButton() 
    {
        falseAll();
        locationSelectedGO.SetActive(true);
        pickLocationPanel.SetActive(true);
    }

    private void locationSelectedButton()
    {
        falseAll();
    }

    public void coffeeUnselectedButton()
    {
        falseAll();
        coffeeSelectedGO.SetActive(true);
        interest1Panel.SetActive(true);
    }

    private void coffeeSelectedButton()
    {
        falseAll();
    }

    public void medalUnselectedButton()
    {
        falseAll();
        medalSelectedGO.SetActive(true); 
        medal1Panel.SetActive(true);
    }
    private void medalSelectedButton()
    {
        falseAll();
    }

    public void peopleUnselectedButton()
    {
        falseAll();
        peopleSelectedGO.SetActive(true);
        people1Panel.SetActive(true);
    }
    private void peopleSelectedButton()
    {
        falseAll();
    }

    public void settingsUnselectedButton()
    {
        falseAll();
        settingsSelectedGO.SetActive(true);
        settings1Panel.SetActive(true);
    }
    private void settingsSelectedButton()
    {
        falseAll();
    }

    public void Quit()
    {
        Application.Quit();
    }
    
    public void clearLocationBanner()
    {
        locationBanner.SetActive(false);
        glynnVivianArtGalleryText.SetActive(false);
        plantasiaTropicalZooText.SetActive(false);
        swanseaArenaText.SetActive(false);
        swanseaGrandTheatreText.SetActive(false);
        swanseaMuseumText.SetActive(false);
    }
    public void falseAll()
    {
        dropDownPanel.SetActive(false);
        
        pickLocationPanel.SetActive(false);
        pickLocation2Panel.SetActive(false);

        interest1Panel.SetActive(false);
        interest2Panel.SetActive(false);

        medal1Panel.SetActive(false);
        medal2Panel.SetActive(false);

        people1Panel.SetActive(false);
        people2Panel.SetActive(false);

        settings1Panel.SetActive(false);
        settings2Panel.SetActive(false);

        dropDownSelectedGO.SetActive(false);
        locationSelectedGO.SetActive(false);
        coffeeSelectedGO.SetActive(false);
        medalSelectedGO.SetActive(false);
        peopleSelectedGO.SetActive(false);
        settingsSelectedGO.SetActive(false);

        dropDownUnselectedGO.SetActive(true);
        locationUnselectedGO.SetActive(true);
        coffeeUnselectedGO.SetActive(true);
        medalUnselectedGO.SetActive(true);
        peopleUnselectedGO.SetActive(true);
        settingsUnselectedGO.SetActive(true);
    }
}
