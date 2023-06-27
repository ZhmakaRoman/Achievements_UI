using System;
using UnityEngine;

public class SearchForPressedButton : MonoBehaviour
{
    public Action FirstButtonEvent;
    public Action SecondButtonEvent;
    public Action ThirdButtonEvent;
    public Action FourthButtonEvent;
    private GameObject[] _buttonObjecs;
    private GameObject  _buttonOne;
    private GameObject _buttonTwo;
    private GameObject _buttonThree;
    private GameObject _buttonfour;
    private bool _isButtonEnabled;
    
    private void Start()
    {
       SearchButton();
    }

    private void SearchButton()
    {
        _buttonObjecs = GameObject.FindGameObjectsWithTag("ButtonPanel");
    
        for (int i = 0; i < _buttonObjecs.Length; i++)
        {
            _buttonOne = _buttonObjecs[0];
            _buttonTwo = _buttonObjecs[1];
            _buttonThree = _buttonObjecs[2];
            _buttonfour = _buttonObjecs[3];
        }
    }
    

    private void Update()
    {
        CheckFirstButtonPress();
        CheckSecondButtonPress();
        CheckThirdButtonPress();
        CheckFourthButtonPress();
    }

   private void CheckFirstButtonPress()
   {
       if (_buttonOne.activeSelf)
       {
           return;
       }
       else if(!_isButtonEnabled)
       {
           FirstButtonEvent?.Invoke();
       } 
   }
    private void CheckSecondButtonPress()
    {
        if (_buttonTwo.activeSelf)
        {
            return;
        }
        else if(!_isButtonEnabled)
        {
            SecondButtonEvent?.Invoke();
        } 
    }
    private void CheckThirdButtonPress()
    {
        if (_buttonThree.activeSelf)
        {
            return;
        }
        else if(!_isButtonEnabled)
        {
            ThirdButtonEvent?.Invoke();
        } 
    }
    private void CheckFourthButtonPress()
    {
        if (_buttonfour.activeSelf)
        {
            return;
        }
        else if(!_isButtonEnabled)
        {
            FourthButtonEvent?.Invoke();
        } 
    }
}
