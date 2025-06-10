using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Flow : MonoBehaviour
{
    public TextMeshProUGUI uiText;
    string star;

    public void Phase1()
    {
        star = string.Empty;

        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                star += "¡Ú";
            }
            star += "\n";
        }
        uiText.text = star;
    }

    public void Phase2()
    {
        star = string.Empty;

        for (int i = 1; i <= 5; i++)
        {
            for (int j = 0; j < 5 - i; j++)
            {
                star += "¡¡"; 
            }

            for (int j = 0; j < i; j++)
            {
                star += "¡Ú";
            }

            star += "\n";
        }
        uiText.text = star;
    }

    public void Phase3()
    {
        star = string.Empty;

        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                star += "¡Ú";
            }
            star += "\n";
        }

        for (int i = 4; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                star += "¡Ú";
            }
            star += "\n";
        }
        uiText.text = star;
    }

    public void Phase4()
    {
        star = string.Empty;

        for (int i = 1; i <= 5; i++)
        {
            
            for (int j = 0; j < 5 - i; j++)
            {
                star += "¡¡"; 
            }

            for (int j = 1; j <= i; j++)
            {
                star += "¡Ú";
            }
            star += "\n";
        }

        for (int i = 4; i >= 1; i--)
        {
            for (int j = 0; j < 5 - i; j++)
            {
                star += "¡¡"; 
            }

            for (int j = 1; j <= i; j++)
            {
                star += "¡Ú";
            }
            star += "\n";
        }
        uiText.text = star;
    }

    public void Phase5()
    {
        star = string.Empty;

        int maxStars = 9; 

        for (int i = 1; i <= maxStars; i += 2)
        {
            int spaces = (maxStars - i) / 2; 

            for (int j = 0; j < spaces; j++)
            {
                star += "¡¡";
            }

            for (int j = 0; j < i; j++)
            {
                star += "¡Ú";
            }

            for (int j = 0; j < spaces; j++)
            {
                star += "¡¡";
            }

            star += "\n";
        }

        for (int i = maxStars - 2; i >= 1; i -= 2)
        {
            int spaces = (maxStars - i) / 2;

            for (int j = 0; j < spaces; j++)
            {
                star += "¡¡";
            }

            for (int j = 0; j < i; j++)
            {
                star += "¡Ú";
            }

            for (int j = 0; j < spaces; j++)
            {
                star += "¡¡";
            }

            star += "\n";
        }
        uiText.text = star;
    }
}