#region Copyright (C) 2016 Kevin (OSS��Դϵ��) ���ںţ�osscoder

/***************************************************************************
*����	�ļ�������������������ʵ�ֽӿ�
*
*����	�����ˣ� Kevin
*       ������Email��1985088337@qq.com
*       
*****************************************************************************/

#endregion
using System;
using System.Collections.Generic;

namespace OSS.Common.Modules.CacheModule
{
    /// <summary>
    /// 
    /// </summary>
    public interface ICache
    {
        /// <summary>
        /// ���ӻ���,������������
        /// </summary>
        /// <typeparam name="T">���ӻ����������</typeparam>
        /// <param name="key">���Ӷ����key</param>
        /// <param name="obj">ֵ</param>
        /// <param name="slidingExpiration">��Թ��ڵ�TimeSpan  ���ʹ�ù̶�ʱ��  =TimeSpan.Zero</param>
        /// <param name="absoluteExpiration"> ���Թ���ʱ��,��Ϊ�����վ��Թ���ʱ����� </param>
        /// <returns>�Ƿ����ӳɹ�</returns>
        bool AddOrUpdate<T>(string key, T obj, TimeSpan slidingExpiration, DateTime? absoluteExpiration = null);

        /// <summary>
        /// ��ȡ�������
        /// </summary>
        /// <typeparam name="T">��ȡ�����������</typeparam>
        /// <param name="key">key</param>
        /// <returns>��ȡָ��key��Ӧ��ֵ </returns>
        T Get<T>(string key);

        /// <summary>
        /// �Ƴ��������
        /// </summary>
        /// <param name="key"></param>
        /// <returns>�Ƿ�ɹ�</returns>
        bool Remove(string key);

    }
}