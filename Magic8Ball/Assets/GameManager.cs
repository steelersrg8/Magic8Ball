using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public GUISkin layout;
    public Texture ball;
    public string msg = "Ask and ye shall receive";

    void OnGUI()
    {
        GUI.skin = layout;
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), ball);
        GUI.TextArea (new Rect(Screen.width / 2 - 50, Screen.height / 2 + 50, 100, 100), msg);
        if (GUI.Button(new Rect(Screen.width / 2 - 35, Screen.height / 2 - 100, 80, 80), "Ask"))
        {
            float rand = Random.Range(0.0f, 200f);
            if (rand < 10.0f)
            {
                msg = "It is certain.";
            }
            else if (rand < 20.0f)
            {
                 msg = "It is decidedly so.";
            }
            else if (rand < 30.0f)
            {
                msg = "Without a doubt.";
            }
            else if (rand < 40.0f)
            {
                msg = "Yes - definitely.";
            }
            else if (rand < 50.0f)
            {
                msg = "You may rely on it.";
            }
            else if (rand < 60.0f)
            {
                msg = "As I see it, yes.";
            }
            else if (rand < 70.0f)
            {
                msg = "Most likely.";
            }
            else if (rand < 80.0f)
            {
                msg = "Outlook good.";
            }
            else if (rand < 90.0f)
            {
                msg = "Yes.";
            }
            else if (rand < 100.0f)
            {
                msg = "Signs point to yes.";
            }
            else if (rand < 110.0f)
            {
                msg = "Reply hazy, try again.";
            }
            else if (rand < 120.0f)
            {
                msg = "Ask again later.";
            }
            else if (rand < 130.0f)
            {
                msg = "Better not tell you now.";
            }
            else if (rand < 140.0f)
            {
                msg = "Cannot predict now.";
            }
            else if (rand < 150.0f)
            {
                msg = "Concentrate and ask again.";
            }
            else if (rand < 160.0f)
            {
                msg = "Don't count on it.";
            }
            else if (rand < 170.0f)
            {
                msg = "My reply is no.";
            }
            else if (rand < 180.0f)
            {
                msg = "My sources say no.";
            }
            else if (rand < 190.0f)
            {
                msg = "Outlook not so good.";
            }
            else if (rand < 200.0f)
            {
                msg = "Very doubtful.";
            }
        }
    }
}
// Update is called once per frame
