using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewPlayer : PhysicsObject
{


    [SerializeField] private float maxSpeed = 1;
    [SerializeField] private float jumpPower = 10;

    public int coinsCollected;
    public Text coinsText;
    public Image healthBar;
    [SerializeField] private Vector2 healthBarOrigSize;

    // Start is called before the first frame update
    void Start()
    {
        healthBarOrigSize = healthBar.rectTransform.sizeDelta;
    }

    // Update is called once per frame
    void Update()
    {
        targetVelocity = new Vector2(Input.GetAxis("Horizontal")* maxSpeed,0);

        if (Input.GetButtonDown("Jump") && grounded)
        {
            velocity.y = jumpPower;
        }
        
    }

    public void UpdateUI()
    {
        coinsText.text = coinsCollected.ToString();

        healthBar.rectTransform.sizeDelta = new Vector2(100, healthBar.rectTransform.sizeDelta.y);
    }
}
