using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="ItemSettingsProvider",menuName = "ScriptableObject/ItemSettingsProvider ")]
public class ItemSettingsProvider :ScriptableObject
{
 [SerializeField] private List<ItemSettings> _item = new List<ItemSettings>();

 public List<ItemSettings> GetItems()
 {
  return _item;
 }
}
