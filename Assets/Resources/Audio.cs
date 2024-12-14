using UnityEngine.UI;
using UnityEngine;
using UnityEngine.Audio;

public class Audio : MonoBehaviour
{
    //Audio�~�L�T�[������Ƃ��ł�
    [SerializeField] AudioMixer audioMixer1;
    [SerializeField] AudioMixer audioMixer2;

    //���ꂼ��̃X���C�_�[������Ƃ��ł��B�B
    [SerializeField] Slider BGMSlider;
    [SerializeField] Slider SESlider;

    private void Start()
    {
        //�~�L�T�[��volume�ɃX���C�_�[��volume�����Ă܂��B

        //BGM
        audioMixer1.GetFloat("BGM", out float bgmVolume);
        BGMSlider.value = bgmVolume;
        //SE
        audioMixer2.GetFloat("SE", out float seVolume);
        SESlider.value = seVolume;
    }

    public void SetBGM(float volume)
    {
        audioMixer1.SetFloat("BGM", volume);
    }

    public void SetSE(float volume)
    {
        audioMixer2.SetFloat("SE", volume);
    }
}