using TMPro;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using Unity.VisualScripting;
using static UnityEngine.ParticleSystem;

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

    public int remainingPresses = 10;

    private Tween fadeOutTween;

	private string currentRequiredKey;

    private Animator animator;
    private ParticleSystem particle1;
    private ParticleSystem particle2;

	public void Start()
	{
        currentColor = normalColor;
		currentRequiredKey = SelectRandomCharacter();
		SetText(currentRequiredKey);
        animator =  transform.Find("Pref_Udders").GetComponent<Animator>();
        var particles = GetComponentsInChildren<ParticleSystem>();
        particle1 = particles[0];
        particle2 = particles[1];

    }

    public void Update() {
        if (!Input.anyKeyDown) return;

		if (remainingPresses > 0 && Input.GetKeyDown(currentRequiredKey.ToString()))
        {
            animator.SetTrigger("MilkedRight");
            particle1.Play();
            particle2.Play();
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

            if (remainingPresses <= 0) 
            {
                GameManager.instance.backToGame();
                ScoreManager.instance.UpdateScore(10);
                remainingPresses = 10;
            }

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
