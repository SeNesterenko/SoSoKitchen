using System;
using UnityEngine;

namespace Clients
{
    public interface ISpawner<T> where T: MonoBehaviour
    {
        public T Spawn();
        public void Release(T item);
    }
}

