using System;
using System.Collections;
using UnityEngine;

namespace Timer
{
    public class TimerController : MonoBehaviour
    {
        public delegate void FinishTimer();
        public event FinishTimer OnTimerFinished;
        
        [SerializeField]
        private TimerView _view;
        [SerializeField] 
        private float _stepTime = 0.05f;

        private float _waitTime, _passedTime;
        
        private Coroutine _currentCoroutine;
        private YieldInstruction _waitCoroutine;
        
        public void Initialize(float waitTime)
        {
            _waitTime = waitTime;
            _passedTime = 0;
            _waitCoroutine = new WaitForSeconds(_stepTime);
  
            
            _view.Display(0);
            _view.Show();
        }

        public void StopTimer()
        {
            StopCoroutine(_currentCoroutine);
        }

        private IEnumerator Wait()
        {
            
            while(_passedTime < _waitTime)
            {
                _passedTime += _stepTime;
                
                var ratio = _passedTime / _waitTime;
                if (ratio > 1)
                    ratio = 1;
                
                _view.Display(ratio);
                
                yield return _waitCoroutine;
            }

            _view.Hide();
            OnTimerFinished?.Invoke();
        }
        
        public void StartTimer()
        {
            _currentCoroutine = StartCoroutine(Wait());
        }
        
        
    }
}

