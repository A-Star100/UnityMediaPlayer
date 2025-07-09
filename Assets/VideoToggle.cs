using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using TMPro;  // Add this for TMP_Text

public class VideoToggle : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public Button toggleButton;
    public TMP_Text buttonText;  // Use TMP_Text instead of Text

    void Start()
    {
        // Automatically assign the TMP_Text if not manually linked
        if (buttonText == null)
        {
            buttonText = toggleButton.GetComponentInChildren<TMP_Text>();
        }

        toggleButton.onClick.AddListener(TogglePlayPause);
    }

    void TogglePlayPause()
    {
        if (videoPlayer.isPlaying)
        {
            videoPlayer.Pause();
            buttonText.text = "Play";
        }
        else
        {
            videoPlayer.Play();
            buttonText.text = "Pause";
        }
    }
}
