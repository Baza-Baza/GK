using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FinishPoint : MonoBehaviour
{
    public GameObject Panel;
    public GameObject Player;




     void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            Player.GetComponent<moveSphere>().enabled = false;
            Player.SetActive(false);
            Panel.SetActive(true);
        }

    }


}
