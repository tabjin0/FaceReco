using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using Regedit_Learn.initUser.pojo;
using Regedit_Learn.initUser.vo;

namespace Regedit_Learn.initUser.model {
    public class Register {
        string _baseKey = "HARDWARE";
        string _subKey = @"Dayang\dydatabase\NetManageDBSetting";
        RegisterInfo _registerInfo;
        public Register(string baseKey, string subKey, RegisterInfo registerInfo) {
            _baseKey = baseKey;
            _subKey = subKey;
            _registerInfo = registerInfo;
        }
        #region 添加信息到注册表
        public void AddInfoToRegedit() {
            RegistryKey rkLocalMachine = Registry.LocalMachine;
            RegistryKey rkChild = rkLocalMachine.OpenSubKey(_baseKey, true).CreateSubKey(_subKey);
            var abc = this._registerInfo;
            //rkChild.SetValue("uuid", "");
            rkChild.SetValue("Server Name", _registerInfo.serverName);
            rkChild.SetValue("Datbase Type", _registerInfo.databaseType, RegistryValueKind.DWord);
            rkChild.SetValue("Database Name", _registerInfo.databaseName);
            rkChild.SetValue("Database User Name", _registerInfo.userName);
            rkChild.SetValue("Password", _registerInfo.password);
        }
        #endregion

        #region 从注册表中获取信息 ok
        /// <summary>
        /// 数据库主机名、数据库类型、数据库名、数据库用户名、数据库密码
        /// 用户唯一ID
        /// </summary>
        /// <returns></returns>
        public RegisterInfoVO GetInfoFromRegedit() {
            RegistryKey rkLocalMachine = Registry.LocalMachine;
            RegistryKey rkChild = rkLocalMachine.OpenSubKey(_baseKey, true).CreateSubKey(_subKey);

            RegisterInfoVO registerInfoVO = new RegisterInfoVO();
            if (rkChild.GetValue("Database Server Name").ToString().Length != 0) {
                registerInfoVO.serverName = rkChild.GetValue("Database Server Name").ToString();
            }
            if (rkChild.GetValue("Datbase Type").ToString().Length != 0) {
                registerInfoVO.databaseType = Convert.ToInt64(rkChild.GetValue("Datbase Type"));
            }
            if (rkChild.GetValue("Database Name").ToString().Length != 0) {
                registerInfoVO.databaseName = rkChild.GetValue("Database Name").ToString();
            }
            if (rkChild.GetValue("Database User Name").ToString().Length != 0) {
                registerInfoVO.userName = rkChild.GetValue("Database User Name").ToString();
            }
            if (rkChild.GetValue("Database Password").ToString().Length != 0) {
                registerInfoVO.password = rkChild.GetValue("Database Password").ToString();
            }
            if (rkChild.GetValue("UID").ToString().Length != 0) {
                registerInfoVO.uuid = rkChild.GetValue("UID").ToString();
            }
            return registerInfoVO;
        }
        #endregion

        #region 修改注册表信息
        public void UpdateRegInfo(UserInfo userInfo) {
            RegistryKey rkLocalMachine = Registry.LocalMachine;
            RegistryKey rkChild = rkLocalMachine.OpenSubKey(_baseKey, true).CreateSubKey(_subKey);
            // 用户基本信息更新注册表
            rkChild.SetValue("UID", userInfo.strUserID);
            rkChild.SetValue("NAME", userInfo.strName);
            rkChild.SetValue("PASSWORD", userInfo.strPassword);
            // 用户连接数据库相关信息更新
            rkChild.SetValue("Database Server Name", _registerInfo.serverName);
            rkChild.SetValue("Datbase Type", _registerInfo.databaseType, RegistryValueKind.DWord);
            rkChild.SetValue("Database Name", _registerInfo.databaseName);
            rkChild.SetValue("Database User Name", _registerInfo.userName);
            rkChild.SetValue("Database Password", _registerInfo.password);
        }
        #endregion

        #region 从注册表中删除信息
        public void DeleteRegeditInfo() {

        }
        #endregion
    }
}
