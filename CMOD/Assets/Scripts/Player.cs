using UnityEngine;
using System.Collections;
using System;

public class Player : MonoBehaviour {

    //public Health var
    private int iHealth = 100;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public int Health
    {
        get { return iHealth; }

        set
        {
            iHealth = value;

            if(iHealth <= 0)
            {
                Die();
            }

            //GameManager.OnPlayerHealthChange();
        }
    }

    public void Die()
    {
        //TODO death code
    }
}
