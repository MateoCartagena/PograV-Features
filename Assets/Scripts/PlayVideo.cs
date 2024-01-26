using UnityEngine;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public VideoClip videoClip1;
    public VideoClip videoClip2;

    void Start()
    {
        videoPlayer.clip = videoClip1;
        videoPlayer.loopPointReached += CheckOver;
        videoPlayer.Play();
    }

    void CheckOver(UnityEngine.Video.VideoPlayer vp)
    {
        vp.loopPointReached -= CheckOver;
        vp.clip = videoClip2;
        vp.Play();
    }
}




