using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{

    // [SerializeField] private bool isCoin;

    //  [SerializeField] private bool isHealth;

    //[SerializeField] private bool isAmmo;

    enum ItemType { Coin, Health, Ammo}// dropdown

    [SerializeField] private ItemType itemType;

    NewPlayer newPlayer;

    // Start is called before the first frame update
    void Start()
    {
      
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ( collision.gameObject.name == "Player") 
        {

             newPlayer = GameObject.Find("Player").GetComponent<NewPlayer>();


            
           newPlayer .coinsCollected += 1;
           newPlayer.UpdateUI();


            Destroy(gameObject);

        }


    }
}
