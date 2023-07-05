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
    public GameObject pickLocationPanel;
    public GameObject dropDownPanel;

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

    private void locationUnselectedButton() 
    {
        falseAll();
        locationSelectedGO.SetActive(true);
        pickLocationPanel.SetActive(true);
    }

    private void locationSelectedButton()
    {
        falseAll();
    }

    private void coffeeUnselectedButton()
    {
        falseAll();
        coffeeSelectedGO.SetActive(true);
    }

    private void coffeeSelectedButton()
    {
        falseAll();
    }

    private void medalUnselectedButton()
    {
        falseAll();
        medalSelectedGO.SetActive(true);
    }
    private void medalSelectedButton()
    {
        falseAll();
    }

    private void peopleUnselectedButton()
    {
        falseAll();
        peopleSelectedGO.SetActive(true);
    }
    private void peopleSelectedButton()
    {
        falseAll();
    }

    private void settingsUnselectedButton()
    {
        falseAll();
        settingsSelectedGO.SetActive(true);
    }
    private void settingsSelectedButton()
    {
        falseAll();
    }

    private void falseAll()
    {
        pickLocationPanel.SetActive(false);
        dropDownPanel.SetActive(false);

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
