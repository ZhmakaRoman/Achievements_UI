using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WalletCrystals : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textScore;
    [SerializeField]private float _calculatingTime  = 0.5f;//время изменения счета на UI
    [SerializeField] private float _endScore;
    [SerializeField] private SearchForPressedButton _clickCrystalButtonEvent;

    private float _currentScore; //текущий счет
  

    private void Start()
    {
        _clickCrystalButtonEvent.SecondButtonEvent += WorkCalculation;
        
    }

    public void WorkCalculation()
    {
        StartCoroutine(ShowMoneyCalculation());
  
    }

    private void OnDestroy()
    {
       _clickCrystalButtonEvent.SecondButtonEvent -= WorkCalculation;
     

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
