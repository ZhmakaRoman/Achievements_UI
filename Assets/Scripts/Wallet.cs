using System;
using System.Collections;
using TMPro;
using UnityEngine;

public class Wallet : MonoBehaviour
{

  [SerializeField] private TextMeshProUGUI _textScore;
  [SerializeField]private float _calculatingTime  = 0.5f;//время изменения счета на UI
  [SerializeField] private float _endScore;
  [SerializeField] private SearchForPressedButton _clickCoinsEvent;

  private float _currentScore; //текущий счет
  

  private void Start()
  {
   
    _clickCoinsEvent.FirstButtonEvent +=WorkCalculation;
  }

  public void WorkCalculation()
  {
    StartCoroutine(ShowMoneyCalculation());
  
  }

  private void OnDestroy()
  {
  
    _clickCoinsEvent.FirstButtonEvent -= WorkCalculation;

  }

  private IEnumerator ShowMoneyCalculation()
    {
      float currentTime = 0;// начальное значение для текущего времени
      var startScore = _currentScore;// начальное знчение для счета
      while (currentTime < _calculatingTime)
      {
        _currentScore = Mathf.Lerp(startScore, _endScore,currentTime / _calculatingTime);
          currentTime += Time.deltaTime;
        _textScore.text = _currentScore.ToString("0");
        yield return null;
      }

      _currentScore = _endScore;//текущему счету присвоить конечное значение
       _textScore.text = _currentScore.ToString("0");
    }
  
}

