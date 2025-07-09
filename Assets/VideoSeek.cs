using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoSeek : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public Button rewindButton;
    public Button forwardButton;
    public double seekAmount = 5.0; // seconds to jump

    void Start()
    {
        rewindButton.onClick.AddListener(Rewind);
        forwardButton.onClick.AddListener(Forward);
    }

    void Rewind()
    {
        if (videoPlayer.canSetTime)
        {
            videoPlayer.time = Mathf.Max(0f, (float)videoPlayer.time - (float)seekAmount);
        }
    }

    void Forward()
    {
        if (videoPlayer.canSetTime)
        {
            videoPlayer.time = Mathf.Min((float)videoPlayer.length, (float)videoPlayer.time + (float)seekAmount);
        }
    }
}
