using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class watchselect11 : MonoBehaviour
{
    public GameObject watchModel1;
    public GameObject watchmodel2;
    public GameObject watchmodel3;

    public GameObject w1Window;
    public GameObject w2Window;
    public GameObject w3Window;

    Animation w1windowAnimation;
    Animation w2windowAnimation;
    Animation w3windowAnimation;


    // Start is called before the first frame update
    void Start()
    {
        
        w1windowAnimation = w1Window.GetComponent<Animation>();
        w2windowAnimation = w2Window.GetComponent<Animation>();
        w3windowAnimation = w3Window.GetComponent<Animation>();

    }

    public void WatchOneButtonClicked(){

        //1)show watch 1 model on user's wrist
        watchModel1.SetActive(true);
        watchmodel2.SetActive(false);
        watchmodel3.SetActive(false);

        //2)animate with watch1 window
        w1windowAnimation["w1Animation"].speed = 1;
        w1windowAnimation.Play();

    }

    public void WatchTwoButtonClicked() {

        //1)show watch 2 model on user's wrist
        watchModel1.SetActive(false);
        watchmodel2.SetActive(true);
        watchmodel3.SetActive(false);
        //2)animate with watch2 window

        w2windowAnimation["w2Animation"].speed = 1;
        w2windowAnimation.Play();

    }

    public void WatchThreeButtonClicked(){

        //show watch 3 on user's wrist

        watchModel1.SetActive(false);
        watchmodel2.SetActive(false);
        watchmodel3.SetActive(true);

        //2)animate with watch3 window
        w3windowAnimation["w3Animation"].speed = 1;
        w3windowAnimation.Play();

    }
    public void CloseButtonClicked(){

        string buttonName = EventSystem.current.currentSelectedGameObject.name;

        if (buttonName == "w1close") {
            //Player animation to close w1
            w1windowAnimation["w1Animation"].speed = -1;
            w1windowAnimation["w1Animation"].time = w1windowAnimation["w1Animation"].length;
            w1windowAnimation.Play();
        
        }

        else if (buttonName == "w2close") {
            //Player animation to close w2
            w2windowAnimation["w2Animation"].speed = -1;
            w2windowAnimation["w2Animation"].time = w2windowAnimation["w2Animation"].length;
            w2windowAnimation.Play();

        }

        else if (buttonName == "w3close") {
            //Player animation to close w3
            w3windowAnimation["w3Animation"].speed = -1;
            w3windowAnimation["w3Animation"].time = w3windowAnimation["w3Animation"].length;
            w3windowAnimation.Play();



        }


    }

}
