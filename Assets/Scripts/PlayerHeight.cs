using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHeight : MonoBehaviour
{

    public Transform player;
    private Text scoreTxt;

    // Start is called before the first frame update
    void Start()
    {
        scoreTxt = GetComponent<Text> ();
    }

    // Update is called once per frame
    void Update()
    {
        scoreTxt.text = Mathf.RoundToInt (player.position.y).ToString();
    }
}
