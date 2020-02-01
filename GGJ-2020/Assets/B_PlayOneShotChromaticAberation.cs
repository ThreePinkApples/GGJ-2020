using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class B_PlayOneShotChromaticAberation : MonoBehaviour
{
    private float _intensity;
    private float _speed;
    private float _pause;
    private float timer = 0;

    public ChromaticAberration _ca;

    public void PlayOneShot(float intensity, float speed, float pause)
    {
        _intensity = intensity;
        _speed = speed;
        _pause = pause;

        this.GetComponent<PostProcessVolume>().profile.TryGetSettings(out _ca);

        StartCoroutine(Shot());
    }

    private IEnumerator Shot()
    {
        while(timer / _speed < 1)
        {
            timer += Time.deltaTime;

            _ca.intensity.value = _intensity * (timer / _speed);

            yield return null;
        }

        yield return new WaitForSeconds(_pause);

        while (timer > 0)
        {
            timer -= Time.deltaTime;

            _ca.intensity.value = _intensity * (timer / _speed);

            yield return null;
        }
    }
}
