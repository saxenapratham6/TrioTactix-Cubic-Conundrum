using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class GameManager : NetworkBehaviour
{
    public bool xTurn;

    public List<PlayerScript> playerList;

    private int rand;

    public bool gameEnded;

    [SerializeField] private GameObject gameOverText;

    [SerializeField] public List<LargerGameScript> largerGames;
    
    // Start is called before the first frame update
    void Start()
    {
        NetworkManager.Singleton.OnClientConnectedCallback += OnClientConnected;

        rand = Random.Range(0,1);

        xTurn = true;
    }

    private void Awake()
    {
        gameEnded = false;

        foreach(Transform child in transform)
        {
            largerGames.Add(child.GetComponent<LargerGameScript>());
        }

        int rand = Random.Range(0, 8);
        foreach (LargerGameScript zone in largerGames)
        {
            if(largerGames.IndexOf(zone) == rand)
            {
                zone.isActive = true;
            }
            
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        if(gameEnded)
        {
            GameEndServerRpc();
        }
        
    }

    public void SetZoneActive(string zoneName)
    {
        foreach(LargerGameScript zone in largerGames)
        {
            if(zone.name == zoneName)
            {
                zone.isActive = true;
            }
            else
            {
                zone.isActive = false;
            }
        }
    }

    
    

    
    private void OnClientConnected(ulong clientId)
    {
        if(IsServer)
        {
            Debug.Log($"Client {clientId} connected!");

            NetworkObject clientNetworkObject = NetworkManager.Singleton.ConnectedClients[clientId].PlayerObject;
            GameObject clientGameObject = clientNetworkObject.gameObject;

            if (((int)clientId) == rand)
            {
                clientGameObject.GetComponent<PlayerScript>().isX = true;


            }
            else
            {
                clientGameObject.GetComponent<PlayerScript>().isO = true;


            }
        }

       

        

      
    }


    [ServerRpc]
    private void GameEndServerRpc()
    {
        gameOverText.SetActive(true);
    }

    






}
