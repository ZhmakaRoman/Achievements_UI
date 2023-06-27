using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "ItemSettings",menuName = "ScriptableObject/ItemSettings",order = 50)]
public class ItemSettings : ScriptableObject
{
  
   public string  Name => _actionName;
   public string Description =>_description;
   public Sprite Icon => _iconBack;
   public Sprite MainIcon => _mainIcon;
   public Sprite Resorce => _resource;
//   public int Cost => _cost;
   
   
   [SerializeField]
   private string _actionName;
   [SerializeField]
   private string _description;
   [SerializeField]
   private Sprite _iconBack;
   [SerializeField]
   private Sprite _mainIcon;
   [SerializeField]
   private Sprite _resource;
  // [SerializeField]
  // private int _cost;
  
   
}
