using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;


public class playFootsteps : MonoBehaviour
{
    public AudioSource footsteps;
    public GameObject player;

    private void Start()
    {
        player = GameObject.Find("Locomotion");
    }




}
