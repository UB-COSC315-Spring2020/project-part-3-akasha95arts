using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{

    public static GameMaster gm;

     void Start()
    {
        if(gm == null)
        {
            gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        }
    }

    public Transform PlayerPrefab;
    public Transform spawnPoint;

    public void RespawnPlayer()
    {
        Instantiate(PlayerPrefab, spawnPoint.position, spawnPoint.rotation);
    }



    public static void KillPlayer(PlayerScript player )
    {
        Destroy(player.gameObject);
        gm.RespawnPlayer();
    }




}
