﻿//------------------------------------------------------------------------------
// <auto-generated>
// 此代码由Codesmith工具生成。
// 此文件的更改可能会导致不正确的行为，如果
// 重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using ProtoBuf;
using ZyGames.Framework.Cache.Generic;
using ZyGames.Framework.Common;
using ZyGames.Framework.Collection;
using ZyGames.Framework.Model;


namespace ZyGames.Doudizhu.Model
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable, ProtoContract]
    [EntityTable(DbConfig.Data)]
    public class UserAchieve : BaseEntity
    {

        /// <summary>
        /// </summary>
        public UserAchieve()
            : base(false)
        {
            AchievePackage = new CacheList<UserAchieveInfo>();
        }

        public UserAchieve(int userid)
            :this()
        {
            UserID = userid;
        }
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(1)]
        [EntityField(true)]
        public int UserID { get; set; }
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(2)]
        [EntityField( true, ColumnDbType.Text)]
        public CacheList<UserAchieveInfo> AchievePackage { get; set; }


        protected override int GetIdentityId()
        {
            //设置玩家的UserID
            //若要做为全局使用设置类绑定的自定义属性[EntityTable(CacheType.Entity, DbConfig.Config, @TableName, @PeriodTime)]
            return UserID;
        }

    }
}