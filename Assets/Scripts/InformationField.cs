using System;
using UnityEngine;
using UnityEngine.UI;

public class InformationField : MonoBehaviour
{
    [SerializeField] private Buttoncontroler _buttonEvent;
    public Action Onclick;
   
     private Image _image;
     
   private void Start()
   {
       _image = GetComponent<Image>();
       _buttonEvent.OnButtonOffEvent += HideImage;
   }

    private void HideImage()
    {
       _image.color = Color.blue; 
       Onclick?.Invoke();
    }

    private void OnDestroy()
    {
        _buttonEvent.OnButtonOffEvent -= HideImage;
    }
}