using System;
using System.Collections.Generic;
using System.IO;
using JinJvLi;
using JinJvLi.Lobby;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.UI;

namespace JinJvli
{
    [PanelConfig("Assets/JinJvLi/Res/JJL_Panel/CreateGamePanel.prefab")]
    public class CreateGamePanel: PanelBase
    {
        public static class Config
        {
            public const string GAME_INFO_LIST_PATH="Assets/JinJvLi/Res/GameCreateList.asset";
        }

        [SerializeField]
        UIList m_uiList;
        CreateGameInfo[] m_listData;
        CreateGameInfo m_curSelect;

        public override void OnCreate()
        {
            m_uiList.m_ItemShow += onItemShow;
            // m_listData  = Resources.Load<GameCreateList>(Config.GAME_INFO_LIST_PATH).List;
        }

        public override void OnShow(object _openData = null)
        {
            m_curSelect=null;
            m_uiList.ItemNum=0;
            if(m_listData==null)
            {
                Addressables.LoadAssetAsync<GameCreateList>(Config.GAME_INFO_LIST_PATH).Completed += (handle)=>
                {
                    m_listData = handle.Result.List;
                    m_uiList.ItemNum=m_listData.Length;
                };
            }
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
                GameServer gameServer = Main.Manager<NetworkManager>().CreateServer<GameServer>();

                var ip = NetworkManager.GetLocalIP().ToString();

                PB_GameRoom gameRoom = new PB_GameRoom();
                string user_json = PlayerPrefs.GetString(LoginPanel.Config.SELF_INFO);
                gameRoom.Host = PB_UserInfo.Parser.ParseJson(user_json);
                gameRoom.Host.Address = new PB_IPAddress(){IP=ip,Port=Main.Manager<NetworkManager>().Client<GameClinet>().Port};
                gameRoom.GameName = m_curSelect.Name;
                gameRoom.ID = m_curSelect.ID;
                
                gameServer.Start(gameRoom);
                Main.Manager<PanelManager>().ShowToast("游戏已创建 等待其他玩家加入和你的开始",5);

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