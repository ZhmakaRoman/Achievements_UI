using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Reward : MonoBehaviour
{
    [SerializeField] private Transform _endPosition;
    [SerializeField] private float _speedReward = 0.6f;
   [SerializeField] private SearchReward _startPosition; 
    [SerializeField] private SearchForPressedButton _coinsEvent;
    private float _currentTime;

  private void Start()
  {
      _coinsEvent.FirstButtonEvent += StartMoved;
  }

  private void OnDestroy()
  {
      _coinsEvent.FirstButtonEvent -= StartMoved;
  }


  public void StartMoved()
    {
        
        StartCoroutine(MoveToTarget());
    }

    
    private IEnumerator MoveToTarget()
     {
      
       
         var time = 1f;
         var currentTime = 0f;
         while (currentTime < time)
         {
           _currentTime += Time.deltaTime;
             
           var newPosition=  Vector3.Lerp(_startPosition.StartPositionOneReward, _endPosition.position, _currentTime / _speedReward);
           transform.position = newPosition;  
           if (transform.position == _endPosition.position)
           {
               Destroy(gameObject);

               yield break; 
           }

           yield return null;
           
       
         }
      
     }
   
}
