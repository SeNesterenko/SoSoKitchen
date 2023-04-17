using System;
using UnityEngine;

namespace Serving
{
    [CreateAssetMenu(fileName = "Ingredient", menuName = "Ingredient")]
    public class Ingredient: ScriptableObject
    {
        public Sprite Sprite => _sprite;
        public string Name => _name;
        public float CookingTime => _cookingTime;
       // public List<KitchenUtencil> KitchenUtencils => _kitchenUtencils;
        
        [SerializeField] private Sprite _sprite;
        [SerializeField] private string _name;
        [SerializeField] private float _cookingTime;
        //[SerializeField] private List<KitchenUtencil> _kitchenUtencils = new List<KitchenUtencil>();
    }
}

