
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemSelectionButton : MonoBehaviour
{
 [SerializeField] private Image _iconBack;
 [SerializeField] private Image _mainIcon;
 [SerializeField] private Image _resource;
 [SerializeField] private  TextMeshProUGUI _name;
 [SerializeField] private TextMeshProUGUI _description;
// [SerializeField] private TextMeshProUGUI _cost;

 
 private ItemSettings _itemSettings; 
 
    public void Initialize(ItemSettings itemSettings)
    {
        _itemSettings = itemSettings;
        _iconBack.sprite = itemSettings.Icon;
        _mainIcon.sprite = itemSettings.MainIcon;
        _resource.sprite = itemSettings.Resorce;
        _name.text = itemSettings.Name;
        _description.text = itemSettings.Description;
     //   _cost.text = itemSettings.Cost.ToString();
    }
}
