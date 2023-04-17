using Orders;
using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "OrderConfig", menuName = "OrderConfig")]
    public class OrderConfig : ScriptableObject
    {
        public Order[] Orders => _orders;
        
        [SerializeField] private Order[] _orders;
    }
}