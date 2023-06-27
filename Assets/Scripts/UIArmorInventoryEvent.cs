using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIArmorInventoryEvent : MonoBehaviour
{
    [SerializeField] private SearchForPressedButton _searchFourtButton;
    [SerializeField] private GameObject _gameObject;
    private void Start()
    {
        _searchFourtButton.FourthButtonEvent += IncludedAnimation;
    }

   
    private void IncludedAnimation()
    {
        _gameObject.SetActive(true);
       Debug.Log("lllo");
    }


    private void OnDestroy()
    {
        _searchFourtButton.FourthButtonEvent-= IncludedAnimation;

    }
}
