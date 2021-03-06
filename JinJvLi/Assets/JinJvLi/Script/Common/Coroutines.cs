using System;
using UnityEngine;
using System.Collections;

/// <summary>
/// 协程工具
/// </summary>
public class Coroutines : MonoSingleton<Coroutines>
{
    public Coroutine Delay(float _delay,Action _callBack)
    {
        return StartCoroutine(delay(_delay,_callBack));
    }

    IEnumerator delay(float _delay,Action _callBack)
    {
        yield return new WaitForSeconds(_delay);
        _callBack();
    }
    public Coroutine DelayFrame(int _frameCount,Action _callBack)
    {
        return StartCoroutine(delayFrame(_frameCount,_callBack));
    }

    IEnumerator delayFrame(int _frameCount,Action _callBack)
    {
        for (int i = 0; i < _frameCount; i++)
        {
            yield return null;
        }
        _callBack();
    }

    /// <summary>
    /// 多次调用
    /// </summary>
    /// <param name="_delay"></param>
    /// <param name="_count">小于0表示不限次数</param>
    /// <param name="_callBack"></param>
    /// <returns></returns>
    public Coroutine LoopRun(float _delay,int _count,Action _callBack)
    {
        return StartCoroutine(loopRun(_delay,_count,_callBack));
    }

    IEnumerator loopRun(float _delay,int _count,Action _callBack)
    {
        int count=0;
        var wait = new WaitForSeconds(_delay);
        while(_count!=count)
        {
            _callBack();
            count++;
            yield return wait;
        }
    }

    public Coroutine Run(IEnumerator _enumerator)
    {
        return StartCoroutine(_enumerator);
    }

    public void Stop(Coroutine _enumerator)
    {
        StopCoroutine(_enumerator);
    }

    public void Clear()
    {
        StopAllCoroutines();
    }
}