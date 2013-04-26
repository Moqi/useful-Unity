using UnityEngine;
using System.Collections;

public class AnimatedTexture : MonoBehaviour
{
    public Texture2D[] animation1Textures = new Texture2D[5];
    public Texture2D[] animation2Textures = new Texture2D[5];
    public Texture2D[] animation3Textures = new Texture2D[5];
	public Texture2D[] animation4Textures = new Texture2D[5];

    public float animation1Speed = 0.2f;
    public float animation2Speed = 0.2f;
    public float animation3Speed = 0.2f;
	public float animation4Speed = 0.2f;
	
    public int currentFrame;
    public bool bPlaying;

    private float startTime;
    private float timeDiff;
    private Vector3 startPos;

    public enum Animation {
        ANIMATION1 = 0,
        ANIMATION2,
        ANIMATION3,
		ANIMATION4,
    }
    public Animation currentAnimation = Animation.ANIMATION1;

    void Awake() {
        currentFrame = 1;
        startPos = transform.position;
    }

    void Start() {
        SetTexture();
        startTime = Time.time;
    }

    void SetTexture() {
        switch (currentAnimation) {
            case Animation.ANIMATION1:
			renderer.material.mainTexture = animation1Textures[currentFrame - 1];
                break;
            case Animation.ANIMATION2:
				renderer.material.mainTexture = animation2Textures[currentFrame - 1];
                break;
            case Animation.ANIMATION3:
				renderer.material.mainTexture = animation3Textures[currentFrame - 1];
                break;
		case Animation.ANIMATION4:
				renderer.material.mainTexture = animation4Textures[currentFrame - 1];
                break;}
    }

    void Update() {
        timeDiff = Time.time - startTime;

        switch (currentAnimation) {
            case Animation.ANIMATION1:
                if (timeDiff >= animation1Speed) {
                    currentFrame++;
                    if (currentFrame > animation1Textures.Length)
                        currentFrame = 1;
                    SetTexture();
                    startTime = Time.time;
                }
                break;
            case Animation.ANIMATION2:
                if (timeDiff >= animation2Speed) {
                    currentFrame++;
                    if (currentFrame > animation2Textures.Length)
                        currentFrame = 1;
                    SetTexture();
                    startTime = Time.time;
                }
                break;
            case Animation.ANIMATION3:
                if (timeDiff >= animation3Speed) {
                    currentFrame++;
                    if (currentFrame > animation3Textures.Length)
                        currentFrame = 1;
                    SetTexture();
                    startTime = Time.time;
                }
                break;
			case Animation.ANIMATION4:
                if (timeDiff >= animation4Speed) {
                    currentFrame++;
                    if (currentFrame > animation4Textures.Length)
                        currentFrame = 1;
                    SetTexture();
                    startTime = Time.time;
                }
                break;
        }
    }

    public void Reset() {
        currentFrame = 1;
    }

    public void StartAnimation() {
        bPlaying = true;
    }

    public void StopAnimation() {
        bPlaying = false;
    }

    public void SetFrame(int frame) {
        currentFrame = frame;
    }

    public void SetAnimation(Animation animation) {
        currentAnimation = animation;
    }
}
