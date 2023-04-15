using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;
using Random = UnityEngine.Random;

namespace Clients
{
    public class ClientsSpawner : MonoBehaviour, ISpawner<Client>
    {
        private IObjectPool<Client> _pool;
        [SerializeField]
        private int _maxPoolSize = 4;
        [SerializeField]
        private List<Client> _clientPrefabs = new List<Client>();

        [SerializeField]
        private Transform _parent;
        
        private void Awake()
        {
            _pool = new ObjectPool<Client>(
                () => CreateClient(),
                actionOnGet: (client) => OnGet(client),
                actionOnRelease: (client) => OnRelease(client),
                actionOnDestroy: (client) => OnClientDestroy(client),
                collectionCheck: false,
                maxSize: _maxPoolSize
            
            );
        }

        public Client Spawn()
        {
            return _pool.Get();
        }

        public void Release(Client client)
        {
            _pool.Release(client);
        }
        
        private Client CreateClient()
        {
            var id = Random.Range(0, _clientPrefabs.Count);
            var client = Instantiate(_clientPrefabs[id], _parent.position, Quaternion.identity, _parent);
            
            return client;
        }

        private Client OnGet(Client client)
        {
            client.gameObject.SetActive(true);
            //client.initialize();
            return client;
        }

        private void OnRelease(Client client)
        {
            client.gameObject.SetActive(false);
        }

        private void OnClientDestroy(Client client)
        {
            Destroy(client.gameObject);
        }


        private  void OnDestroy()
        {
            _pool.Clear();
            _clientPrefabs.Clear();
        }
        
    }
}

