using UnityEngine;

namespace Serving
{
    public class IngredientContainer : MonoBehaviour
    {
        public Ingredient Ingredient => _ingredientPrefab;
    
        [SerializeField]
        private Ingredient _ingredientPrefab;
    }
}

