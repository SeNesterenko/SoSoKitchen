using Orders;
using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "OrderConfig", menuName = "OrderConfig")]
    public class OrderConfig : ScriptableObject
    {
        public Order[] Order => _order;
        
        [SerializeField] private Order[] _order;
    }
}