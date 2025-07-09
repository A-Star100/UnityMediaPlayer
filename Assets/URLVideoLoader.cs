using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using TMPro;  // TextMeshPro namespace

public class URLVideoLoader : MonoBehaviour
{
    public TMP_InputField urlInputField;   // Use TMP_InputField here
    public Button loadButton;
    public VideoPlayer videoPlayer;

    void Start()
    {
        loadButton.onClick.AddListener(OnLoadButtonClicked);
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
}
