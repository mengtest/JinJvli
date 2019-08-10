using System;
using System.Collections.Generic;
using System.IO;
using JinJvLi;
using JinJvLi.Lobby;
using UnityEngine;
using UnityEngine.UI;

namespace JinJvli
{
    [PanelConfig("JJL_Panel/CreateGamePanel")]
    public class CreateGamePanel: PanelBase
    {
        public static class Config
        {
            public const string GAME_INFO_LIST_PATH="GameCreateList";
        }

        [SerializeField]
        UIList m_uiList;
        CreateGameInfo[] m_listData;
        CreateGameInfo m_curSelect;

        public override void OnCreate(object _openData = null)
        {
            m_uiList.m_ItemShow += onItemShow;
            m_listData  = Resources.Load<GameCreateList>(Config.GAME_INFO_LIST_PATH).List;
        }

        public override void OnShow()
        {
            m_curSelect=null;
            m_uiList.ItemNum=0;
            m_uiList.ItemNum=m_listData.Length;
            base.OnShow();
        }

        public override void OnHide()
        {
            base.OnHide();
        }

        public void OnClickCreate()
        {
            if(m_curSelect != null)
            {
                PB_GameRoom gameRoom = new PB_GameRoom();
                gameRoom.GameName = m_curSelect.Name;
                gameRoom.ID = m_curSelect.ID;

                Main.Manager<PanelManager>().Open<GameRoomPanel>(gameRoom);
            }
        }

        void onItemShow(int _index, RectTransform _item)
        {
            _item.GetChild(0).GetComponent<Text>().text = m_listData[_index].Name;
            _item.GetChild(1).gameObject.SetActive(false);
            _item.GetComponent<Button>().onClick.RemoveAllListeners();
            _item.GetComponent<Button>().onClick.AddListener(()=>
            {
                selectItem(_index,_item.GetChild(1).gameObject);
            });
        }

        void selectItem(int _index,GameObject _select)
        {
            if(_select.activeSelf)
            {
                m_curSelect=null;
                _select.SetActive(false);
            }
            else
            {
                m_curSelect=m_listData[_index];
                _select.SetActive(true);
            }
        }
    }
}