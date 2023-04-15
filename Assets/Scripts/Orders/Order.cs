using System;
using Serving;
using UnityEngine;

namespace Orders
{
    [Serializable]
    public class Order
    {
        public string Name => _name;
        public int Cost => _cost;
        public Ingredient[] Ingredients => _ingredients;

        [SerializeField] private string _name;
        [SerializeField] private int _cost;
        [SerializeField] private Ingredient[] _ingredients;
    }
}