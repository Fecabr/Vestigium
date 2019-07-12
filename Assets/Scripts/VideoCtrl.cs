using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoCtrl : MonoBehaviour {

    public enum BtnVideo { 
        play,
        pause,
        stop
    }

    public BtnVideo btnVideo;
    public VideoPlayer videoplayer;
    public GameObject texture;
	// Use this for initialization
	void Start () {
    }

    public void OnclickBtnvideo()
    {
        switch (btnVideo)
        {
            case BtnVideo.play:
                if (texture)
                {
                    texture.SetActive(true);
                }
                videoplayer.Play();
                break;
            case BtnVideo.pause:
                videoplayer.Pause();
                break;
            case BtnVideo.stop:
                videoplayer.Stop();
                break;
        }
    }
}
