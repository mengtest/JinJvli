using System;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 事件广播工具 用于功能集之间解耦
/// </summary>
public static class Broadcaster
{
    static Dictionary<Type, Action<IMessage>> m_events = new Dictionary<Type, Action<IMessage>>(); 
    static Dictionary<Delegate, Action<IMessage>> m_eventSources = new Dictionary<Delegate, Action<IMessage>>(); 

    public static void Clear<T>()
    {
        Type key = typeof(T);
        Action<IMessage> evt;
        if(m_events.TryGetValue(key,out evt))
        {
            var eventSources = m_eventSources.GetEnumerator();
            List<Delegate> removes = new List<Delegate>();
            int delegateCount=evt.GetInvocationList().Length;
            while(eventSources.MoveNext())
            {
                evt-=eventSources.Current.Value;
                if(evt==null)
                {
                    removes.Add(eventSources.Current.Key);
                    break;
                }
                else if(evt.GetInvocationList().Length<delegateCount)
                {
                    removes.Add(eventSources.Current.Key);
                }
                delegateCount=evt.GetInvocationList().Length;
            }
            m_events.Remove(key);
            for (int i = 0; i < removes.Count; i++)
            {
                m_eventSources.Remove(removes[i]);
            }
        }
    }

    public static void ClearAll()
    {
        m_events.Clear();
        m_eventSources.Clear();
    }

    public static void Add<T>(Action<T> _event) where T : struct,IMessage
    {
        if(m_eventSources.ContainsKey(_event))
        {
            Debug.LogWarning($"[Broadcaster.Add]事件重复监听\n{_event}");
            return;
        }
        Type eventType = typeof(T);
        Action<IMessage> evt = (_msg)=>{ _event((T)_msg); };
        m_eventSources[_event] = evt;
        if(m_events.ContainsKey(eventType))
        {
            m_events[eventType] += evt;
        }
        else
        {
            m_events[eventType] = evt;
        }
    }

    public static void Remove<T>(Action<T> _event) where T : struct,IMessage
    {
        Action<IMessage> evt;
        if(m_eventSources.TryGetValue(_event,out evt))
        {
            Type eventType = typeof(T);
            Action<IMessage> eventAction = m_events[eventType];
            eventAction -= evt;
            if(eventAction==null)
            {
                m_events.Remove(eventType);
            } 
            else
            {
                m_events[eventType] = eventAction;
            }
            m_eventSources.Remove(_event);
        }
    }

    public static void Broadcast<T>(T _message) where T : struct,IMessage
    {
        Type key = typeof(T);
        Action<IMessage> evt;
        if(m_events.TryGetValue(key,out evt))
        {
           evt(_message);
        }
    }

    /// <summary>
    /// 表示他是一个可广播的信息
    /// </summary>
    public interface IMessage{}
}