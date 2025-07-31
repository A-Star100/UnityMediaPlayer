using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using TMPro;

public class URLVideoLoader : MonoBehaviour
{
    public TMP_InputField urlInputField;
    public Button loadButton;
    public VideoPlayer videoPlayer;

    void Start()
    {
        loadButton.onClick.AddListener(OnLoadButtonClicked);

        // Subscribe to the video end event
        videoPlayer.loopPointReached += OnVideoFinished;
    }

    void OnLoadButtonClicked()
    {
        string url = urlInputField.text.Trim();
        if (!string.IsNullOrEmpty(url))
        {
            PlayVideoFromURL(url);
        }
        else
        {
            Debug.LogWarning("URL is empty");
        }
    }

    void PlayVideoFromURL(string url)
    {
        videoPlayer.url = url;
        videoPlayer.Play();

        // Hide input and button after loading
        urlInputField.gameObject.SetActive(false);
        loadButton.gameObject.SetActive(false);
    }

    void OnVideoFinished(VideoPlayer vp)
    {
        // Show input and button again after video ends
        urlInputField.gameObject.SetActive(true);
        loadButton.gameObject.SetActive(true);
    }
}
