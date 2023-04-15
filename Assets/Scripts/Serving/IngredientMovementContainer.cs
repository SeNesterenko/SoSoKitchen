using UnityEngine;

namespace Serving
{
    public class IngredientMovementContainer : MonoBehaviour
    {
        public Ingredient Ingredient => _ingredient;

        [SerializeField]
        private Ingredient _ingredient;
    }
}

