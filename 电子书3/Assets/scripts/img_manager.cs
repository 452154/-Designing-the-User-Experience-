using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class img_manager : MonoBehaviour
{

    // public List<Texture2D> allTex2d = new List<Texture2D>();

    public List<GameObject> rawImages = new List<GameObject>();
    public List<AudioClip> a_clip = new List<AudioClip>();
    public List<string> texts = new List<string>();
    public List<GameObject> ani = new List<GameObject>();

    public GameObject home_hide_ui;
    public GameObject start_btn1;



    public AudioSource audioSource;
    public AudioSource bgm_audioSource;

    public Text zimu_text;
    public float zoomSpeed = 0.4f; // Ëõ·ÅËÙ¶È


    public RawImage img;
    int i = 0;

    private void Update()
    {


    }
    public void bgm_()
    {
        if (bgm_audioSource.isPlaying)
        {
            bgm_audioSource.Pause();
        }
        else
        {
            bgm_audioSource.Play();
        }
    }
    public void start_btn()
    {
        hide();
        audioSource.Stop();
        audioSource.PlayOneShot(a_clip[1]);
        rawImages[i + 1].SetActive(true);

        zimu_text.text = texts[i + 1];
        start_btn1.SetActive(false);
        home_hide_ui.SetActive(true);

        i++;
    }
    public void next_img()
    {

        if (i >= rawImages.Count - 1)
        {

        }
        else
        {
            hide();
            home_hide_ui.SetActive(true);
            audioSource.Stop();
            audioSource.PlayOneShot(a_clip[i + 1]);
            rawImages[i + 1].SetActive(true);

            zimu_text.text = texts[i + 1];

            i++;
        }
    }
    public void pre_img()
    {
        if (i == 1)
        {
            home_hide_ui.SetActive(false);
            start_btn1.SetActive(true);

        }
        if (i == 0)
        {

        }
        else
        {
            hide();
            audioSource.Stop();

            audioSource.PlayOneShot(a_clip[i - 1]);
            rawImages[i - 1].SetActive(true);

            zimu_text.text = texts[i - 1];

            i--;
        }
    }
    public void to_home()
    {
        hide();
        home_hide_ui.SetActive(false);

        rawImages[0].SetActive(true);
        audioSource.Stop();
        audioSource.PlayOneShot(a_clip[0]);
        zimu_text.text = texts[0];
        start_btn1.SetActive(true);


        i = 0;
    }
    private void Start()
    {
        hide();
        audioSource.PlayOneShot(a_clip[i]);
        rawImages[0].SetActive(true);
        zimu_text.text = texts[i];
        home_hide_ui.SetActive(false);


    }
    public float min_scale = 0.3f;
    void hide()
    {
        foreach (GameObject gameObject in rawImages)
        {
            gameObject.SetActive(false);
            /* foreach(Transform child in gameObject.transform)
             {
                 child.localScale = new Vector3(min_scale, min_scale, 1);
             }*/

        }

    }
    public void to_1()
    {
        hide();
        i = 0;
        rawImages[0].SetActive(true);
        zimu_text.text = texts[0];

        home_hide_ui.SetActive(false);
        start_btn1.SetActive(true);


    }
    public void to_2()
    {
        hide();
        i = 1;
        rawImages[1].SetActive(true);
        zimu_text.text = texts[1];

        start_btn1.SetActive(false);
        home_hide_ui.SetActive(true);


    }
    public void to_3()
    {
        hide();
        i = 2;
        rawImages[2].SetActive(true);
        zimu_text.text = texts[2];

        start_btn1.SetActive(false);
        home_hide_ui.SetActive(true);


    }
    public void to_4()
    {
        hide();
        i = 3;
        rawImages[3].SetActive(true);
        zimu_text.text = texts[3];

        start_btn1.SetActive(false);
        home_hide_ui.SetActive(true);


    }
    public void to_5()
    {
        hide();
        i = 4;
        rawImages[4].SetActive(true);
        zimu_text.text = texts[4];

        start_btn1.SetActive(false);
        home_hide_ui.SetActive(true);


    }
    public void to_6()
    {
        hide();
        i = 5;
        rawImages[5].SetActive(true);
        zimu_text.text = texts[5];

        start_btn1.SetActive(false);
        home_hide_ui.SetActive(true);


    }
}