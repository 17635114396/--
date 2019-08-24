using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyStartingManager : MonoBehaviour
{

    public GameObject setting;
    bool isSetting=false;
    // Start is called before the first frame update
    public void MyStart() {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Gaming01");
    }
    public void MySet()
    {
        if (isSetting)
        {
            isSetting = false;
            setting.transform.Translate(new Vector3(-617, 0, 0));
            //setting.transform.position -= new Vector3(617, 0, 0);//另一种方法
            //Vector3.Lerp(setting.transform.position, setting.transform.position - new Vector3(617, 0, 0), 2f);//错误的方法
        }
        else {
            isSetting = true;
            setting.transform.Translate(new Vector3(617, 0, 0));
        }
    }
    public void MyExit() {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Landing");
    }
    public void MyMute(bool isActive) {
        AudioSource al = this.GetComponent<AudioSource>();
        if (isActive == false) al.volume = 1;
        else al.volume = 0;
    }
    public void MyVolume(float volume) {
        AudioSource al = this.GetComponent<AudioSource>();
        al.volume = volume;
    }
    public void MySample(bool sample) {
        if (sample) MyStaticManager.difficultCount = 0;
        print(MyStaticManager.difficultCount);
    }
    public void MyGeneral(bool general) {
        if (general) MyStaticManager.difficultCount = 1;
        print(MyStaticManager.difficultCount);
    }
    public void MyHard(bool hard) {
        if (hard) MyStaticManager.difficultCount = 2;
        print(MyStaticManager.difficultCount);
    }


}
