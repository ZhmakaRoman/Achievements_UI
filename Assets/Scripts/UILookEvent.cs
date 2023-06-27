using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UILookEvent : MonoBehaviour
{
    [SerializeField] private SearchForPressedButton _searchThirdButton;
    [SerializeField] private GameObject _gameObject;
    private void Start()
    {
        _searchThirdButton.ThirdButtonEvent += IncludedAnimation;
    }

   
    private void IncludedAnimation()
    {
        _gameObject.SetActive(true);
       
    }


    private void OnDestroy()
    {
        _searchThirdButton.ThirdButtonEvent -= IncludedAnimation;

    }
}
