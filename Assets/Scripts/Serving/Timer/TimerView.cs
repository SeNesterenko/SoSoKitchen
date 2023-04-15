using UnityEngine;
using UnityEngine.UI;

namespace Timer
{
    public class TimerView : MonoBehaviour
    {
        [SerializeField]
        private Image _image;

        public void Show()
        {
            _image.enabled = true;
        }

        public void Hide()
        {
            _image.enabled = false;
        }
        
        public void Display(float ratio)
        {
            _image.fillAmount = ratio;
        }
    } 
}

