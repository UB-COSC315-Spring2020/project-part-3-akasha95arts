using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    [System.Serializable]
    public class PlayerStats // Class for player stats 
    {
        public int Health = 100;
    }


    public PlayerStats playerStats = new PlayerStats(); //created instance of class

    public int fallBoundary = -20;

    private void Update()
    {
        if (transform.position.y <= -20)
        DamagePlayer(999999);

        
    }

    public void DamagePlayer(int damage)
    {
        playerStats.Health -= damage;
        if (playerStats.Health <= 0)
        {
            GameMaster.KillPlayer(this);
        }
    }



}
