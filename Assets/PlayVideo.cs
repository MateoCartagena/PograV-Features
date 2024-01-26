using UnityEngine;
using UnityEngine.Video;

public class VideoPlayerController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public string[] videoNames = { "1", "2" };  // Nombres de los videos en la carpeta "Assets"
    private int currentVideoIndex = 0;

    void Start()
    {
        videoPlayer = gameObject.AddComponent<VideoPlayer>();
        PlayNextVideo();
    }

    void Update()
    {
        // Verifica si el video actual ha terminado y reproduce el siguiente.
        if (!videoPlayer.isPlaying && videoPlayer.isPrepared)
        {
            PlayNextVideo();
        }
    }

    void PlayNextVideo()
    {
        if (currentVideoIndex < videoNames.Length)
        {
            string videoPath = "Assets/" + videoNames[currentVideoIndex];
            videoPlayer.url = videoPath;
            videoPlayer.Prepare();
            currentVideoIndex++;

            // Opcional: Puedes configurar otras propiedades del VideoPlayer aquí.

            videoPlayer.Play();
        }
        else
        {
            Debug.Log("Todos los videos han sido reproducidos.");
        }
    }
}

