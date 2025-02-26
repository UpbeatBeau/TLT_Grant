using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameScript : MonoBehaviour
{
    public TextMeshProUGUI end;
    public Canvas endtext;
    public Camera main;
    public GameObject player;
    public GameObject nxtbutton;

    public void YouLose()
    {
        endtext.enabled = true;
        end.text = "You Lost!";
        Camera.main.GetComponent<MouseController>().enabled = false;
        player.GetComponent<WaterGun>().enabled = false;
        player.GetComponent<Gunfollow>().enabled = false;
        Camera.main.transform.rotation = Quaternion.Euler(Vector3.zero);
        nxtbutton.SetActive(true);
    }

    public void YouWin()
    {
       
        endtext.enabled = true;
        end.text = "You Won!";
        Camera.main.GetComponent<MouseController>().enabled = false;
        player.GetComponent<WaterGun>().enabled = false;
        player.GetComponent<Gunfollow>().enabled = false;
        Camera.main.transform.rotation = Quaternion.Euler(Vector3.zero);
        nxtbutton.SetActive(true);
    }
}
