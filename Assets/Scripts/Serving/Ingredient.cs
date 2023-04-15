using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Serving
{
    [Serializable]
    public class Ingredient
    {
        public Image Image => _image;
        public string Name => _name;
        public float CookingTime => _cookingTime;
       // public List<KitchenUtencil> KitchenUtencils => _kitchenUtencils;
        
        [SerializeField] private Image _image;
        [SerializeField] private string _name;
        [SerializeField] private float _cookingTime;
        //[SerializeField] private List<KitchenUtencil> _kitchenUtencils = new List<KitchenUtencil>();
    }
}

