using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class MyLandingManage : MonoBehaviour
{
    public GameObject myvideo;//视频的载体接口
    bool ismute = false;//是否静音的标志位
    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
    }
    public void MyStart() {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Starting");//加载下一场景
    }
    public void MySound() {
        VideoPlayer vp = myvideo.GetComponent<VideoPlayer>();
        if (ismute == false){
            ismute = true;
            vp.SetDirectAudioVolume(0, 0);//参数一，声道；参数二，音量
        }
        else{
            ismute = false;
            vp.SetDirectAudioVolume(0, 1);
        }
        /*控制audiolisten监听来控制静音，事实证明无效。大概是因为不是3d立体音效。也有可能是因为是视频自带音效
        AudioListener audio=this.GetComponent<AudioListener>();
        if (audio.enabled == true)   audio.enabled = false;
        else    audio.enabled = true;
        this.GetComponent<AudioListener>().enabled = audio.enabled;
        */
    }
    public void MyPlay() {
        float play = myvideo.GetComponent<VideoPlayer>().playbackSpeed;//播放速度属性
        if (play != 0)    play = 0;
        else    play = 1;
        myvideo.GetComponent<VideoPlayer>().playbackSpeed = play;
    }
}
