using Clients;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    //плохое решение
    [SerializeField]
    private Transform _spawnerTransform;
    private ISpawner<Client> _clientsSpawner;

    private int _clientsSize = 4;
    
    private void Start()
    {
        _clientsSpawner = _spawnerTransform.GetComponent<ISpawner<Client>>();
        //for(int i = 0; i < _clientsSize; i++)
        //    _clientsSpawner.Spawn<Client>();
    }
}
