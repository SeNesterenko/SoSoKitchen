using System;
using Timer;
using UnityEngine;

namespace Serving.Handlers
{
    //TO DO
    //подумать на монобехом
    [RequireComponent(typeof(TimerController))]
    public class PanHandler : MonoBehaviour, IIngredientHandler
    {
        public bool IsCooking = false;
        
        private TimerController _timerController;
        private Ingredient _ingredient;
        
        private void Awake()
        {
            _timerController = GetComponent<TimerController>();
            _timerController.OnTimerFinished += () => { IsCooking = false;};
        }

        public Ingredient GetIngredient()
        {
            //если таймер не закончился
            if(IsCooking)
                return null;

            return _ingredient;
        }

        public void Initialize(Ingredient ingredient)
        {
            _ingredient = ingredient;
            // TO DO
            // начать жарить продукт
            _timerController.Initialize(ingredient.CookingTime);
            _timerController.StartTimer();
            IsCooking = true;
        }
    }
}


