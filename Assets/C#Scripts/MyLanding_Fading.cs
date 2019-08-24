using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyLanding_Fading : MonoBehaviour
{
    public float fadingspeed;
    public GameObject colorful;
    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        colorful.GetComponent<Image>().color = Color.Lerp(colorful.GetComponent<Image>().color, Color.clear, Time.timeSinceLevelLoad*fadingspeed);
    }
}
