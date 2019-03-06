using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasStation : MonoBehaviour
{

    bool hasPlayerCar = false;
    public float FillRate = 2;

    float elapsedTime;
    public float fuelTimer = 5;

    PlayerData data;
    
	void Start ()
    {
		
	}


    void Update()
    {
        if (hasPlayerCar)
        {
            elapsedTime += Time.deltaTime;
            if (elapsedTime >= fuelTimer)
            {
                if (data.Fuel < 100)
                {
                    data.Fuel += FillRate;
                    if (data.Fuel > 100.00f)
                        data.Fuel = 100.00f;
                }
                elapsedTime = 0;
            }
            else if (data.Fuel > 100.00f)
            {
                data.Fuel = 100.00f;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
     if(collision.gameObject.tag == "Player")
        {
            hasPlayerCar = true;
            data = collision.gameObject.GetComponent<PlayerData>();
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            hasPlayerCar = false;
            elapsedTime = 0;
            data = null;
        }
    }

}
