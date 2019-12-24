using UnityEngine;

public class GameManager : MonoBehaviour
{
    public AudioSource _audioSource;
    public AudioClip _audioClip;
    public GameObject CC;
    public void CC_OnClick()
    {
        _audioSource.PlayOneShot(_audioClip, 1f);
        Instantiate(CC);
    }

    private void OnBecameInvisible()
    {
        Destroy(CC);
    }

}
