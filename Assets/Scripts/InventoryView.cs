using System;
using TMPro; 
using UnityEngine;
using UnityEngine.UI;

public class InventoryView : MonoBehaviour
{
   private ItemSettings itemSettings;
    [SerializeField] private TextMeshProUGUI _name;
    [SerializeField] private TextMeshProUGUI _description;
    [SerializeField] private Image _iconBack;
    [SerializeField] private Image _mainIcon;
    [SerializeField] private Image _resource;
//    [SerializeField] private TextMeshProUGUI _cost;

    public void UpdateItemCharacteristicsView(ItemSettings itemSettings)
    {
        _name.text = itemSettings.Name;
        _description.text = itemSettings.Description;
        _iconBack.sprite = itemSettings.Icon;
        _mainIcon.sprite = itemSettings.MainIcon;
        _resource.sprite = itemSettings.Resorce;
   //     _cost.text = itemSettings.Cost.ToString();
    }


}
