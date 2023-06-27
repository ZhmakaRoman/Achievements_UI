using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchReward : MonoBehaviour
{
    public Vector3 StartPositionOneReward => _buttonOne.transform.position;
    public Vector3 StartPositionTwoReward => _buttonTwo.transform.position;
    private GameObject[] _buttonReward;
    private GameObject  _buttonOne;
    private GameObject _buttonTwo;

   
    // public Vector3 position;

    private void Start()
    {
        SearchAward();
    }

    private void SearchAward()
    {
        _buttonReward = GameObject.FindGameObjectsWithTag("Reward");
    
        for (int i = 0; i < _buttonReward.Length; i++)
        {
            _buttonOne = _buttonReward[0];
            _buttonTwo = _buttonReward[1];
        }
    }
}
