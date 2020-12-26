using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainManager : MonoBehaviour
{
    private GameManager _gameManager;
    public bool isRain;

    // Start is called before the first frame update
    void Start()
    {
        _gameManager = FindObjectOfType(typeof(GameManager)) as GameManager;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            _gameManager.onOfRain(isRain);
        }
    }
}
