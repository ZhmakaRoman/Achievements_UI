using System;
using System.Collections;
using JetBrains.Annotations;
using UnityEngine;


public class Buttoncontroler : MonoBehaviour
{
   // //при нажатие на ккнопку оключаем ++++++
   // //при нажатие кнопи изменяем фон  +++++
   // //при нажатие кнопики должны перечислить 500 монет в счетчик +++++
   // // и зделать плавный посчет +++++
   // // при нажатие на кнопку долны вылетить монеты в сторону счетчика
    public Action OnButtonOffEvent;
    

   
    [UsedImplicitly]
    public void RunCoroutine()
    {
        StartCoroutine(LetGoy());
        
     
    }

    
    private IEnumerator LetGoy()
    {
        yield return new WaitForSeconds(0.1f);
        gameObject.SetActive(false);
        OnButtonOffEvent?.Invoke();
    }
}