using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSelectionButtons : MonoBehaviour
{
   [SerializeField] private ItemSettingsProvider _itemSettingsProvider;
   [SerializeField] private ItemSelectionButton _itemPrefab;
   [SerializeField] private RectTransform _buttonRoot;
       
   
   private void Awake()
   {
      var items = _itemSettingsProvider.GetItems();
      foreach (var itemSettings in items)
      {
       
         var itemButten = Instantiate(_itemPrefab, _buttonRoot);
         itemButten.Initialize(itemSettings);
      }
   }

  
   
}
