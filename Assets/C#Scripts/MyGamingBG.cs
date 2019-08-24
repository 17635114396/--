using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyGamingBG : MonoBehaviour
{
    public GameObject logicBG;
    public float scaleSpeed;
    public float scaleTime;

    public GameObject firstButton;

    // Start is called before the first frame update
    void Start()
    {
        firstButton.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        /*
        Vector3 position = logicBG.transform.position;
        while (position.z > 9f) { 
            position = Vector3.Lerp(position, position - new Vector3(0, 0, 691), Time.time * 0.02f);
        logicBG.transform.position = position;
        }
        */
        if(Time.timeSinceLevelLoad < scaleTime)//树莓背景放大
        {
            logicBG.transform.localScale += new Vector3(scaleSpeed, scaleSpeed, scaleSpeed);
        }
        if (Time.timeSinceLevelLoad > 7f)//第一个按钮出现
        {
            firstButton.SetActive(true);
        }
    }
}
