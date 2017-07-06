﻿using Sheng.Kernal;
using Sheng.AdoNetPlus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sheng.ADO.NET.Plus
{
    public class ServiceUnity
    {
        private static readonly ServiceUnity _instance = new ServiceUnity();
        public static ServiceUnity Instance
        {
            get { return _instance; }
        }

        private DatabaseWrapper _dataBase;
        /// <summary>
        /// 连接Config文件中指定的默认数据库
        /// </summary>
        public DatabaseWrapper Database
        {
            get
            {
                if (_dataBase == null)
                {
                    _dataBase = new DatabaseWrapper();
                }
                return _dataBase;
            }
        }

        private ServiceUnity()
        {

        }

        private LogService _log = LogService.Instance;
        public LogService Log
        {
            get { return _log; }
        }

        private ExceptionHandlingService _exceptionHandling = ExceptionHandlingService.Instance;
        /// <summary>
        /// HandleException 后，会自动写日志，并调用自定义处理程序
        /// </summary>
        public ExceptionHandlingService ExceptionHandling
        {
            get { return _exceptionHandling; }
        }
    }
}
