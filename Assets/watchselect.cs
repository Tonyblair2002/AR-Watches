﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class watchselect : MonoBehaviour
{
    public GameObject watchModel1;
    public GameObject watchModel2;
    public GameObject watchModel3;

    public GameObject w1Window;
    public GameObject w2Window;
    public GameObject w3Window;

    Animation w1WindowAnimation;
    Animation w2WindowAnimation;
    Animation w3WindowAnimation;

    // Start is called before the first frame update
    void Start()
    {
        w1WindowAnimation = w1Window.GetComponent<Animation>();
        w2WindowAnimation = w2Window.GetComponent<Animation>();
        w3WindowAnimation = w3Window.GetComponent<Animation>();


    }
    public void watchOneButtonClicked() {
        // show watch 1 model on users wrist 
        watchModel1.SetActive(true);
        watchModel2.SetActive(false);
        watchModel3.SetActive(false);
        // animate watch 1 window 
        w1WindowAnimation["w1Animation"].speed = 1;
        w1WindowAnimation.Play();

    }
    public void watchTwoButtonClicked() {
        // show watch 2 model on users wrist 
        watchModel1.SetActive(false);
        watchModel2.SetActive(true);
        watchModel3.SetActive(false);
        // animate watch 2 window 
        w2WindowAnimation["w2Animation"].speed = 1;
        w2WindowAnimation.Play();
    }
    public void watchThreeButtonClicked() {
        // show watch 3 model on users wrist 
        watchModel1.SetActive(false);
        watchModel2.SetActive(false);
        watchModel3.SetActive(true);
        // animate watch 3 window 
        w3WindowAnimation["w3Animation"].speed = 1;
        w3WindowAnimation.Play();

    }
    public void CloseButtonClicked()
    {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;
        if (buttonName == "w1close")
        {
            //play animation to close w1
            w1WindowAnimation["w1Animation"].speed = -1;
            w1WindowAnimation["w1Animation"].time = w1WindowAnimation["w1Animation"].length;
            w1WindowAnimation.Play();
        }
        else if (buttonName == "w2close")
        {
            //play animation to close w2
            w2WindowAnimation["w2Animation"].speed = -1;
            w2WindowAnimation["w2Animation"].time = w2WindowAnimation["w2Animation"].length;
            w2WindowAnimation.Play();
        }
        else if (buttonName == "w3close")
        {
            //play animation to close w3
            w3WindowAnimation["w3Animation"].speed = -1;
            w3WindowAnimation["w3Animation"].time = w3WindowAnimation["w3Animation"].length;
            w3WindowAnimation.Play();
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
