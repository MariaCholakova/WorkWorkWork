using TMPro;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class PressButtonScript : MonoBehaviour
{
    private int fadeSpeed;
    private int fadeProgress;

	public Button button;
	public TMP_Text keyText;
    public Color normalColor = new Color(255, 255, 255);
    public Color currentColor;
    public Color guessColor;
    public Color wrongColor;
    public float fadeOutTime;

    public int remainingPresses = 20;

    private Tween fadeOutTween;

	private string currentRequiredKey;

	public void Start()
	{
        currentColor = normalColor;
		currentRequiredKey = SelectRandomCharacter();
		SetText(currentRequiredKey);
	}

    public void Update() {
        if (!Input.anyKeyDown) return;

		if (remainingPresses > 0 && Input.GetKeyDown(currentRequiredKey.ToString()))
        {   
            currentRequiredKey = SelectRandomCharacter();
            SetText(currentRequiredKey);
            remainingPresses -= 1;

            // Change color instant
            ChangeColor(guessColor);

            // Fade out color 
            fadeOutTween = DOTween.To(
                () => button.colors.normalColor,
                x => ChangeColor(x),
                normalColor,
                fadeOutTime
            );

        }
        else
        {
            if (fadeOutTween != null)
            {
                fadeOutTween.Kill();
            }

            fadeOutTween = DOTween.To(
                () => button.colors.normalColor,
                x => ChangeColor(x),
                normalColor,
                fadeOutTime
            );

            ChangeColor(wrongColor);
        }
    }

    private void adjustColor()
    {

    }

    private void ChangeColor(Color color)
    {
        ColorBlock colorBlock = button.colors;
        colorBlock.normalColor = color;
        button.colors = colorBlock;
    }

    private string SelectRandomCharacter() => ((char)Random.Range('a', 'z')).ToString();

	private void SetText(string text) => keyText.text = currentRequiredKey.ToUpper();
}
