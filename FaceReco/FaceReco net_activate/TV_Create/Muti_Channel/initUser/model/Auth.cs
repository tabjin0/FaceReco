using Regedit_Learn.initUser.pojo;
using Regedit_Learn.initUser.vo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regedit_Learn.initUser.model {
    public class Auth {
        Boolean faceOk = true;
        Boolean loginOk = true;
        string _baseKey = "HARDWARE";
        string _subKey = @"Dayang\dydatabase\NetManageDBSetting";
        Register register = null;//注册表操作类

        #region 构造函数
        public Auth(string baseKey, string subKey, RegisterInfo registerInfo) {
            this._baseKey = baseKey;
            this._subKey = subKey;
            this.register = new Register(this._baseKey, this._subKey, registerInfo);// 初始化注册表操作类
        }
        #endregion

        #region 初始化注册表信息
        public RegisterInfoVO _getRegInfo() {
            // 主要是用户更新后刷新注册表信息
            // 从数据库中获取到新的用户信息，多频道数据库抛出uuid -> 查询本地数据库对应的uuid -> 
            return null;
        }
        #endregion


        #region 身份校验
        public RegisterInfoVO authCheck(UserInfo userInfo) {
            //1.用户进行人脸识别->通过->切换注册表->跳转指定频道，实现自动登录
            //2.用户人脸识别失败->输入用户名密码->通过->切换注册表->跳转指定频道，实现自动登录
            RegisterInfoVO registerInfoVO = null;
            if (faceOk || loginOk) {// 人脸校验成功或者账号密码校验成功
                // 根据uuid检验当前身份与注册表中的上次驻留身份是否一致，该uuid是存在本地数据库的唯一标识
                if (true) {//不是同一个人，更新注册表，这边校验uuid
                    this.register.UpdateRegInfo(userInfo);
                }

                registerInfoVO = this.register.GetInfoFromRegedit();
            }
            return registerInfoVO;
        }
        #endregion

    }
}
