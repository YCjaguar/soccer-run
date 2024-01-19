using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundImage : MonoBehaviour
{
    public Sprite soundOnImage;
    public Sprite soundOffImage;
    private Image buttonImage;
    private bool isImageSoundOn;
    // Start is called before the first frame update
    void Start()
    {
        buttonImage = GetComponent<Image>();
        isImageSoundOn = true;
    }

    public void ToggleImage()
    {
        if (isImageSoundOn)
            buttonImage.sprite = soundOffImage;
        else
            buttonImage.sprite = soundOnImage;

        isImageSoundOn = !isImageSoundOn;
    }
}
