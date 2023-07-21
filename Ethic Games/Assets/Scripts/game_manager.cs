using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Reflection;
using UnityEditor.SearchService;

public class game_manager : MonoBehaviour

    
{
    public TextMeshProUGUI dialoguetxt_value, nametxt_value, titletxt_value;
    public string dialtxt, nametxt, titletxt;
    public GameObject menu, chapters, avatar, bg, dialogbox;
    public Sprite carlN, carlA, carlG, carlS,
                  jenN, jenA, jenG, jenS,
                  ethN, ethA, ethG, ethS,
                  bga1, bga2, bgb1, bgb2, bgb3,
                  bgc1, bgc2, bgd1, bgd2, bgd3, bgd4; //a = classroom, b = hallway, c = lib, d = bedrum

    public string bgs;
    public string ch; //2 chars, 1st is first letter of each character's name, 2nd is assigned mood number
                      //1 = Neutral ._., 2 = Angry >:c , 3 = Grinning ^w^, 4 = Sad :(

    //Dialogue buttons
    public GameObject a1, a2, a3, a4, a5, a6, a7, a8, b1, b2, c1, c2, c3,
                      d1, d2, d3, d4, d5, d6, d7, d8, d9, e1,
                      e2, e3, e4, e5, f1, f2, f3, g1, g2, h1,
                      h2, h3, h4, h5, i1, i2, i3, i4, j1, j2,
                      j3, j4, j5, j6, j7, j8, j9, k1, k2, k3,
                      k4, k5, k6, l1, l2, l3, l4, m1, m2, m3,
                      m4, m5, m6, m7, m8, m9, m10, m11, m12,
                      end1, end2, end3, ch1, ch2;
          


    // Start is called before the first frame update
    void Start()
    {
        dialtxt = "";
        nametxt = "";
        titletxt = "";
        chapters.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        //For character sprites and expressions
        switch (ch)
        {
            case "E1": avatar.GetComponent<Image>().sprite = ethN; break;
            case "E2": avatar.GetComponent<Image>().sprite = ethA; break;
            case "E3": avatar.GetComponent<Image>().sprite = ethG; break;
            case "E4": avatar.GetComponent<Image>().sprite = ethS; break;

            case "J1": avatar.GetComponent<Image>().sprite = jenN; break;
            case "J2": avatar.GetComponent<Image>().sprite = jenA; break;
            case "J3": avatar.GetComponent<Image>().sprite = jenG; break;
            case "J4": avatar.GetComponent<Image>().sprite = jenS; break;

            case "C1": avatar.GetComponent<Image>().sprite = carlN; break;
            case "C2": avatar.GetComponent<Image>().sprite = carlA; break;
            case "C3": avatar.GetComponent<Image>().sprite = carlG; break;
            case "C4": avatar.GetComponent<Image>().sprite = carlS; break;
            default: avatar.GetComponent<Image>().sprite = null; break;
        }

        //For BG
        switch (bgs)
        {
            case "A1": bg.GetComponent<Image>().sprite = bga1; break;
            case "A2": bg.GetComponent<Image>().sprite = bga2; break;

            case "B1": bg.GetComponent<Image>().sprite = bgb1; break;
            case "B2": bg.GetComponent<Image>().sprite = bgb2; break;
            case "B3": bg.GetComponent<Image>().sprite = bgb3; break;

            case "C1": bg.GetComponent<Image>().sprite = bgc1; break;
            case "C2": bg.GetComponent<Image>().sprite = bgc2; break;

            case "D1": bg.GetComponent<Image>().sprite = bgd1; break;
            case "D2": bg.GetComponent<Image>().sprite = bgd2; break;
            case "D3": bg.GetComponent<Image>().sprite = bgd3; break;
            case "D4": bg.GetComponent<Image>().sprite = bgd4; break;

        }
        dialoguetxt_value.text = dialtxt;
        nametxt_value.text = nametxt;
        titletxt_value.text = titletxt;
    }

    public void startgame()
    {
        dialogbox.SetActive(true);
        avatar.SetActive(false);
        menu.SetActive(false);
        bgs = "A2";
        dialtxt = "Alright class, go to your group mates and discuss your finals.";
        nametxt = "The Professor";
        a2.SetActive(true);
    }

    public void A2()
    {
        dialtxt = "Ethan goes to his group and kindly greets them.";
        nametxt = "";
        a3.SetActive(true);
    }

    public void A3()
    {
        avatar.SetActive(true);
        ch = "E1";
        dialtxt = "Hello guys.";
        nametxt = "Ethan";
        a4.SetActive(true);
    }

    public void A4()
    {
        ch = "C1";
        dialtxt = "Hi.";
        nametxt = "Carl";
        a5.SetActive(true);
    }

    public void A5()
    {
        ch = "J3";
        dialtxt = "Hello hello!";
        nametxt = "Jen";
        a6.SetActive(true);
    }

    public void A6()
    {
        avatar.SetActive(false);
        dialtxt = "They’re discussing what they’ll do for the final project.";
        nametxt = "";
        a7.SetActive(true);
    }

    public void A7()
    {
        avatar.SetActive(true);
        ch = "C1";
        dialtxt = "Okay, that’s the plan. Can you guys handle your part?";
        nametxt = "Carl";
        a8.SetActive(true);
    }

    public void A8()
    {
        avatar.SetActive(true);
        ch = "C1";
        dialtxt = "Okay, that’s the plan. Can you guys handle your part?";
        nametxt = "Carl";
        ch1.SetActive(true);
        dialogbox.SetActive(false);
    }

    public void ch1a()
    {
        dialogbox.SetActive(true);
        ch1.SetActive(false);
        dialtxt = "I'll manage.";
        nametxt = "Ethan";
        ch = "E3";
        c2.SetActive(true);
    }

    public void ch1b()
    {
        dialogbox.SetActive(true);
        ch1.SetActive(false);
        dialtxt = "How about you Ethan?";
        nametxt = "Carl";
        ch = "C4";
        b2.SetActive(true);
    }
    
    public void B2()
    {
        ch = "E1";
        dialtxt = "Yeah... yeah";
        nametxt = "Ethan";
        d1.SetActive(true);
    }

    public void C2()
    {
        ch = "C4";
        dialtxt = "I hope we finish this as soon as possible because I have finals in other subjects.";
        nametxt = "Carl";
        c3.SetActive(true);
    }

    public void C3()
    {
        ch = "J3";
        dialtxt = "We will, this will be a piece of cake!";
        nametxt = "Jen";
        d1.SetActive(true);
    }

    public void D1()
    {
        bgs = "D4";
        ch = "E1";
        dialtxt = "Ethan opens his laptop and begins to work on his part.";
        nametxt = "";
        d2.SetActive(true);
    }

    public void D2()
    {
        ch = "E4";
        dialtxt = "*sigh*";
        nametxt = "Ethan";
        d3.SetActive(true);
    }

    public void D3()
    {
        ch = "E1";
        dialtxt = "Let's do this!";
        nametxt = "Ethan";
        d4.SetActive(true);
    }

    public void D4()
    {
        ch = "E1";
        dialtxt = "Ethan stares at his laptop...";
        nametxt = "";
        d5.SetActive(true);
    }

    public void D5()
    {
        ch = "E4";
        dialtxt = "The... nothing";
        nametxt = "Ethan";
        d6.SetActive(true);
    }

    public void D6()
    {
        ch = "E2";
        dialtxt = "Ethan is frustrated and rubs his face.";
        nametxt = "";
        d7.SetActive(true);
    }

    public void D7()
    {
        ch = "E2";
        dialtxt = "I'M SCREWED!";
        nametxt = "Ethan";
        d8.SetActive(true);
    }

    public void D8()
    {
        ch = "E4";
        dialtxt = ".... Should I use Andrei GPT?";
        nametxt = "Ethan";
        d9.SetActive(true);
    }

    public void D9()
    {
        ch = "E4";
        dialtxt = "";
        nametxt = "";
        ch2.SetActive(true);
        dialogbox.SetActive(false);
    }

    public void ch2a()
    {
        dialogbox.SetActive(true);
        ch2.SetActive(false);
        dialtxt = "Ethan opens Andrei GPT and asks the AI to write a story for him.";
        nametxt = "";
        ch = "E1";
        e2.SetActive(true);
    }

    public void ch2b()
    {
        dialogbox.SetActive(true);
        ch2.SetActive(false);
        dialtxt = "I'm not gonna do that";
        nametxt = "Ethan";
        ch = "E1";
        f2.SetActive(true);
    }

}



    //IEnumerator TypeSentence(string sentence)
    //{
    //    dialogueText.text = "";
    //    foreach (char letter in sentence.ToCharArray())
    //    {
    //        dialogueText.text += letter;
    //        yield return new WaitForSecondsRealtime(textspeed);
    //    }
    //}

